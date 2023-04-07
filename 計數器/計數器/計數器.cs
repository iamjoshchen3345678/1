using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計數器
{
    public partial class 計數器 : Form
    {
        public 計數器()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String temp = label1.Text;
            int count = 0;
            try
            {
                count = Int32.Parse(temp) + 1;
            }
            catch (Exception e1)
            {
                label1.Text = "0";
            }

            //label2.Text =cout+"";
            label1.Text = count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String temp = label1.Text;
            int count = 0;
            try
            {
                count = Int32.Parse(temp) - 1;
            }
            catch (Exception e1)
            {
                label1.Text = "0";
            }

            //label2.Text =cout-"";
            label1.Text = count.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
