namespace CTDB
{
    partial class FormEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquipment));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.beUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.beAdd = new System.Windows.Forms.Button();
            this.label199 = new System.Windows.Forms.Label();
            this.ceType = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.ceLocation = new System.Windows.Forms.TextBox();
            this.ceName = new System.Windows.Forms.TextBox();
            this.ceNameA = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ceNote = new System.Windows.Forms.TextBox();
            this.ceDescription = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.ceID = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.ceContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 230);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(501, 169);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(413, 178);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 42);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 58);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 62;
            this.label22.Text = "Name";
            // 
            // beUpdate
            // 
            this.beUpdate.Location = new System.Drawing.Point(414, 70);
            this.beUpdate.Name = "beUpdate";
            this.beUpdate.Size = new System.Drawing.Size(75, 42);
            this.beUpdate.TabIndex = 61;
            this.beUpdate.Text = "Update";
            this.beUpdate.UseVisualStyleBackColor = true;
            this.beUpdate.Click += new System.EventHandler(this.beUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(413, 31);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 28);
            this.btDelete.TabIndex = 60;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // beAdd
            // 
            this.beAdd.Location = new System.Drawing.Point(414, 118);
            this.beAdd.Name = "beAdd";
            this.beAdd.Size = new System.Drawing.Size(75, 42);
            this.beAdd.TabIndex = 59;
            this.beAdd.Text = "Add";
            this.beAdd.UseVisualStyleBackColor = true;
            this.beAdd.Click += new System.EventHandler(this.beAdd_Click);
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.Location = new System.Drawing.Point(13, 85);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(29, 12);
            this.label199.TabIndex = 58;
            this.label199.Text = "Type";
            // 
            // ceType
            // 
            this.ceType.Location = new System.Drawing.Point(91, 78);
            this.ceType.Name = "ceType";
            this.ceType.Size = new System.Drawing.Size(299, 21);
            this.ceType.TabIndex = 57;
            this.ceType.Text = "-";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(13, 113);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 12);
            this.label25.TabIndex = 56;
            this.label25.Text = "Loacation";
            // 
            // ceLocation
            // 
            this.ceLocation.Location = new System.Drawing.Point(91, 103);
            this.ceLocation.Name = "ceLocation";
            this.ceLocation.Size = new System.Drawing.Size(299, 21);
            this.ceLocation.TabIndex = 55;
            this.ceLocation.Text = "-";
            // 
            // ceName
            // 
            this.ceName.Location = new System.Drawing.Point(91, 55);
            this.ceName.Name = "ceName";
            this.ceName.Size = new System.Drawing.Size(299, 21);
            this.ceName.TabIndex = 54;
            this.ceName.Text = "-";
            // 
            // ceNameA
            // 
            this.ceNameA.Location = new System.Drawing.Point(91, 31);
            this.ceNameA.Name = "ceNameA";
            this.ceNameA.Size = new System.Drawing.Size(299, 21);
            this.ceNameA.TabIndex = 53;
            this.ceNameA.Text = "-";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 52;
            this.label20.Text = "Abbreviation";
            // 
            // ceNote
            // 
            this.ceNote.Location = new System.Drawing.Point(91, 190);
            this.ceNote.Multiline = true;
            this.ceNote.Name = "ceNote";
            this.ceNote.Size = new System.Drawing.Size(299, 30);
            this.ceNote.TabIndex = 50;
            this.ceNote.Text = "-";
            // 
            // ceDescription
            // 
            this.ceDescription.Location = new System.Drawing.Point(91, 126);
            this.ceDescription.Multiline = true;
            this.ceDescription.Name = "ceDescription";
            this.ceDescription.Size = new System.Drawing.Size(299, 30);
            this.ceDescription.TabIndex = 51;
            this.ceDescription.Text = "No";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 195);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 46;
            this.label21.Text = "Note";
            // 
            // ceID
            // 
            this.ceID.AutoSize = true;
            this.ceID.Location = new System.Drawing.Point(90, 10);
            this.ceID.Name = "ceID";
            this.ceID.Size = new System.Drawing.Size(11, 12);
            this.ceID.TabIndex = 47;
            this.ceID.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 12);
            this.label23.TabIndex = 48;
            this.label23.Text = "Equipment ID";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 133);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 12);
            this.label24.TabIndex = 49;
            this.label24.Text = "Description";
            // 
            // ceContact
            // 
            this.ceContact.Location = new System.Drawing.Point(92, 159);
            this.ceContact.Multiline = true;
            this.ceContact.Name = "ceContact";
            this.ceContact.Size = new System.Drawing.Size(299, 28);
            this.ceContact.TabIndex = 63;
            this.ceContact.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 49;
            this.label1.Text = "Contact";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ceContact);
            this.panel1.Controls.Add(this.beAdd);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.beUpdate);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label199);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ceType);
            this.panel1.Controls.Add(this.ceID);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.ceLocation);
            this.panel1.Controls.Add(this.ceDescription);
            this.panel1.Controls.Add(this.ceName);
            this.panel1.Controls.Add(this.ceNote);
            this.panel1.Controls.Add(this.ceNameA);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 230);
            this.panel1.TabIndex = 64;
            // 
            // FormEquipment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEquipment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CTDB -  Equipment";
            this.Load += new System.EventHandler(this.CTDBFormAddSpecies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button beUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button beAdd;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.TextBox ceType;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox ceLocation;
        private System.Windows.Forms.TextBox ceName;
        private System.Windows.Forms.TextBox ceNameA;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox ceNote;
        private System.Windows.Forms.TextBox ceDescription;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label ceID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox ceContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}