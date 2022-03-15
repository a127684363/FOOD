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
    public partial class Form5 : Form
    {
        bool turn = true;
        int turnCount = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
                    private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn =!turn;
            b.Enabled = false;
            turnCount ++;
            Winner();
        }
        private void Winner()
        {
            bool win = false;
            //平線
            if( (button1.Text == button2.Text)
                && (button2.Text == button3.Text)
                &&(!button1.Enabled))
            {
                win = true;
            }
           else if ((button4.Text == button5.Text)
                && (button5.Text == button6.Text)
                && (!button4.Enabled))
            {
                win = true;
            }
           else if ((button7.Text == button8.Text)
                && (button8.Text == button9.Text) 
                && (!button7.Enabled))
            {
                win = true;
            }

            //直線
            if ((button1.Text == button4.Text) 
                && (button4.Text == button7.Text) 
                && (!button1.Enabled))
            {
                win = true;
            }
            else if ((button2.Text == button5.Text) 
                && (button5.Text == button8.Text) 
                && (!button2.Enabled))
            {
                win = true;
            }
            else if ((button3.Text == button6.Text) 
                && (button6.Text == button9.Text) 
                && (!button3.Enabled))
            {
                win = true;
            }

            //斜線
            if ((button1.Text == button5.Text)
                && (button5.Text == button9.Text)
                && (!button1.Enabled))
            {
                win = true;
            }
            else if ((button3.Text == button5.Text)
                && (button5.Text == button7.Text)
                && (!button3.Enabled))
            {
                win = true;
            }
            if (win)
            {
                String winwin = "";
                if (turn)
                {
                    winwin = "O";
                }
                else
                {
                    winwin = "X";
                }
                MessageBox.Show(winwin + "手獲勝！", "完局");
                restGame();
            }
            else
            {
                if(turnCount == 9)
                {
                    MessageBox.Show("平手！");
                    turn = true;
                    turnCount = 0;

                    foreach (Control c in Controls)
                    {
                        Button b = (Button)c;
                        b.Enabled = true;
                    }
                    button1.Text = ""; button2.Text = ""; button3.Text = ""; 
                    button4.Text = ""; button5.Text = ""; button6.Text = ""; 
                    button7.Text = ""; button8.Text = ""; button9.Text = "";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            restGame();
        }
        void restGame()
        {
            turn = true;
            turnCount = 0;

            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = true;
            }
            button1.Text = ""; button2.Text = ""; button3.Text = "";
            button4.Text = ""; button5.Text = ""; button6.Text = "";
            button7.Text = ""; button8.Text = ""; button9.Text = "";
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            switch (e.KeyCode)
            {
                case Keys.R:
                    restGame();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }
    }
    }

