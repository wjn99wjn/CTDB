namespace CTDB
{
    partial class FormSpecies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpecies));
            this.bSpeciesUpdate = new System.Windows.Forms.Button();
            this.bSpeciesDel = new System.Windows.Forms.Button();
            this.cspeciesID = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cspeciesCHN = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cspeciesLatin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cspeciesSpecies = new System.Windows.Forms.TextBox();
            this.cspeciesGenus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cspeciesFamily = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bSpeciesAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cspeciesOrder = new System.Windows.Forms.ComboBox();
            this.lbSPcount = new System.Windows.Forms.Label();
            this.cspeciesNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSpeciesUpdate
            // 
            this.bSpeciesUpdate.Location = new System.Drawing.Point(597, 50);
            this.bSpeciesUpdate.Name = "bSpeciesUpdate";
            this.bSpeciesUpdate.Size = new System.Drawing.Size(75, 42);
            this.bSpeciesUpdate.TabIndex = 44;
            this.bSpeciesUpdate.Text = "Update";
            this.bSpeciesUpdate.UseVisualStyleBackColor = true;
            this.bSpeciesUpdate.Click += new System.EventHandler(this.bSpeciesUpdate_Click);
            // 
            // bSpeciesDel
            // 
            this.bSpeciesDel.Location = new System.Drawing.Point(597, 16);
            this.bSpeciesDel.Name = "bSpeciesDel";
            this.bSpeciesDel.Size = new System.Drawing.Size(75, 25);
            this.bSpeciesDel.TabIndex = 43;
            this.bSpeciesDel.Text = "Delete";
            this.bSpeciesDel.UseVisualStyleBackColor = true;
            this.bSpeciesDel.Click += new System.EventHandler(this.bSpeciesDel_Click);
            // 
            // cspeciesID
            // 
            this.cspeciesID.AutoSize = true;
            this.cspeciesID.Location = new System.Drawing.Point(71, 12);
            this.cspeciesID.Name = "cspeciesID";
            this.cspeciesID.Size = new System.Drawing.Size(11, 12);
            this.cspeciesID.TabIndex = 42;
            this.cspeciesID.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(209, 12);
            this.label19.TabIndex = 41;
            this.label19.Text = "Species ID       has      specimen";
            // 
            // cspeciesCHN
            // 
            this.cspeciesCHN.Location = new System.Drawing.Point(72, 83);
            this.cspeciesCHN.Name = "cspeciesCHN";
            this.cspeciesCHN.Size = new System.Drawing.Size(186, 21);
            this.cspeciesCHN.TabIndex = 40;
            this.cspeciesCHN.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 39;
            this.label15.Text = "Chinese";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 37;
            this.label13.Text = "Latin Full";
            // 
            // cspeciesLatin
            // 
            this.cspeciesLatin.Location = new System.Drawing.Point(72, 57);
            this.cspeciesLatin.Name = "cspeciesLatin";
            this.cspeciesLatin.Size = new System.Drawing.Size(186, 21);
            this.cspeciesLatin.TabIndex = 35;
            this.cspeciesLatin.Text = "-";
            this.cspeciesLatin.TextChanged += new System.EventHandler(this.cspeciesLatin_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 12);
            this.label12.TabIndex = 34;
            this.label12.Text = "Species/Latin Abbr.(G+S)";
            // 
            // cspeciesSpecies
            // 
            this.cspeciesSpecies.Enabled = false;
            this.cspeciesSpecies.Location = new System.Drawing.Point(175, 137);
            this.cspeciesSpecies.Name = "cspeciesSpecies";
            this.cspeciesSpecies.Size = new System.Drawing.Size(285, 21);
            this.cspeciesSpecies.TabIndex = 33;
            this.cspeciesSpecies.Text = "sp.";
            // 
            // cspeciesGenus
            // 
            this.cspeciesGenus.Enabled = false;
            this.cspeciesGenus.Location = new System.Drawing.Point(311, 110);
            this.cspeciesGenus.Name = "cspeciesGenus";
            this.cspeciesGenus.Size = new System.Drawing.Size(149, 21);
            this.cspeciesGenus.TabIndex = 32;
            this.cspeciesGenus.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "Genus";
            // 
            // cspeciesFamily
            // 
            this.cspeciesFamily.Location = new System.Drawing.Point(311, 83);
            this.cspeciesFamily.Name = "cspeciesFamily";
            this.cspeciesFamily.Size = new System.Drawing.Size(149, 21);
            this.cspeciesFamily.TabIndex = 30;
            this.cspeciesFamily.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "Family";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(270, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "Order";
            // 
            // bSpeciesAdd
            // 
            this.bSpeciesAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bSpeciesAdd.Location = new System.Drawing.Point(516, 116);
            this.bSpeciesAdd.Name = "bSpeciesAdd";
            this.bSpeciesAdd.Size = new System.Drawing.Size(75, 42);
            this.bSpeciesAdd.TabIndex = 26;
            this.bSpeciesAdd.Text = "Add";
            this.bSpeciesAdd.UseVisualStyleBackColor = true;
            this.bSpeciesAdd.Click += new System.EventHandler(this.bSpeciesAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 169);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(684, 242);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cspeciesOrder);
            this.panel1.Controls.Add(this.lbSPcount);
            this.panel1.Controls.Add(this.cspeciesNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.bSpeciesAdd);
            this.panel1.Controls.Add(this.bSpeciesUpdate);
            this.panel1.Controls.Add(this.bSpeciesDel);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cspeciesID);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cspeciesCHN);
            this.panel1.Controls.Add(this.cspeciesFamily);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cspeciesGenus);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cspeciesSpecies);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cspeciesLatin);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 169);
            this.panel1.TabIndex = 46;
            // 
            // cspeciesOrder
            // 
            this.cspeciesOrder.FormattingEnabled = true;
            this.cspeciesOrder.Location = new System.Drawing.Point(311, 57);
            this.cspeciesOrder.Name = "cspeciesOrder";
            this.cspeciesOrder.Size = new System.Drawing.Size(149, 20);
            this.cspeciesOrder.TabIndex = 146;
            this.cspeciesOrder.Text = "Coleoptera";
            // 
            // lbSPcount
            // 
            this.lbSPcount.AutoSize = true;
            this.lbSPcount.Location = new System.Drawing.Point(133, 12);
            this.lbSPcount.Name = "lbSPcount";
            this.lbSPcount.Size = new System.Drawing.Size(11, 12);
            this.lbSPcount.TabIndex = 79;
            this.lbSPcount.Text = "0";
            // 
            // cspeciesNote
            // 
            this.cspeciesNote.Location = new System.Drawing.Point(72, 28);
            this.cspeciesNote.Name = "cspeciesNote";
            this.cspeciesNote.Size = new System.Drawing.Size(388, 21);
            this.cspeciesNote.TabIndex = 0;
            this.cspeciesNote.Text = "sp.";
            this.cspeciesNote.TextChanged += new System.EventHandler(this.cspeciesNote_TextChanged);
            this.cspeciesNote.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cspeciesNote_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 46;
            this.label1.Text = "Note";
            // 
            // Close
            // 
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.Location = new System.Drawing.Point(597, 116);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 42);
            this.Close.TabIndex = 26;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSpecies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CTDB - Species";
            this.Activated += new System.EventHandler(this.FormSpecies_Activated);
            this.Load += new System.EventHandler(this.CTDBFormAddSpecies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bSpeciesUpdate;
        private System.Windows.Forms.Button bSpeciesDel;
        private System.Windows.Forms.Label cspeciesID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox cspeciesCHN;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cspeciesLatin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cspeciesSpecies;
        private System.Windows.Forms.TextBox cspeciesGenus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cspeciesFamily;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bSpeciesAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cspeciesNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSPcount;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ComboBox cspeciesOrder;
    }
}