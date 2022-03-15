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
    public partial class Form4 : Form
    {
        string name = "";
        string a = "0";
        string b = "0";
        string c = "0";

        public Form4()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
           data.Click += data_Click;
            high.Click += high_Click;
        }

        private void high_Click(object sender, EventArgs e)
        {
            int aa = Int32.Parse(a);
            int bb = Int32.Parse(b);
            int cc = Int32.Parse(c);
            bool isNum1 = int.TryParse(textBox2.Text, out aa);
            bool isNum2 = int.TryParse(textBox3.Text, out bb);
            bool isNum3 = int.TryParse(textBox4.Text, out cc);
            if (isNum1 && isNum2 && isNum3)
            {
                if (aa > bb && bb > cc)
                {
                    showHigh.Text = ("最高科目為國文：" + aa + "分" + "\r\n最低科目為數學：" + cc + "分");
                }
                else if (aa > bb && cc > bb && aa > cc)
                {
                    showHigh.Text = ("最高科目為國文：" + aa + "分" + "\r\n最低科目為英文：" + bb + "分");
                }
                else if (bb > aa && aa > cc)
                {
                    showHigh.Text = ("最高科目為英文：" + bb + "分" + "\r\n最低科目為數學：" + cc + "分");
                }
                else if (bb > aa && cc > aa && bb > cc)
                {
                    showHigh.Text = ("最高科目為英文：" + bb + "分" + "\r\n最低科目為國文：" + aa + "分");
                }
                else if (cc > bb && bb > aa)
                {
                    showHigh.Text = ("最高科目為數學：" + cc + "分" + "\r\n最低科目為國文：" + aa + "分");
                }
                else if (cc > bb && aa > bb && cc > aa)
                {
                    showHigh.Text = ("最高科目為數學：" + cc + "分" + "\r\n最低科目為英文：" + bb + "分");
                }
                else if (aa == bb && bb > cc)
                {
                    showHigh.Text = ("最高科目為國文和英文：" + aa + "分" + "\r\n最低科目為數學：" + cc + "分");
                }
                else if (aa == bb && bb < cc)
                {
                    showHigh.Text = ("最高科目為數學：" + cc + "分" + "\r\n最低科目為國文和英文：" + aa + "分");
                }
                else if (aa == cc && cc > bb)
                {
                    showHigh.Text = ("最高科目為國文和數學：" + aa + "分" + "\r\n最低科目為英文：" + bb + "分");
                }
                else if (aa == cc && cc < bb)
                {
                    showHigh.Text = ("最高科目為英文：" + bb + "分" + "\r\n最低科目為國文和數學：" + aa + "分");
                }
                else if (bb == cc && cc > aa)
                {
                    showHigh.Text = ("最高科目為英文和數學：" + bb + "分" + "\r\n最低科目為國文：" + aa + "分");
                }
                else if (bb == cc && cc < aa)
                {
                    showHigh.Text = ("最高科目為國文：" + aa + "分" + "\r\n最低科目為英文和數學：" + bb + "分");
                }
                else
                {
                    showHigh.Text = ("三科一樣分數" + bb + "分");
                }
            }
            else
            {
                showHigh.Text = ("請不要亂打");
            }
        }

        private void data_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            int aa = Int32.Parse(a);
            int bb = Int32.Parse(b);
            int cc = Int32.Parse(c);
            bool isNum1 = int.TryParse(textBox2.Text, out aa);
            bool isNum2 = int.TryParse(textBox3.Text, out bb);
            bool isNum3 = int.TryParse(textBox4.Text, out cc);
            if (isNum1 && isNum2 && isNum3)
            {
                showData.Text = ("姓名：" + name + "\r\n國文：" + aa + "\r\n英文：" + bb + "\r\n數學：" + cc);
                data.Click -= data_Click;
            }
        }

    }
}
