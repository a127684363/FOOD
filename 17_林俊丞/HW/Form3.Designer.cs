
namespace HW
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.wine = new System.Windows.Forms.Button();
            this.whisky = new System.Windows.Forms.Button();
            this.tequila = new System.Windows.Forms.Button();
            this.beer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.card = new System.Windows.Forms.Button();
            this.cash = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.del = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.wine);
            this.panel1.Controls.Add(this.whisky);
            this.panel1.Controls.Add(this.tequila);
            this.panel1.Controls.Add(this.beer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 295);
            this.panel1.TabIndex = 0;
            // 
            // wine
            // 
            this.wine.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.wine.Image = ((System.Drawing.Image)(resources.GetObject("wine.Image")));
            this.wine.Location = new System.Drawing.Point(134, 155);
            this.wine.Name = "wine";
            this.wine.Size = new System.Drawing.Size(98, 111);
            this.wine.TabIndex = 4;
            this.wine.Text = "紅酒\r\nWine\r\nNT$320";
            this.wine.UseVisualStyleBackColor = true;
            this.wine.Click += new System.EventHandler(this.wine_Click);
            // 
            // whisky
            // 
            this.whisky.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.whisky.Image = ((System.Drawing.Image)(resources.GetObject("whisky.Image")));
            this.whisky.Location = new System.Drawing.Point(11, 155);
            this.whisky.Name = "whisky";
            this.whisky.Size = new System.Drawing.Size(98, 111);
            this.whisky.TabIndex = 3;
            this.whisky.Text = "威士忌\r\nWhisky\r\nNT$350";
            this.whisky.UseVisualStyleBackColor = true;
            this.whisky.Click += new System.EventHandler(this.whisky_Click);
            // 
            // tequila
            // 
            this.tequila.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tequila.Image = ((System.Drawing.Image)(resources.GetObject("tequila.Image")));
            this.tequila.Location = new System.Drawing.Point(134, 38);
            this.tequila.Name = "tequila";
            this.tequila.Size = new System.Drawing.Size(98, 111);
            this.tequila.TabIndex = 2;
            this.tequila.Text = "龍舌蘭\r\nTequila\r\nNT$180";
            this.tequila.UseVisualStyleBackColor = true;
            this.tequila.Click += new System.EventHandler(this.tequila_Click);
            // 
            // beer
            // 
            this.beer.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.beer.ForeColor = System.Drawing.Color.Black;
            this.beer.Image = ((System.Drawing.Image)(resources.GetObject("beer.Image")));
            this.beer.Location = new System.Drawing.Point(11, 38);
            this.beer.Name = "beer";
            this.beer.Size = new System.Drawing.Size(98, 111);
            this.beer.TabIndex = 1;
            this.beer.Text = "啤酒\r\nBeer\r\nNT$120";
            this.beer.UseVisualStyleBackColor = true;
            this.beer.Click += new System.EventHandler(this.beer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜單MENU";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(291, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 107);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(-1, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(216, 107);
            this.panel6.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(10, 62);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 40);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "NT$0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 31);
            this.label12.TabIndex = 5;
            this.label12.Text = "總金額 total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(96, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 31);
            this.label10.TabIndex = 9;
            this.label10.Text = "菜單MENU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(4, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "菜單MENU";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.card);
            this.panel3.Controls.Add(this.cash);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(291, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 155);
            this.panel3.TabIndex = 1;
            // 
            // card
            // 
            this.card.Location = new System.Drawing.Point(106, 50);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(91, 49);
            this.card.TabIndex = 8;
            this.card.Text = "信用卡";
            this.card.UseVisualStyleBackColor = true;
            this.card.Click += new System.EventHandler(this.card_Click);
            // 
            // cash
            // 
            this.cash.Location = new System.Drawing.Point(9, 50);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(91, 49);
            this.cash.TabIndex = 7;
            this.cash.Text = "現金";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.Click += new System.EventHandler(this.cash_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "付款方式";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(79, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(132, 36);
            this.panel5.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(12, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 31);
            this.label9.TabIndex = 8;
            this.label9.Text = "信用卡九折";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.del);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(529, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 295);
            this.panel4.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(21, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 173);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "尚未點餐";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(163, 237);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(91, 49);
            this.del.TabIndex = 9;
            this.del.Text = "清除清單";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 31);
            this.label11.TabIndex = 9;
            this.label11.Text = "購物清單list";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Pos";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button wine;
        private System.Windows.Forms.Button whisky;
        private System.Windows.Forms.Button tequila;
        private System.Windows.Forms.Button beer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button card;
        private System.Windows.Forms.Button cash;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}