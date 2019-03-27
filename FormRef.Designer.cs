namespace CTDB
{
    partial class FormRef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRef));
            this.bSpeciesUpdate = new System.Windows.Forms.Button();
            this.bSpeciesDel = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.refURL = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.refCite = new System.Windows.Forms.TextBox();
            this.refDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.refYear = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.refAuthor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bSpeciesAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refID = new System.Windows.Forms.Label();
            this.refTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSpeciesUpdate
            // 
            this.bSpeciesUpdate.Location = new System.Drawing.Point(574, 114);
            this.bSpeciesUpdate.Name = "bSpeciesUpdate";
            this.bSpeciesUpdate.Size = new System.Drawing.Size(64, 27);
            this.bSpeciesUpdate.TabIndex = 44;
            this.bSpeciesUpdate.Text = "Update";
            this.bSpeciesUpdate.UseVisualStyleBackColor = true;
            this.bSpeciesUpdate.Click += new System.EventHandler(this.bSpeciesUpdate_Click);
            // 
            // bSpeciesDel
            // 
            this.bSpeciesDel.Location = new System.Drawing.Point(434, 3);
            this.bSpeciesDel.Name = "bSpeciesDel";
            this.bSpeciesDel.Size = new System.Drawing.Size(49, 25);
            this.bSpeciesDel.TabIndex = 43;
            this.bSpeciesDel.Text = "Delete";
            this.bSpeciesDel.UseVisualStyleBackColor = true;
            this.bSpeciesDel.Click += new System.EventHandler(this.bSpeciesDel_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 41;
            this.label19.Text = "Reference ID";
            // 
            // refURL
            // 
            this.refURL.Location = new System.Drawing.Point(65, 132);
            this.refURL.Name = "refURL";
            this.refURL.Size = new System.Drawing.Size(348, 21);
            this.refURL.TabIndex = 40;
            this.refURL.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 39;
            this.label15.Text = "Document";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 37;
            this.label13.Text = "Title";
            // 
            // refCite
            // 
            this.refCite.Location = new System.Drawing.Point(65, 43);
            this.refCite.Name = "refCite";
            this.refCite.Size = new System.Drawing.Size(573, 21);
            this.refCite.TabIndex = 35;
            // 
            // refDoc
            // 
            this.refDoc.Location = new System.Drawing.Point(65, 159);
            this.refDoc.Name = "refDoc";
            this.refDoc.Size = new System.Drawing.Size(348, 21);
            this.refDoc.TabIndex = 32;
            this.refDoc.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "URL";
            // 
            // refYear
            // 
            this.refYear.Location = new System.Drawing.Point(454, 102);
            this.refYear.Name = "refYear";
            this.refYear.Size = new System.Drawing.Size(62, 21);
            this.refYear.TabIndex = 30;
            this.refYear.Text = "2019";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(419, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "Year";
            // 
            // refAuthor
            // 
            this.refAuthor.Location = new System.Drawing.Point(65, 99);
            this.refAuthor.Name = "refAuthor";
            this.refAuthor.Size = new System.Drawing.Size(348, 21);
            this.refAuthor.TabIndex = 28;
            this.refAuthor.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "Author";
            // 
            // bSpeciesAdd
            // 
            this.bSpeciesAdd.Location = new System.Drawing.Point(482, 147);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 195);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(650, 210);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(563, 147);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 42);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refID);
            this.panel1.Controls.Add(this.refTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.bSpeciesAdd);
            this.panel1.Controls.Add(this.bSpeciesUpdate);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnParse);
            this.panel1.Controls.Add(this.bSpeciesDel);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.refAuthor);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.refURL);
            this.panel1.Controls.Add(this.refYear);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.refDoc);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.refCite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 195);
            this.panel1.TabIndex = 46;
            // 
            // refID
            // 
            this.refID.AutoSize = true;
            this.refID.Location = new System.Drawing.Point(108, 19);
            this.refID.Name = "refID";
            this.refID.Size = new System.Drawing.Size(11, 12);
            this.refID.TabIndex = 79;
            this.refID.Text = "0";
            // 
            // refTitle
            // 
            this.refTitle.Location = new System.Drawing.Point(65, 68);
            this.refTitle.Name = "refTitle";
            this.refTitle.Size = new System.Drawing.Size(451, 21);
            this.refTitle.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 46;
            this.label1.Text = "Cite";
            this.label1.DoubleClick += new System.EventHandler(this.btnParse_Click);
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(574, 67);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(64, 33);
            this.btnParse.TabIndex = 43;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // FormRef
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 405);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormRef";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CTDB - Data Source or Cite Reference";
            this.Load += new System.EventHandler(this.CTDBFormAddSpecies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSpeciesUpdate;
        private System.Windows.Forms.Button bSpeciesDel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox refURL;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox refCite;
        private System.Windows.Forms.TextBox refDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox refYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox refAuthor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bSpeciesAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox refTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label refID;
        private System.Windows.Forms.Button btnParse;
    }
}