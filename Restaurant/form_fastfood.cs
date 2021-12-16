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
    public partial class form_fastfood : Form
    {
        public form_fastfood()
        {
            InitializeComponent();
        }
        Qlist q = new Qlist();
        
      
        private void Form2_Load(object sender, EventArgs e)
        {
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms[0].Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            q.enqueue(button1.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            q.enqueue(button2.Text);

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            q.enqueue(button3.Text);

          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            q.enqueue(button6.Text);

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            q.enqueue(button5.Text);

         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            q.enqueue(button4.Text);

          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Get menue
            string y = q.print();
            if (y != " ")
            {
                textBox3.Text =System.Environment.NewLine+y;
            }
            else
            {
                textBox3.Clear();
                MessageBox.Show("   the Orders have been Finished   ");
                q.clear();
                y = null;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Get order
            string y = q.dequeue();
            if (y != " ")
            {
                MessageBox.Show("Order has been prepared : " + y
                  +"\n\n"  +"datetime: "+DateTime.Now);
            }
            else
            {
                textBox3.Clear();
                MessageBox.Show("  Orders have been finished    ");
                q.clear();
                y = null;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            q.clear();
            textBox3.Clear();

        }

        
    }
}
