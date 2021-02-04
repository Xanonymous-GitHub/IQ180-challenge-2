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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        int jbutton = 0;
        int ibutton = 0;
        string ques = "";
        public static int qname;
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            DateTime df = new DateTime(2015, 9, 9);
            if (d > df)
            {
                DialogResult a = MessageBox.Show("活動已過期!不過，你還是可以玩玩。要開嗎?", "時光飛逝", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    start stt = new start();
                    stt.ShowDialog();
                }
                else
                {
                    this.Close();
                    Environment.Exit(Environment.ExitCode);
                    InitializeComponent();
                }
            }
            else
            {
                start st = new start();
                st.ShowDialog();
            }
        }

        private void xButton4_Click(object sender, EventArgs e)//返回按鈕動作
        {
            DateTime d = DateTime.Now;
            DateTime dff = new DateTime(2015, 9, 9);
            switch (jbutton)
            {
                case 0:
                    this.Close();
                    Environment.Exit(Environment.ExitCode);
                    InitializeComponent();
                    break;
                case 1:
                    pictureBox1.Visible = true;
                    xButton1.Visible = true;
                    xButton2.Visible = true;
                    xButton3.Visible = true;
                    jbutton = 0;
                    xButton4.Text = "離開";
                    richTextBox1.Visible = false;
                    iButton10.Visible = false;
                    break;
                case 2:
                    pictureBox1.Visible = true;
                    xButton1.Visible = true;
                    xButton2.Visible = true;
                    xButton3.Visible = true;
                    jbutton = 0;
                    xButton4.Text = "離開";
                    groupBox1.Visible = false;
                    iButton10.Visible = false;
                    xButton10.Visible = false;
                    break;
                case 3:
                    pictureBox1.Visible = false;
                    xButton1.Visible = false;
                    xButton2.Visible = false;
                    xButton3.Visible = false;
                    EASYBOX.Visible = false;
                    MIDDLEBOX.Visible = false;
                    HARDBOX.Visible = false;
                    MOSTHBOX.Visible = false;
                    VERYHBOX.Visible = false;
                    groupBox1.Enabled = true;
                    iButton10.Visible = true;
                    jbutton = 2;
                    xButton4.Text = "返回";
                    groupBox1.Visible = true;
                    iButton10.Visible = true;
                    if (d > dff) { xButton10.Visible = true; }
                    break;

            }
                   
        }

        private void xButton3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            xButton1.Visible = false;
            xButton2.Visible = false;
            xButton3.Visible = false;
            jbutton = 1;
            ibutton = 0;
            xButton4.Text = "返回";
            richTextBox1.Visible = true;
            iButton10.Visible = true;
            iButton10.Text = "關於";
                                  
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            DateTime df = new DateTime(2015, 3, 9);
            DateTime dff = new DateTime(2015, 9, 9);
            if (d < df)
            {
                MessageBox.Show("太早太早!活動3月10號才開始呢!", "不讓你挑戰", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pictureBox1.Visible = false;
                xButton1.Visible = false;
                xButton2.Visible = false;
                xButton3.Visible = false;
                groupBox1.Enabled = true;
                groupBox1.Visible = true;
                EASYBOX.Visible = false;
                MIDDLEBOX.Visible = false;
                HARDBOX.Visible = false;
                VERYHBOX.Visible = false;
                MOSTHBOX.Visible = false;
                iButton10.Visible = true;
                iButton10.Text = "作答";
                jbutton = 2;
                ibutton = 1;
                xButton4.Text = "返回";
                groupBox1.Visible = true;
                if (d > dff) { xButton10.Visible = true; }
            }
        }
        void qq(string que)
        {
            switch (que)
            {
                case "easy":
                    EASYBOX.Visible = true;
                    groupBox1.Visible = false;
                    iButton10.Visible = false;
                    xButton10.Visible = false;
                    break;
                case "middle":
                    MIDDLEBOX.Visible = true;
                    groupBox1.Visible = false;
                    iButton10.Visible = false;
                    xButton10.Visible = false;
                    break;
                case "hard":
                    HARDBOX.Visible = true;
                    groupBox1.Visible = false;
                    iButton10.Visible = false;
                    xButton10.Visible = false;
                    break;
                case "veryhard":
                    VERYHBOX.Visible = true;
                    groupBox1.Visible = false;
                    iButton10.Visible = false;
                    xButton10.Visible = false;
                    break;
                case "mosthard":
                    MOSTHBOX.Visible = true;
                    groupBox1.Visible = false;
                    iButton10.Visible = false;
                    xButton10.Visible = false;
                    break;
            }
        }

        private void xButton5_Click(object sender, EventArgs e)
        {
            ques = "easy";
            jbutton = 3;
            qq(ques);
        }

        private void xButton6_Click(object sender, EventArgs e)
        {
            ques = "middle";
            jbutton = 3;
            qq(ques);
        }

        private void xButton7_Click(object sender, EventArgs e)
        {
            ques = "hard";
            jbutton = 3;
            qq(ques);
        }

        private void xButton8_Click(object sender, EventArgs e)
        {
            ques = "veryhard";
            jbutton = 3;
            qq(ques);
        }

        private void xButton9_Click(object sender, EventArgs e)
        {
            ques = "mosthard";
            jbutton = 3;
            qq(ques);
        }

        private void iButton10_Click(object sender, EventArgs e)
        {
            switch (ibutton)
            {
                case 0:
                    IF iff = new IF();
                    iff.ShowDialog();
                    break;
                case 1://作答
                    ANS ans = new ANS();
                    ans.ShowDialog();
                    break;
            }
        }
        #region 題目按鈕
        private void easy3_Click(object sender, EventArgs e)
        {
            MainForm.qname = 3;
            q qq = new q();
            qq.ShowDialog();
        }

        private void easy1_Click(object sender, EventArgs e)
        {
            MainForm.qname = 1;
            q qq = new q();
            qq.ShowDialog();
        }

        private void easy2_Click(object sender, EventArgs e)
        {
            MainForm.qname = 2;
            q qq = new q();
            qq.ShowDialog();
        }

        private void easy4_Click(object sender, EventArgs e)
        {
            MainForm.qname = 4;
            q qq = new q();
            qq.ShowDialog();
        }

        private void easy5_Click(object sender, EventArgs e)
        {
            MainForm.qname = 5;
            q qq = new q();
            qq.ShowDialog();
        }

        private void middle1_Click(object sender, EventArgs e)
        {
            MainForm.qname = 6;
            q qq = new q();
            qq.ShowDialog();
        }

        private void middle2_Click(object sender, EventArgs e)
        {
            MainForm.qname = 7;
            q qq = new q();
            qq.ShowDialog();
        }

        private void middle3_Click(object sender, EventArgs e)
        {
            MainForm.qname = 8;
            q qq = new q();
            qq.ShowDialog();
        }

        private void middle4_Click(object sender, EventArgs e)
        {
            MainForm.qname = 9;
            q qq = new q();
            qq.ShowDialog();
        }

        private void hard1_Click(object sender, EventArgs e)
        {
            MainForm.qname = 10;
            q qq = new q();
            qq.ShowDialog();
        }

        private void hard2_Click(object sender, EventArgs e)
        {
            MainForm.qname = 11;
            q qq = new q();
            qq.ShowDialog();
        }

        private void hard3_Click(object sender, EventArgs e)
        {
            MainForm.qname = 12;
            q qq = new q();
            qq.ShowDialog();
        }

        private void veryh1_Click(object sender, EventArgs e)
        {
            MainForm.qname = 13;
            q qq = new q();
            qq.ShowDialog();
        }

        private void veryh2_Click(object sender, EventArgs e)
        {
            MainForm.qname = 14;
            q qq = new q();
            qq.ShowDialog();
        }

        private void mosth1_Click(object sender, EventArgs e)
        {
            MainForm.qname = 15;
            q qq = new q();
            qq.ShowDialog();
        }

        private void mosth2_Click(object sender, EventArgs e)
        {
            MainForm.qname = 16;
            q qq = new q();
            qq.ShowDialog();
        }
        #endregion
        private void xButton2_Click(object sender, EventArgs e)
        {
            pras pra = new pras();
            pra.ShowDialog();
        }

        private void xButton10_Click(object sender, EventArgs e)
        {
            trueans tr = new trueans();
            tr.ShowDialog();
        }
    }
}
