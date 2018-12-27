using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Epub3DuplicatedImagesRemoverTool.Helper;
using Epub3DuplicatedImagesRemoverTool.Model;

namespace Epub3DuplicatedImagesRemoverTool
{
    public partial class FormMain : Form
    {
        private readonly BackgroundWorker _bgFindingTask = new BackgroundWorker();
        private readonly BackgroundWorker _bgTab3FindingTask = new BackgroundWorker();
        private readonly BackgroundWorker _bgReplaceTask = new BackgroundWorker();
        private List<DuplicatedItem> _listDuplicatedItem = new List<DuplicatedItem>();
        private DataTable _dtDuplicatedItems = new DataTable();
        private DataTable _dtTab3DuplicatedItems = new DataTable();

        public FormMain()
        {
            InitializeComponent();

            Application.EnableVisualStyles();

            LoadSavedTextboxes();

            InitializeBackgroundWorkers();
        }

        void BgFindingTaskDoWork(object sender, DoWorkEventArgs e)
        {
            _dtDuplicatedItems = new DataTable();
            var path = e.Argument as string;
            ProcessFindingDuplicatedFiles(path);
        }

        void BgTab3FindingTaskDoWork(object sender, DoWorkEventArgs e)
        {
            _dtTab3DuplicatedItems = new DataTable();
            var paths = e.Argument as string[];
            ProcessTab3FindingDuplicatedFiles(paths?[0], paths?[1]);
        }

        void BgTab3FindingTaskRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnTab3Perform.Enabled = true;

