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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }
        bool r = false;
        private void xButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);
            InitializeComponent();
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"c:\Program Files\iq180_2settings\beginsettings.dll",Encoding.UTF8);
            string hh = sr.ReadToEnd();
            sr.Close();
            if (textBox1.Text.Trim() == hh)
            {
                MessageBox.Show("歡迎光臨!", "你還是老樣子", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("通關密語不對喔!你是不是忘了呢?","糟糕",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox1.ForeColor = Color.Red;
                xButton1.Visible = false;
                r = false;
            }
        }

        private void textBox1_click(object sender, EventArgs e)
        {
            if (r==false)
            {
                r = true;
                textBox1.ForeColor = Color.LimeGreen;
                xButton1.Enabled = true;
                xButton1.Visible = true;
            }
            
        }

        private void start_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"c:\Program Files\iq180_2settings\");
            if (dir.Exists == false) 
            {
                begin bg = new begin();
                bg.ShowDialog();
            }
        }
    }
}
