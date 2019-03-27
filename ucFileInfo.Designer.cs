namespace CTDB
{
    partial class ucFileInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCount = new System.Windows.Forms.Label();
            this.btnFileAdd = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.cbFileType = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbCountAll = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(172, 0);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(11, 12);
            this.lbCount.TabIndex = 117;
            this.lbCount.Text = "0";
            // 
            // btnFileAdd
            // 
            this.btnFileAdd.Location = new System.Drawing.Point(142, 15);
            this.btnFileAdd.Name = "btnFileAdd";
            this.btnFileAdd.Size = new System.Drawing.Size(47, 21);
            this.btnFileAdd.TabIndex = 61;
            this.btnFileAdd.Text = "+File";
            this.btnFileAdd.UseVisualStyleBackColor = true;
            this.btnFileAdd.Click += new System.EventHandler(this.btnFileAdd_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Dock = System.Windows.Forms.DockStyle.Top;
            this.label44.Location = new System.Drawing.Point(3, 17);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(29, 12);
            this.label44.TabIndex = 115;
            this.label44.Text = "Type";
            // 
            // cbFileType
            // 
            this.cbFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFileType.FormattingEnabled = true;
            this.cbFileType.Location = new System.Drawing.Point(38, 15);
            this.cbFileType.Name = "cbFileType";
            this.cbFileType.Size = new System.Drawing.Size(98, 20);
            this.cbFileType.TabIndex = 116;
            this.cbFileType.SelectedIndexChanged += new System.EventHandler(this.cbFileType_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbCountAll);
            this.groupBox6.Controls.Add(this.lbCount);
            this.groupBox6.Controls.Add(this.cbFileType);
            this.groupBox6.Controls.Add(this.btnFileAdd);
            this.groupBox6.Controls.Add(this.label44);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(195, 42);
            this.groupBox6.TabIndex = 144;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "File Count All:         Sel";
            // 
            // lbCountAll
            // 
            this.lbCountAll.AutoSize = true;
            this.lbCountAll.Location = new System.Drawing.Point(102, 0);
            this.lbCountAll.Name = "lbCountAll";
            this.lbCountAll.Size = new System.Drawing.Size(11, 12);
            this.lbCountAll.TabIndex = 118;
            this.lbCountAll.Text = "0";
            // 
            // ucFileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Name = "ucFileInfo";
            this.Size = new System.Drawing.Size(195, 42);
            this.Load += new System.EventHandler(this.ucFileInfo_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFileAdd;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox cbFileType;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbCountAll;
    }
}
