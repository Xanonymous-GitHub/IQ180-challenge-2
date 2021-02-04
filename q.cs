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
    public partial class q : Form
    {
        public q()
        {
            InitializeComponent();
        }
        int qw = MainForm.qname;
        public static string quee = "";
        private void xButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region 所有題目和提示
        private void q_Load(object sender, EventArgs e)
        {
            switch (qw)//題目&提示請打這~
            {
                case 1:
                    label1.Text = "LEVEL-C-1";
                    QBOX.Text = "(99*78)(99*78)+X=100000000，問X=?";
                    q.quee = "計算機真是個偉大的發明!";
                    gue.Enabled = true;
                    break;
                case 2:
                    label1.Text = "LEVEL-C-2";
                    QBOX.Text = "我前去埃及，然後去俄國觀光，請問發生什麼事呢?";
                    q.quee = "";
                    gue.Enabled = false;
                    break;
                case 3:
                    label1.Text = "LEVEL-C-3";
                    QBOX.Text = "THEREWASASQUAREHEREITSLENGTHOFASIDEWASAPLUSTENBUTTHEREWASANOTHERSQUAREINTHESQUAREITSLENGTHOFASIDEWASAITSGREYBESIDESSMALLSQUARETHPARTOFGREYWASFOURHUNDREDSQUARECM,求大正方形和小正方形的邊長的合的1997倍加72。";
                    q.quee = "在內部某處加上一個'E'，並轉小寫。";
                    gue.Enabled = true;
                    break;
                case 4:
                    label1.Text = "LEVEL-C-4";
                    QBOX.Text = "伊莉莎白二世問伊莉莎白三世說:甚是?? ???伊莉莎白三世回答伊莉莎白二世說:是??? ??嗎?伊莉莎白二世說:不是!伊莉莎白三世又問說:「…………」,然後伊莉莎白二世就說:沒錯!妳答對了! 求伊莉莎白三世說了啥?(A)「是?? ??? 」(B)「是? ????嗎? 」(C)「是?? ???嗎? 」(D)「是??? ?? 」";
                    q.quee = "借代伊莉莎白二世和伊莉莎白三世。";
                    gue.Enabled = true;
                    break;
                case 5:
                    label1.Text = "LEVEL-C-5";
                    QBOX.Text = "已知12-7=5;69-1=68;求1+1=? (A)2平方的0.5(B)2公升(C)無解(D)王";
                    q.quee = "太簡單了!?";
                    gue.Enabled = true;
                    break;
                case 6:
                    label1.Text = "LEVEL-B-1";
                    QBOX.Text = "(23+43)+3000+(15+85+99+101)/33%*55%+25(X)=1，X=？";
                    q.quee = "要有想像力...";
                    gue.Enabled = true;
                    break;
                case 7:
                    label1.Text = "LEVEL-B-2";
                    QBOX.Text = "設X為=59.54685則,2T(BRONU(X+1))=?";
                    q.quee = "在26字中，有些英文字母長的像某些數字呢!";
                    gue.Enabled = true;
                    break;
                case 8:
                    label1.Text = "LEVEL-B-3";
                    QBOX.Text = "甲說我殺了乙／丙說乙死了嗎／甲又說我殺了乙／丁說乙是死了吧／戊說乙死了／甲說我就說我殺了乙／丙說乙是死了嗎你確定／己說你們幹嘛聽這瘋子講的話／甲說我說我殺了乙你這瘋子認清真相／從上對話選出正確項:(A)己是瘋子(B)丙是瘋子(C)甲是瘋子(D)甲丁戊是瘋子";
                    q.quee = "自行加上標點符號會好過一點!";
                    gue.Enabled = true;
                    break;
                case 9:
                    label1.Text = "LEVEL-B-4";
                    QBOX.Text = "世人總認為自己第一。中國人總是死讀書,但都只會讀儒家思想的書。生命充滿了考試,但它們似乎悄悄奪走了你的幸福!人生啊~!人人總是說要[上進],到底要上到啥啊?他們一天到晚都叫你讀書讀書,成績不好就點點點!唉~!你有沒有想過中國人這幾千年來都在幹啥?只會讀書啊!回去告訴長輩!現在是(a=4)[萬般皆下品唯有讀書糟]!所以啊!你真的認為他們說的都對嗎?讓我告訴你!你被洗腦了!一切!崛起吧!不必想太多!做自己!根據上文,做出正確判斷:(A)書上寫a=5,a=5(B)書上寫a=4,a=4(C)書上寫a=4,a=5(D)書上寫a=5,a=3";
                    q.quee = "做自己的主人!題目要看仔細!";
                    gue.Enabled = true;
                    break;
                case 10:
                    label1.Text = "LEVEL-A-1";
                    QBOX.Text = "木之士兵 煮木豆食 不知感恩 忘恩負義 旁兵羞愧 不臉放擺 不是不報 只必天責。已知此為一字，問:此字為何?";
                    q.quee = "";
                    gue.Enabled = false;
                    break;
                case 11:
                    label1.Text = "LEVEL-A-2";
                    QBOX.Text = "X%+AHEH+GJ-NSF+SNF-5DAH＝？";
                    q.quee = "要有想像力...";
                    gue.Enabled = true;
                    break;
                case 12:
                    label1.Text = "LEVEL-A-3";
                    QBOX.Text = "已知y+2=97;y-96=-97;求y。";
                    q.quee = "Y音同於歪。";
                    gue.Enabled = true;
                    break;
                case 13:
                    label1.Text = "LEVEL-S-1";
                    QBOX.Text = "五行顛倒 口吃一丁 未必福禍 天生注定 生離死別 因氏判定。若照詩中做，那麼，此物為何?";
                    q.quee = "要有想像力...";
                    gue.Enabled = true;
                    break;
                case 14:
                    label1.Text = "LEVEL-S-2";
                    QBOX.Text = "X+Y=6,(Visual(C#))+(Visual(C++))=?";
                    q.quee = "司馬懿在空城記中是怎麼敗給諸葛亮的?";
                    gue.Enabled = true;
                    break;
                case 15:
                    label1.Text = "LEVEL-X-1";
                    QBOX.Text = "AX+BC+5+2+CBB*9+ACGH+Z-Z+ZY-BY=?";
                    q.quee = "一切到底接成空...";
                    gue.Enabled = true;
                    break;
                case 16:
                    label1.Text = "LEVEL-X-2";
                    QBOX.Text = "TTNEDNPXO 先生喜歡 GSPLLBRXVKMF 小姐。這位小姐的名字是?";
                    q.quee = "「有什麼」一定要念成「ㄧㄡˇㄕㄣˊㄇㄜ˙」嗎?";
                    gue.Enabled = true;
                    break;
            }
        }
        #endregion
        private void START_Click(object sender, EventArgs e)
        {
            QBOX.Visible = true;
            richTextBox1.Visible = false;
            START.Visible = false;
            gue.Visible = true;
        }

        private void gue_Click(object sender, EventArgs e)
        {
            gue df = new gue();
            df.ShowDialog();
        }
    }
}