            gridTab3Images.DataSource = _dtTab3DuplicatedItems;
            gridTab3Images.BindingContext = new BindingContext();
            StopStatusBar();
            MessageBox.Show(@"Xong roài!", @"Ấu yè!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void BgFindingTaskRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnPerform.Enabled = true;

            gridImages.DataSource = _dtDuplicatedItems;
            gridImages.BindingContext = new BindingContext();
            StopStatusBar();
            MessageBox.Show(@"Xong roài!", @"Ấu yè!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProcessFindingDuplicatedFiles(string path)
        {
            GetDuplicatedItemsList(path);
        }

        private void ProcessTab3FindingDuplicatedFiles(string path1, string path2)
        {
            GetTab3DuplicatedItemsList(path1, path2);
        }

        private void GetDuplicatedItemsList(string path)
        {
            _listDuplicatedItem = new List<DuplicatedItem>();
            foreach (var subDir in Directory.GetDirectories(path))
            {
                foreach (var duplicateImageList in ImageTool.GetDuplicateImages(subDir, false))
                {
                    for (var i = 1; i < duplicateImageList.Count; i++)
                    {
                        var duplicatedItem = new DuplicatedItem
                        {
                            BaseFileName = duplicateImageList.ElementAt(0),
                            BelongFolderPath = subDir,
                            DuplicatedFileName = duplicateImageList[i],
                            XhtmlFileName = Directory.GetFiles(subDir, "*.xhtml", SearchOption.TopDirectoryOnly)
                                .FirstOrDefault()
                        };
                        duplicatedItem.XhtmlFileContent = File.ReadAllText(duplicatedItem.XhtmlFileName);
                        _listDuplicatedItem.Add(duplicatedItem);
                    }
                }
            }

            AddDataTableHeader(_dtDuplicatedItems, Tab1ColumnsList);

            var gridId = 1;
            foreach (var item in _listDuplicatedItem)
            {
                var baseImage = Image.FromFile(item.BaseFileName);

                var imageRatio = (float)baseImage.Width / baseImage.Height;

                using (var stream = new FileStream(item.DuplicatedFileName, FileMode.Open, FileAccess.Read))
                {
                    _dtDuplicatedItems.Rows.Add(gridId++,
                                               false,
                                               item.BaseFileName,
                                               item.DuplicatedFileName,
                                               Image.FromFile(item.BaseFileName).Resize(Convert.ToInt32(300 * imageRatio), 300),
                                               Image.FromStream(stream).Resize(Convert.ToInt32(300 * imageRatio), 300),
                                               item.XhtmlFileName,
                                               item.XhtmlFileContent);
                }
            }
        }

        private IEnumerable<Tuple<string, Type>> Tab1ColumnsList =>
            new List<Tuple<string, Type>>
            {
                new Tuple<string, Type>("Id", null),
                new Tuple<string, Type>("Check", null),
                new Tuple<string, Type>("BaseFileName", null),
                new Tuple<string, Type>("DuplicatedFileName", null),
                new Tuple<string, Type>("BaseFileNameImage", typeof(Image)),
                new Tuple<string, Type>("DuplicatedFileNameImage", typeof(Image)),
                new Tuple<string, Type>("XhtmlFileName", null),
                new Tuple<string, Type>("XhtmlFileContent", null)
            };

        private void AddDataTableHeader(DataTable dataTable, IEnumerable<Tuple<string, Type>> columnsList)
        {
            foreach (var col in columnsList)
            {
                 dataTable.Columns.Add(col.Item1, col.Item2 ?? typeof(string));
            }
        }

        private void GetTab3DuplicatedItemsList(string baseFolderPath, string targetFolderPath)
        {
            _listDuplicatedItem = new List<DuplicatedItem>();
            var baseImageFiles = new List<string>(ImagesPathInFolderAndSubFolders(baseFolderPath));
            var targetImageFiles = new List<string>(ImagesPathInFolderAndSubFolders(targetFolderPath));

            foreach (var baseImageFile in baseImageFiles)
            {
                var isFound = false;

                foreach (var targetImageFile in targetImageFiles)
                {
                    var threshold = byte.Parse(txtTab3Threshold.Text);
                    var acceptableDiff_percent = float.Parse(txtTab3AcceptableDiff_percent.Text);
                    var difference_percent = ImageTool.GetPercentageDifference(baseImageFile, targetImageFile, threshold) * 100;

                    if (difference_percent > acceptableDiff_percent) continue;

                    isFound = true;

                    var duplicatedItem = new DuplicatedItem
                    {
                        BaseFileName = baseImageFile,
                        DuplicatedFileName = targetImageFile,
                        DifferencePercentage = difference_percent
                    };

                    _listDuplicatedItem.Add(duplicatedItem);
                }

                if (isFound) continue;
                {
                    var duplicatedItem = new DuplicatedItem
                    {
                        BaseFileName = baseImageFile,
                        DuplicatedFileName = "(Not used)"
                    };

                    _listDuplicatedItem.Add(duplicatedItem);
                }
            }

            AddDataTableHeader(_dtTab3DuplicatedItems, Tab3ColumnsList);

            var gridId = 1;
            foreach (var item in _listDuplicatedItem)
            {
                var baseImage = Image.FromFile(item.BaseFileName);

                var imageRatio = (float)baseImage.Width / baseImage.Height;

                if (!File.Exists(item.DuplicatedFileName))
                {
                    _dtTab3DuplicatedItems.Rows.Add(gridId++,
                        false,
                        item.BaseFileName,
                        item.DuplicatedFileName,
                        Image.FromFile(item.BaseFileName).Resize(Convert.ToInt32(300 * imageRatio), 300),
                        null,
                        item.DifferencePercentage);

                    continue;
                }

                using (var stream = new FileStream(item.DuplicatedFileName, FileMode.Open, FileAccess.Read))
                {
                    _dtTab3DuplicatedItems.Rows.Add(gridId++,
                                               false,
                                               item.BaseFileName,
                                               item.DuplicatedFileName,
                                               Image.FromFile(item.BaseFileName).Resize(Convert.ToInt32(300 * imageRatio), 300),
                                               Image.FromStream(stream).Resize(Convert.ToInt32(300 * imageRatio), 300),
                                               item.DifferencePercentage);
                }
            }
        }

        private static IEnumerable<string> ImagesPathInFolderAndSubFolders(string folderPath) => 
            Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories)
            .Where(file => file.EndsWith("jpg", StringComparison.InvariantCultureIgnoreCase) ||
                           file.EndsWith("bmp", StringComparison.InvariantCultureIgnoreCase) ||
                           file.EndsWith("gif", StringComparison.InvariantCultureIgnoreCase) ||
                           file.EndsWith("ico", StringComparison.InvariantCultureIgnoreCase) ||
                           file.EndsWith("png", StringComparison.InvariantCultureIgnoreCase))
            .ToList();

        private IEnumerable<Tuple<string, Type>> Tab3ColumnsList => 
            new List<Tuple<string, Type>>
            {
                new Tuple<string, Type>("Id", null),
                new Tuple<string, Type>("Check", null),
                new Tuple<string, Type>("BaseFileName", null),
                new Tuple<string, Type>("DuplicatedFileName", null),
                new Tuple<string, Type>("BaseFileNameImage", typeof(Image)),
                new Tuple<string, Type>("DuplicatedFileNameImage", typeof(Image)),
                new Tuple<string, Type>("Difference %", null)
            };

        private void btnBrowsePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;

            txtFolderPath.Text = Properties.Settings.Default.FolderPath = folderBrowserDialog.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            btnPerform.Enabled = false;
            if (!Directory.Exists(txtFolderPath.Text))
            {
                MessageBox.Show(@"Xem lại thư mục!", @"Èèèèè...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StartStatusBar();
            _bgFindingTask.RunWorkerAsync(txtFolderPath.Text);
        }

        private void LoadSavedTextboxes()
        {
            txtFolderPath.Text                 = Properties.Settings.Default.FolderPath;
            txtTab3BaseFolder.Text             = Properties.Settings.Default.Tab3FolderPath1;
            txtTab3TargetFolder.Text           = Properties.Settings.Default.Tab3FolderPath2;
            txtImage1Path.Text                 = Properties.Settings.Default.Image1Path;
            txtImage2Path.Text                 = Properties.Settings.Default.Image2Path;
            txtThreshold.Text                  = Properties.Settings.Default.Threshold.Equals(string.Empty) ? "5" : Properties.Settings.Default.Threshold;
            txtTab3AcceptableDiff_percent.Text = Properties.Settings.Default.Tab3AcceptableDiff.Equals(string.Empty) ? "20" : Properties.Settings.Default.Tab3AcceptableDiff;
            txtTab3Threshold.Text              = Properties.Settings.Default.Tab3Threshold.Equals(string.Empty) ? "5" : Properties.Settings.Default.Tab3Threshold;
        }

        private void InitializeBackgroundWorkers()
        {
            _bgFindingTask.DoWork += BgFindingTaskDoWork;
            _bgFindingTask.RunWorkerCompleted += BgFindingTaskRunWorkerCompleted;

            _bgTab3FindingTask.DoWork += BgTab3FindingTaskDoWork;
            _bgTab3FindingTask.RunWorkerCompleted += BgTab3FindingTaskRunWorkerCompleted;

            _bgReplaceTask.DoWork += _bgReplaceTask_DoWork;
            _bgReplaceTask.RunWorkerCompleted += _bgReplaceTask_RunWorkerCompleted;
        }

        void _bgReplaceTask_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StopStatusBar();

            MessageBox.Show(@"Xong roài!", @"Ấu yè!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void _bgReplaceTask_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (DataGridViewRow duplicatedItem in gridImages.Rows)
            {
                if (!Convert.ToBoolean(duplicatedItem.Cells["Check"].Value)) continue;

                var fileContent = ((string)duplicatedItem.Cells["XhtmlFileContent"].Value).Replace(Path.GetFileName((string)duplicatedItem.Cells["DuplicatedFilePath"].Value), Path.GetFileName((string)duplicatedItem.Cells["BaseFilePath"].Value));
                var duplicatedFileName = duplicatedItem.Cells["DuplicatedFilePath"].Value.ToString();
                var xhtmlFileName = duplicatedItem.Cells["XhtmlFileName"].Value.ToString();

                File.Delete(duplicatedFileName);

                File.WriteAllText(xhtmlFileName, fileContent);
            }
        }

        private void StartStatusBar()
        {
            toolStripStatusLabel.Text = @"Bemming...";
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.MarqueeAnimationSpeed = 30;
        }

        private void StopStatusBar()
        {
            toolStripStatusLabel.Text = @"Bemmed...";
            toolStripProgressBar.Style = ProgressBarStyle.Continuous;
            toolStripProgressBar.MarqueeAnimationSpeed = 0;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tool này thực hiện task: Kiểm tra trong các thư mục, " +
                            "nếu các thư mục con chứa các ảnh giống nhau thì:\n1. Tool " +
                            "sẽ compare và xóa đi những ảnh thừa, chỉ để lại 1 cái\n2. " +
                            "Sửa file *.xhtml và thay thế file bị xóa bằng file được giữ lại",
                            @"Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnBrowseImage1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImage1Path.Text = Properties.Settings.Default.Image1Path = openFileDialog.FileName;
                Properties.Settings.Default.Save();

                using (var fileStream = new FileStream(txtImage1Path.Text, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = new Bitmap(fileStream).Resize(400, 500);
                }
            }
        }

        private void btnBrowseImage2_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            txtImage2Path.Text = Properties.Settings.Default.Image2Path = openFileDialog.FileName;
            Properties.Settings.Default.Save();
            using (var fileStream = new FileStream(txtImage2Path.Text, FileMode.Open, FileAccess.Read))
            {
                pictureBox2.Image = new Bitmap(fileStream).Resize(400, 500);
            }
        }

        private void btnCompare2Images_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Phần trăm match : " + (100 - ImageTool.GetPercentageDifference(txtImage1Path.Text, txtImage2Path.Text) * 100) + "%", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkCheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (DataRow item in _dtDuplicatedItems.Rows)
            {
                item["Check"] = true;
            }
        }

