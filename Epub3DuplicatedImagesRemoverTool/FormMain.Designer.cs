namespace Epub3DuplicatedImagesRemoverTool
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnBrowsePath = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPerform = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.lnkCheckNone = new System.Windows.Forms.LinkLabel();
            this.lnkCheckAll = new System.Windows.Forms.LinkLabel();
            this.btnReplace = new System.Windows.Forms.Button();
            this.gridImages = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BaseFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuplicatedFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.DuplicatedImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.XhtmlFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XhtmlFileContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCompare2Images = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImage2Path = new System.Windows.Forms.TextBox();
            this.btnBrowseImage2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImage1Path = new System.Windows.Forms.TextBox();
            this.btnBrowseImage1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridTab3Images = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTab3TargetFolder = new System.Windows.Forms.TextBox();
            this.btnTab3BrowsePathFolder2 = new System.Windows.Forms.Button();
            this.btnTab3Perform = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTab3Threshold = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTab3BaseFolder = new System.Windows.Forms.TextBox();
            this.btnTab3BrowsePathFolder1 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnTab3CopyDupFilesFolder1 = new System.Windows.Forms.Button();
            this.btnTab3CopyDupFilesFolder2 = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImages)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTab3Images)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Folder";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderPath.Location = new System.Drawing.Point(83, 7);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(498, 19);
            this.txtFolderPath.TabIndex = 1;
            // 
            // btnBrowsePath
            // 
            this.btnBrowsePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowsePath.Location = new System.Drawing.Point(587, 6);
            this.btnBrowsePath.Name = "btnBrowsePath";
            this.btnBrowsePath.Size = new System.Drawing.Size(75, 21);
            this.btnBrowsePath.TabIndex = 2;
            this.btnBrowsePath.Text = "Browse";
            this.btnBrowsePath.UseVisualStyleBackColor = true;
            this.btnBrowsePath.Click += new System.EventHandler(this.btnBrowsePath_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 588);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(861, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel.Text = "Bem đi :3";
            // 
            // lnkAbout
            // 
            this.lnkAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAbout.Location = new System.Drawing.Point(809, 574);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(40, 16);
            this.lnkAbout.TabIndex = 5;
            this.lnkAbout.TabStop = true;
            this.lnkAbout.Text = "About";
            this.lnkAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 560);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPerform);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtThreshold);
            this.tabPage1.Controls.Add(this.lnkCheckNone);
            this.tabPage1.Controls.Add(this.lnkCheckAll);
            this.tabPage1.Controls.Add(this.btnReplace);
            this.tabPage1.Controls.Add(this.gridImages);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtFolderPath);
            this.tabPage1.Controls.Add(this.btnBrowsePath);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Batch Process";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPerform
            // 
            this.btnPerform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPerform.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerform.ForeColor = System.Drawing.Color.White;
            this.btnPerform.Location = new System.Drawing.Point(678, 6);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(145, 62);
            this.btnPerform.TabIndex = 10;
            this.btnPerform.Text = "FIND";
            this.btnPerform.UseVisualStyleBackColor = false;
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Threshold";
            // 
            // txtThreshold
            // 
            this.txtThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThreshold.Location = new System.Drawing.Point(83, 48);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(579, 19);
            this.txtThreshold.TabIndex = 9;
            this.txtThreshold.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThreshold_KeyPress);
            // 
            // lnkCheckNone
            // 
            this.lnkCheckNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkCheckNone.AutoSize = true;
            this.lnkCheckNone.Location = new System.Drawing.Point(65, 490);
            this.lnkCheckNone.Name = "lnkCheckNone";
            this.lnkCheckNone.Size = new System.Drawing.Size(67, 12);
            this.lnkCheckNone.TabIndex = 7;
            this.lnkCheckNone.TabStop = true;
            this.lnkCheckNone.Text = "Check None";
            this.lnkCheckNone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCheckNone_LinkClicked);
            // 
            // lnkCheckAll
            // 
            this.lnkCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkCheckAll.AutoSize = true;
            this.lnkCheckAll.Location = new System.Drawing.Point(7, 490);
            this.lnkCheckAll.Name = "lnkCheckAll";
            this.lnkCheckAll.Size = new System.Drawing.Size(55, 12);
            this.lnkCheckAll.TabIndex = 6;
            this.lnkCheckAll.TabStop = true;
            this.lnkCheckAll.Text = "Check All";
            this.lnkCheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCheckAll_LinkClicked);
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.ForeColor = System.Drawing.Color.White;
            this.btnReplace.Location = new System.Drawing.Point(658, 490);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(165, 41);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "REPLACE";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // gridImages
            // 
            this.gridImages.AllowUserToAddRows = false;
            this.gridImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridImages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridImages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Check,
            this.BaseFilePath,
            this.DuplicatedFilePath,
            this.BaseImage,
            this.DuplicatedImage,
            this.XhtmlFileName,
            this.XhtmlFileContent});
            this.gridImages.Location = new System.Drawing.Point(10, 73);
            this.gridImages.Name = "gridImages";
            this.gridImages.Size = new System.Drawing.Size(813, 412);
            this.gridImages.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "-";
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            this.Id.Width = 36;
            // 
            // Check
            // 
            this.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Check.DataPropertyName = "Check";
            this.Check.FalseValue = "false";
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.TrueValue = "true";
            this.Check.Width = 5;
            // 
            // BaseFilePath
            // 
            this.BaseFilePath.DataPropertyName = "BaseFileName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BaseFilePath.DefaultCellStyle = dataGridViewCellStyle2;
            this.BaseFilePath.HeaderText = "Base File Path";
            this.BaseFilePath.Name = "BaseFilePath";
            this.BaseFilePath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BaseFilePath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DuplicatedFilePath
            // 
            this.DuplicatedFilePath.DataPropertyName = "DuplicatedFileName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DuplicatedFilePath.DefaultCellStyle = dataGridViewCellStyle3;
            this.DuplicatedFilePath.HeaderText = "Duplicated File Path";
            this.DuplicatedFilePath.Name = "DuplicatedFilePath";
            this.DuplicatedFilePath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DuplicatedFilePath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BaseImage
            // 
            this.BaseImage.DataPropertyName = "BaseFileNameImage";
            this.BaseImage.HeaderText = "Base Image";
            this.BaseImage.Name = "BaseImage";
            this.BaseImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DuplicatedImage
            // 
            this.DuplicatedImage.DataPropertyName = "DuplicatedFileNameImage";
            this.DuplicatedImage.HeaderText = "Duplicated Image";
            this.DuplicatedImage.Name = "DuplicatedImage";
            this.DuplicatedImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DuplicatedImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // XhtmlFileName
            // 
            this.XhtmlFileName.DataPropertyName = "XhtmlFileName";
            this.XhtmlFileName.HeaderText = "Xhtml FileName";
            this.XhtmlFileName.Name = "XhtmlFileName";
            this.XhtmlFileName.Visible = false;
            // 
            // XhtmlFileContent
            // 
            this.XhtmlFileContent.DataPropertyName = "XhtmlFileContent";
            this.XhtmlFileContent.HeaderText = "Xhtml File Content";
            this.XhtmlFileContent.Name = "XhtmlFileContent";
            this.XhtmlFileContent.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.btnCompare2Images);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtImage2Path);
            this.tabPage2.Controls.Add(this.btnBrowseImage2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtImage1Path);
            this.tabPage2.Controls.Add(this.btnBrowseImage1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(829, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compare 2 images";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(816, 458);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(411, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(402, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "IMAGE 2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(411, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(402, 434);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(3, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(402, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "IMAGE 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 434);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnCompare2Images
            // 
            this.btnCompare2Images.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare2Images.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCompare2Images.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare2Images.ForeColor = System.Drawing.Color.White;
            this.btnCompare2Images.Location = new System.Drawing.Point(678, 6);
            this.btnCompare2Images.Name = "btnCompare2Images";
            this.btnCompare2Images.Size = new System.Drawing.Size(145, 62);
            this.btnCompare2Images.TabIndex = 9;
            this.btnCompare2Images.Text = "BEM";
            this.btnCompare2Images.UseVisualStyleBackColor = false;
            this.btnCompare2Images.Click += new System.EventHandler(this.btnCompare2Images_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Image 2 Path";
            // 
            // txtImage2Path
            // 
            this.txtImage2Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImage2Path.Location = new System.Drawing.Point(83, 48);
            this.txtImage2Path.Name = "txtImage2Path";
            this.txtImage2Path.Size = new System.Drawing.Size(498, 19);
            this.txtImage2Path.TabIndex = 7;
            // 
            // btnBrowseImage2
            // 
            this.btnBrowseImage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseImage2.Location = new System.Drawing.Point(587, 46);
            this.btnBrowseImage2.Name = "btnBrowseImage2";
            this.btnBrowseImage2.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseImage2.TabIndex = 8;
            this.btnBrowseImage2.Text = "Browse";
            this.btnBrowseImage2.UseVisualStyleBackColor = true;
            this.btnBrowseImage2.Click += new System.EventHandler(this.btnBrowseImage2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Image 1 Path";
            // 
            // txtImage1Path
            // 
            this.txtImage1Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImage1Path.Location = new System.Drawing.Point(83, 7);
            this.txtImage1Path.Name = "txtImage1Path";
            this.txtImage1Path.Size = new System.Drawing.Size(498, 19);
            this.txtImage1Path.TabIndex = 4;
            // 
            // btnBrowseImage1
            // 
            this.btnBrowseImage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseImage1.Location = new System.Drawing.Point(587, 6);
            this.btnBrowseImage1.Name = "btnBrowseImage1";
            this.btnBrowseImage1.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseImage1.TabIndex = 5;
            this.btnBrowseImage1.Text = "Browse";
            this.btnBrowseImage1.UseVisualStyleBackColor = true;
            this.btnBrowseImage1.Click += new System.EventHandler(this.btnBrowseImage1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnTab3CopyDupFilesFolder2);
            this.tabPage3.Controls.Add(this.btnTab3CopyDupFilesFolder1);
            this.tabPage3.Controls.Add(this.gridTab3Images);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtTab3TargetFolder);
            this.tabPage3.Controls.Add(this.btnTab3BrowsePathFolder2);
            this.tabPage3.Controls.Add(this.btnTab3Perform);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtTab3Threshold);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtTab3BaseFolder);
            this.tabPage3.Controls.Add(this.btnTab3BrowsePathFolder1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(829, 534);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Find duplicated files in 2 folders";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridTab3Images
            // 
            this.gridTab3Images.AllowUserToAddRows = false;
            this.gridTab3Images.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTab3Images.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTab3Images.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridTab3Images.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTab3Images.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gridTab3Images.Location = new System.Drawing.Point(7, 84);
            this.gridTab3Images.Name = "gridTab3Images";
            this.gridTab3Images.Size = new System.Drawing.Size(813, 395);
            this.gridTab3Images.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "-";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 36;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Check";
            this.dataGridViewCheckBoxColumn1.FalseValue = "false";
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "true";
            this.dataGridViewCheckBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BaseFileName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.HeaderText = "Base File Path";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DuplicatedFileName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "Duplicated File Path";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "BaseFileNameImage";
            this.dataGridViewImageColumn1.HeaderText = "Base Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "DuplicatedFileNameImage";
            this.dataGridViewImageColumn2.HeaderText = "Duplicated Image";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "XhtmlFileName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Xhtml FileName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "XhtmlFileContent";
            this.dataGridViewTextBoxColumn5.HeaderText = "Xhtml File Content";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "Target Folder";
            // 
            // txtTab3TargetFolder
            // 
            this.txtTab3TargetFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTab3TargetFolder.Location = new System.Drawing.Point(87, 33);
            this.txtTab3TargetFolder.Name = "txtTab3TargetFolder";
            this.txtTab3TargetFolder.Size = new System.Drawing.Size(502, 19);
            this.txtTab3TargetFolder.TabIndex = 21;
            // 
            // btnTab3BrowsePathFolder2
            // 
            this.btnTab3BrowsePathFolder2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTab3BrowsePathFolder2.Location = new System.Drawing.Point(595, 31);
            this.btnTab3BrowsePathFolder2.Name = "btnTab3BrowsePathFolder2";
            this.btnTab3BrowsePathFolder2.Size = new System.Drawing.Size(75, 21);
            this.btnTab3BrowsePathFolder2.TabIndex = 22;
            this.btnTab3BrowsePathFolder2.Text = "Browse";
            this.btnTab3BrowsePathFolder2.UseVisualStyleBackColor = true;
            this.btnTab3BrowsePathFolder2.Click += new System.EventHandler(this.btnTab3BrowsePathFolder2_Click);
            // 
            // btnTab3Perform
            // 
            this.btnTab3Perform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTab3Perform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTab3Perform.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTab3Perform.ForeColor = System.Drawing.Color.White;
            this.btnTab3Perform.Location = new System.Drawing.Point(676, 7);
            this.btnTab3Perform.Name = "btnTab3Perform";
            this.btnTab3Perform.Size = new System.Drawing.Size(145, 70);
            this.btnTab3Perform.TabIndex = 19;
            this.btnTab3Perform.Text = "FIND";
            this.btnTab3Perform.UseVisualStyleBackColor = false;
            this.btnTab3Perform.Click += new System.EventHandler(this.btnTab3Perform_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "Threshold";
            // 
            // txtTab3Threshold
            // 
            this.txtTab3Threshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTab3Threshold.Location = new System.Drawing.Point(87, 59);
            this.txtTab3Threshold.Name = "txtTab3Threshold";
            this.txtTab3Threshold.Size = new System.Drawing.Size(583, 19);
            this.txtTab3Threshold.TabIndex = 18;
            this.txtTab3Threshold.TextChanged += new System.EventHandler(this.txtTab3Threshold_TextChanged);
            this.txtTab3Threshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTab3Threshold_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Base Folder";
            // 
            // txtTab3BaseFolder
            // 
            this.txtTab3BaseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTab3BaseFolder.Location = new System.Drawing.Point(87, 8);
            this.txtTab3BaseFolder.Name = "txtTab3BaseFolder";
            this.txtTab3BaseFolder.Size = new System.Drawing.Size(502, 19);
            this.txtTab3BaseFolder.TabIndex = 15;
            // 
            // btnTab3BrowsePathFolder1
            // 
            this.btnTab3BrowsePathFolder1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTab3BrowsePathFolder1.Location = new System.Drawing.Point(595, 7);
            this.btnTab3BrowsePathFolder1.Name = "btnTab3BrowsePathFolder1";
            this.btnTab3BrowsePathFolder1.Size = new System.Drawing.Size(75, 21);
            this.btnTab3BrowsePathFolder1.TabIndex = 16;
            this.btnTab3BrowsePathFolder1.Text = "Browse";
            this.btnTab3BrowsePathFolder1.UseVisualStyleBackColor = true;
            this.btnTab3BrowsePathFolder1.Click += new System.EventHandler(this.btnTab3BrowsePathFolder1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files|*.jpg;*.png;*.bmp;*.gif";
            // 
            // btnTab3CopyDupFilesFolder1
            // 
            this.btnTab3CopyDupFilesFolder1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTab3CopyDupFilesFolder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTab3CopyDupFilesFolder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTab3CopyDupFilesFolder1.ForeColor = System.Drawing.Color.White;
            this.btnTab3CopyDupFilesFolder1.Location = new System.Drawing.Point(7, 485);
            this.btnTab3CopyDupFilesFolder1.Name = "btnTab3CopyDupFilesFolder1";
            this.btnTab3CopyDupFilesFolder1.Size = new System.Drawing.Size(403, 46);
            this.btnTab3CopyDupFilesFolder1.TabIndex = 24;
            this.btnTab3CopyDupFilesFolder1.Text = "Copy dupplicated files from folder 1";
            this.btnTab3CopyDupFilesFolder1.UseVisualStyleBackColor = false;
            this.btnTab3CopyDupFilesFolder1.Click += new System.EventHandler(this.btnTab3CopyDupFilesFolder1_Click);
            // 
            // btnTab3CopyDupFilesFolder2
            // 
            this.btnTab3CopyDupFilesFolder2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTab3CopyDupFilesFolder2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTab3CopyDupFilesFolder2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTab3CopyDupFilesFolder2.ForeColor = System.Drawing.Color.White;
            this.btnTab3CopyDupFilesFolder2.Location = new System.Drawing.Point(418, 485);
            this.btnTab3CopyDupFilesFolder2.Name = "btnTab3CopyDupFilesFolder2";
            this.btnTab3CopyDupFilesFolder2.Size = new System.Drawing.Size(403, 46);
            this.btnTab3CopyDupFilesFolder2.TabIndex = 25;
            this.btnTab3CopyDupFilesFolder2.Text = "Copy dupplicated files from folder 2";
            this.btnTab3CopyDupFilesFolder2.UseVisualStyleBackColor = false;
            this.btnTab3CopyDupFilesFolder2.Click += new System.EventHandler(this.btnTab3CopyDupFilesFolder2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 610);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lnkAbout);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPUB3 Duplicated Images Remover Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImages)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTab3Images)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnBrowsePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.LinkLabel lnkAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCompare2Images;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImage2Path;
        private System.Windows.Forms.Button btnBrowseImage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImage1Path;
        private System.Windows.Forms.Button btnBrowseImage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView gridImages;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.LinkLabel lnkCheckNone;
        private System.Windows.Forms.LinkLabel lnkCheckAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.Button btnPerform;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuplicatedFilePath;
        private System.Windows.Forms.DataGridViewImageColumn BaseImage;
        private System.Windows.Forms.DataGridViewImageColumn DuplicatedImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn XhtmlFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn XhtmlFileContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridTab3Images;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTab3TargetFolder;
        private System.Windows.Forms.Button btnTab3BrowsePathFolder2;
        private System.Windows.Forms.Button btnTab3Perform;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTab3Threshold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTab3BaseFolder;
        private System.Windows.Forms.Button btnTab3BrowsePathFolder1;
        private System.Windows.Forms.Button btnTab3CopyDupFilesFolder1;
        private System.Windows.Forms.Button btnTab3CopyDupFilesFolder2;
    }
}

