using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WindowsFormsApplication80
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox5.Text = DateTime.Now.ToString("yyyy/MM/dd" + " " + "dddd", new System.Globalization.CultureInfo("en-iq"));
            textBox6.Text = DateTime.Now.ToString( "dddd", new System.Globalization.CultureInfo("en-iq"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            textBox4.Text = DateTime.Now.ToString("hh : mm : ss .tt");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text=="12345")
            {
            Form3 fr = new Form3();
            fr.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("The Username Or Password Is Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
