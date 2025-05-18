namespace PROJEE2
{
    partial class Form4
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
            this.yorumtxt = new System.Windows.Forms.TextBox();
            this.gonderbt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kullaniciaditxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yorumunuz";
            // 
            // yorumtxt
            // 
            this.yorumtxt.Location = new System.Drawing.Point(120, 47);
            this.yorumtxt.Name = "yorumtxt";
            this.yorumtxt.Size = new System.Drawing.Size(300, 20);
            this.yorumtxt.TabIndex = 1;
            this.yorumtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gonderbt
            // 
            this.gonderbt.Location = new System.Drawing.Point(426, 45);
            this.gonderbt.Name = "gonderbt";
            this.gonderbt.Size = new System.Drawing.Size(75, 23);
            this.gonderbt.TabIndex = 2;
            this.gonderbt.Text = "Gönder";
            this.gonderbt.UseVisualStyleBackColor = true;
            this.gonderbt.Click += new System.EventHandler(this.gonderbt_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(120, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 134);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // kullaniciaditxt
            // 
            this.kullaniciaditxt.Location = new System.Drawing.Point(120, 13);
            this.kullaniciaditxt.Name = "kullaniciaditxt";
            this.kullaniciaditxt.Size = new System.Drawing.Size(162, 20);
            this.kullaniciaditxt.TabIndex = 5;
            this.kullaniciaditxt.TextChanged += new System.EventHandler(this.kullaniciaditxt_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEE2.Properties.Resources.a9cb00fa5dd90d70878ac7b78effb2e2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 321);
            this.Controls.Add(this.kullaniciaditxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gonderbt);
            this.Controls.Add(this.yorumtxt);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yorum";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yorumtxt;
        private System.Windows.Forms.Button gonderbt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullaniciaditxt;
    }
}