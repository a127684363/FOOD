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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            Form1 form =new Form1();
            form.TopLevel =false;
            this.panel3.Controls.Add(form);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            Form2 form = new Form2();
            form.TopLevel = false;
            this.panel3.Controls.Add(form);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            Form3 form = new Form3();
            form.TopLevel = false;
            this.panel3.Controls.Add(form);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            Form4 form = new Form4();
            form.TopLevel = false;
            this.panel3.Controls.Add(form);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            Form5 form = new Form5();
            form.TopLevel = false;
            this.panel3.Controls.Add(form);
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            Form6 form = new Form6();
            form.TopLevel = false;
            this.panel3.Controls.Add(form);
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            Form7 form = new Form7();
            form.TopLevel = false;
            this.panel3.Controls.Add(form);
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            Form8 form = new Form8();
            form.TopLevel = false;
            this.panel3.Controls.Add(form);
            form.Show();
        }
    }
}
