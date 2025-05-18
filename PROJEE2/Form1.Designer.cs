namespace PROJEE2
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullaniciaditxt = new System.Windows.Forms.TextBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.girisbtn = new System.Windows.Forms.Button();
            this.kayitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // kullaniciaditxt
            // 
            this.kullaniciaditxt.Location = new System.Drawing.Point(117, 36);
            this.kullaniciaditxt.Name = "kullaniciaditxt";
            this.kullaniciaditxt.Size = new System.Drawing.Size(100, 20);
            this.kullaniciaditxt.TabIndex = 3;
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(117, 71);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.PasswordChar = '*';
            this.sifretxt.Size = new System.Drawing.Size(100, 20);
            this.sifretxt.TabIndex = 4;
            // 
            // girisbtn
            // 
            this.girisbtn.Location = new System.Drawing.Point(81, 111);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(75, 23);
            this.girisbtn.TabIndex = 5;
            this.girisbtn.Text = "Giriş";
            this.girisbtn.UseVisualStyleBackColor = true;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // kayitbtn
            // 
            this.kayitbtn.Location = new System.Drawing.Point(177, 111);
            this.kayitbtn.Name = "kayitbtn";
            this.kayitbtn.Size = new System.Drawing.Size(75, 23);
            this.kayitbtn.TabIndex = 6;
            this.kayitbtn.Text = "Kayıt Ol";
            this.kayitbtn.UseVisualStyleBackColor = true;
            this.kayitbtn.Click += new System.EventHandler(this.kayitbtn_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEE2.Properties.Resources._7175_E_Kitaplar__Kitaplara_Gore_Gozleri_Daha_Cok_mu_yoruyor01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 221);
            this.Controls.Add(this.kayitbtn);
            this.Controls.Add(this.girisbtn);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kullaniciaditxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kullaniciaditxt;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Button girisbtn;
        private System.Windows.Forms.Button kayitbtn;
    }
}

