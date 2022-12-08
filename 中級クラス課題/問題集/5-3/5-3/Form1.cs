﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string BrithDayToConstellation(int Month, int Day)
        {
            string YourConstellation = string.Empty;

            if (Month == 1)
            {
                if (Day <= 20)
                {
                    YourConstellation = "やぎ座";
                }
                else
                {
                    YourConstellation = "みずがめ座";
                }
            }
            else if (Month == 2)
            {
                if (Day <= 19)
                {
                    YourConstellation = "みずがめ座";
                }
                else
                {
                    YourConstellation = "うお座";
                }
            }
            else if (Month == 3)
            {
                if (Day <= 20)
                {
                    YourConstellation = "うお座";
                }
                else
                {
                    YourConstellation = "牡羊座";
                }
            }
            else if (Month == 4)
            {
                if (Day <= 21)
                {
                    YourConstellation = "牡羊座";
                }
                else
                {
                    YourConstellation = "おうし座";
                }
            }
            else if (Month == 5)
            {
                if (Day <= 21)
                {
                    YourConstellation = "おうし座";
                }
                else
                {
                    YourConstellation = "ふたご座";
                }
            }
            else if (Month == 6)
            {
                if (Day <= 21)
                {
                    YourConstellation = "ふたご座";
                }
                else
                {
                    YourConstellation = "かに座";
                }
            }
            else if (Month == 7)
            {
                if (Day <= 22)
                {
                    YourConstellation = "かに座";
                }
                else
                {
                    YourConstellation = "しし座";
                }
            }
            else if (Month == 8)
            {
                if (Day <= 21)
                {
                    YourConstellation = "しし座";
                }
                else
                {
                    YourConstellation = "おとめ座";
                }
            }
            else if (Month == 9)
            {
                if (Day <= 22)
                {
                    YourConstellation = "おとめ座";
                }
                else
                {
                    YourConstellation = "てんびん座";
                }
            }
            else if (Month == 10)
            {
                if (Day <= 23)
                {
                    YourConstellation = "さそり座";
                }
                else
                {
                    YourConstellation = "いて座";
                }
            }
            else if (Month == 11)
            {
                if (Day <= 22)
                {
                    YourConstellation = "いて座";
                }
                else
                {
                    YourConstellation = "やぎ座";
                }
            }
            else
            {
                YourConstellation = "やぎ座";
            }

            return YourConstellation;
        }

        private void Display_button_Click(object sender, EventArgs e)
        {
            int Month = 0;
            int Day = 0;
            bool Flag_Name = false;
            bool Flag_BirthDay = false;

            if (this.Name_textBox.Text == string.Empty)
            {
                Flag_Name = false;
                this.Name_textBox.Text = string.Empty;
                MessageBox.Show("名前を入力してください。");
            }
            else
            {
                Flag_Name = true;
            }

            if (!int.TryParse(this.Month_textBox.Text, out Month) || !int.TryParse(this.Day_textBox.Text, out Day))
            {
                Flag_BirthDay = false;
                this.Month_textBox.Text = string.Empty;
                this.Day_textBox.Text = string.Empty;
                MessageBox.Show("正しい生年月日を入力してください。");
            }
            else
            {
                Flag_BirthDay = true;
            }

            if(Flag_Name == true && Flag_BirthDay == true)
            {
                string OutPutConstellation = BrithDayToConstellation(Month, Day);

                MessageBox.Show(this.Name_textBox.Text + "さん、あなたは" + OutPutConstellation + "ですね。");
            }
        }
    }
}
