using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期末3A713138陳永毅
{   
    
    public partial class Form2 : Form
    {
        public int STR = 0;
        public int MSTR = 0;
        public int x = 0;
        Form1 form;
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {   
            
            
            if (x > 0)
            {
                MSTR = MSTR + 1;
                string MSTRs = MSTR.ToString();
                label5.Text = MSTRs;
                x = x- 1;
                string points = x.ToString();
                label3.Text = points;
            }
            else
            {
                MessageBox.Show($"點數不足", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
       
            if (x > 0)
            {
                STR = STR + 1;
                string STRs = STR.ToString();
                label4.Text = STRs;
                x = x - 1;
                string points = x.ToString();
                label3.Text = points;
            }
            else
            {
                MessageBox.Show($"點數不足", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (STR > 0)
            {
                STR = STR - 1;
                string MSTRs = MSTR.ToString();
                label5.Text = MSTRs;
                x = x + 1;
                string points = x.ToString();
                label3.Text = points;
            }
            else
            {
                MessageBox.Show($"點數不足", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (MSTR > 0)
            {
                MSTR = MSTR - 1;
                string MSTRs = MSTR.ToString();
                label4.Text = MSTRs;
                x = x + 1;
                string points = x.ToString();
                label3.Text = points;
            }
            else
            {

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            
            string points = x.ToString();
            label3.Text = points;
        }
    }
}
