using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CTDB
{
    public partial class About : Form
    {
        public About() { InitializeComponent(); }
        public About(string t = "")
        {
            InitializeComponent();
            ShowCMD = t;
        }
        public About(string title, string content)
        {
            InitializeComponent();
            this.Text = title;
            this.textBox1.Text = content;
        }

        public string ShowCMD = "";

        private void About_Load(object sender, EventArgs e)
        {
            switch (ShowCMD)
            {
                case "help_ct_Sample":
                    textBox1.Text = Properties.Resources.help_ct_Sample;
                    break;
                case "help_ct_Scan":
                    textBox1.Text = Properties.Resources.help_ct_Scan;
                    break;
                case "help_ct":
                    textBox1.Text = Properties.Resources.help_ct;
                    break;
                default:
                    break;
            }
        }


    }
}