        private void lnkCheckNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (DataRow item in _dtDuplicatedItems.Rows)
            {
                item["Check"] = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Threshold = txtThreshold.Text;
            Properties.Settings.Default.Save();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            btnReplace.Enabled = false;

            StartStatusBar();
            _bgReplaceTask.RunWorkerAsync();
        }

        private void btnTab3BrowsePathFolder1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;

            txtTab3BaseFolder.Text = Properties.Settings.Default.Tab3FolderPath1 = folderBrowserDialog.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void btnTab3BrowsePathFolder2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;

            txtTab3TargetFolder.Text = Properties.Settings.Default.Tab3FolderPath2 = folderBrowserDialog.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void btnTab3Perform_Click(object sender, EventArgs e)
        {
            btnTab3Perform.Enabled = false;
            if (!Directory.Exists(txtTab3BaseFolder.Text) || !Directory.Exists(txtTab3TargetFolder.Text))
            {
                MessageBox.Show(@"Xem lại thư mục!", @"Èèèèè...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            gridTab3Images.DataSource = null;

            StartStatusBar();
            _bgTab3FindingTask.RunWorkerAsync(new[] { txtTab3BaseFolder.Text, txtTab3TargetFolder.Text });
        }

        private void txtTab3Threshold_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Tab3Threshold = txtTab3Threshold.Text;
            Properties.Settings.Default.Save();
        }

        private void txtTab3AcceptableDiff_percent_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Tab3AcceptableDiff = txtTab3AcceptableDiff_percent.Text;
            Properties.Settings.Default.Save();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnTab3CopyDupFilesFolder1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(
                string.Join("\r\n", _listDuplicatedItem
                    .Where(f => 
                        f.DuplicatedFileName.StartsWith(txtTab3BaseFolder.Text) || 
                        f.BaseFileName.StartsWith(txtTab3BaseFolder.Text))
                    .Select(f => f.DuplicatedFileName.StartsWith(txtTab3BaseFolder.Text) ? f.DuplicatedFileName : f.BaseFileName))
            );

            MessageBox.Show("Files copied to clipboard!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTab3CopyDupFilesFolder2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(
                string.Join("\r\n", _listDuplicatedItem
                    .Where(f =>
                        f.DuplicatedFileName.StartsWith(txtTab3TargetFolder.Text) ||
                        f.BaseFileName.StartsWith(txtTab3TargetFolder.Text))
                    .Select(f => f.DuplicatedFileName.StartsWith(txtTab3TargetFolder.Text) ? f.DuplicatedFileName : f.BaseFileName))
            );

            MessageBox.Show("Files copied to clipboard!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
