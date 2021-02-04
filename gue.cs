using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IQ180大挑戰2
{
    public partial class gue : Form
    {
        public gue()
        {
            InitializeComponent();
        }
        string guee = q.quee;
        private void xButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gue_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = (guee);
        }
    }
}
