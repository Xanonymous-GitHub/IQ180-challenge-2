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
    public partial class SYSTEMUSERmessge : Form
    {
        public SYSTEMUSERmessge()
        {
            InitializeComponent();
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            windhide ww = new windhide();
            ww.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            xButton1.Enabled = true;
            radioButton2.Enabled = false;
        }
    }
}
