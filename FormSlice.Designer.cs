namespace CTDB
{
    partial class FormSlice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSlice));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmitAddFileStack = new System.Windows.Forms.ToolStripMenuItem();
            this.cmitAddFile3D = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clLabelNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucFileInfo1 = new CTDB.ucFileInfo();
            this.btnMDScan = new System.Windows.Forms.Button();
            this.clCutMethod = new System.Windows.Forms.ComboBox();
            this.clOpenStatus = new System.Windows.Forms.ComboBox();
            this.label50 = new System.Windows.Forms.Label();
            this.clID = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.clPixelSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.clReconstructionProgram = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.clScan = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.bsmUpdate = new System.Windows.Forms.Button();
            this.bsmDelete = new System.Windows.Forms.Button();
            this.bsmAdd = new System.Windows.Forms.Button();
            this.cscSliceNo = new System.Windows.Forms.Label();
            this.clSliceNo = new System.Windows.Forms.Label();
            this.cmitExportMeta = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 183);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(872, 444);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitDelete,
            this.cmitAddFileStack,
            this.cmitAddFile3D,
            this.cmitExportMeta});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // mitDelete
            // 
            this.mitDelete.Enabled = false;
            this.mitDelete.Name = "mitDelete";
            this.mitDelete.Size = new System.Drawing.Size(180, 22);
            this.mitDelete.Text = "Delete";
            this.mitDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmitAddFileStack
            // 
            this.cmitAddFileStack.Name = "cmitAddFileStack";
            this.cmitAddFileStack.Size = new System.Drawing.Size(180, 22);
            this.cmitAddFileStack.Text = "Add Image Stack";
            this.cmitAddFileStack.Click += new System.EventHandler(this.cmitAddFileStack_Click);
            // 
            // cmitAddFile3D
            // 
            this.cmitAddFile3D.Name = "cmitAddFile3D";
            this.cmitAddFile3D.Size = new System.Drawing.Size(180, 22);
            this.cmitAddFile3D.Text = "Add 3D Model";
            this.cmitAddFile3D.Click += new System.EventHandler(this.cmitAddFile3D_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(774, 95);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 42);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clLabelNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ucFileInfo1);
            this.panel1.Controls.Add(this.btnMDScan);
            this.panel1.Controls.Add(this.clCutMethod);
            this.panel1.Controls.Add(this.clOpenStatus);
            this.panel1.Controls.Add(this.label50);
            this.panel1.Controls.Add(this.clID);
            this.panel1.Controls.Add(this.label49);
            this.panel1.Controls.Add(this.clPixelSize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.clReconstructionProgram);
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.clScan);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.bsmUpdate);
            this.panel1.Controls.Add(this.bsmDelete);
            this.panel1.Controls.Add(this.bsmAdd);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 183);
            this.panel1.TabIndex = 46;
            // 
            // clLabelNo
            // 
            this.clLabelNo.AutoSize = true;
            this.clLabelNo.Location = new System.Drawing.Point(173, 9);
            this.clLabelNo.Name = "clLabelNo";
            this.clLabelNo.Size = new System.Drawing.Size(11, 12);
            this.clLabelNo.TabIndex = 150;
            this.clLabelNo.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 149;
            this.label2.Text = "LabelCount";
            // 
            // ucFileInfo1
            // 
            this.ucFileInfo1.Location = new System.Drawing.Point(477, 34);
            this.ucFileInfo1.Name = "ucFileInfo1";
            this.ucFileInfo1.ParaDatasetID = 0;
            this.ucFileInfo1.ParaTable = "tbSlice";
            this.ucFileInfo1.Size = new System.Drawing.Size(195, 42);
            this.ucFileInfo1.TabIndex = 116;
            this.ucFileInfo1.UpdateFile += new System.EventHandler(this.ucFileInfo1_UpdateFile);
            this.ucFileInfo1.OpenFileDialog += new System.EventHandler(this.ucFileInfo1_OpenFileDialog);
            // 
            // btnMDScan
            // 
            this.btnMDScan.Location = new System.Drawing.Point(66, 34);
            this.btnMDScan.Name = "btnMDScan";
            this.btnMDScan.Size = new System.Drawing.Size(27, 20);
            this.btnMDScan.TabIndex = 115;
            this.btnMDScan.Text = "+";
            this.btnMDScan.UseVisualStyleBackColor = true;
            this.btnMDScan.Click += new System.EventHandler(this.btnMDScan_Click);
            // 
            // clCutMethod
            // 
            this.clCutMethod.FormattingEnabled = true;
            this.clCutMethod.Location = new System.Drawing.Point(156, 150);
            this.clCutMethod.Name = "clCutMethod";
            this.clCutMethod.Size = new System.Drawing.Size(149, 20);
            this.clCutMethod.TabIndex = 113;
            // 
            // clOpenStatus
            // 
            this.clOpenStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clOpenStatus.FormattingEnabled = true;
            this.clOpenStatus.Location = new System.Drawing.Point(66, 60);
            this.clOpenStatus.Name = "clOpenStatus";
            this.clOpenStatus.Size = new System.Drawing.Size(376, 20);
            this.clOpenStatus.TabIndex = 111;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(11, 62);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(53, 12);
            this.label50.TabIndex = 110;
            this.label50.Text = "Share as";
            // 
            // clID
            // 
            this.clID.AutoSize = true;
            this.clID.Location = new System.Drawing.Point(64, 9);
            this.clID.Name = "clID";
            this.clID.Size = new System.Drawing.Size(11, 12);
            this.clID.TabIndex = 109;
            this.clID.Text = "0";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(11, 9);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(53, 12);
            this.label49.TabIndex = 108;
            this.label49.Text = "Slice ID";
            // 
            // clPixelSize
            // 
            this.clPixelSize.Location = new System.Drawing.Point(156, 121);
            this.clPixelSize.Name = "clPixelSize";
            this.clPixelSize.Size = new System.Drawing.Size(75, 21);
            this.clPixelSize.TabIndex = 107;
            this.clPixelSize.Text = "1.04";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 106;
            this.label1.Text = "Cut Method";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.Color.Red;
            this.label43.Location = new System.Drawing.Point(12, 125);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(95, 12);
            this.label43.TabIndex = 106;
            this.label43.Text = "Resolution (µm)";
            // 
            // clReconstructionProgram
            // 
            this.clReconstructionProgram.Location = new System.Drawing.Point(156, 86);
            this.clReconstructionProgram.Name = "clReconstructionProgram";
            this.clReconstructionProgram.Size = new System.Drawing.Size(75, 21);
            this.clReconstructionProgram.TabIndex = 103;
            this.clReconstructionProgram.Text = "NRecon";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(12, 89);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(137, 12);
            this.label45.TabIndex = 102;
            this.label45.Text = "Reconstruction Program";
            // 
            // clScan
            // 
            this.clScan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clScan.FormattingEnabled = true;
            this.clScan.Location = new System.Drawing.Point(99, 34);
            this.clScan.Name = "clScan";
            this.clScan.Size = new System.Drawing.Size(343, 20);
            this.clScan.TabIndex = 101;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 100;
            this.label17.Text = "Scan";
            // 
            // bsmUpdate
            // 
            this.bsmUpdate.Location = new System.Drawing.Point(636, 95);
            this.bsmUpdate.Name = "bsmUpdate";
            this.bsmUpdate.Size = new System.Drawing.Size(75, 42);
            this.bsmUpdate.TabIndex = 92;
            this.bsmUpdate.Text = "Update";
            this.bsmUpdate.UseVisualStyleBackColor = true;
            this.bsmUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bsmDelete
            // 
            this.bsmDelete.Enabled = false;
            this.bsmDelete.Location = new System.Drawing.Point(541, 143);
            this.bsmDelete.Name = "bsmDelete";
            this.bsmDelete.Size = new System.Drawing.Size(308, 27);
            this.bsmDelete.TabIndex = 91;
            this.bsmDelete.Text = "Delete - Right Click Record";
            this.bsmDelete.UseVisualStyleBackColor = true;
            this.bsmDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bsmAdd
            // 
            this.bsmAdd.Location = new System.Drawing.Point(774, 22);
            this.bsmAdd.Name = "bsmAdd";
            this.bsmAdd.Size = new System.Drawing.Size(75, 27);
            this.bsmAdd.TabIndex = 79;
            this.bsmAdd.Text = "Add";
            this.bsmAdd.UseVisualStyleBackColor = true;
            this.bsmAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cscSliceNo
            // 
            this.cscSliceNo.AutoSize = true;
            this.cscSliceNo.Location = new System.Drawing.Point(173, 9);
            this.cscSliceNo.Name = "cscSliceNo";
            this.cscSliceNo.Size = new System.Drawing.Size(11, 12);
            this.cscSliceNo.TabIndex = 150;
            this.cscSliceNo.Text = "0";
            // 
            // clSliceNo
            // 
            this.clSliceNo.AutoSize = true;
            this.clSliceNo.Location = new System.Drawing.Point(173, 9);
            this.clSliceNo.Name = "clSliceNo";
            this.clSliceNo.Size = new System.Drawing.Size(11, 12);
            this.clSliceNo.TabIndex = 150;
            this.clSliceNo.Text = "0";
            // 
            // cmitExportMeta
            // 
            this.cmitExportMeta.Name = "cmitExportMeta";
            this.cmitExportMeta.Size = new System.Drawing.Size(180, 22);
            this.cmitExportMeta.Text = "Export Meta";
            this.cmitExportMeta.Click += new System.EventHandler(this.cmitExportMeta_Click);
            // 
            // FormSlice
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 627);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(888, 666);
            this.Name = "FormSlice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CTDB - Slice Images Information";
            this.Load += new System.EventHandler(this.FormSlice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bsmUpdate;
        private System.Windows.Forms.Button bsmDelete;
        private System.Windows.Forms.Button bsmAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mitDelete;
        private System.Windows.Forms.ComboBox clOpenStatus;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label clID;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox clPixelSize;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox clReconstructionProgram;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox clScan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox clCutMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMDScan;
        private System.Windows.Forms.ToolStripMenuItem cmitAddFileStack;
        private System.Windows.Forms.ToolStripMenuItem cmitAddFile3D;
        private ucFileInfo ucFileInfo1;
        private System.Windows.Forms.Label clLabelNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cscSliceNo;
        private System.Windows.Forms.Label clSliceNo;
        private System.Windows.Forms.ToolStripMenuItem cmitExportMeta;
    }
}