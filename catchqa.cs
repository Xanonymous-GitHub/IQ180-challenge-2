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
    public partial class catchqa : Form
    {
        public catchqa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string te = textBox1.Text;
            if (te.Trim() == "DWEUIKIGBTHFVEULOYHESCLPOMBERXHJOI")
            {
                #region 題庫的Build
                
                    string[] texxq = new string[34];
                    string[] texxa = new string[34];
                    int i = 0;
                    texxq[i] = "魚缸裡有9條金魚，走近一看死了兩條，這時魚缸裡還有幾條金魚?";
                    texxa[i] = "9條。";
                    i += 1;
                    texxq[i] = "王爺爺共有三個兒子都結婚了，王爺爺還有幾個兒子？";
                    texxa[i] = "3個（結婚的兒子還是他的兒子）。";
                    i += 1;
                    texxq[i] = "屋內亮著7盞燈，關掉3盞，屋裡還有幾盞燈？";
                    texxa[i] = "7盞（關掉的燈還是燈）。";
                    i += 1;
                    texxq[i] = "父子倆對手下棋，每人都下了五盤，他們共下了幾盤棋？";
                    texxa[i] = "5盤。";
                    i += 1;
                    texxq[i] = "一面五星紅旗上有兩種顏色（紅、黃），10面五星紅旗上共有多少種顏色？";
                    texxa[i] = "紅黃兩種顏色。";
                    i += 1;
                    texxq[i] = "《趣味數學》這本書叫什麼名字？";
                    texxa[i] = "叫《趣味數學》。";
                    i += 1;
                    texxq[i] = "一個人唱完《學雷鋒》這支歌用2分鐘，3個人唱完《學雷鋒》這支歌最少用幾分鐘？";
                    texxa[i] = "2分鐘，合唱。";
                    i += 1;
                    texxq[i] = "媽媽煮熟一個雞蛋要用8分鐘，煮熟三個雞蛋最少要用幾分鐘？";
                    texxa[i] = "8分鐘，一起煮。";
                    i += 1;
                    texxq[i] = "劃著一根火柴用1秒鐘，劃著4根火柴最少用幾秒鐘？";
                    texxa[i] = "1秒种，一起劃。";
                    i += 1;
                    texxq[i] = "3個人合下了3小時跳棋，每人下了幾小時？";
                    texxa[i] = "3小時（因為三個人合下）。";
                    i += 1;
                    texxq[i] = "三匹馬拉著一台大車向前跑了6米，每匹馬向前跑了多少米？";
                    texxa[i] = "6米。";
                    i += 1;
                    texxq[i] = "一位老師到學生家去家訪，看到媽媽面前有3個女孩，便問：“你只有這三個女兒嗎？”媽媽說：“何止這3個，她們每人都有一個哥哥。”請問這家共有幾個孩子？";
                    texxa[i] = "4個，1個大的是哥哥，3個小的是他妹妹。";
                    i += 1;
                    texxq[i] = "樹上落了3隻鳥，獵人開槍打下一隻，樹上還有幾隻？";
                    texxa[i] = "0只，因為另兩隻鳥聽到槍聲嚇跑了。";
                    i += 1;
                    texxq[i] = "沙灘上落了3隻鳥，獵人開槍打死一隻，沙灘上還有幾隻鳥？";
                    texxa[i] = "1只，“死的”。";
                    i += 1;
                    texxq[i] = "平放的桌面上落了3只蒼蠅，有人打死了一隻，桌面上還有幾隻？";
                    texxa[i] = "1只，“死的”。";
                    i += 1;
                    texxq[i] = "河面上落了3只水鳥，獵人開槍打死一隻，此刻河面上活著的還有幾隻？";
                    texxa[i] = "0只，“一死二飛”";
                    i += 1;
                    texxq[i] = "小明在環形跑道上練習跑步，他前邊有3個人，後邊也有3個人，算一算，正在練習跑步的有多少人？";
                    texxa[i] = "3＋1=4，4人";
                    i += 1;
                    texxq[i] = "小明家有4個哥哥和4個弟弟，但並不是9個兄弟。他家到底有兄弟多少人？";
                    texxa[i] = "5人，注：此題與“小明有4個哥哥和4個弟弟，他家有兄弟多少人？”問法不同。";
                    i += 1;
                    texxq[i] = "1＋1在什麼時候不等於2？";
                    texxa[i] = "一種情況，在算錯的時候不等於2；另一種情況，在“二進位”中“1＋1=10”。";
                    i += 1;
                    texxq[i] = "昨天是八號，明天該是幾號？";
                    texxa[i] = "10號。";
                    i += 1;
                    texxq[i] = "昨天是星期六，明天是星期幾？";
                    texxa[i] = "星期一。";
                    i += 1;
                    texxq[i] = "昨天的明天是哪天？";
                    texxa[i] = "今天。";
                    i += 1;
                    texxq[i] = "一個星期有（ ）天，每天有（ ）小時。";
                    texxa[i] = "7，24。";
                    i += 1;
                    texxq[i] = "像個蛋，不是蛋，說它圓，它不圓，說它沒有它也有，成千上萬連成串。（猜一個數字）";
                    texxa[i] = "謎底：0。";
                    i += 1;
                    texxq[i] = "小明家裡養了雞，一隻鴨子混到隊裡，正著數它是第七，倒著數它是第三。請你算一算，小明家養了幾隻雞？（雞鴨排成一排）";
                    texxa[i] = "7＋3-2＝8（只），養了8隻雞。";
                    i += 1;
                    texxq[i] = "媽媽買來一塊布，剪成兩段，長的一段是6尺，長短相差是2尺。請你幫助算一算，媽媽買了幾尺布？";
                    texxa[i] = "6-（？）＝2，？=4，6+4=10（尺），買了10尺布。";
                    i += 1;
                    texxq[i] = "大公雞、小母雞，合起來共4只，想一想，算一算，公雞、母雞各幾隻？";
                    texxa[i] = "因為公雞、母雞總數為4，公雞、母雞數都不為0，所以答案是1和3或2和2或3和1三種情況。";
                    i += 1;
                    texxq[i] = "你有9支鉛筆，我有3支鉛筆，你給我幾支咱倆就一樣多？";
                    texxa[i] = "9-3=6，6=3＋3，你給我3支咱倆就一樣多。";
                    i += 1;
                    texxq[i] = "一根繩子長15尺，剪去8尺，剪去的比剩下的多幾尺？";
                    texxa[i] = "15-8=7（尺），8-7＝1（尺），多1尺。";
                    i += 1;
                    texxq[i] = "一根繩子對折，再對折是4尺長，這根繩子放開再放開是幾尺長（原來有多長）？";
                    texxa[i] = "4＋4=8（尺），8＋8=16（尺），原來有16尺長";
                    i += 1;
                    texxq[i] = "小朋友出門口，前後排成一隊走，一人走在兩人前，一人走在兩人後，一人走在兩人中間，問共有幾個小朋友？";
                    texxa[i] = "3個。";
                    i += 1;
                    texxq[i] = "有兩個數，它們的和與差相等，這兩個數各是多少？";
                    texxa[i] = "1＋0=1-0，2＋0=2-0，3＋0=3-0，…（答案無窮多種）。";
                    i += 1;
                    texxq[i] = "下面哪些數在鏡子裡看和原來大小是一樣的?（1）0，1，2，3，4，5，6，7，8，9，10；";
                    texxa[i] = "(1）0，1，8。";
                    i += 1;
                    texxq[i] = "從鏡子裡看鬧鐘，時間是早上五點半，實際上是早上幾點半？";
                    texxa[i] = "6點半";
                
                #endregion
                FileStream fq = new FileStream(@"C:\Program Files\iq180_2settings\DefauleIQ1802question.dll", FileMode.Create);
                FileStream fa = new FileStream(@"C:\Program Files\iq180_2settings\DefauleIQ1802ANSs.dll", FileMode.Create);
                StreamWriter swq = new StreamWriter(fq,Encoding.Default);
                StreamWriter swa = new StreamWriter(fa,Encoding.Default);
                for (int ii = 0; ii < 34; ii++)
                {
                    swq.WriteLine(texxq[ii]);
                    swa.WriteLine(texxa[ii]);
                }
                swq.Close();
                swa.Close();
                fq.Close();
                fa.Close();
                MessageBox.Show("您已經取得題庫!", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else { MessageBox.Show("輸入的認證碼不正確!","錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 34)
            {
                button1.Enabled = true;
            }
            else { button1.Enabled = false; }
        }
    }
}
