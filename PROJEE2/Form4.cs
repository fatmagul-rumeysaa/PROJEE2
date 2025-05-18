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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJEE2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            {
                YorumlariYukle();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gonderbt_Click(object sender, EventArgs e)
        {
            
            string KullaniciAdi = kullaniciaditxt.Text;
            string Yorum = yorumtxt.Text;

            if (string.IsNullOrWhiteSpace(KullaniciAdi) || string.IsNullOrWhiteSpace(Yorum))
            {
                MessageBox.Show("Lütfen hem adınızı hem de yorumunuzu girin.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("Server=DESKTOP-5KQACGN\\SQLEXPRESS;Database=kitapokuma;Integrated Security=True;"))
            {
                conn.Open();

                // KullaniciAdi veritabanında var mı kontrol et
                SqlCommand kontrolKomutu = new SqlCommand("SELECT COUNT(*) FROM Kayit WHERE KullaniciAdi = @kullaniciadi", conn);
                kontrolKomutu.Parameters.AddWithValue("@kullaniciadi", KullaniciAdi);
                int kayitSayisi = (int)kontrolKomutu.ExecuteScalar();

                if (kayitSayisi == 0)
                {
                    MessageBox.Show("Bu kullanıcı adına ait bir kayıt bulunamadı. Lütfen önce kayıt olun.");
                    return;
                }

                // Yorum ekleme işlemi
                SqlCommand komut = new SqlCommand("INSERT INTO Yorum (KullaniciAdi, Yorum) VALUES (@ad, @yorum)", conn);
                komut.Parameters.AddWithValue("@ad", KullaniciAdi);
                komut.Parameters.AddWithValue("@yorum", Yorum);
                komut.ExecuteNonQuery();
            }

            MessageBox.Show("Yorum kaydedildi!");
            yorumtxt.Clear();
            YorumlariYukle(); // Yeni yorumu da listele
        }

        

        private void kullaniciaditxt_TextChanged(object sender, EventArgs e)
        {

        }

            private void YorumlariYukle()
        {
            listBox1.Items.Clear();

            using (SqlConnection conn = new SqlConnection("Server=DESKTOP-5KQACGN\\SQLEXPRESS;Database=kitapokuma;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand komut = new SqlCommand("SELECT KullaniciAdi, Yorum FROM Yorum", conn);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    string gosterim = oku["KullaniciAdi"].ToString() + ": " + oku["Yorum"].ToString();
                    listBox1.Items.Add(gosterim);
                }

                oku.Close();
            }
        }

    }
}
  

