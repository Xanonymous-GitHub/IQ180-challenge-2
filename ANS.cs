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
    public partial class ANS : Form
    {
        public ANS()
        {
            InitializeComponent();
        }
        int select;
        private void xButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            select = listBox1.SelectedIndex;
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            button3.Enabled = false;
            xButton1.Enabled = false;
            switch (select)
            {
                case 0:
                    groupBox4.Enabled = false;
                    break;
                case 1:
                    groupBox4.Enabled = false;
                    break;
                case 2:
                    groupBox4.Enabled = false;
                    break;
                case 3:
                    groupBox3.Enabled = false;
                    break;
                case 4:
                    groupBox3.Enabled = false;
                    break;
                case 5:
                    groupBox4.Enabled = false;
                    break;
                case 6:
                    groupBox4.Enabled = false;
                    break;
                case 7:
                    groupBox3.Enabled = false;
                    break;
                case 8:
                    groupBox3.Enabled = false;
                    break;
                case 9:
                    groupBox4.Enabled = false;
                    break;
                case 10:
                    groupBox4.Enabled = false;
                    break;
                case 11:
                    groupBox4.Enabled = false;
                    break;
                case 12:
                    groupBox4.Enabled = false;
                    break;
                case 13:
                    groupBox4.Enabled = false;
                    break;
                case 14:
                    groupBox4.Enabled = false;
                    break;
                case 15:
                    groupBox4.Enabled = false;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button3.Enabled == true)
            {
                DialogResult a = MessageBox.Show("答案未儲存喔!要放棄儲存嗎?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (a == DialogResult.Yes)
                {
                    richTextBox1.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                    xButton1.Enabled = true;
                }
            }
            else
            {
                richTextBox1.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
                xButton1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sel="";
            if (groupBox4.Enabled == true)
            {
                if (radioButton1.Checked == true)
                {
                    sel = "A";
                }
                if (radioButton2.Checked == true)
                {
                    sel = "B";
                }
                if (radioButton3.Checked == true)
                {
                    sel = "C";
                }
                if (radioButton4.Checked == true)
                {
                    sel = "D";
                }
            }
            #region save the ANS()
            try
            {
                switch (select)
                {
                    case 0:
                        StreamWriter sw1 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc1.dll");
                        sw1.Write(richTextBox1.Text);
                        sw1.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        StreamWriter sw2 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc2.dll");
                        sw2.Write(richTextBox1.Text);
                        sw2.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        StreamWriter sw3 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc3.dll");
                        sw3.Write(richTextBox1.Text);
                        sw3.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        StreamWriter sw4 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc4.dll");
                        sw4.Write(sel);
                        sw4.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 4:
                        StreamWriter sw5 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc5.dll");
                        sw5.Write(sel);
                        sw5.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 5:
                        StreamWriter sw6 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc6.dll");
                        sw6.Write(richTextBox1.Text);
                        sw6.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 6:
                        StreamWriter sw7 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc7.dll");
                        sw7.Write(richTextBox1.Text);
                        sw7.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 7:
                        StreamWriter sw8 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc8.dll");
                        sw8.Write(sel);
                        sw8.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 8:
                        StreamWriter sw9 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc9.dll");
                        sw9.Write(sel);
                        sw9.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 9:
                        StreamWriter sw10 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc10.dll");
                        sw10.Write(richTextBox1.Text);
                        sw10.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 10:
                        StreamWriter sw11 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc11.dll");
                        sw11.Write(richTextBox1.Text);
                        sw11.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 11:
                        StreamWriter sw12 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc12.dll");
                        sw12.Write(richTextBox1.Text);
                        sw12.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 12:
                        StreamWriter sw13 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc13.dll");
                        sw13.Write(richTextBox1.Text);
                        sw13.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 13:
                        StreamWriter sw14 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc14.dll");
                        sw14.Write(richTextBox1.Text);
                        sw14.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 14:
                        StreamWriter sw15 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc15.dll");
                        sw15.Write(richTextBox1.Text);
                        sw15.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 15:
                        StreamWriter sw16 = new StreamWriter(@"C:\Program Files\iq180_2settings\ansc16.dll");
                        sw16.Write(richTextBox1.Text);
                        sw16.Close();
                        MessageBox.Show("答案存好了!", "搞定", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch 
            {
                MessageBox.Show("發生作答系統錯誤,請執行作答系統修復精靈!", "糟糕",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            #endregion
            button3.Enabled = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void ANS_Load(object sender, EventArgs e)
        {
            DateTime d = new DateTime(2015, 9, 9);
            DateTime ddd = DateTime.Now;
            DirectoryInfo dd = new DirectoryInfo(@"c:\Program Files\iq180_2settings\iq180_2_excctenaled\");
            if (dd.Exists == true) { panel1.Visible = true; }
            else if (ddd > d) { panel2.Visible = true; }
            else { button1.Enabled = false; }
        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            #region streamreader file...
            StreamReader sr1 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc1.dll");
            StreamReader sr2 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc2.dll");
            StreamReader sr3 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc3.dll");
            StreamReader sr4 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc4.dll");
            StreamReader sr5 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc5.dll");
            StreamReader sr6 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc6.dll");
            StreamReader sr7 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc7.dll");
            StreamReader sr8 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc8.dll");
            StreamReader sr9 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc9.dll");
            StreamReader sr10 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc10.dll");
            StreamReader sr11 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc11.dll");
            StreamReader sr12 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc12.dll");
            StreamReader sr13 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc13.dll");
            StreamReader sr14 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc14.dll");
            StreamReader sr15 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc15.dll");
            StreamReader sr16 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc16.dll");
            string[] ans= new string[16];
            ans[0] = sr1.ReadToEnd();
            ans[1] = sr2.ReadToEnd();
            ans[2] = sr3.ReadToEnd();
            ans[3] = sr4.ReadToEnd();
            ans[4] = sr5.ReadToEnd();
            ans[5] = sr6.ReadToEnd();
            ans[6] = sr7.ReadToEnd();
            ans[7] = sr8.ReadToEnd();
            ans[8] = sr9.ReadToEnd();
            ans[9] = sr10.ReadToEnd();
            ans[10] = sr11.ReadToEnd();
            ans[11] = sr12.ReadToEnd();
            ans[12] = sr13.ReadToEnd();
            ans[13] = sr14.ReadToEnd();
            ans[14] = sr15.ReadToEnd();
            ans[15] = sr16.ReadToEnd();
            sr1.Close();
            sr2.Close();
            sr3.Close();
            sr4.Close();
            sr5.Close();
            sr6.Close();
            sr7.Close();
            sr8.Close();
            sr9.Close();
            sr10.Close();
            sr11.Close();
            sr12.Close();
            sr13.Close();
            sr14.Close();
            sr15.Close();
            sr16.Close();
            #endregion
            bool bl=true;
            for (int i = 0; i < 16; i++)
            {
                if ((ans[i].Trim()) == "")
                {
                    bl = false;
                }
            }
            if (bl == false) { MessageBox.Show("您還不能交卷!!","注意",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); }
            if (bl == true)
            {
                MessageBox.Show("您已經可以交卷!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xButton3.Enabled = true;
                xButton2.Enabled = false;
            }
        }

        private void xButton3_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("聽好!交卷不是想教就交!因為交了之後就無法更改答案了!你只能交一次!就像考試一樣!考卷交了,就再也拿不回來!所以我勸你期限快到時再交!(自己決定)好!要不要交?", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (a == DialogResult.Yes)
            {
                DialogResult b = MessageBox.Show("你確定嗎??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (b == DialogResult.Yes)
                {
                    StreamReader sr1 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc1.dll");
                    StreamReader sr2 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc2.dll");
                    StreamReader sr3 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc3.dll");
                    StreamReader sr4 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc4.dll");
                    StreamReader sr5 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc5.dll");
                    StreamReader sr6 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc6.dll");
                    StreamReader sr7 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc7.dll");
                    StreamReader sr8 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc8.dll");
                    StreamReader sr9 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc9.dll");
                    StreamReader sr10 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc10.dll");
                    StreamReader sr11 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc11.dll");
                    StreamReader sr12 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc12.dll");
                    StreamReader sr13 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc13.dll");
                    StreamReader sr14 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc14.dll");
                    StreamReader sr15 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc15.dll");
                    StreamReader sr16 = new StreamReader(@"C:\Program Files\iq180_2settings\ansc16.dll");
                    string[] ans = new string[16];
                    ans[0] = sr1.ReadToEnd();
                    ans[1] = sr2.ReadToEnd();
                    ans[2] = sr3.ReadToEnd();
                    ans[3] = sr4.ReadToEnd();
                    ans[4] = sr5.ReadToEnd();
                    ans[5] = sr6.ReadToEnd();
                    ans[6] = sr7.ReadToEnd();
                    ans[7] = sr8.ReadToEnd();
                    ans[8] = sr9.ReadToEnd();
                    ans[9] = sr10.ReadToEnd();
                    ans[10] = sr11.ReadToEnd();
                    ans[11] = sr12.ReadToEnd();
                    ans[12] = sr13.ReadToEnd();
                    ans[13] = sr14.ReadToEnd();
                    ans[14] = sr15.ReadToEnd();
                    ans[15] = sr16.ReadToEnd();
                    DirectoryInfo dd = new DirectoryInfo(@"c:\IQ1802ANS\");
                    dd.Create();
                    DirectoryInfo ddd = new DirectoryInfo(@"c:\Program Files\iq180_2settings\iq180_2_excctenaled\");
                    ddd.Create();
                    StreamWriter sw = new StreamWriter(@"c:\IQ1802ANS\IQ180_2活動答案卷.dll");
                    StreamWriter cantexx = new StreamWriter(@"c:\Program Files\iq180_2settings\iq180_2_excctenaled\excctenaled.dll");
                    for (int i = 0; i < 16; i++)
                    {
                        sw.Write("System{$rehorgoegrmhgwiugph98uhp,drfug,iudregjeuidrjguiepg?/reogijo/reg jei,jg 9g9ejurghu??}/:::");
                        sw.Write(i + 1);
                        cantexx.Write("System{$rehorgoegrmhgwiugph98uhp,drfug,iudregjeuidrjguiepg?/reogijo/reg jei,jg 9g9ejurghu??}/:::");
                        cantexx.Write(i + 1);
                        sw.Write(".");
                        cantexx.Write(".");
                        sw.WriteLine(ans[i]);
                        cantexx.WriteLine(ans[i]);
                    }
                    sw.Close();
                    cantexx.Close();
                    sr1.Close();
                    sr2.Close();
                    sr3.Close();
                    sr4.Close();
                    sr5.Close();
                    sr6.Close();
                    sr7.Close();
                    sr8.Close();
                    sr9.Close();
                    sr10.Close();
                    sr11.Close();
                    sr12.Close();
                    sr13.Close();
                    sr14.Close();
                    sr15.Close();
                    sr16.Close();
                    MessageBox.Show(@"交卷成功!位置:(C:\IQ1802ANS\IQ180_2活動答案卷.dll)", "交卷已完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Visible = true;
                }
            }
        }

        private void xButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region 問題與解決方案
        private void xButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"它的位置:(C:\IQ1802ANS\IQ180_2活動答案卷.dll)如果真的遺失了,請嘗試[答案卷備份補發]。", "問題與解決方案", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void xButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("交卷後就不能再更改答案,這是遊戲規則啊!你交卷時我也有提醒過你!這樣瞭嗎!別再問我這鬼問題!", "問題與解決方案", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void xButton7_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("需要補發備份的答案卷嗎??", "問題與解決方案", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                StreamReader sr = new StreamReader(@"c:\Program Files\iq180_2settings\iq180_2_excctenaled\excctenaled.dll");
                string spp = sr.ReadToEnd();
                DirectoryInfo dd = new DirectoryInfo(@"c:\IQ1802ANS\");
                dd.Create();
                StreamWriter sw = new StreamWriter(@"c:\IQ1802ANS\IQ180_2活動答案卷.dll");
                sw.Write(spp);
                sr.Close();
                sw.Close();
                MessageBox.Show(@"補發完成。它的位置:(C:\IQ1802ANS\IQ180_2活動答案卷.dll)別再搞丟了!", "問題與解決方案", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }
        #endregion
        private void xButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
