using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void bt1_Click(object sender, EventArgs e)
        {
            double money = 0;
            double year = 0;
            double per = 0;
            double head = 0;
            bool isNum1 = double.TryParse(tbt1.Text, out money);
            bool isNum2 = double.TryParse(tbt2.Text, out year);
            bool isNum3 = double.TryParse(tbt3.Text, out per);
            bool isNum4 = double.TryParse(tbt4.Text, out head);
            if (isNum1 && isNum2 && isNum3 && isNum4)
            {
                money = double.Parse(tbt1.Text);
                 year = double.Parse(tbt2.Text) * 12;
                 per = double.Parse(tbt3.Text) / 100 / 12;
                 head = double.Parse(tbt4.Text);


                double Mloan = (Math.Pow((1 + per), year) * per) / (Math.Pow((1 + per), year) - 1);
                double PMT = (money - head) * Mloan;
                PMT = Math.Round(PMT);
                MessageBox.Show("月付款:" + PMT + "元");
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        public void bt2_Click(object sender, EventArgs e)
        {
            double money = 0;
            double year = 0;
            double per = 0;
            double head = 0;
            bool isNum1 = double.TryParse(tbt1.Text, out money);
            bool isNum2 = double.TryParse(tbt2.Text, out year);
            bool isNum3 = double.TryParse(tbt3.Text, out per);
            bool isNum4 = double.TryParse(tbt4.Text, out head);
            if (isNum1 && isNum2 && isNum3 && isNum4)
            {
                 money = double.Parse(tbt1.Text);
                year = double.Parse(tbt2.Text) * 12;
                per = double.Parse(tbt3.Text) / 100 / 12;
                head = double.Parse(tbt4.Text);


                double Mloan = (Math.Pow((1 + per), year) * per) / (Math.Pow((1 + per), year) - 1);
                double PMT = (money - head) * Mloan;
                PMT = Math.Round(PMT);
                double total = PMT * 12;
                MessageBox.Show("總付款:" + total + "元");
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }

        }
        
        public void bt3_Click(object sender, EventArgs e)
        {
            Form2a report = new Form2a();
            
            {
                double money = 0;
                double year = 0;
                double per = 0;
                double head = 0;
                bool isNum1 = double.TryParse(tbt1.Text, out money);
                bool isNum2 = double.TryParse(tbt2.Text, out year);
                bool isNum3 = double.TryParse(tbt3.Text, out per);
                bool isNum4 = double.TryParse(tbt4.Text, out head);
                if (isNum1 && isNum2 && isNum3 && isNum4)
                {
                    money = double.Parse(tbt1.Text);
                    year = double.Parse(tbt2.Text) * 12;
                    per = double.Parse(tbt3.Text) / 100 / 12;
                    head = double.Parse(tbt4.Text);


                    double Mloan = (Math.Pow((1 + per), year) * per) / (Math.Pow((1 + per), year) - 1);
                    double PMT = (money - head) * Mloan;
                    PMT = Math.Round(PMT);
                    double total = PMT * 12;


                    report.label6.Text = this.tbt1.Text;
                    report.label7.Text = this.tbt2.Text;
                    report.label8.Text = this.tbt3.Text;
                    report.label9.Text = PMT.ToString();
                    report.label10.Text = total.ToString();
                    report.Show();
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                }
            }
          }
    }
}


