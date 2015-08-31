using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpHomework1
{
    public partial class Homework1 : Form
    {
        //全域變數群
        Button[] buttons = new Button[1000]; //動態按鈕
        int[] ay = new int[1000]; //存亂數值，順便給Restart用
        int[] ay2 = new int[1000]; //備存亂數值
        int[] locationRow = new int[1000];
        int[] locationColumn = new int[1000];
        int ns; //存選擇器內容
        int ns2;//備存選擇器
        Random random = new Random(); //亂數Class
        int i = 0; //給迴圈用
        int score = 0;
        int highestscore = 0;

        public Homework1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Restart.Enabled = false; //Restart初始化為不能點
            MessageBox.Show("歡迎光臨", "我做好久");
            listBox1.Items.Add("Click Button(列,行)with the value of \"Value\"\r\n");
            for (int k = 0; k <= 100; k++) //陣列初始化 沒有這個會錯!!
            {
                ay[k] = 100;
                ay2[k] = 100;
            }
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            //初始化
            panel1.Controls.Clear();
            listBox1.Items.Clear();
            listBox1.Items.Add("Click Button(列,行)with the value of \"Value\"\r\n");
            int count = 0;
            int column = 0;
            int row = 0;
            //雜項
            Slabel.Text = "00"; //Restart分數歸零
            score = 0; //Restart分數歸零
            //
            ns2 = ns; //ns2已被減至0 所以調回來!
            for (int k = 0; k <= 100; k++) //ay[]值調回儲存值
            {
                ay[k] = ay2[k];
            }
            //
            for (i = 0; i < ns; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = ay[i] + ""; //存的亂數值派上用場
                buttons[i].Name = "button" + i; //給每個按鈕名字
                buttons[i].Location = new Point(12 + (column * 40), 12 + (row * 20));
                buttons[i].Size = new Size(40, 20);
                buttons[i].TabIndex = ay[i]; //存的亂數值派上用場
                buttons[i].Click += new EventHandler(buttons_Click);
                column += 1; //往右移動一格~!
                count += 1; //計數器 有幾個按鈕
                this.panel1.Controls.Add(buttons[i]);
                if (count % 10 == 0) //一列有十個就
                {
                    column = 0; //換到第一行
                    row += 1; //跑到下一列
                }
            }
        }
        private void NewGame_Click(object sender, EventArgs e)
        {
            //初始化
            panel1.Controls.Clear();
            listBox1.Items.Clear();
            listBox1.Items.Add("Click Button(列,行)with the value of \"Value\"\r\n");
            int count = 0;
            int column = 0;
            int row = 0;
            //雜項
            Restart.Enabled = true; //點NewGame,Restart才能點
            HSlabel.Text = "00"; //最高分數初始化
            highestscore = 0; //最高分數初始化
            Slabel.Text = "00"; //分數歸零
            score = 0; //分數歸零
            //
            ns = (int)numberselector.Value; //得到選擇器內容並強制轉型
            ns2 = ns; //第一次存ns2
            //
            for (i = 0; i < ns; i++)
            {
                //跟上面比 多的行數
                int onetoten = random.Next(1, 11); //亂數只有1~10
                ay[i] = onetoten; //存亂數值
                ay2[i] = onetoten;
                locationRow[i] = row + 1; //存列行給歷史記錄用
                locationColumn[i] = column + 1; //存列行給歷史記錄用
                //
                buttons[i] = new Button();
                buttons[i].Text = onetoten + "";
                buttons[i].Name = "button" + i; //給每個按鈕名字
                buttons[i].Location = new Point(12 + (column * 40), 12 + (row * 20));
                buttons[i].Size = new Size(40, 20);
                buttons[i].TabIndex = onetoten; //索引值
                buttons[i].Click += new EventHandler(buttons_Click);
                column += 1; //往右移動一格~!
                count += 1; //計數器 有幾個按鈕
                this.panel1.Controls.Add(buttons[i]);
                if (count % 10 == 0) //一列有十個就
                {
                    column = 0; //換到第一行 
                    row += 1; //跑到下一列
                }
            }

        }
        private void buttons_Click(object sender, EventArgs e)
        {
            //歷史紀錄
            Console.WriteLine(((Button)(sender)).Name);
            Console.WriteLine(((Button)(sender)).Text);
            for (int k = 0; k <= 100; k++)
            {
                if ((sender as Button).Name == "button" + k)
                {
                    listBox1.Items.Add("Click Button(" + locationRow[k] + "," + locationColumn[k] + ")with the value of " + ((Button)(sender)).Text + "\r\n");
                }
            }
            //存按鈕的值
            Console.WriteLine(((Button)(sender)).TabIndex);
            int x = ((Button)(sender)).TabIndex;
            //刪除按鈕自己
            Console.WriteLine(((Button)(sender)).Name);
            for (int k = 0; k <= 100; k++)
            {
                if ((sender as Button).Name == "button" + k)
                {
                    panel1.Controls.Remove(buttons[k]);
                    ns2--; //減少直到0
                }
            }
            //刪除值為k-1&k+1的按鈕
            for (int k = 0; k <= 100; k++)
            {
                if (ay[k] == x + 1)
                {
                    panel1.Controls.Remove(buttons[k]);
                    ns2--; //減少直到0
                    ay[k] = 100; //別讓他出來搗亂
                }
            }
            for (int k = 0; k <= 100; k++)
            {
                if (ay[k] == x - 1)
                {
                    panel1.Controls.Remove(buttons[k]);
                    ns2--; //減少直到0
                    ay[k] = 100; //別讓他出來搗亂
                }
            }
            //分數判斷
            score += x;
            Slabel.Text = score + "";
            if (score > highestscore)
            {
                highestscore = score;
                HSlabel.Text = score + "";
            }
            //遊戲結束 得到結果
            if (ns2 == 0)
            {
                MessageBox.Show(score + "/" + highestscore, "Result");
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //離開
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}