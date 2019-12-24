namespace CTDB
{
    partial class FormUpload
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpload));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lboxFile = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cdFileType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cdFileAuthor = new System.Windows.Forms.TextBox();
            this.checkSkipSameFile = new System.Windows.Forms.CheckBox();
            this.cdFileRef = new System.Windows.Forms.ComboBox();
            this.cdFileOpenStatus = new System.Windows.Forms.ComboBox();
            this.checkUploadFile = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCountFileSelect = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbDBFile = new System.Windows.Forms.Label();
            this.lboxDB = new System.Windows.Forms.ListBox();
            this.contextMenuStripDatabase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitCreatedFromSlice = new System.Windows.Forms.ToolStripMenuItem();
            this.mitCreatedFromLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.mitDBDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInforToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unSelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCheckDB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bScanDelete = new System.Windows.Forms.Button();
            this.lbSpecimenID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbFileCount = new System.Windows.Forms.Label();
            this.lbDSName = new System.Windows.Forms.Label();
            this.lbDataset = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTableName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pbar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lbNote = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStripDatabase.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbDBFile);
            this.splitContainer1.Panel2.Controls.Add(this.lboxDB);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(784, 539);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lboxFile);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 539);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local Files";
            // 
            // lboxFile
            // 
            this.lboxFile.AllowDrop = true;
            this.lboxFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxFile.FormattingEnabled = true;
            this.lboxFile.HorizontalScrollbar = true;
            this.lboxFile.ItemHeight = 12;
            this.lboxFile.Location = new System.Drawing.Point(3, 240);
            this.lboxFile.Name = "lboxFile";
            this.lboxFile.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxFile.Size = new System.Drawing.Size(370, 296);
            this.lboxFile.TabIndex = 50;
            this.lboxFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.lboxFile_DragDrop);
            this.lboxFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.lboxFile_DragEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cdFileType);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cdFileAuthor);
            this.panel3.Controls.Add(this.checkSkipSameFile);
            this.panel3.Controls.Add(this.cdFileRef);
            this.panel3.Controls.Add(this.cdFileOpenStatus);
            this.panel3.Controls.Add(this.checkUploadFile);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnUpload);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbCountFileSelect);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 223);
            this.panel3.TabIndex = 49;
            // 
            // cdFileType
            // 
            this.cdFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdFileType.FormattingEnabled = true;
            this.cdFileType.Location = new System.Drawing.Point(98, 0);
            this.cdFileType.Name = "cdFileType";
            this.cdFileType.Size = new System.Drawing.Size(87, 20);
            this.cdFileType.TabIndex = 91;
            this.cdFileType.SelectedIndexChanged += new System.EventHandler(this.cdFileType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 90;
            this.label2.Text = "File Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(0, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 12);
            this.label5.TabIndex = 48;
            this.label5.Text = "Selected Files Count :";
            // 
            // cdFileAuthor
            // 
            this.cdFileAuthor.Location = new System.Drawing.Point(98, 78);
            this.cdFileAuthor.Name = "cdFileAuthor";
            this.cdFileAuthor.Size = new System.Drawing.Size(140, 21);
            this.cdFileAuthor.TabIndex = 88;
            this.cdFileAuthor.Text = "-";
            // 
            // checkSkipSameFile
            // 
            this.checkSkipSameFile.AutoSize = true;
            this.checkSkipSameFile.Checked = true;
            this.checkSkipSameFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSkipSameFile.Location = new System.Drawing.Point(193, 172);
            this.checkSkipSameFile.Name = "checkSkipSameFile";
            this.checkSkipSameFile.Size = new System.Drawing.Size(174, 16);
            this.checkSkipSameFile.TabIndex = 52;
            this.checkSkipSameFile.Text = "Skip files with same name";
            this.checkSkipSameFile.UseVisualStyleBackColor = true;
            // 
            // cdFileRef
            // 
            this.cdFileRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdFileRef.FormattingEnabled = true;
            this.cdFileRef.Location = new System.Drawing.Point(98, 49);
            this.cdFileRef.Name = "cdFileRef";
            this.cdFileRef.Size = new System.Drawing.Size(140, 20);
            this.cdFileRef.TabIndex = 87;
            // 
            // cdFileOpenStatus
            // 
            this.cdFileOpenStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdFileOpenStatus.FormattingEnabled = true;
            this.cdFileOpenStatus.Location = new System.Drawing.Point(98, 24);
            this.cdFileOpenStatus.Name = "cdFileOpenStatus";
            this.cdFileOpenStatus.Size = new System.Drawing.Size(140, 20);
            this.cdFileOpenStatus.TabIndex = 87;
            // 
            // checkUploadFile
            // 
            this.checkUploadFile.AutoSize = true;
            this.checkUploadFile.Checked = true;
            this.checkUploadFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUploadFile.Location = new System.Drawing.Point(193, 194);
            this.checkUploadFile.Name = "checkUploadFile";
            this.checkUploadFile.Size = new System.Drawing.Size(174, 16);
            this.checkUploadFile.TabIndex = 51;
            this.checkUploadFile.Text = "Upload file synchronously";
            this.checkUploadFile.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(9, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 12);
            this.label9.TabIndex = 84;
            this.label9.Text = "Source/Ref";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(9, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 12);
            this.label8.TabIndex = 84;
            this.label8.Text = "Owner";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(289, 113);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(69, 53);
            this.btnUpload.TabIndex = 50;
            this.btnUpload.Text = "Upload To DB ->";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.miUpload_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 36);
            this.button1.TabIndex = 50;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.miDelAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(78, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 36);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Clear";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.miDel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 12);
            this.label4.TabIndex = 85;
            this.label4.Text = "Open Status";
            // 
            // lbCountFileSelect
            // 
            this.lbCountFileSelect.AutoSize = true;
            this.lbCountFileSelect.Location = new System.Drawing.Point(142, 212);
            this.lbCountFileSelect.Name = "lbCountFileSelect";
            this.lbCountFileSelect.Size = new System.Drawing.Size(11, 12);
            this.lbCountFileSelect.TabIndex = 48;
            this.lbCountFileSelect.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 53);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Select";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.miAdd_Click);
            // 
            // lbDBFile
            // 
            this.lbDBFile.AutoSize = true;
            this.lbDBFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbDBFile.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDBFile.Location = new System.Drawing.Point(0, 454);
            this.lbDBFile.Name = "lbDBFile";
            this.lbDBFile.Size = new System.Drawing.Size(131, 12);
            this.lbDBFile.TabIndex = 91;
            this.lbDBFile.Text = "Selected file info";
            // 
            // lboxDB
            // 
            this.lboxDB.ContextMenuStrip = this.contextMenuStripDatabase;
            this.lboxDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxDB.FormattingEnabled = true;
            this.lboxDB.HorizontalScrollbar = true;
            this.lboxDB.ItemHeight = 12;
            this.lboxDB.Location = new System.Drawing.Point(0, 93);
            this.lboxDB.Name = "lboxDB";
            this.lboxDB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lboxDB.Size = new System.Drawing.Size(400, 373);
            this.lboxDB.TabIndex = 49;
            this.lboxDB.SelectedIndexChanged += new System.EventHandler(this.lboxDB_SelectedIndexChanged);
            // 
            // contextMenuStripDatabase
            // 
            this.contextMenuStripDatabase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitCreatedFromSlice,
            this.mitCreatedFromLabel,
            this.mitDBDelete,
            this.updateInforToolStripMenuItem,
            this.selectALLToolStripMenuItem,
            this.unSelectAllToolStripMenuItem});
            this.contextMenuStripDatabase.Name = "contextMenuStripDatabase";
            this.contextMenuStripDatabase.Size = new System.Drawing.Size(179, 136);
            // 
            // mitCreatedFromSlice
            // 
            this.mitCreatedFromSlice.Name = "mitCreatedFromSlice";
            this.mitCreatedFromSlice.Size = new System.Drawing.Size(178, 22);
            this.mitCreatedFromSlice.Text = "Created from Slice";
            this.mitCreatedFromSlice.Visible = false;
            this.mitCreatedFromSlice.Click += new System.EventHandler(this.mitCreateExampleFromSlice_Click);
            // 
            // mitCreatedFromLabel
            // 
            this.mitCreatedFromLabel.Name = "mitCreatedFromLabel";
            this.mitCreatedFromLabel.Size = new System.Drawing.Size(178, 22);
            this.mitCreatedFromLabel.Text = "Created from label";
            this.mitCreatedFromLabel.Visible = false;
            this.mitCreatedFromLabel.Click += new System.EventHandler(this.mitCreateExampleFromLabel_Click);
            // 
            // mitDBDelete
            // 
            this.mitDBDelete.Name = "mitDBDelete";
            this.mitDBDelete.Size = new System.Drawing.Size(178, 22);
            this.mitDBDelete.Text = "Delete selected";
            this.mitDBDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // updateInforToolStripMenuItem
            // 
            this.updateInforToolStripMenuItem.Name = "updateInforToolStripMenuItem";
            this.updateInforToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.updateInforToolStripMenuItem.Text = "Update Information";
            this.updateInforToolStripMenuItem.Click += new System.EventHandler(this.updateInforToolStripMenuItem_Click);
            // 
            // selectALLToolStripMenuItem
            // 
            this.selectALLToolStripMenuItem.Name = "selectALLToolStripMenuItem";
            this.selectALLToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.selectALLToolStripMenuItem.Text = "Select ALL";
            this.selectALLToolStripMenuItem.Click += new System.EventHandler(this.selectALLToolStripMenuItem_Click);
            // 
            // unSelectAllToolStripMenuItem
            // 
            this.unSelectAllToolStripMenuItem.Name = "unSelectAllToolStripMenuItem";
            this.unSelectAllToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.unSelectAllToolStripMenuItem.Text = "UnSelect All";
            this.unSelectAllToolStripMenuItem.Click += new System.EventHandler(this.unSelectAllToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.btnCheckDB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 73);
            this.panel2.TabIndex = 52;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(286, 15);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 41);
            this.btnOK.TabIndex = 51;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCheckDB
            // 
            this.btnCheckDB.Location = new System.Drawing.Point(8, 15);
            this.btnCheckDB.Name = "btnCheckDB";
            this.btnCheckDB.Size = new System.Drawing.Size(69, 41);
            this.btnCheckDB.TabIndex = 50;
            this.btnCheckDB.Text = "Check Database";
            this.btnCheckDB.UseVisualStyleBackColor = true;
            this.btnCheckDB.Click += new System.EventHandler(this.btnCheckDB_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 81);
            this.panel1.TabIndex = 51;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bScanDelete);
            this.groupBox2.Controls.Add(this.lbSpecimenID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbFileCount);
            this.groupBox2.Controls.Add(this.lbDSName);
            this.groupBox2.Controls.Add(this.lbDataset);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbTableName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 74);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dataset Information";
            // 
            // bScanDelete
            // 
            this.bScanDelete.Location = new System.Drawing.Point(325, 12);
            this.bScanDelete.Name = "bScanDelete";
            this.bScanDelete.Size = new System.Drawing.Size(69, 53);
            this.bScanDelete.TabIndex = 50;
            this.bScanDelete.Text = "Delete From Database";
            this.bScanDelete.UseVisualStyleBackColor = true;
            this.bScanDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbSpecimenID
            // 
            this.lbSpecimenID.AutoSize = true;
            this.lbSpecimenID.Location = new System.Drawing.Point(250, 17);
            this.lbSpecimenID.Name = "lbSpecimenID";
            this.lbSpecimenID.Size = new System.Drawing.Size(11, 12);
            this.lbSpecimenID.TabIndex = 49;
            this.lbSpecimenID.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(149, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 50;
            this.label7.Text = "SpecimenID";
            // 
            // lbFileCount
            // 
            this.lbFileCount.AutoSize = true;
            this.lbFileCount.Location = new System.Drawing.Point(89, 54);
            this.lbFileCount.Name = "lbFileCount";
            this.lbFileCount.Size = new System.Drawing.Size(11, 12);
            this.lbFileCount.TabIndex = 48;
            this.lbFileCount.Text = "0";
            // 
            // lbDSName
            // 
            this.lbDSName.AutoSize = true;
            this.lbDSName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDSName.Location = new System.Drawing.Point(6, 36);
            this.lbDSName.Name = "lbDSName";
            this.lbDSName.Size = new System.Drawing.Size(89, 12);
            this.lbDSName.TabIndex = 48;
            this.lbDSName.Text = "Remote Files";
            // 
            // lbDataset
            // 
            this.lbDataset.AutoSize = true;
            this.lbDataset.Location = new System.Drawing.Point(89, 17);
            this.lbDataset.Name = "lbDataset";
            this.lbDataset.Size = new System.Drawing.Size(17, 12);
            this.lbDataset.TabIndex = 48;
            this.lbDataset.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "File Count";
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTableName.Location = new System.Drawing.Point(6, 17);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(17, 12);
            this.lbTableName.TabIndex = 48;
            this.lbTableName.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 48;
            this.label1.Text = "Remote Files";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbar1,
            this.lbNote});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pbar1
            // 
            this.pbar1.Name = "pbar1";
            this.pbar1.Size = new System.Drawing.Size(300, 16);
            // 
            // lbNote
            // 
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(33, 17);
            this.lbNote.Text = "Note";
            // 
            // FormUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CTDB - File";
            this.Load += new System.EventHandler(this.FormUpload_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.contextMenuStripDatabase.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pbar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboxDB;
        private System.Windows.Forms.ToolStripStatusLabel lbNote;
        private System.Windows.Forms.Label lbDataset;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.Label lbDSName;
        private System.Windows.Forms.Button bScanDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbFileCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lboxFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbCountFileSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheckDB;
        private System.Windows.Forms.CheckBox checkUploadFile;
        private System.Windows.Forms.CheckBox checkSkipSameFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDBFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDatabase;
        private System.Windows.Forms.ToolStripMenuItem mitCreatedFromSlice;
        private System.Windows.Forms.ToolStripMenuItem mitCreatedFromLabel;
        private System.Windows.Forms.ToolStripMenuItem mitDBDelete;
        private System.Windows.Forms.ComboBox cdFileType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSpecimenID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cdFileAuthor;
        private System.Windows.Forms.ComboBox cdFileRef;
        private System.Windows.Forms.ComboBox cdFileOpenStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem updateInforToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem selectALLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unSelectAllToolStripMenuItem;
    }
}