using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberpuzzle
{
    public partial class Form1 : Form
    {
        int Counter;

        public Form1()
        {
            InitializeComponent();

        }

        private void EmptyButtonChecker(Button b1, Button b2)
        {
            if (b2.Text == "")
            {
                b2.Text = b1.Text;
                b1.Text = "";

            }
        }

        private void Checker()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" &&
               button4.Text == "4" && button5.Text == "5" && button6.Text == "6" &&
               button8.Text == "7" && button7.Text == "8")
            {
                MessageBox.Show("게임에서 승리하셨습니다!", "숫자 퍼즐 게임",
                    MessageBoxButtons.OK);


            }
            Counter = Counter + 1;
            lb_ct.Text = "움직임 횟수: " + Counter;
            

        }

        public void Mix()
        {
            int[] bnum = new int[9];
            int i, j, row;
            bool flag = false;

            i = 1;
            do
            {
                Random r = new Random();
                row = Convert.ToInt32((r.Next(0, 8)) + 1);

                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == row)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    bnum[i] = row;
                    i = i + 1;
                }
            }
            while (i <= 8);

            button1.Text = bnum[1].ToString();
            button2.Text = bnum[2].ToString();
            button3.Text = bnum[3].ToString();
            button4.Text = bnum[4].ToString();
            button5.Text = bnum[5].ToString();
            button6.Text = bnum[6].ToString();
            button7.Text = "";
            button8.Text = bnum[8].ToString();
            button9.Text = bnum[7].ToString();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mix();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmptyButtonChecker(button1, button2);
            EmptyButtonChecker(button1, button4);
            Checker();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmptyButtonChecker(button2, button1);
            EmptyButtonChecker(button2, button3);
            EmptyButtonChecker(button2, button5);
            Checker();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmptyButtonChecker(button3, button2);
            EmptyButtonChecker(button3, button6);
           Checker();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmptyButtonChecker(button4, button1);
            EmptyButtonChecker(button4, button5);
            EmptyButtonChecker(button4, button7);
            Checker();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmptyButtonChecker(button5, button2);
            EmptyButtonChecker(button5, button4);
            EmptyButtonChecker(button5, button6);
            EmptyButtonChecker(button5, button8);
            Checker();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EmptyButtonChecker(button6, button3);
            EmptyButtonChecker(button6, button5);
            EmptyButtonChecker(button6, button9);
            Checker();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmptyButtonChecker(button7, button4);
            EmptyButtonChecker(button7, button8);
            Checker();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmptyButtonChecker(button8, button5);
            EmptyButtonChecker(button8, button7);
            EmptyButtonChecker(button8, button9);
            Checker();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EmptyButtonChecker(button9, button6);
            EmptyButtonChecker(button9, button8);
            Checker();
        }

        private void btn_sf_Click(object sender, EventArgs e)
        {
            Mix();

            Counter = 0;
            lb_ct.Text = "움직임 횟수: " + Counter;
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
       
}
