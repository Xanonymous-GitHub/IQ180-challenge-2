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
    public partial class begin : Form
    {
        public begin()
        {
            InitializeComponent();
        }
        string paword;
        private void xButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);
            InitializeComponent();
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            SYSTEMUSERmessge sys = new SYSTEMUSERmessge();
            sys.ShowDialog();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            xButton1.Visible = false;
            xButton2.Visible = false;
            label1.Visible = false;
            panel1.Visible = true;
        }

        private void xButton3_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("您正在設定通關密語,真的要離開嗎?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
                Environment.Exit(Environment.ExitCode);
                InitializeComponent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            paword = textBox1.Text;
        }
        
        private void xButton4_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"c:\Program Files\iq180_2settings\");
            dir.Create();
            FileStream dll = new FileStream(@"c:\Program Files\iq180_2settings\beginsettings.dll", FileMode.Create);
            StreamWriter sw = new StreamWriter(dll, Encoding.UTF8);
            sw.Write(paword);
            sw.Close();
            FileStream a1 = new FileStream(@"C:\Program Files\iq180_2settings\ansc1.dll", FileMode.Create);
            FileStream a2 = new FileStream(@"C:\Program Files\iq180_2settings\ansc2.dll", FileMode.Create);
            FileStream a3 = new FileStream(@"C:\Program Files\iq180_2settings\ansc3.dll", FileMode.Create);
            FileStream a4 = new FileStream(@"C:\Program Files\iq180_2settings\ansc4.dll", FileMode.Create);
            FileStream a5 = new FileStream(@"C:\Program Files\iq180_2settings\ansc5.dll", FileMode.Create);
            FileStream a6 = new FileStream(@"C:\Program Files\iq180_2settings\ansc6.dll", FileMode.Create);
            FileStream a7 = new FileStream(@"C:\Program Files\iq180_2settings\ansc7.dll", FileMode.Create);
            FileStream a8 = new FileStream(@"C:\Program Files\iq180_2settings\ansc8.dll", FileMode.Create);
            FileStream a9 = new FileStream(@"C:\Program Files\iq180_2settings\ansc9.dll", FileMode.Create);
            FileStream a10 = new FileStream(@"C:\Program Files\iq180_2settings\ansc10.dll", FileMode.Create);
            FileStream a11 = new FileStream(@"C:\Program Files\iq180_2settings\ansc11.dll", FileMode.Create);
            FileStream a12 = new FileStream(@"C:\Program Files\iq180_2settings\ansc12.dll", FileMode.Create);
            FileStream a13 = new FileStream(@"C:\Program Files\iq180_2settings\ansc13.dll", FileMode.Create);
            FileStream a14 = new FileStream(@"C:\Program Files\iq180_2settings\ansc14.dll", FileMode.Create);
            FileStream a15 = new FileStream(@"C:\Program Files\iq180_2settings\ansc15.dll", FileMode.Create);
            FileStream a16 = new FileStream(@"C:\Program Files\iq180_2settings\ansc16.dll", FileMode.Create);
            a1.Close();
            a2.Close();
            a3.Close();
            a4.Close();
            a5.Close();
            a6.Close();
            a7.Close();
            a8.Close();
            a9.Close();
            a10.Close();
            a11.Close();
            a12.Close();
            a13.Close();
            a14.Close();
            a15.Close();
            a16.Close();
            this.Close();
        }

        private void xButton5_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text.Trim();
            string text2 = textBox2.Text.Trim();
            if ((text1) != ("") & (text2) != (""))//是否有正確輸入
            {
                if (text1 == text2)//是否相等
                {
                    DialogResult a = MessageBox.Show("您的通關密語可以使用。確定要用這組密語嗎?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (a == DialogResult.Yes)
                    {
                        xButton5.Enabled = false;
                        xButton5.Text = "overed";
                        button1.Enabled = true;
                        button1.BackColor = Color.Red;
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        xButton3.Enabled = false;
                        checkBox1.Enabled = false;
                        checkBox2.Enabled = false;
                        textBox1.UseSystemPasswordChar = true;
                        textBox2.UseSystemPasswordChar = true;
                    }
                }
                else//不相等
                {
                    MessageBox.Show("通關密語無法確認!","錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else//有空缺項
            {
                MessageBox.Show("有空缺項!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
