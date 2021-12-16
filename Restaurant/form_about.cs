using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class form_about : Form
    {
        public form_about()
        {
            InitializeComponent();
        }

        private void form_about_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms[0].Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cookdoor.com.eg/");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
