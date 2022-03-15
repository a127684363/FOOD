
namespace HW
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbt1 = new System.Windows.Forms.TextBox();
            this.tbt2 = new System.Windows.Forms.TextBox();
            this.tbt3 = new System.Windows.Forms.TextBox();
            this.tbt4 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "English Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "性別:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "星座:";
            // 
            // tbt1
            // 
            this.tbt1.Location = new System.Drawing.Point(208, 43);
            this.tbt1.Name = "tbt1";
            this.tbt1.Size = new System.Drawing.Size(100, 22);
            this.tbt1.TabIndex = 4;
            // 
            // tbt2
            // 
            this.tbt2.Location = new System.Drawing.Point(208, 97);
            this.tbt2.Name = "tbt2";
            this.tbt2.Size = new System.Drawing.Size(100, 22);
            this.tbt2.TabIndex = 5;
            // 
            // tbt3
            // 
            this.tbt3.Location = new System.Drawing.Point(208, 151);
            this.tbt3.Name = "tbt3";
            this.tbt3.Size = new System.Drawing.Size(100, 22);
            this.tbt3.TabIndex = 6;
            // 
            // tbt4
            // 
            this.tbt4.Location = new System.Drawing.Point(208, 206);
            this.tbt4.Name = "tbt4";
            this.tbt4.Size = new System.Drawing.Size(100, 22);
            this.tbt4.TabIndex = 7;
            // 
            // bt1
            // 
            this.bt1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt1.BackgroundImage")));
            this.bt1.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt1.Location = new System.Drawing.Point(12, 260);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(149, 64);
            this.bt1.TabIndex = 8;
            this.bt1.Text = "Say Hello!";
            this.bt1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt2.BackgroundImage")));
            this.bt2.Font = new System.Drawing.Font("Noto Sans CJK TC Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt2.Location = new System.Drawing.Point(208, 260);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(149, 64);
            this.bt2.TabIndex = 9;
            this.bt2.Text = "Say Hi!";
            this.bt2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tbt4);
            this.Controls.Add(this.tbt3);
            this.Controls.Add(this.tbt2);
            this.Controls.Add(this.tbt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "你好C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbt1;
        private System.Windows.Forms.TextBox tbt2;
        private System.Windows.Forms.TextBox tbt3;
        private System.Windows.Forms.TextBox tbt4;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
    }
}

