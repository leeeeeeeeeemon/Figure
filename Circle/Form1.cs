using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if(form2.ShowDialog(this) == DialogResult.OK)
            {
                var paper = panel1.CreateGraphics();
                var pen = new Pen(Color.Pink, 7);
                if (form2.TextBox1.Text != null && form2.TextBox2.Text != null && form2.TextBox3.Text != null)
                {
                    paper.DrawEllipse(pen, Convert.ToInt32(form2.TextBox1.Text), Convert.ToInt32(form2.TextBox2.Text), Convert.ToInt32(form2.TextBox3.Text), Convert.ToInt32(form2.TextBox3.Text));
                }
                
            }
        }
    }
}
