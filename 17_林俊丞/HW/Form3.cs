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
    public partial class Form3 : Form
    {
        static double total = 0;
        string com = "";
        string dom = "";
        string eom = "";
        string fom = "";
        int drink1 = 120, drink2 = 180, drink3 = 350, drink4 = 320;
         static int aa = 0;
        static int bb = 0;
        static int cc = 0;
        static int dd = 0;
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;


        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cash_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "NT$0")
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額:NT$"+total, "確認付款",MessageBoxButtons.YesNo);
            }
        }

        private void whisky_Click(object sender, EventArgs e)
        {
            total = total + drink3;
            textBox2.Text = total.ToString();
            c += 1;
            cc += drink3;
            eom = "威士忌" + c + "瓶" + cc;
            if (d == 0 && b == 0 && a == 0)
            {
                textBox1.Text =eom;
            }
            else if (d == 0 && b != 0 && a != 0)
            {
                textBox1.Text = com + Environment.NewLine + dom + Environment.NewLine + eom;
            }
            else if (d != 0 && b == 0 && a != 0)
            {
                textBox1.Text = com+ Environment.NewLine + eom + Environment.NewLine + fom;
            }
            else if (d != 0 && b != 0 && a == 0)
            {
                textBox1.Text =dom + Environment.NewLine + eom + Environment.NewLine + fom;
            }
            else if (d == 0 && b == 0 && a != 0)
            {
                textBox1.Text = com+ Environment.NewLine + eom;
            }
            else if (d == 0 && b != 0 && a == 0)
            {
                textBox1.Text =dom + Environment.NewLine + eom;
            }
            else if (d != 0 && b == 0 && a == 0)
            {
                textBox1.Text =eom + Environment.NewLine + fom;
            }
            else
            {
                textBox1.Text = com + Environment.NewLine + dom + Environment.NewLine + eom + Environment.NewLine + fom;
            }
        }

        private void wine_Click(object sender, EventArgs e)
        {
            total = total + drink4;
            textBox2.Text = total.ToString();
            d += 1;
            dd += drink4;
            fom = "紅酒" + d + "瓶" + dd;
            if (a == 0 && b == 0&&c==0)
            {
                textBox1.Text = fom;
            }
            else if (a == 0 && b != 0 && c != 0)
            {
                textBox1.Text = dom + Environment.NewLine + eom + Environment.NewLine + fom;
            }
            else if (a != 0 && b == 0 && c != 0)
            {
                textBox1.Text = com + Environment.NewLine + eom + Environment.NewLine + fom;
            }
            else if (a != 0 && b != 0 && c == 0)
            {
                textBox1.Text = com + Environment.NewLine + dom + Environment.NewLine + fom;
            }
            else if (a == 0 && b == 0 && c != 0)
            {
                textBox1.Text = eom + Environment.NewLine + fom;
            }
            else if (a == 0 && b != 0 && c == 0)
            {
                textBox1.Text = dom + Environment.NewLine + fom;
            }
            else if (a != 0 && b == 0 && c == 0)
            {
                textBox1.Text = com + Environment.NewLine + fom;
            }
            else
            {
                textBox1.Text = com + Environment.NewLine + dom + Environment.NewLine + eom + Environment.NewLine + fom;
            }
        }

        private void card_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "NT$0")
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額:NT$" + total+"\r\n折扣後金額:" + total*0.9, "確認付款", MessageBoxButtons.YesNo);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {
            textBox1.Text = "尚未點餐";
            textBox2.Text = "NT$0";
            total = 0;
            aa = 0;
            bb = 0;
            cc = 0;
            dd = 0;
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            com = "";
            dom = "";
            eom = "";
            fom = "";
        }

       
        
        private void beer_Click(object sender, EventArgs e)
        {
            
            total = total + drink1;
            textBox2.Text = total.ToString();
            a += 1;
            aa += drink1;
            com = "啤酒"+a+"瓶" + aa;
            if (d == 0 && b == 0 && c == 0)
            {
                textBox1.Text = com;
            }
            else if (d == 0 && b != 0 && c != 0)
            {
                textBox1.Text = com + Environment.NewLine + dom + Environment.NewLine + eom;
            }
            else if (d != 0 && b == 0 && c != 0)
            {
                textBox1.Text = com+ Environment.NewLine + eom + Environment.NewLine + fom;
            }
            else if (d != 0 && b != 0 && c == 0)
            {
                textBox1.Text = com + Environment.NewLine + dom+ Environment.NewLine + fom;
            }
            else if (d == 0 && b == 0 && c != 0)
            {
                textBox1.Text = com+ Environment.NewLine + eom;
            }
            else if (d == 0 && b != 0 && c == 0)
            {
                textBox1.Text = com + Environment.NewLine + dom;
            }
            else if (d != 0 && b == 0 && c == 0)
            {
                textBox1.Text = com+ Environment.NewLine + fom;
            }
            else
            {
                textBox1.Text = com + Environment.NewLine + dom + Environment.NewLine + eom + Environment.NewLine + fom;
            }
        }

        private void tequila_Click(object sender, EventArgs e)
        {
            total = total + drink2;
            textBox2.Text = total.ToString();
            b += 1;
            bb += drink2;
            dom = "龍舌蘭" + b + "瓶" +bb;
            if (d == 0 && a == 0 && c == 0)
            {
                textBox1.Text = dom;
            }
            else if (d == 0 && a != 0 && c != 0)
            {
                textBox1.Text = com + Environment.NewLine + dom + Environment.NewLine + eom;
            }
            else if (d != 0 && a == 0 && c != 0)
            {
                textBox1.Text =dom + Environment.NewLine + eom + Environment.NewLine + fom;
            }
            else if (d != 0 && a != 0 && c == 0)
            {
                textBox1.Text = com + Environment.NewLine + dom + Environment.NewLine + fom;
            }
            else if (d == 0 && a == 0 && c != 0)
            {
                textBox1.Text =dom + Environment.NewLine + eom;
            }
            else if (d == 0 && a != 0 && c == 0)
            {
                textBox1.Text = com + Environment.NewLine + dom;
            }
            else if (d != 0 && a == 0 && c == 0)
            {
                textBox1.Text =dom+ Environment.NewLine + fom;
            }
            else
            {
                textBox1.Text = com + Environment.NewLine + dom + Environment.NewLine + eom + Environment.NewLine + fom;
            }
        }
    }
}
