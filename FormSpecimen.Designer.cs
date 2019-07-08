namespace CTDB
{
    partial class FormSpecimen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpecimen));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitAddExample3D = new System.Windows.Forms.ToolStripMenuItem();
            this.addSamplePhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitAddScan = new System.Windows.Forms.ToolStripMenuItem();
            this.mitDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label63 = new System.Windows.Forms.Label();
            this.ucFileInfo1 = new CTDB.ucFileInfo();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbSpeciesLatin = new System.Windows.Forms.Label();
            this.lbSPcount = new System.Windows.Forms.Label();
            this.csmID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSpeciesCHN = new System.Windows.Forms.Label();
            this.csmSpecies = new System.Windows.Forms.ComboBox();
            this.csmNote = new System.Windows.Forms.TextBox();
            this.btnAddSpecies = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.csmPS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.csmDriedSpecimenSavePosition = new System.Windows.Forms.TextBox();
            this.csmSex = new System.Windows.Forms.ComboBox();
            this.csmAge = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.csmSPID = new System.Windows.Forms.TextBox();
            this.btnMDExample = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.csmCollector = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.csmCollectTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.csmCollectPlace = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.csmDryInstrument = new System.Windows.Forms.ComboBox();
            this.csmDryCycleTime = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.csmDehydrant = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.bsmUpdate = new System.Windows.Forms.Button();
            this.bsmDelete = new System.Windows.Forms.Button();
            this.bsmAdd = new System.Windows.Forms.Button();
            this.lbScancount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.csmIdentifier = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 288);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(872, 339);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitAddExample3D,
            this.addSamplePhotoToolStripMenuItem,
            this.mitAddScan,
            this.mitDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 92);
            // 
            // mitAddExample3D
            // 
            this.mitAddExample3D.Name = "mitAddExample3D";
            this.mitAddExample3D.Size = new System.Drawing.Size(173, 22);
            this.mitAddExample3D.Text = "Add 3D Demos";
            this.mitAddExample3D.Click += new System.EventHandler(this.btnAddExample_Click);
            // 
            // addSamplePhotoToolStripMenuItem
            // 
            this.addSamplePhotoToolStripMenuItem.Name = "addSamplePhotoToolStripMenuItem";
            this.addSamplePhotoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addSamplePhotoToolStripMenuItem.Text = "Add Sample Photo";
            this.addSamplePhotoToolStripMenuItem.Click += new System.EventHandler(this.btnAddExample_Click);
            // 
            // mitAddScan
            // 
            this.mitAddScan.Name = "mitAddScan";
            this.mitAddScan.Size = new System.Drawing.Size(173, 22);
            this.mitAddScan.Text = "To Add a Scan";
            this.mitAddScan.Click += new System.EventHandler(this.mitAddScan_Click);
            // 
            // mitDelete
            // 
            this.mitDelete.Enabled = false;
            this.mitDelete.Name = "mitDelete";
            this.mitDelete.Size = new System.Drawing.Size(173, 22);
            this.mitDelete.Text = "Delete";
            this.mitDelete.Click += new System.EventHandler(this.bsmDelete_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(785, 234);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 42);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label63);
            this.panel1.Controls.Add(this.ucFileInfo1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnMDExample);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.bsmUpdate);
            this.panel1.Controls.Add(this.bsmDelete);
            this.panel1.Controls.Add(this.bsmAdd);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 288);
            this.panel1.TabIndex = 46;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(853, 3);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(17, 12);
            this.label63.TabIndex = 105;
            this.label63.Tag = "help_ct_Specimen";
            this.label63.Text = "？";
            this.label63.DoubleClick += new System.EventHandler(this.label62_DoubleClick);
            // 
            // ucFileInfo1
            // 
            this.ucFileInfo1.Location = new System.Drawing.Point(667, 24);
            this.ucFileInfo1.Name = "ucFileInfo1";
            this.ucFileInfo1.ParaDatasetID = 0;
            this.ucFileInfo1.ParaTable = "";
            this.ucFileInfo1.Size = new System.Drawing.Size(195, 42);
            this.ucFileInfo1.TabIndex = 104;
            this.ucFileInfo1.UpdateFile += new System.EventHandler(this.ucFileInfo1_UpdateFile);
            this.ucFileInfo1.OpenFileDialog += new System.EventHandler(this.ucFileInfo1_OpenFileDialog);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbSpeciesLatin);
            this.groupBox4.Controls.Add(this.lbSPcount);
            this.groupBox4.Controls.Add(this.csmID);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lbSpeciesCHN);
            this.groupBox4.Controls.Add(this.csmSpecies);
            this.groupBox4.Controls.Add(this.csmNote);
            this.groupBox4.Controls.Add(this.btnAddSpecies);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 99);
            this.groupBox4.TabIndex = 103;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Record Abstract";
            // 
            // lbSpeciesLatin
            // 
            this.lbSpeciesLatin.AutoSize = true;
            this.lbSpeciesLatin.Location = new System.Drawing.Point(168, 38);
            this.lbSpeciesLatin.Name = "lbSpeciesLatin";
            this.lbSpeciesLatin.Size = new System.Drawing.Size(23, 12);
            this.lbSpeciesLatin.TabIndex = 99;
            this.lbSpeciesLatin.Text = "CHN";
            // 
            // lbSPcount
            // 
            this.lbSPcount.AutoSize = true;
            this.lbSPcount.Location = new System.Drawing.Point(222, 0);
            this.lbSPcount.Name = "lbSPcount";
            this.lbSPcount.Size = new System.Drawing.Size(11, 12);
            this.lbSPcount.TabIndex = 98;
            this.lbSPcount.Text = "0";
            // 
            // csmID
            // 
            this.csmID.AutoSize = true;
            this.csmID.Location = new System.Drawing.Point(109, 0);
            this.csmID.Name = "csmID";
            this.csmID.Size = new System.Drawing.Size(11, 12);
            this.csmID.TabIndex = 76;
            this.csmID.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 83;
            this.label6.Text = "Species";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 77;
            this.label3.Text = "Note";
            // 
            // lbSpeciesCHN
            // 
            this.lbSpeciesCHN.AutoSize = true;
            this.lbSpeciesCHN.Location = new System.Drawing.Point(65, 38);
            this.lbSpeciesCHN.Name = "lbSpeciesCHN";
            this.lbSpeciesCHN.Size = new System.Drawing.Size(23, 12);
            this.lbSpeciesCHN.TabIndex = 97;
            this.lbSpeciesCHN.Text = "CHN";
            // 
            // csmSpecies
            // 
            this.csmSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.csmSpecies.FormattingEnabled = true;
            this.csmSpecies.Location = new System.Drawing.Point(67, 15);
            this.csmSpecies.Name = "csmSpecies";
            this.csmSpecies.Size = new System.Drawing.Size(210, 20);
            this.csmSpecies.TabIndex = 84;
            this.csmSpecies.SelectedIndexChanged += new System.EventHandler(this.csmSpecies_SelectedIndexChanged);
            // 
            // csmNote
            // 
            this.csmNote.Location = new System.Drawing.Point(67, 55);
            this.csmNote.Multiline = true;
            this.csmNote.Name = "csmNote";
            this.csmNote.Size = new System.Drawing.Size(210, 34);
            this.csmNote.TabIndex = 82;
            this.csmNote.Text = "-";
            // 
            // btnAddSpecies
            // 
            this.btnAddSpecies.Location = new System.Drawing.Point(283, 14);
            this.btnAddSpecies.Name = "btnAddSpecies";
            this.btnAddSpecies.Size = new System.Drawing.Size(30, 21);
            this.btnAddSpecies.TabIndex = 80;
            this.btnAddSpecies.Tag = "Add New Species";
            this.btnAddSpecies.Text = "+";
            this.btnAddSpecies.UseVisualStyleBackColor = true;
            this.btnAddSpecies.Click += new System.EventHandler(this.btnAddSpecies_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.csmIdentifier);
            this.groupBox3.Controls.Add(this.csmPS);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.csmDriedSpecimenSavePosition);
            this.groupBox3.Controls.Add(this.csmSex);
            this.groupBox3.Controls.Add(this.csmAge);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.csmSPID);
            this.groupBox3.Location = new System.Drawing.Point(12, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 165);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Specimen Information";
            // 
            // csmPS
            // 
            this.csmPS.FormattingEnabled = true;
            this.csmPS.Items.AddRange(new object[] {
            "Leica EM CPD 300"});
            this.csmPS.Location = new System.Drawing.Point(112, 134);
            this.csmPS.Name = "csmPS";
            this.csmPS.Size = new System.Drawing.Size(179, 20);
            this.csmPS.TabIndex = 104;
            this.csmPS.Text = "Leica EM CPD 300";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 105;
            this.label2.Text = "Preserve Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 76;
            this.label10.Text = "Curator";
            // 
            // csmDriedSpecimenSavePosition
            // 
            this.csmDriedSpecimenSavePosition.Location = new System.Drawing.Point(112, 110);
            this.csmDriedSpecimenSavePosition.Name = "csmDriedSpecimenSavePosition";
            this.csmDriedSpecimenSavePosition.Size = new System.Drawing.Size(179, 21);
            this.csmDriedSpecimenSavePosition.TabIndex = 67;
            this.csmDriedSpecimenSavePosition.Text = "Zong Le";
            // 
            // csmSex
            // 
            this.csmSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.csmSex.FormattingEnabled = true;
            this.csmSex.Location = new System.Drawing.Point(81, 38);
            this.csmSex.Name = "csmSex";
            this.csmSex.Size = new System.Drawing.Size(210, 20);
            this.csmSex.TabIndex = 103;
            // 
            // csmAge
            // 
            this.csmAge.FormattingEnabled = true;
            this.csmAge.Items.AddRange(new object[] {
            "Adult",
            "Larva",
            "Larva - 1",
            "Larva - 2",
            "Larva - 3",
            "Larva - 4",
            "Larva - 5",
            "Nymphae",
            "Egg"});
            this.csmAge.Location = new System.Drawing.Point(81, 62);
            this.csmAge.Name = "csmAge";
            this.csmAge.Size = new System.Drawing.Size(210, 20);
            this.csmAge.TabIndex = 102;
            this.csmAge.Text = "Adult";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 12);
            this.label30.TabIndex = 93;
            this.label30.Text = "ID/Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 100;
            this.label5.Text = "Sex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 100;
            this.label1.Text = "Age";
            // 
            // csmSPID
            // 
            this.csmSPID.Location = new System.Drawing.Point(81, 15);
            this.csmSPID.Name = "csmSPID";
            this.csmSPID.Size = new System.Drawing.Size(210, 21);
            this.csmSPID.TabIndex = 94;
            this.csmSPID.Text = "-";
            // 
            // btnMDExample
            // 
            this.btnMDExample.Enabled = false;
            this.btnMDExample.Location = new System.Drawing.Point(505, 222);
            this.btnMDExample.Name = "btnMDExample";
            this.btnMDExample.Size = new System.Drawing.Size(261, 30);
            this.btnMDExample.TabIndex = 99;
            this.btnMDExample.Text = "Add Example - Right Click Record";
            this.btnMDExample.UseVisualStyleBackColor = true;
            this.btnMDExample.Click += new System.EventHandler(this.btnAddExample_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.csmCollector);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.csmCollectTime);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.csmCollectPlace);
            this.groupBox2.Location = new System.Drawing.Point(385, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 99);
            this.groupBox2.TabIndex = 98;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Collection Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 85;
            this.label7.Text = "Collector";
            // 
            // csmCollector
            // 
            this.csmCollector.Location = new System.Drawing.Point(67, 13);
            this.csmCollector.Name = "csmCollector";
            this.csmCollector.Size = new System.Drawing.Size(200, 21);
            this.csmCollector.TabIndex = 86;
            this.csmCollector.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 87;
            this.label8.Text = "Date/Time";
            // 
            // csmCollectTime
            // 
            this.csmCollectTime.Location = new System.Drawing.Point(67, 39);
            this.csmCollectTime.Name = "csmCollectTime";
            this.csmCollectTime.Size = new System.Drawing.Size(200, 21);
            this.csmCollectTime.TabIndex = 88;
            this.csmCollectTime.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 89;
            this.label9.Text = "Place";
            // 
            // csmCollectPlace
            // 
            this.csmCollectPlace.Location = new System.Drawing.Point(67, 66);
            this.csmCollectPlace.Name = "csmCollectPlace";
            this.csmCollectPlace.Size = new System.Drawing.Size(200, 21);
            this.csmCollectPlace.TabIndex = 90;
            this.csmCollectPlace.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.csmDryInstrument);
            this.groupBox1.Controls.Add(this.csmDryCycleTime);
            this.groupBox1.Controls.Add(this.label60);
            this.groupBox1.Controls.Add(this.label61);
            this.groupBox1.Controls.Add(this.csmDehydrant);
            this.groupBox1.Controls.Add(this.label59);
            this.groupBox1.Location = new System.Drawing.Point(385, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 103);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dehydration Information";
            // 
            // csmDryInstrument
            // 
            this.csmDryInstrument.FormattingEnabled = true;
            this.csmDryInstrument.Items.AddRange(new object[] {
            "Leica EM CPD 300"});
            this.csmDryInstrument.Location = new System.Drawing.Point(78, 45);
            this.csmDryInstrument.Name = "csmDryInstrument";
            this.csmDryInstrument.Size = new System.Drawing.Size(179, 20);
            this.csmDryInstrument.TabIndex = 75;
            this.csmDryInstrument.Text = "Leica EM CPD 300";
            // 
            // csmDryCycleTime
            // 
            this.csmDryCycleTime.Location = new System.Drawing.Point(78, 71);
            this.csmDryCycleTime.Name = "csmDryCycleTime";
            this.csmDryCycleTime.Size = new System.Drawing.Size(179, 21);
            this.csmDryCycleTime.TabIndex = 67;
            this.csmDryCycleTime.Text = "25";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(7, 18);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(59, 12);
            this.label60.TabIndex = 70;
            this.label60.Text = "Dehydrant";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(7, 45);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(65, 12);
            this.label61.TabIndex = 71;
            this.label61.Text = "Instrument";
            // 
            // csmDehydrant
            // 
            this.csmDehydrant.FormattingEnabled = true;
            this.csmDehydrant.Items.AddRange(new object[] {
            "75%-100% Alcohol",
            "100% Alcohol",
            "75%-100% Alcohol + Acetone"});
            this.csmDehydrant.Location = new System.Drawing.Point(78, 18);
            this.csmDehydrant.Name = "csmDehydrant";
            this.csmDehydrant.Size = new System.Drawing.Size(179, 20);
            this.csmDehydrant.TabIndex = 69;
            this.csmDehydrant.Text = "75%-100% Alcohol";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(6, 75);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(71, 12);
            this.label59.TabIndex = 72;
            this.label59.Text = "Cycle Times";
            // 
            // bsmUpdate
            // 
            this.bsmUpdate.Location = new System.Drawing.Point(785, 170);
            this.bsmUpdate.Name = "bsmUpdate";
            this.bsmUpdate.Size = new System.Drawing.Size(75, 42);
            this.bsmUpdate.TabIndex = 92;
            this.bsmUpdate.Text = "Update";
            this.bsmUpdate.UseVisualStyleBackColor = true;
            this.bsmUpdate.Click += new System.EventHandler(this.bsmUpdate_Click);
            // 
            // bsmDelete
            // 
            this.bsmDelete.Enabled = false;
            this.bsmDelete.Location = new System.Drawing.Point(505, 249);
            this.bsmDelete.Name = "bsmDelete";
            this.bsmDelete.Size = new System.Drawing.Size(261, 27);
            this.bsmDelete.TabIndex = 91;
            this.bsmDelete.Text = "Delete - Right Click Record";
            this.bsmDelete.UseVisualStyleBackColor = true;
            this.bsmDelete.Click += new System.EventHandler(this.bsmDelete_Click);
            // 
            // bsmAdd
            // 
            this.bsmAdd.Location = new System.Drawing.Point(691, 171);
            this.bsmAdd.Name = "bsmAdd";
            this.bsmAdd.Size = new System.Drawing.Size(75, 42);
            this.bsmAdd.TabIndex = 79;
            this.bsmAdd.Text = "Add";
            this.bsmAdd.UseVisualStyleBackColor = true;
            this.bsmAdd.Click += new System.EventHandler(this.bsmAdd_Click);
            // 
            // lbScancount
            // 
            this.lbScancount.AutoSize = true;
            this.lbScancount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbScancount.Location = new System.Drawing.Point(222, 0);
            this.lbScancount.Name = "lbScancount";
            this.lbScancount.Size = new System.Drawing.Size(11, 12);
            this.lbScancount.TabIndex = 98;
            this.lbScancount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 107;
            this.label4.Text = "Identifier";
            // 
            // csmIdentifier
            // 
            this.csmIdentifier.Location = new System.Drawing.Point(112, 87);
            this.csmIdentifier.Name = "csmIdentifier";
            this.csmIdentifier.Size = new System.Drawing.Size(179, 21);
            this.csmIdentifier.TabIndex = 106;
            this.csmIdentifier.Text = "Zong Le";
            // 
            // FormSpecimen
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 627);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(888, 666);
            this.Name = "FormSpecimen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CTDB - Specimen Information";
            this.Load += new System.EventHandler(this.CTDBFormSpecimen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox csmDryInstrument;
        private System.Windows.Forms.TextBox csmDryCycleTime;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.ComboBox csmDehydrant;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox csmSPID;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button bsmUpdate;
        private System.Windows.Forms.Button bsmDelete;
        private System.Windows.Forms.TextBox csmCollectPlace;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox csmCollectTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox csmCollector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox csmSpecies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddSpecies;
        private System.Windows.Forms.Button bsmAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label csmID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMDExample;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mitDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox csmSex;
        private System.Windows.Forms.ComboBox csmAge;
        private System.Windows.Forms.ToolStripMenuItem mitAddExample3D;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox csmNote;
        private System.Windows.Forms.Label lbSpeciesCHN;
        private System.Windows.Forms.ToolStripMenuItem mitAddScan;
        private System.Windows.Forms.ToolStripMenuItem addSamplePhotoToolStripMenuItem;
        private System.Windows.Forms.ComboBox csmPS;
        private System.Windows.Forms.Label label2;
        private ucFileInfo ucFileInfo1;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox csmDriedSpecimenSavePosition;
        private System.Windows.Forms.Label lbSPcount;
        private System.Windows.Forms.Label lbScancount;
        private System.Windows.Forms.Label lbSpeciesLatin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox csmIdentifier;
    }
}