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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            Form6_1 pop = new Form6_1();
            pop.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form6_2 pop = new Form6_2();
            pop.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form6_3 pop = new Form6_3();
            pop.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6_4 pop = new Form6_4();
            pop.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6_5 pop = new Form6_5();
            pop.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form6_6 pop = new Form6_6();
            pop.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form6_7 pop = new Form6_7();
            pop.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
