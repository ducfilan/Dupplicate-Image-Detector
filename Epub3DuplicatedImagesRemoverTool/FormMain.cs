using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Epub3DuplicatedImagesRemoverTool.Helper;
using Epub3DuplicatedImagesRemoverTool.Model;

namespace Epub3DuplicatedImagesRemoverTool
{
    public partial class FormMain : Form
    {
        BackgroundWorker _bgFindingTask = new BackgroundWorker();
        BackgroundWorker _bgReplaceTask = new BackgroundWorker();
        List<DuplicatedItem> _listDuplicatedItem = new List<DuplicatedItem>();
        DataTable _dtDuplicatedItems = new DataTable();

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

        private void GetDuplicatedItemsList(string path)
        {
            _listDuplicatedItem = new List<DuplicatedItem>();
            foreach (var subDir in Directory.GetDirectories(path))
            {
                foreach (var duplicateImageList in ImageTool.GetDuplicateImages(subDir, false))
                {
                    for (int i = 1; i < duplicateImageList.Count; i++)
                    {
                        var duplicatedItem = new DuplicatedItem()
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

            _dtDuplicatedItems.Columns.Add("Id");
            _dtDuplicatedItems.Columns.Add("Check");
            _dtDuplicatedItems.Columns.Add("BaseFileName");
            _dtDuplicatedItems.Columns.Add("DuplicatedFileName");
            _dtDuplicatedItems.Columns.Add("BaseFileNameImage", typeof(Image));
            _dtDuplicatedItems.Columns.Add("DuplicatedFileNameImage", typeof(Image));
            _dtDuplicatedItems.Columns.Add("XhtmlFileName");
            _dtDuplicatedItems.Columns.Add("XhtmlFileContent");

            int gridId = 1;
            foreach (var item in _listDuplicatedItem)
            {
                var baseImage = Image.FromFile(item.BaseFileName);

                float imageRatio = (float)baseImage.Width / baseImage.Height;

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

        private void btnBrowsePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = Properties.Settings.Default.FolderPath = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            btnPerform.Enabled = false;
            if (!Directory.Exists(txtFolderPath.Text))
            {
                MessageBox.Show(@"Xem lại thư mục!", "Èèèèè...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StartStatusBar();
            _bgFindingTask.RunWorkerAsync(txtFolderPath.Text);
        }

        private void LoadSavedTextboxes()
        {
            txtFolderPath.Text = Properties.Settings.Default.FolderPath;
            txtImage1Path.Text = Properties.Settings.Default.Image1Path;
            txtImage2Path.Text = Properties.Settings.Default.Image2Path;
            txtThreshold.Text = txtThreshold.Text.Equals(string.Empty) ? "5" : Properties.Settings.Default.Threshold;
        }

        private void InitializeBackgroundWorkers()
        {
            _bgFindingTask.DoWork += BgFindingTaskDoWork;
            _bgFindingTask.RunWorkerCompleted += BgFindingTaskRunWorkerCompleted;

            _bgReplaceTask.DoWork += _bgReplaceTask_DoWork;
            _bgReplaceTask.RunWorkerCompleted += _bgReplaceTask_RunWorkerCompleted;
        }

        void _bgReplaceTask_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnReplace.Enabled = true;
            StopStatusBar();

            MessageBox.Show(@"Xong roài!", @"Ấu yè!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void _bgReplaceTask_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (DataGridViewRow duplicatedItem in gridImages.Rows)
            {
                if (!Convert.ToBoolean(duplicatedItem.Cells["Check"].Value)) continue;

                string fileContent = ((string)duplicatedItem.Cells["XhtmlFileContent"].Value).Replace(Path.GetFileName((string)duplicatedItem.Cells["DuplicatedFilePath"].Value), Path.GetFileName((string)duplicatedItem.Cells["BaseFilePath"].Value));
                string duplicatedFileName = duplicatedItem.Cells["DuplicatedFilePath"].Value.ToString();
                string xhtmlFileName = duplicatedItem.Cells["XhtmlFileName"].Value.ToString();

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
                            "Info",
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImage2Path.Text = Properties.Settings.Default.Image2Path = openFileDialog.FileName;
                Properties.Settings.Default.Save();
                using (var fileStream = new FileStream(txtImage2Path.Text, FileMode.Open, FileAccess.Read))
                {
                    pictureBox2.Image = new Bitmap(fileStream).Resize(400, 500);
                }
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

        private void txtThreshold_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            btnReplace.Enabled = false;

            StartStatusBar();
            _bgReplaceTask.RunWorkerAsync();
        }
    }
}
