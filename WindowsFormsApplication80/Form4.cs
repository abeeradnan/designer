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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            txt.Location = new Point(100, 50);
            Controls.Add(txt);
            txt.Width = 150;
            txt.Name = "t";


            Label l = new Label();
            Controls.Add(l);
            l.Location = new Point(250, 50);
            l.Text = " : الاسم ".ToString();


            Button bo = new Button();
            Controls.Add(bo);
            bo.Location = new Point(100, 100);
            bo.Width = 150;
            bo.Text = "حفظ";
            bo.BackColor = Color.DarkGray;
        
        }
    }
}
