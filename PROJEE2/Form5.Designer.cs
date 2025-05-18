namespace PROJEE2
{
    partial class kayit
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
            this.kullaniciaditxt = new System.Windows.Forms.TextBox();
            this.yazartxt = new System.Windows.Forms.TextBox();
            this.yayinevitxt = new System.Windows.Forms.TextBox();
            this.ozettxt = new System.Windows.Forms.RichTextBox();
            this.kitapeklebt = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yayınevi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Özet";
            // 
            // kullaniciaditxt
            // 
            this.kullaniciaditxt.Location = new System.Drawing.Point(109, 20);
            this.kullaniciaditxt.Name = "kullaniciaditxt";
            this.kullaniciaditxt.Size = new System.Drawing.Size(100, 20);
            this.kullaniciaditxt.TabIndex = 4;
            // 
            // yazartxt
            // 
            this.yazartxt.Location = new System.Drawing.Point(109, 57);
            this.yazartxt.Name = "yazartxt";
            this.yazartxt.Size = new System.Drawing.Size(100, 20);
            this.yazartxt.TabIndex = 5;
            // 
            // yayinevitxt
            // 
            this.yayinevitxt.Location = new System.Drawing.Point(109, 95);
            this.yayinevitxt.Name = "yayinevitxt";
            this.yayinevitxt.Size = new System.Drawing.Size(100, 20);
            this.yayinevitxt.TabIndex = 6;
            // 
            // ozettxt
            // 
            this.ozettxt.Location = new System.Drawing.Point(109, 130);
            this.ozettxt.Name = "ozettxt";
            this.ozettxt.Size = new System.Drawing.Size(100, 140);
            this.ozettxt.TabIndex = 7;
            this.ozettxt.Text = "";
            // 
            // kitapeklebt
            // 
            this.kitapeklebt.Location = new System.Drawing.Point(254, 247);
            this.kitapeklebt.Name = "kitapeklebt";
            this.kitapeklebt.Size = new System.Drawing.Size(75, 23);
            this.kitapeklebt.TabIndex = 8;
            this.kitapeklebt.Text = "Kitap Ekle";
            this.kitapeklebt.UseVisualStyleBackColor = true;
            this.kitapeklebt.Click += new System.EventHandler(this.kitapeklebt_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(364, 247);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 23);
            this.geri.TabIndex = 9;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 329);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.kitapeklebt);
            this.Controls.Add(this.ozettxt);
            this.Controls.Add(this.yayinevitxt);
            this.Controls.Add(this.yazartxt);
            this.Controls.Add(this.kullaniciaditxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kayit";
            this.Text = "Kayıt";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kullaniciaditxt;
        private System.Windows.Forms.TextBox yazartxt;
        private System.Windows.Forms.TextBox yayinevitxt;
        private System.Windows.Forms.RichTextBox ozettxt;
        private System.Windows.Forms.Button kitapeklebt;
        private System.Windows.Forms.Button geri;
    }
}