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
    public partial class 計數開始 : Form
    {
        public 計數開始()
        {
            InitializeComponent();
        }

        private void 開始計數_Click(object sender, EventArgs e)
        {
            Form 計數器 = new 計數器();
            計數器.Show();
        }
    }
}
