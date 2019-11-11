namespace CTDB
{
    partial class FormQuick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuick));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mitDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cscanEquipment = new System.Windows.Forms.ComboBox();
            this.tbParas = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cscanTagSpecimenParty = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.cscanExposure = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cscanSourceVoltage = new System.Windows.Forms.TextBox();
            this.cscanSourceCurrent = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cscanCameraBinning = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cscanTimeBegin = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cscanPath = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cspeciesNote = new System.Windows.Forms.TextBox();
            this.cspeciesOrder = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.csmSavePosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.csmSex = new System.Windows.Forms.ComboBox();
            this.csmAge = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.csmSPID = new System.Windows.Forms.TextBox();
            this.csmNote = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.csmCollector = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.csmCollectTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.csmCollectPlace = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.csliceSavePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.csmDryCycleTime = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.csmDehydrant = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.bsmAdd = new System.Windows.Forms.Button();
            this.csliceID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mitViewInBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.mitViewMeta = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 415);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(872, 212);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitAddFile,
            this.mitDelete,
            this.mitViewInBrowser,
            this.mitViewMeta});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // mitAddFile
            // 
            this.mitAddFile.Name = "mitAddFile";
            this.mitAddFile.Size = new System.Drawing.Size(180, 22);
            this.mitAddFile.Text = "Add Slice Files";
            this.mitAddFile.Click += new System.EventHandler(this.mitAddFile_Click);
            // 
            // mitDelete
            // 
            this.mitDelete.Enabled = false;
            this.mitDelete.Name = "mitDelete";
            this.mitDelete.Size = new System.Drawing.Size(180, 22);
            this.mitDelete.Text = "Delete";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(750, 353);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 42);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.tbParas);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnAddFile);
            this.panel1.Controls.Add(this.bsmAdd);
            this.panel1.Controls.Add(this.csliceID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 415);
            this.panel1.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(571, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 12);
            this.label11.TabIndex = 114;
            this.label11.Text = "Paste record below for parsing";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cscanEquipment);
            this.groupBox7.Location = new System.Drawing.Point(292, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(262, 38);
            this.groupBox7.TabIndex = 106;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Equipment";
            // 
            // cscanEquipment
            // 
            this.cscanEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cscanEquipment.FormattingEnabled = true;
            this.cscanEquipment.Location = new System.Drawing.Point(6, 13);
            this.cscanEquipment.Name = "cscanEquipment";
            this.cscanEquipment.Size = new System.Drawing.Size(240, 20);
            this.cscanEquipment.TabIndex = 103;
            // 
            // tbParas
            // 
            this.tbParas.Location = new System.Drawing.Point(573, 24);
            this.tbParas.Multiline = true;
            this.tbParas.Name = "tbParas";
            this.tbParas.Size = new System.Drawing.Size(287, 271);
            this.tbParas.TabIndex = 0;
            this.tbParas.TextChanged += new System.EventHandler(this.tbParas_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cscanTagSpecimenParty);
            this.groupBox5.Controls.Add(this.label51);
            this.groupBox5.Controls.Add(this.cscanExposure);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.cscanSourceVoltage);
            this.groupBox5.Controls.Add(this.cscanSourceCurrent);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.cscanCameraBinning);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.cscanTimeBegin);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.cscanPath);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(292, 47);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 218);
            this.groupBox5.TabIndex = 104;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Scan Information";
            // 
            // cscanTagSpecimenParty
            // 
            this.cscanTagSpecimenParty.FormattingEnabled = true;
            this.cscanTagSpecimenParty.Location = new System.Drawing.Point(103, 14);
            this.cscanTagSpecimenParty.Name = "cscanTagSpecimenParty";
            this.cscanTagSpecimenParty.Size = new System.Drawing.Size(143, 20);
            this.cscanTagSpecimenParty.TabIndex = 114;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(9, 17);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(83, 12);
            this.label51.TabIndex = 113;
            this.label51.Text = "Specimen Part";
            // 
            // cscanExposure
            // 
            this.cscanExposure.Location = new System.Drawing.Point(126, 187);
            this.cscanExposure.Name = "cscanExposure";
            this.cscanExposure.Size = new System.Drawing.Size(55, 21);
            this.cscanExposure.TabIndex = 112;
            this.cscanExposure.Text = "2010";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(9, 193);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(77, 12);
            this.label36.TabIndex = 111;
            this.label36.Text = "Exposure (s)";
            // 
            // cscanSourceVoltage
            // 
            this.cscanSourceVoltage.Location = new System.Drawing.Point(126, 132);
            this.cscanSourceVoltage.Name = "cscanSourceVoltage";
            this.cscanSourceVoltage.Size = new System.Drawing.Size(55, 21);
            this.cscanSourceVoltage.TabIndex = 108;
            this.cscanSourceVoltage.Text = "40";
            // 
            // cscanSourceCurrent
            // 
            this.cscanSourceCurrent.Location = new System.Drawing.Point(126, 159);
            this.cscanSourceCurrent.Name = "cscanSourceCurrent";
            this.cscanSourceCurrent.Size = new System.Drawing.Size(55, 21);
            this.cscanSourceCurrent.TabIndex = 110;
            this.cscanSourceCurrent.Text = "250";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 165);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(89, 12);
            this.label28.TabIndex = 109;
            this.label28.Text = "Source Current";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 135);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(89, 12);
            this.label27.TabIndex = 107;
            this.label27.Text = "Source Voltage";
            // 
            // cscanCameraBinning
            // 
            this.cscanCameraBinning.Location = new System.Drawing.Point(126, 99);
            this.cscanCameraBinning.Name = "cscanCameraBinning";
            this.cscanCameraBinning.Size = new System.Drawing.Size(55, 21);
            this.cscanCameraBinning.TabIndex = 106;
            this.cscanCameraBinning.Text = "1x1";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 102);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(89, 12);
            this.label29.TabIndex = 105;
            this.label29.Text = "Camera Binning";
            // 
            // cscanTimeBegin
            // 
            this.cscanTimeBegin.Location = new System.Drawing.Point(103, 69);
            this.cscanTimeBegin.Name = "cscanTimeBegin";
            this.cscanTimeBegin.Size = new System.Drawing.Size(143, 21);
            this.cscanTimeBegin.TabIndex = 104;
            this.cscanTimeBegin.Text = "2015-2-20";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 77;
            this.label19.Text = "Date/Time";
            // 
            // cscanPath
            // 
            this.cscanPath.Location = new System.Drawing.Point(103, 42);
            this.cscanPath.Name = "cscanPath";
            this.cscanPath.Size = new System.Drawing.Size(143, 21);
            this.cscanPath.TabIndex = 81;
            this.cscanPath.Text = "No";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 96;
            this.label17.Text = "Save Path";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cspeciesNote);
            this.groupBox4.Controls.Add(this.cspeciesOrder);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(12, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 74);
            this.groupBox4.TabIndex = 103;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Species Information";
            // 
            // cspeciesNote
            // 
            this.cspeciesNote.Location = new System.Drawing.Point(75, 16);
            this.cspeciesNote.Name = "cspeciesNote";
            this.cspeciesNote.Size = new System.Drawing.Size(171, 21);
            this.cspeciesNote.TabIndex = 104;
            this.cspeciesNote.Text = "-";
            // 
            // cspeciesOrder
            // 
            this.cspeciesOrder.FormattingEnabled = true;
            this.cspeciesOrder.Items.AddRange(new object[] {
            "Adult",
            "Larva -1",
            "Larva -2",
            "Larva -3",
            "Larva -4",
            "Nymph",
            "Egg"});
            this.cspeciesOrder.Location = new System.Drawing.Point(74, 43);
            this.cspeciesOrder.Name = "cspeciesOrder";
            this.cspeciesOrder.Size = new System.Drawing.Size(171, 20);
            this.cspeciesOrder.TabIndex = 103;
            this.cspeciesOrder.Text = "Coleoptera";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 93;
            this.label10.Text = "Name|Note";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 96;
            this.label14.Text = "Order";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.csmSavePosition);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.csmSex);
            this.groupBox3.Controls.Add(this.csmAge);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.csmSPID);
            this.groupBox3.Controls.Add(this.csmNote);
            this.groupBox3.Location = new System.Drawing.Point(12, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 170);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Specimen Information";
            // 
            // csmSavePosition
            // 
            this.csmSavePosition.Location = new System.Drawing.Point(75, 140);
            this.csmSavePosition.Name = "csmSavePosition";
            this.csmSavePosition.Size = new System.Drawing.Size(171, 21);
            this.csmSavePosition.TabIndex = 77;
            this.csmSavePosition.Text = "T7900/F/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 78;
            this.label6.Text = "Save Path";
            // 
            // csmSex
            // 
            this.csmSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.csmSex.FormattingEnabled = true;
            this.csmSex.Location = new System.Drawing.Point(75, 47);
            this.csmSex.Name = "csmSex";
            this.csmSex.Size = new System.Drawing.Size(171, 20);
            this.csmSex.TabIndex = 103;
            // 
            // csmAge
            // 
            this.csmAge.FormattingEnabled = true;
            this.csmAge.Items.AddRange(new object[] {
            "Adult",
            "Larva -1",
            "Larva -2",
            "Larva -3",
            "Larva -4",
            "Nymph",
            "Egg"});
            this.csmAge.Location = new System.Drawing.Point(75, 73);
            this.csmAge.Name = "csmAge";
            this.csmAge.Size = new System.Drawing.Size(171, 20);
            this.csmAge.TabIndex = 102;
            this.csmAge.Text = "Adult";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 27);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 12);
            this.label30.TabIndex = 93;
            this.label30.Text = "ID/Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 100;
            this.label5.Text = "Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 77;
            this.label3.Text = "Note";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 100;
            this.label1.Text = "Age";
            // 
            // csmSPID
            // 
            this.csmSPID.Location = new System.Drawing.Point(75, 20);
            this.csmSPID.Name = "csmSPID";
            this.csmSPID.Size = new System.Drawing.Size(171, 21);
            this.csmSPID.TabIndex = 94;
            this.csmSPID.Text = "-";
            // 
            // csmNote
            // 
            this.csmNote.Location = new System.Drawing.Point(75, 100);
            this.csmNote.Multiline = true;
            this.csmNote.Name = "csmNote";
            this.csmNote.Size = new System.Drawing.Size(171, 34);
            this.csmNote.TabIndex = 82;
            this.csmNote.Text = "-";
            this.csmNote.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.csmCollector);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.csmCollectTime);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.csmCollectPlace);
            this.groupBox2.Location = new System.Drawing.Point(12, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 110);
            this.groupBox2.TabIndex = 98;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Collection Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 85;
            this.label7.Text = "Collector";
            // 
            // csmCollector
            // 
            this.csmCollector.Location = new System.Drawing.Point(97, 28);
            this.csmCollector.Name = "csmCollector";
            this.csmCollector.Size = new System.Drawing.Size(148, 21);
            this.csmCollector.TabIndex = 86;
            this.csmCollector.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 87;
            this.label8.Text = "CollectTime";
            // 
            // csmCollectTime
            // 
            this.csmCollectTime.Location = new System.Drawing.Point(97, 54);
            this.csmCollectTime.Name = "csmCollectTime";
            this.csmCollectTime.Size = new System.Drawing.Size(148, 21);
            this.csmCollectTime.TabIndex = 88;
            this.csmCollectTime.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 89;
            this.label9.Text = "CollectPlace";
            // 
            // csmCollectPlace
            // 
            this.csmCollectPlace.Location = new System.Drawing.Point(97, 80);
            this.csmCollectPlace.Name = "csmCollectPlace";
            this.csmCollectPlace.Size = new System.Drawing.Size(148, 21);
            this.csmCollectPlace.TabIndex = 90;
            this.csmCollectPlace.Text = "-";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.csliceSavePath);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(292, 271);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(262, 52);
            this.groupBox6.TabIndex = 95;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Slice Images Information";
            // 
            // csliceSavePath
            // 
            this.csliceSavePath.Location = new System.Drawing.Point(101, 17);
            this.csliceSavePath.Name = "csliceSavePath";
            this.csliceSavePath.Size = new System.Drawing.Size(145, 21);
            this.csliceSavePath.TabIndex = 67;
            this.csliceSavePath.Text = "T7900/F/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 70;
            this.label2.Text = "Save Path";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.csmDryCycleTime);
            this.groupBox1.Controls.Add(this.label60);
            this.groupBox1.Controls.Add(this.csmDehydrant);
            this.groupBox1.Controls.Add(this.label59);
            this.groupBox1.Location = new System.Drawing.Point(292, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 74);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dehydration Information";
            // 
            // csmDryCycleTime
            // 
            this.csmDryCycleTime.Location = new System.Drawing.Point(100, 44);
            this.csmDryCycleTime.Name = "csmDryCycleTime";
            this.csmDryCycleTime.Size = new System.Drawing.Size(145, 21);
            this.csmDryCycleTime.TabIndex = 67;
            this.csmDryCycleTime.Text = "25";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(7, 20);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(59, 12);
            this.label60.TabIndex = 70;
            this.label60.Text = "Dehydrant";
            // 
            // csmDehydrant
            // 
            this.csmDehydrant.FormattingEnabled = true;
            this.csmDehydrant.Items.AddRange(new object[] {
            "75%-100% Alcohol",
            "100% Alcohol",
            "75%-100% Alcohol + Acetone",
            "75% Acetone"});
            this.csmDehydrant.Location = new System.Drawing.Point(100, 17);
            this.csmDehydrant.Name = "csmDehydrant";
            this.csmDehydrant.Size = new System.Drawing.Size(145, 20);
            this.csmDehydrant.TabIndex = 69;
            this.csmDehydrant.Text = "75%-100% Alcohol";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(7, 49);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(65, 12);
            this.label59.TabIndex = 72;
            this.label59.Text = "CycleTimes";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(573, 350);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 42);
            this.btnExport.TabIndex = 79;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(654, 301);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 42);
            this.btnAddFile.TabIndex = 79;
            this.btnAddFile.Text = "Import Batch";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // bsmAdd
            // 
            this.bsmAdd.Location = new System.Drawing.Point(573, 301);
            this.bsmAdd.Name = "bsmAdd";
            this.bsmAdd.Size = new System.Drawing.Size(75, 42);
            this.bsmAdd.TabIndex = 79;
            this.bsmAdd.Text = "Import";
            this.bsmAdd.UseVisualStyleBackColor = true;
            this.bsmAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // csliceID
            // 
            this.csliceID.AutoSize = true;
            this.csliceID.Location = new System.Drawing.Point(100, 6);
            this.csliceID.Name = "csliceID";
            this.csliceID.Size = new System.Drawing.Size(11, 12);
            this.csliceID.TabIndex = 76;
            this.csliceID.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 78;
            this.label4.Text = "Record ID";
            // 
            // mitViewInBrowser
            // 
            this.mitViewInBrowser.Name = "mitViewInBrowser";
            this.mitViewInBrowser.Size = new System.Drawing.Size(180, 22);
            this.mitViewInBrowser.Text = "View in Browser";
            this.mitViewInBrowser.Click += new System.EventHandler(this.mitViewInBrowser_Click);
            // 
            // mitViewMeta
            // 
            this.mitViewMeta.Name = "mitViewMeta";
            this.mitViewMeta.Size = new System.Drawing.Size(180, 22);
            this.mitViewMeta.Text = "View Meta";
            this.mitViewMeta.Click += new System.EventHandler(this.mitViewMeta_Click);
            // 
            // FormQuick
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 627);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(888, 666);
            this.Name = "FormQuick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CTDB - Quick Operation From";
            this.Load += new System.EventHandler(this.CTDBFormAddSpecies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox csmDryCycleTime;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.ComboBox csmDehydrant;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox csmSPID;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox csmCollectPlace;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox csmCollectTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox csmCollector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox csmNote;
        private System.Windows.Forms.Button bsmAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label csliceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mitDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox csmSex;
        private System.Windows.Forms.ComboBox csmAge;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox cscanPath;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbParas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox csmSavePosition;
        private System.Windows.Forms.ComboBox cscanEquipment;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox cscanTimeBegin;
        private System.Windows.Forms.TextBox cscanCameraBinning;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox cscanSourceVoltage;
        private System.Windows.Forms.TextBox cscanSourceCurrent;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox cscanExposure;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox cscanTagSpecimenParty;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox csliceSavePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cspeciesOrder;
        private System.Windows.Forms.TextBox cspeciesNote;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem mitAddFile;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ToolStripMenuItem mitViewInBrowser;
        private System.Windows.Forms.ToolStripMenuItem mitViewMeta;
    }
}