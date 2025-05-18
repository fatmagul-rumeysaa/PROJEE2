namespace PROJEE2
{
    partial class anasayfa
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yazartxt = new System.Windows.Forms.TextBox();
            this.yayinevitxt = new System.Windows.Forms.TextBox();
            this.ozetokubtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınEviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ozetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapokumaDataSet = new PROJEE2.kitapokumaDataSet();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.yorumbtn = new System.Windows.Forms.Button();
            this.kitapTableAdapter = new PROJEE2.kitapokumaDataSetTableAdapters.KitapTableAdapter();
            this.kitapaditxt = new System.Windows.Forms.ComboBox();
            this.kitapeklebt = new System.Windows.Forms.Button();
            this.geribt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapokumaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yayın Evi";
            // 
            // yazartxt
            // 
            this.yazartxt.Location = new System.Drawing.Point(140, 52);
            this.yazartxt.Name = "yazartxt";
            this.yazartxt.Size = new System.Drawing.Size(121, 20);
            this.yazartxt.TabIndex = 4;
            // 
            // yayinevitxt
            // 
            this.yayinevitxt.Location = new System.Drawing.Point(140, 83);
            this.yayinevitxt.Name = "yayinevitxt";
            this.yayinevitxt.Size = new System.Drawing.Size(121, 20);
            this.yayinevitxt.TabIndex = 5;
            // 
            // ozetokubtn
            // 
            this.ozetokubtn.Location = new System.Drawing.Point(151, 129);
            this.ozetokubtn.Name = "ozetokubtn";
            this.ozetokubtn.Size = new System.Drawing.Size(75, 23);
            this.ozetokubtn.TabIndex = 6;
            this.ozetokubtn.Text = "Özet Oku";
            this.ozetokubtn.UseVisualStyleBackColor = true;
            this.ozetokubtn.Click += new System.EventHandler(this.ozetokubtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapAdiDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.yayınEviDataGridViewTextBoxColumn,
            this.ozetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(285, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 80);
            this.dataGridView1.TabIndex = 7;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            // 
            // yazarDataGridViewTextBoxColumn
            // 
            this.yazarDataGridViewTextBoxColumn.DataPropertyName = "Yazar";
            this.yazarDataGridViewTextBoxColumn.HeaderText = "Yazar";
            this.yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            // 
            // yayınEviDataGridViewTextBoxColumn
            // 
            this.yayınEviDataGridViewTextBoxColumn.DataPropertyName = "YayınEvi";
            this.yayınEviDataGridViewTextBoxColumn.HeaderText = "YayınEvi";
            this.yayınEviDataGridViewTextBoxColumn.Name = "yayınEviDataGridViewTextBoxColumn";
            // 
            // ozetDataGridViewTextBoxColumn
            // 
            this.ozetDataGridViewTextBoxColumn.DataPropertyName = "Ozet";
            this.ozetDataGridViewTextBoxColumn.HeaderText = "Ozet";
            this.ozetDataGridViewTextBoxColumn.Name = "ozetDataGridViewTextBoxColumn";
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.kitapokumaDataSet;
            // 
            // kitapokumaDataSet
            // 
            this.kitapokumaDataSet.DataSetName = "kitapokumaDataSet";
            this.kitapokumaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(112, 260);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(517, 121);
            this.listBox1.TabIndex = 9;
            // 
            // yorumbtn
            // 
            this.yorumbtn.Location = new System.Drawing.Point(635, 358);
            this.yorumbtn.Name = "yorumbtn";
            this.yorumbtn.Size = new System.Drawing.Size(75, 23);
            this.yorumbtn.TabIndex = 10;
            this.yorumbtn.Text = "Yorum Ekle";
            this.yorumbtn.UseVisualStyleBackColor = true;
            this.yorumbtn.Click += new System.EventHandler(this.yorumbtn_Click);
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // kitapaditxt
            // 
            this.kitapaditxt.FormattingEnabled = true;
            this.kitapaditxt.Location = new System.Drawing.Point(140, 22);
            this.kitapaditxt.Name = "kitapaditxt";
            this.kitapaditxt.Size = new System.Drawing.Size(121, 21);
            this.kitapaditxt.TabIndex = 14;
            this.kitapaditxt.SelectedIndexChanged += new System.EventHandler(this.kitapaditxt_SelectedIndexChanged);
            // 
            // kitapeklebt
            // 
            this.kitapeklebt.Location = new System.Drawing.Point(456, 119);
            this.kitapeklebt.Name = "kitapeklebt";
            this.kitapeklebt.Size = new System.Drawing.Size(75, 23);
            this.kitapeklebt.TabIndex = 15;
            this.kitapeklebt.Text = "Kitap Ekle";
            this.kitapeklebt.UseVisualStyleBackColor = true;
            this.kitapeklebt.Click += new System.EventHandler(this.kitapeklebt_Click);
            // 
            // geribt
            // 
            this.geribt.Location = new System.Drawing.Point(667, 119);
            this.geribt.Name = "geribt";
            this.geribt.Size = new System.Drawing.Size(75, 23);
            this.geribt.TabIndex = 16;
            this.geribt.Text = "GERİ";
            this.geribt.UseVisualStyleBackColor = true;
            this.geribt.Click += new System.EventHandler(this.geribt_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJEE2.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 400);
            this.Controls.Add(this.geribt);
            this.Controls.Add(this.kitapeklebt);
            this.Controls.Add(this.kitapaditxt);
            this.Controls.Add(this.yorumbtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ozetokubtn);
            this.Controls.Add(this.yayinevitxt);
            this.Controls.Add(this.yazartxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapokumaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yazartxt;
        private System.Windows.Forms.TextBox yayinevitxt;
        private System.Windows.Forms.Button ozetokubtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button yorumbtn;
        private kitapokumaDataSet kitapokumaDataSet;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private kitapokumaDataSetTableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınEviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ozetDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox kitapaditxt;
        private System.Windows.Forms.Button kitapeklebt;
        private System.Windows.Forms.Button geribt;
    }
}