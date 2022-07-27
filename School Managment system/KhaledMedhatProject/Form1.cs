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
    public partial class Form1 : Form
    {
        public static string Setvalue = "";
        Login x = new Login();
        public static Form1 firstform;
        public Form1()
        {
            InitializeComponent();
            firstform = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Setvalue = textBox2.Text;
            if (x.log_in() == 1)
            {
                textBox1.Text = textBox2.Text = "";
                prog f2 = new prog();
                f2.Show();
                firstform.Hide();


            }
            else { MessageBox.Show("ERROR"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SIGNUP x = new SIGNUP();
            x.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            x.InputName = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            x.InputPass = textBox1.Text;
        }
    }
}
