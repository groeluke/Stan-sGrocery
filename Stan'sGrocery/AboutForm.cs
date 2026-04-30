using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stan_sGrocery
{
    public partial class AboutForm : System.Windows.Forms.Form
    {
        public AboutForm()
        {
            InitializeComponent();
            UpdateLabel();
        }

        void UpdateLabel()
        {
            AboutOkLabel.Text =
                $"Graphics Example\n" +
                $"ACME Inc.\n" +
                $"Version 1.0.0\n" +
                $"123Wabbit Woad\n" +
                $"Your Mother's House";
        }

        private void OkAboutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
