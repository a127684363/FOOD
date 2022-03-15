
namespace HW
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.tbt1 = new System.Windows.Forms.TextBox();
            this.tbt2 = new System.Windows.Forms.TextBox();
            this.tbt3 = new System.Windows.Forms.TextBox();
            this.tbt4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "頭期款";
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt1.Location = new System.Drawing.Point(18, 306);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(180, 83);
            this.bt1.TabIndex = 4;
            this.bt1.Text = "PMT(月付款)";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt2.Location = new System.Drawing.Point(292, 306);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(180, 83);
            this.bt2.TabIndex = 5;
            this.bt2.Text = "總付款";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt3.Location = new System.Drawing.Point(568, 306);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(180, 83);
            this.bt3.TabIndex = 6;
            this.bt3.Text = "REPORT";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // tbt1
            // 
            this.tbt1.Location = new System.Drawing.Point(116, 9);
            this.tbt1.Name = "tbt1";
            this.tbt1.Size = new System.Drawing.Size(182, 22);
            this.tbt1.TabIndex = 7;
            // 
            // tbt2
            // 
            this.tbt2.Location = new System.Drawing.Point(116, 73);
            this.tbt2.Name = "tbt2";
            this.tbt2.Size = new System.Drawing.Size(182, 22);
            this.tbt2.TabIndex = 8;
            // 
            // tbt3
            // 
            this.tbt3.Location = new System.Drawing.Point(116, 139);
            this.tbt3.Name = "tbt3";
            this.tbt3.Size = new System.Drawing.Size(182, 22);
            this.tbt3.TabIndex = 9;
            // 
            // tbt4
            // 
            this.tbt4.Location = new System.Drawing.Point(116, 208);
            this.tbt4.Name = "tbt4";
            this.tbt4.Size = new System.Drawing.Size(182, 22);
            this.tbt4.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbt4);
            this.Controls.Add(this.tbt3);
            this.Controls.Add(this.tbt2);
            this.Controls.Add(this.tbt1);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.TextBox tbt1;
        private System.Windows.Forms.TextBox tbt2;
        private System.Windows.Forms.TextBox tbt3;
        private System.Windows.Forms.TextBox tbt4;
    }
}