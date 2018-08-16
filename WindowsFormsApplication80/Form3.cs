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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            txt.Location = new Point(500, 150);
            Controls.Add(txt);
            txt.Width = 180;
            

            

            
            Label l = new Label();
            Controls.Add(l);
            l.Location = new Point(690, 150);
            l.Text = " : الاسم ".ToString();


            //ComboBox box = new ComboBox();
            //Controls.Add(box);
            //box.Location = new Point(500, 150);
            //box.Width = 180;

            //Label l2 = new Label();
            //Controls.Add(l2);
            //l2.Location = new Point(690, 150);
            //l2.Text = " : النوع ".ToString();


            ListBox list = new ListBox();
            Controls.Add(list);
            list.Location = new Point(500, 175);
            list.ScrollAlwaysVisible = true;
            list.BackColor = Color.Teal;
            list.Sorted = true;
            list.Width = 230;
            list.Height = 350;

            list.Items.Add("باطنية ");
            list.Items.Add("تخطيط قلب");
            list.Items.Add("جملة عصبية");
            list.Items.Add("العيون");
            list.Items.Add("جراحة");
            list.Items.Add("تجميلية");
            list.Items.Add("الاطفال");
            list.Items.Add("فحص البصر");
            list.Items.Add("العقم");
            list.Items.Add("نسائية");
            list.Items.Add("(ضماد رجالي ونسائي (عمليات صغرى");
            list.Items.Add("مفاصل");
            list.Items.Add("الانف والاذن والحنجرة ");
            list.Items.Add("تجبيس");
            list.Items.Add("كسور");
            list.Items.Add("مختبر");
            list.Items.Add("جلدية");


            for (int i = 1; i < 5; i++)
            {

                Button b = new Button();
                Controls.Add(b);
                b.BackColor = Color.DarkGray;
                b.Left = 500;
                b.Top = 515 + i * 25;
                b.Width = 100;

                if (i == 1)
                {
                    b.Click += new EventHandler(b1click);
                    b.Text = "اضافة";
                    
              
                }


                //if (i == 2)
                //{
                //    b.Click += new EventHandler(b2click);
                //    b.Text = "حذف";
                //}


                //if (i == 3)
                //{
                //    b.Click += new EventHandler(b3click);
                //    b.Text = "تعديل";
                //}


                //if (i == 4)
                //{
                //    b.Click += new EventHandler(b4click);
                //    b.Text = "تكليف";
                //}

            }

        }

        private void b1click(object sender, EventArgs e)
        {

            Form4 fr = new Form4();
            fr.Show();
            fr.BackColor = Color.Teal;
            fr.StartPosition = FormStartPosition.CenterScreen;

            fr.Text = "اضافة الاستشارية";
            fr.Size = new Size(400, 200);
            
         
            


        }













        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}


