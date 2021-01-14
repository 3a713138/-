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
    public partial class Form3 : Form
    {
        public int skill = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skill = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            skill = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            skill = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            skill = 3;
        }
    }
}
