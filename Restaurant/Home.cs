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
    public partial class Home : Form
    {
      
        public Home()
        {
            InitializeComponent();
           
        }
          
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_fastfood ff = new form_fastfood();
            this.Hide();
            ff.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_about fa = new form_about();
          
            fa.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Show();
        }

     
        private void button3_Click(object sender, EventArgs e)
        {
            form_dessert fd = new form_dessert();
            this.Hide();
            fd.Show();
        }

       
    }
}
