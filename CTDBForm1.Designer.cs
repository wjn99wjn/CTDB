namespace CTDB
{
    partial class CTDBForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTDBForm1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lbNote = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.lbHelpSpecimen = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbHelpScan = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lbHelpTag = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.lbHelp2 = new System.Windows.Forms.TextBox();
            this.lbHelp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMDLabel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnQuick1 = new System.Windows.Forms.Button();
            this.btnMDTag = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnSpecimen = new System.Windows.Forms.Button();
            this.btnMDSlice = new System.Windows.Forms.Button();
            this.btnMDScan = new System.Windows.Forms.Button();
            this.btnMDSpecies = new System.Windows.Forms.Button();
            this.btnMDEquipment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage0.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(872, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // lbNote
            // 
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(33, 17);
            this.lbNote.Text = "Note";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(872, 605);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 4;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage0);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(536, 336);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage0
            // 
            this.tabPage0.AutoScroll = true;
            this.tabPage0.Controls.Add(this.lbHelpSpecimen);
            this.tabPage0.Location = new System.Drawing.Point(4, 22);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Size = new System.Drawing.Size(528, 310);
            this.tabPage0.TabIndex = 3;
            this.tabPage0.Text = "Specimen";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // lbHelpSpecimen
            // 
            this.lbHelpSpecimen.AutoSize = true;
            this.lbHelpSpecimen.Location = new System.Drawing.Point(19, 14);
            this.lbHelpSpecimen.Name = "lbHelpSpecimen";
            this.lbHelpSpecimen.Size = new System.Drawing.Size(29, 12);
            this.lbHelpSpecimen.TabIndex = 1;
            this.lbHelpSpecimen.Text = "Help";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbHelpScan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(528, 310);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Scan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbHelpScan
            // 
            this.lbHelpScan.AutoSize = true;
            this.lbHelpScan.Location = new System.Drawing.Point(19, 14);
            this.lbHelpScan.Name = "lbHelpScan";
            this.lbHelpScan.Size = new System.Drawing.Size(29, 12);
            this.lbHelpScan.TabIndex = 1;
            this.lbHelpScan.Text = "Help";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lbHelpTag);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(528, 310);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Tag";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lbHelpTag
            // 
            this.lbHelpTag.AutoSize = true;
            this.lbHelpTag.Location = new System.Drawing.Point(19, 14);
            this.lbHelpTag.Name = "lbHelpTag";
            this.lbHelpTag.Size = new System.Drawing.Size(29, 12);
            this.lbHelpTag.TabIndex = 1;
            this.lbHelpTag.Text = "Help";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.lbHelp2);
            this.tabPage7.Controls.Add(this.lbHelp);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(528, 310);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "Help";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // lbHelp2
            // 
            this.lbHelp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHelp2.Location = new System.Drawing.Point(0, 0);
            this.lbHelp2.Multiline = true;
            this.lbHelp2.Name = "lbHelp2";
            this.lbHelp2.Size = new System.Drawing.Size(528, 310);
            this.lbHelp2.TabIndex = 1;
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.Location = new System.Drawing.Point(19, 14);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(29, 12);
            this.lbHelp.TabIndex = 0;
            this.lbHelp.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMDLabel);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnQuick1);
            this.panel1.Controls.Add(this.btnMDTag);
            this.panel1.Controls.Add(this.btnRef);
            this.panel1.Controls.Add(this.btnSpecimen);
            this.panel1.Controls.Add(this.btnMDSlice);
            this.panel1.Controls.Add(this.btnMDScan);
            this.panel1.Controls.Add(this.btnMDSpecies);
            this.panel1.Controls.Add(this.btnMDEquipment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(536, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 336);
            this.panel1.TabIndex = 0;
            // 
            // btnMDLabel
            // 
            this.btnMDLabel.Enabled = false;
            this.btnMDLabel.Location = new System.Drawing.Point(249, 93);
            this.btnMDLabel.Name = "btnMDLabel";
            this.btnMDLabel.Size = new System.Drawing.Size(75, 51);
            this.btnMDLabel.TabIndex = 9;
            this.btnMDLabel.Text = "Label";
            this.btnMDLabel.UseVisualStyleBackColor = true;
            this.btnMDLabel.Click += new System.EventHandler(this.btnMDLabel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(119, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 44);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnQuick1
            // 
            this.btnQuick1.Location = new System.Drawing.Point(87, 150);
            this.btnQuick1.Name = "btnQuick1";
            this.btnQuick1.Size = new System.Drawing.Size(156, 103);
            this.btnQuick1.TabIndex = 10;
            this.btnQuick1.Text = "Quick";
            this.btnQuick1.UseVisualStyleBackColor = true;
            this.btnQuick1.Click += new System.EventHandler(this.btnQuick1_Click);
            // 
            // btnMDTag
            // 
            this.btnMDTag.Location = new System.Drawing.Point(168, 36);
            this.btnMDTag.Name = "btnMDTag";
            this.btnMDTag.Size = new System.Drawing.Size(75, 51);
            this.btnMDTag.TabIndex = 11;
            this.btnMDTag.Text = "Tag";
            this.btnMDTag.UseVisualStyleBackColor = true;
            this.btnMDTag.Click += new System.EventHandler(this.btnMDTag_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(249, 36);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(75, 51);
            this.btnRef.TabIndex = 3;
            this.btnRef.Text = "Source/Ref";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnMDRef_Click);
            // 
            // btnSpecimen
            // 
            this.btnSpecimen.Location = new System.Drawing.Point(6, 93);
            this.btnSpecimen.Name = "btnSpecimen";
            this.btnSpecimen.Size = new System.Drawing.Size(75, 51);
            this.btnSpecimen.TabIndex = 4;
            this.btnSpecimen.Text = "Specimen";
            this.btnSpecimen.UseVisualStyleBackColor = true;
            this.btnSpecimen.Click += new System.EventHandler(this.btnSpecimen_Click);
            // 
            // btnMDSlice
            // 
            this.btnMDSlice.Location = new System.Drawing.Point(168, 93);
            this.btnMDSlice.Name = "btnMDSlice";
            this.btnMDSlice.Size = new System.Drawing.Size(75, 51);
            this.btnMDSlice.TabIndex = 5;
            this.btnMDSlice.Text = "Slice";
            this.btnMDSlice.UseVisualStyleBackColor = true;
            this.btnMDSlice.Click += new System.EventHandler(this.btnMDSlice_Click);
            // 
            // btnMDScan
            // 
            this.btnMDScan.Location = new System.Drawing.Point(87, 93);
            this.btnMDScan.Name = "btnMDScan";
            this.btnMDScan.Size = new System.Drawing.Size(75, 51);
            this.btnMDScan.TabIndex = 6;
            this.btnMDScan.Text = "Scan";
            this.btnMDScan.UseVisualStyleBackColor = true;
            this.btnMDScan.Click += new System.EventHandler(this.btnMDScan_Click);
            // 
            // btnMDSpecies
            // 
            this.btnMDSpecies.Location = new System.Drawing.Point(87, 36);
            this.btnMDSpecies.Name = "btnMDSpecies";
            this.btnMDSpecies.Size = new System.Drawing.Size(75, 51);
            this.btnMDSpecies.TabIndex = 7;
            this.btnMDSpecies.Text = "Species";
            this.btnMDSpecies.UseVisualStyleBackColor = true;
            this.btnMDSpecies.Click += new System.EventHandler(this.btnMDSpecies_Click);
            // 
            // btnMDEquipment
            // 
            this.btnMDEquipment.Location = new System.Drawing.Point(6, 36);
            this.btnMDEquipment.Name = "btnMDEquipment";
            this.btnMDEquipment.Size = new System.Drawing.Size(75, 51);
            this.btnMDEquipment.TabIndex = 8;
            this.btnMDEquipment.Text = "Equipment";
            this.btnMDEquipment.UseVisualStyleBackColor = true;
            this.btnMDEquipment.Click += new System.EventHandler(this.btnMDEquipment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(872, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // CTDBForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 627);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(888, 666);
            this.Name = "CTDBForm1";
            this.Text = "Insect 3D Database Clicent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CTDBForm1_FormClosing);
            this.Load += new System.EventHandler(this.CTDBForm1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.tabPage0.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel lbNote;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMDLabel;
        private System.Windows.Forms.Button btnQuick1;
        private System.Windows.Forms.Button btnMDTag;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnSpecimen;
        private System.Windows.Forms.Button btnMDSlice;
        private System.Windows.Forms.Button btnMDScan;
        private System.Windows.Forms.Button btnMDSpecies;
        private System.Windows.Forms.Button btnMDEquipment;
        private System.Windows.Forms.Label lbHelpSpecimen;
        private System.Windows.Forms.Label lbHelpScan;
        private System.Windows.Forms.Label lbHelpTag;
        private System.Windows.Forms.TextBox lbHelp2;
        private System.Windows.Forms.Button btnExit;
    }
}