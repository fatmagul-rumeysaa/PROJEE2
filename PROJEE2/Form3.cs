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
    public partial class anasayfa : Form
    {
        private string connectionString = "Server=DESKTOP-5KQACGN\\SQLEXPRESS;Database=kitapokuma;Integrated Security=True;";

        public anasayfa()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.kitapTableAdapter.Fill(this.kitapokumaDataSet.Kitap);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand komut = new SqlCommand("SELECT KitapAdi FROM Kitap", conn);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    kitapaditxt.Items.Add(oku["KitapAdi"].ToString());
                }

                oku.Close();
            }
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      


        private void kitapeklebtn_Click(object sender, EventArgs e)
        {

        }



        private void kitapaditxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string secilenKitap = kitapaditxt.SelectedItem.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand komut = new SqlCommand("SELECT Yazar, YayınEvi FROM Kitap WHERE KitapAdi = @kitapAdi", conn);
                    komut.Parameters.AddWithValue("@kitapAdi", secilenKitap);

                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        yazartxt.Text = oku["Yazar"].ToString();
                        yayinevitxt.Text = oku["YayınEvi"].ToString();
                    }

                    oku.Close();
                }
            }
        }

        private void ozetokubtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Önceki özetleri temizle

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sorgu = "SELECT [KitapAdi], [Ozet] FROM Kitap";

                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    SqlDataReader oku = komut.ExecuteReader();

                    while (oku.Read())
                    {
                        string kitapAdi = oku["KitapAdi"].ToString();
                        string kitapOzeti = oku["Ozet"].ToString();

                        listBox1.Items.Add($"{kitapAdi}: {kitapOzeti}");
                    }

                    oku.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yorumbtn_Click(object sender, EventArgs e)
        {
            Form4 yorumFormu = new Form4();
            yorumFormu.Show();
            this.Hide();
        }

        private void kitapeklebt_Click(object sender, EventArgs e)
        {
            kayit Kayıt = new kayit();
            Kayıt.Show();
            this.Hide();
        }

        private void geribt_Click(object sender, EventArgs e)
        {
            giris Giriş = new giris();
            Giriş.Show();
            this.Hide();
        }
    }
}