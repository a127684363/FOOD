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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
           string a = tbt1.Text;
           string b = tbt2.Text;
           string c = tbt3.Text;
           string d = tbt4.Text;
            MessageBox.Show("Hello 我是" + a + "\n英文名字是" + b + "\n性別是" + c + "\n星座是" + d + "\n很高興認識你。");
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            string a = tbt1.Text;
            string b = tbt2.Text;
            string c = tbt3.Text;
            string d = tbt4.Text;
            MessageBox.Show("Hi 我是" + a + "\n英文名字是" + b + "\n性別是" + c + "\n星座是" + d + "\n很高興認識你。");
        }
    }
}
