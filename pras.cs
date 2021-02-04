using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IQ180大挑戰2
{
    public partial class pras : Form
    {
        public pras()
        {
            InitializeComponent();
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
            richTextBox2.Enabled = true;
            button1.Enabled = false;
            listBox1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            StreamReader sr = new StreamReader(@"C:\Program Files\iq180_2settings\DefauleIQ1802question.dll", Encoding.Default);
            #region 練習顯示
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < 1; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 1:
                    for (int i = 0; i < 2; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 2:
                    for (int i = 0; i < 3; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 3:
                    for (int i = 0; i < 4; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 4:
                    for (int i = 0; i < 5; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 5:
                    for (int i = 0; i < 6; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 6:
                    for (int i = 0; i < 7; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 7:
                    for (int i = 0; i < 8; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 8:
                    for (int i = 0; i < 9; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 9:
                    for (int i = 0; i < 10; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 10:
                    for (int i = 0; i < 11; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 11:
                    for (int i = 0; i < 12; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 12:
                    for (int i = 0; i < 13; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 13:
                    for (int i = 0; i < 14; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 14:
                    for (int i = 0; i < 15; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 15:
                    for (int i = 0; i < 16; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 16:
                    for (int i = 0; i < 17; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 17:
                    for (int i = 0; i < 18; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 18:
                    for (int i = 0; i < 19; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 19:
                    for (int i = 0; i < 20; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 20:
                    for (int i = 0; i < 21; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 21:
                    for (int i = 0; i < 22; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 22:
                    for (int i = 0; i < 23; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 23:
                    for (int i = 0; i < 24; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 24:
                    for (int i = 0; i < 25; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 25:
                    for (int i = 0; i < 26; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 26:
                    for (int i = 0; i < 27; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 27:
                    for (int i = 0; i < 28; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 28:
                    for (int i = 0; i < 29; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 29:
                    for (int i = 0; i < 30; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 30:
                    for (int i = 0; i < 31; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 31:
                    for (int i = 0; i < 32; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 32:
                    for (int i = 0; i < 33; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
                case 33:
                    for (int i = 0; i < 34; i++)
                        richTextBox1.Text = sr.ReadLine();
                    break;
            }
            #endregion   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
            richTextBox2.Enabled = false;
            button1.Enabled = true;
            listBox1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            StreamReader sr = new StreamReader(@"C:\Program Files\iq180_2settings\DefauleIQ1802ANSs.dll", Encoding.Default);
            #region 答案顯示
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < 1; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 1:
                    for (int i = 0; i < 2; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 2:
                    for (int i = 0; i < 3; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 3:
                    for (int i = 0; i < 4; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 4:
                    for (int i = 0; i < 5; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 5:
                    for (int i = 0; i < 6; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 6:
                    for (int i = 0; i < 7; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 7:
                    for (int i = 0; i < 8; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 8:
                    for (int i = 0; i < 9; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 9:
                    for (int i = 0; i < 10; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 10:
                    for (int i = 0; i < 11; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 11:
                    for (int i = 0; i < 12; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 12:
                    for (int i = 0; i < 13; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 13:
                    for (int i = 0; i < 14; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 14:
                    for (int i = 0; i < 15; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 15:
                    for (int i = 0; i < 16; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 16:
                    for (int i = 0; i < 17; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 17:
                    for (int i = 0; i < 18; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 18:
                    for (int i = 0; i < 19; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 19:
                    for (int i = 0; i < 20; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 20:
                    for (int i = 0; i < 21; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 21:
                    for (int i = 0; i < 22; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 22:
                    for (int i = 0; i < 23; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 23:
                    for (int i = 0; i < 24; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 24:
                    for (int i = 0; i < 25; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 25:
                    for (int i = 0; i < 26; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 26:
                    for (int i = 0; i < 27; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 27:
                    for (int i = 0; i < 28; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 28:
                    for (int i = 0; i < 29; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 29:
                    for (int i = 0; i < 30; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 30:
                    for (int i = 0; i < 31; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 31:
                    for (int i = 0; i < 32; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 32:
                    for (int i = 0; i < 33; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
                case 33:
                    for (int i = 0; i < 34; i++)
                        richTextBox2.Text = sr.ReadLine();
                    break;
            }
            #endregion
        }

        private void pras_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(@"C:\Program Files\iq180_2settings\DefauleIQ1802question.dll", Encoding.Default);
                StreamReader ssr = new StreamReader(@"C:\Program Files\iq180_2settings\DefauleIQ1802ANSs.dll", Encoding.Default);
            }
            catch
            {
                listBox1.Items.Clear();
                MessageBox.Show("您沒有任何題庫,或是題目損毀!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Visible = false;
                xButton2.Visible = true;
            }
            button1.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            catchqa cat = new catchqa();
            cat.ShowDialog();
            panel1.Visible = true;
            xButton2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
