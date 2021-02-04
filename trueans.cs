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
    public partial class trueans : Form
    {
        public trueans()
        {
            InitializeComponent();
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: richTextBox1.Text = "40370716"; break;
                case 1: richTextBox1.Text = "挨餓"; break;
                case 2: richTextBox1.Text = "79952"; break;
                case 3: richTextBox1.Text = "A"; break;
                case 4: richTextBox1.Text = "B"; break;
                case 5: richTextBox1.Text = "800"; break;
                case 6: richTextBox1.Text = "0"; break;
                case 7: richTextBox1.Text = "B"; break;
                case 8: richTextBox1.Text = "C"; break;
                case 9: richTextBox1.Text = "樹"; break;
                case 10: richTextBox1.Text = "0"; break;
                case 11: richTextBox1.Text = "無解"; break;
                case 12: richTextBox1.Text = "衛生紙"; break;
                case 13: richTextBox1.Text = "Visual(2C+1+#)"; break;
                case 14: richTextBox1.Text = "7"; break;
                case 15: richTextBox1.Text = "Hermione Granger"; break;
                default: MessageBox.Show("沒這題!重選!","",MessageBoxButtons.OK,MessageBoxIcon.Information); break;
            }
        }

        private void trueans_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
