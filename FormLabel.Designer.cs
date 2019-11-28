namespace CTDB
{
    partial class FormLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLabel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mitClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clbTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ucFileInfo1 = new CTDB.ucFileInfo();
            this.clbStructure = new System.Windows.Forms.ComboBox();
            this.clbMethod = new System.Windows.Forms.ComboBox();
            this.clbOpenStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clbSliceInfo = new System.Windows.Forms.Label();
            this.clbSilceID = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.clbID = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.clbNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.clbAuthor = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.bsmUpdate = new System.Windows.Forms.Button();
            this.bsmAddBatch = new System.Windows.Forms.Button();
            this.bsmAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddBatch = new System.Windows.Forms.Button();
            this.exportTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 174);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(872, 453);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitDelete,
            this.mitClearAll,
            this.exportTableToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // mitDelete
            // 
            this.mitDelete.Enabled = false;
            this.mitDelete.Name = "mitDelete";
            this.mitDelete.Size = new System.Drawing.Size(180, 22);
            this.mitDelete.Text = "Delete";
            this.mitDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mitClearAll
            // 
            this.mitClearAll.Name = "mitClearAll";
            this.mitClearAll.Size = new System.Drawing.Size(180, 22);
            this.mitClearAll.Text = "Clear All";
            this.mitClearAll.Click += new System.EventHandler(this.mitClearAll_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(785, 120);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 42);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clbTitle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ucFileInfo1);
            this.panel1.Controls.Add(this.clbStructure);
            this.panel1.Controls.Add(this.clbMethod);
            this.panel1.Controls.Add(this.clbOpenStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.clbSliceInfo);
            this.panel1.Controls.Add(this.clbSilceID);
            this.panel1.Controls.Add(this.label50);
            this.panel1.Controls.Add(this.clbID);
            this.panel1.Controls.Add(this.label49);
            this.panel1.Controls.Add(this.clbNote);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.clbAuthor);
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.bsmUpdate);
            this.panel1.Controls.Add(this.bsmAddBatch);
            this.panel1.Controls.Add(this.bsmAdd);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 174);
            this.panel1.TabIndex = 46;
            // 
            // clbTitle
            // 
            this.clbTitle.Location = new System.Drawing.Point(118, 146);
            this.clbTitle.Name = "clbTitle";
            this.clbTitle.Size = new System.Drawing.Size(149, 21);
            this.clbTitle.TabIndex = 116;
            this.clbTitle.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 115;
            this.label4.Text = "Label / Title";
            // 
            // ucFileInfo1
            // 
            this.ucFileInfo1.Location = new System.Drawing.Point(582, 6);
            this.ucFileInfo1.Name = "ucFileInfo1";
            this.ucFileInfo1.ParaDatasetID = 0;
            this.ucFileInfo1.ParaTable = "";
            this.ucFileInfo1.Size = new System.Drawing.Size(195, 42);
            this.ucFileInfo1.TabIndex = 114;
            this.ucFileInfo1.UpdateFile += new System.EventHandler(this.ucFileInfo1_UpdateFile);
            this.ucFileInfo1.OpenFileDialog += new System.EventHandler(this.ucFileInfo1_OpenFileDialog);
            // 
            // clbStructure
            // 
            this.clbStructure.FormattingEnabled = true;
            this.clbStructure.Location = new System.Drawing.Point(118, 120);
            this.clbStructure.Name = "clbStructure";
            this.clbStructure.Size = new System.Drawing.Size(149, 20);
            this.clbStructure.TabIndex = 113;
            this.clbStructure.SelectedIndexChanged += new System.EventHandler(this.clbSlice_SelectedIndexChanged);
            // 
            // clbMethod
            // 
            this.clbMethod.FormattingEnabled = true;
            this.clbMethod.Location = new System.Drawing.Point(118, 69);
            this.clbMethod.Name = "clbMethod";
            this.clbMethod.Size = new System.Drawing.Size(149, 20);
            this.clbMethod.TabIndex = 113;
            this.clbMethod.SelectedIndexChanged += new System.EventHandler(this.clbMethod_SelectedIndexChanged);
            // 
            // clbOpenStatus
            // 
            this.clbOpenStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clbOpenStatus.FormattingEnabled = true;
            this.clbOpenStatus.Location = new System.Drawing.Point(118, 43);
            this.clbOpenStatus.Name = "clbOpenStatus";
            this.clbOpenStatus.Size = new System.Drawing.Size(149, 20);
            this.clbOpenStatus.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 110;
            this.label3.Text = "Share Method";
            // 
            // clbSliceInfo
            // 
            this.clbSliceInfo.AutoSize = true;
            this.clbSliceInfo.Location = new System.Drawing.Point(145, 24);
            this.clbSliceInfo.Name = "clbSliceInfo";
            this.clbSliceInfo.Size = new System.Drawing.Size(11, 12);
            this.clbSliceInfo.TabIndex = 110;
            this.clbSliceInfo.Text = "0";
            // 
            // clbSilceID
            // 
            this.clbSilceID.AutoSize = true;
            this.clbSilceID.Location = new System.Drawing.Point(124, 24);
            this.clbSilceID.Name = "clbSilceID";
            this.clbSilceID.Size = new System.Drawing.Size(11, 12);
            this.clbSilceID.TabIndex = 110;
            this.clbSilceID.Text = "0";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(29, 24);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(89, 12);
            this.label50.TabIndex = 110;
            this.label50.Text = "Belonged Slice";
            // 
            // clbID
            // 
            this.clbID.AutoSize = true;
            this.clbID.Location = new System.Drawing.Point(101, 9);
            this.clbID.Name = "clbID";
            this.clbID.Size = new System.Drawing.Size(11, 12);
            this.clbID.TabIndex = 109;
            this.clbID.Text = "0";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(29, 9);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(53, 12);
            this.label49.TabIndex = 108;
            this.label49.Text = "Label ID";
            // 
            // clbNote
            // 
            this.clbNote.Location = new System.Drawing.Point(293, 57);
            this.clbNote.Multiline = true;
            this.clbNote.Name = "clbNote";
            this.clbNote.Size = new System.Drawing.Size(374, 105);
            this.clbNote.TabIndex = 107;
            this.clbNote.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 106;
            this.label2.Text = "Structure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 106;
            this.label1.Text = "Label Method";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(291, 36);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(29, 12);
            this.label43.TabIndex = 106;
            this.label43.Text = "Note";
            // 
            // clbAuthor
            // 
            this.clbAuthor.Location = new System.Drawing.Point(118, 95);
            this.clbAuthor.Name = "clbAuthor";
            this.clbAuthor.Size = new System.Drawing.Size(149, 21);
            this.clbAuthor.TabIndex = 103;
            this.clbAuthor.Text = "-";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(29, 96);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(41, 12);
            this.label45.TabIndex = 102;
            this.label45.Text = "Author";
            // 
            // bsmUpdate
            // 
            this.bsmUpdate.Location = new System.Drawing.Point(785, 6);
            this.bsmUpdate.Name = "bsmUpdate";
            this.bsmUpdate.Size = new System.Drawing.Size(75, 42);
            this.bsmUpdate.TabIndex = 92;
            this.bsmUpdate.Text = "Update";
            this.bsmUpdate.UseVisualStyleBackColor = true;
            this.bsmUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bsmAddBatch
            // 
            this.bsmAddBatch.Location = new System.Drawing.Point(673, 57);
            this.bsmAddBatch.Name = "bsmAddBatch";
            this.bsmAddBatch.Size = new System.Drawing.Size(89, 42);
            this.bsmAddBatch.TabIndex = 79;
            this.bsmAddBatch.Text = "Batch Add From Folder";
            this.bsmAddBatch.UseVisualStyleBackColor = true;
            this.bsmAddBatch.Click += new System.EventHandler(this.bsmAddBatch_Click);
            // 
            // bsmAdd
            // 
            this.bsmAdd.Location = new System.Drawing.Point(673, 120);
            this.bsmAdd.Name = "bsmAdd";
            this.bsmAdd.Size = new System.Drawing.Size(89, 42);
            this.bsmAdd.TabIndex = 79;
            this.bsmAdd.Text = "Add";
            this.bsmAdd.UseVisualStyleBackColor = true;
            this.bsmAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 79;
            this.button1.Text = "Batch Add From Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddBatch
            // 
            this.btnAddBatch.Location = new System.Drawing.Point(673, 57);
            this.btnAddBatch.Name = "btnAddBatch";
            this.btnAddBatch.Size = new System.Drawing.Size(89, 42);
            this.btnAddBatch.TabIndex = 79;
            this.btnAddBatch.Text = "Batch Add From Folder";
            this.btnAddBatch.UseVisualStyleBackColor = true;
            // 
            // exportTableToolStripMenuItem
            // 
            this.exportTableToolStripMenuItem.Name = "exportTableToolStripMenuItem";
            this.exportTableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportTableToolStripMenuItem.Text = "Export Table";
            this.exportTableToolStripMenuItem.Click += new System.EventHandler(this.exportTableToolStripMenuItem_Click);
            // 
            // FormLabel
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 627);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(888, 666);
            this.Name = "FormLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CTDB - Label Images / Models Information";
            this.Load += new System.EventHandler(this.FormLabel_Load);
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
        private System.Windows.Forms.Button bsmAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mitDelete;
        private System.Windows.Forms.ComboBox clbOpenStatus;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label clbID;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox clbAuthor;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox clbMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clbNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox clbStructure;
        private ucFileInfo ucFileInfo1;
        private System.Windows.Forms.TextBox clbTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label clbSliceInfo;
        private System.Windows.Forms.Label clbSilceID;
        private System.Windows.Forms.Button bsmAddBatch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddBatch;
        private System.Windows.Forms.ToolStripMenuItem mitClearAll;
        private System.Windows.Forms.ToolStripMenuItem exportTableToolStripMenuItem;
    }
}