using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEE2
{
    public partial class kayit : Form
    {
        private string connectionString = "Server=DESKTOP-5KQACGN\\SQLEXPRESS;Database=kitapokuma;Integrated Security=True;";
        public kayit()
        {
            InitializeComponent();
        }

        private void kitapeklebt_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sorgu = "INSERT INTO Kitap (KitapAdi, Yazar, Yayınevi, Ozet) VALUES (@kitapadi, @yazar, @yayinevi, @ozet)";
                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@kitapadi", kullaniciaditxt.Text);
                    komut.Parameters.AddWithValue("@yazar", yazartxt.Text);
                    komut.Parameters.AddWithValue("@yayinevi", yayinevitxt.Text);
                    komut.Parameters.AddWithValue("@ozet", ozettxt.Text);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarılı!");

                    anasayfa form3 = new anasayfa();
                    form3.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void geri_Click(object sender, EventArgs e)
        {
            anasayfa Anasayfa = new anasayfa();
            Anasayfa.Show();
            this.Hide();
        }
    }
    }

