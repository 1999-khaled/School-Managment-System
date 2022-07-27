using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhaledMedhatProject
{
    public partial class prog : Form
    {
        Subjects a = new Subjects();
        Gpa z = new Gpa();
        attendence y = new attendence();
        Form1 x = new Form1();
        public prog()
        {
            InitializeComponent();
        }

        private void prog_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.Setvalue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            y.Name = textBox1.Text;
            z.Name = textBox1.Text;
            a.Name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            y.Id =Convert.ToInt32( textBox2.Text);
            z.Id = Convert.ToInt32(textBox2.Text);
            a.Id = Convert.ToInt32(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (a.Sub() != 0)
            {

                label6.Text = a.tostring();

            }
            else { MessageBox.Show("ERROR!!"); }


            if (y.attendance() != 0)
            {

                label5.Text = y.tostring();

            }
            else { MessageBox.Show("ERROR!!"); }



            if (z.gpA() != 0) {

                label7.Text = z.tostring();

            }
            else { MessageBox.Show("ERROR!!"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (z.halfload() == 1) { MessageBox.Show("YES!!"); }
            else { MessageBox.Show("NO!!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(a.numsub()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult iexit;
            iexit = MessageBox.Show("Are you sure you want to exit??","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iexit == DialogResult.Yes) { Application.Exit(); }
            
        }
    }
}
