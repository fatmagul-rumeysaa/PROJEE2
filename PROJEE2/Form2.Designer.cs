namespace PROJEE2
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
            this.epostatxt = new System.Windows.Forms.TextBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.kullaniciaditxt = new System.Windows.Forms.TextBox();
            this.telefonnotxt = new System.Windows.Forms.TextBox();
            this.kayitbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon Numarası";
            // 
            // epostatxt
            // 
            this.epostatxt.Location = new System.Drawing.Point(110, 30);
            this.epostatxt.Name = "epostatxt";
            this.epostatxt.Size = new System.Drawing.Size(100, 20);
            this.epostatxt.TabIndex = 4;
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(110, 62);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(100, 20);
            this.sifretxt.TabIndex = 5;
            // 
            // kullaniciaditxt
            // 
            this.kullaniciaditxt.Location = new System.Drawing.Point(110, 97);
            this.kullaniciaditxt.Name = "kullaniciaditxt";
            this.kullaniciaditxt.Size = new System.Drawing.Size(100, 20);
            this.kullaniciaditxt.TabIndex = 6;
            this.kullaniciaditxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // telefonnotxt
            // 
            this.telefonnotxt.Location = new System.Drawing.Point(110, 131);
            this.telefonnotxt.Name = "telefonnotxt";
            this.telefonnotxt.Size = new System.Drawing.Size(100, 20);
            this.telefonnotxt.TabIndex = 7;
            // 
            // kayitbt
            // 
            this.kayitbt.Location = new System.Drawing.Point(121, 180);
            this.kayitbt.Name = "kayitbt";
            this.kayitbt.Size = new System.Drawing.Size(75, 23);
            this.kayitbt.TabIndex = 8;
            this.kayitbt.Text = "Kayıt Ol";
            this.kayitbt.UseVisualStyleBackColor = true;
            this.kayitbt.Click += new System.EventHandler(this.kayitbt_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEE2.Properties.Resources._394205;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 256);
            this.Controls.Add(this.kayitbt);
            this.Controls.Add(this.telefonnotxt);
            this.Controls.Add(this.kullaniciaditxt);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.epostatxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Formu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox epostatxt;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.TextBox kullaniciaditxt;
        private System.Windows.Forms.TextBox telefonnotxt;
        private System.Windows.Forms.Button kayitbt;
    }
}