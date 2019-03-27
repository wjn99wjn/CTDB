namespace CTDB
{
    partial class FormTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTag));
            this.bSpeciesUpdate = new System.Windows.Forms.Button();
            this.bSpeciesDel = new System.Windows.Forms.Button();
            this.ctagID = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ctagCHN = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ctagTag = new System.Windows.Forms.TextBox();
            this.ctagNote = new System.Windows.Forms.TextBox();
            this.bSpeciesAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ctagPID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSpeciesUpdate
            // 
            this.bSpeciesUpdate.Location = new System.Drawing.Point(219, 178);
            this.bSpeciesUpdate.Name = "bSpeciesUpdate";
            this.bSpeciesUpdate.Size = new System.Drawing.Size(75, 42);
            this.bSpeciesUpdate.TabIndex = 44;
            this.bSpeciesUpdate.Text = "Update";
            this.bSpeciesUpdate.UseVisualStyleBackColor = true;
            this.bSpeciesUpdate.Click += new System.EventHandler(this.bTagUpdate_Click);
            // 
            // bSpeciesDel
            // 
            this.bSpeciesDel.Location = new System.Drawing.Point(331, 12);
            this.bSpeciesDel.Name = "bSpeciesDel";
            this.bSpeciesDel.Size = new System.Drawing.Size(75, 27);
            this.bSpeciesDel.TabIndex = 43;
            this.bSpeciesDel.Text = "Delete";
            this.bSpeciesDel.UseVisualStyleBackColor = true;
            this.bSpeciesDel.Click += new System.EventHandler(this.bTagDel_Click);
            // 
            // ctagID
            // 
            this.ctagID.AutoSize = true;
            this.ctagID.Location = new System.Drawing.Point(85, 11);
            this.ctagID.Name = "ctagID";
            this.ctagID.Size = new System.Drawing.Size(11, 12);
            this.ctagID.TabIndex = 42;
            this.ctagID.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 41;
            this.label19.Text = "Tag ID";
            // 
            // ctagCHN
            // 
            this.ctagCHN.Location = new System.Drawing.Point(83, 64);
            this.ctagCHN.Name = "ctagCHN";
            this.ctagCHN.Size = new System.Drawing.Size(211, 21);
            this.ctagCHN.TabIndex = 40;
            this.ctagCHN.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 39;
            this.label15.Text = "Chinese";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 12);
            this.label14.TabIndex = 38;
            this.label14.Text = "Tag";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 37;
            this.label13.Text = "Note";
            // 
            // ctagTag
            // 
            this.ctagTag.Location = new System.Drawing.Point(83, 37);
            this.ctagTag.Name = "ctagTag";
            this.ctagTag.Size = new System.Drawing.Size(211, 21);
            this.ctagTag.TabIndex = 36;
            this.ctagTag.Text = "-";
            // 
            // ctagNote
            // 
            this.ctagNote.Location = new System.Drawing.Point(83, 91);
            this.ctagNote.Multiline = true;
            this.ctagNote.Name = "ctagNote";
            this.ctagNote.Size = new System.Drawing.Size(211, 54);
            this.ctagNote.TabIndex = 35;
            this.ctagNote.Text = "-";
            // 
            // bSpeciesAdd
            // 
            this.bSpeciesAdd.Location = new System.Drawing.Point(118, 178);
            this.bSpeciesAdd.Name = "bSpeciesAdd";
            this.bSpeciesAdd.Size = new System.Drawing.Size(75, 42);
            this.bSpeciesAdd.TabIndex = 26;
            this.bSpeciesAdd.Text = "Add";
            this.bSpeciesAdd.UseVisualStyleBackColor = true;
            this.bSpeciesAdd.Click += new System.EventHandler(this.bTagAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(232, 226);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(418, 179);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(331, 178);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 42);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.bSpeciesAdd);
            this.panel1.Controls.Add(this.bSpeciesUpdate);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.bSpeciesDel);
            this.panel1.Controls.Add(this.ctagPID);
            this.panel1.Controls.Add(this.ctagID);
            this.panel1.Controls.Add(this.ctagCHN);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.ctagTag);
            this.panel1.Controls.Add(this.ctagNote);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(232, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 226);
            this.panel1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 46;
            this.label2.Text = "Parent ID";
            // 
            // ctagPID
            // 
            this.ctagPID.AutoSize = true;
            this.ctagPID.Location = new System.Drawing.Point(199, 11);
            this.ctagPID.Name = "ctagPID";
            this.ctagPID.Size = new System.Drawing.Size(11, 12);
            this.ctagPID.TabIndex = 42;
            this.ctagPID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "Note";
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(232, 405);
            this.treeView1.TabIndex = 45;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            // 
            // FormTag
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 405);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormTag";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CTDB - Tag";
            this.Load += new System.EventHandler(this.CTDBFormAddSpecies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSpeciesUpdate;
        private System.Windows.Forms.Button bSpeciesDel;
        private System.Windows.Forms.Label ctagID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ctagCHN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ctagTag;
        private System.Windows.Forms.TextBox ctagNote;
        private System.Windows.Forms.Button bSpeciesAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ctagPID;
    }
}