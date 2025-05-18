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
    public partial class Form2 : Form
    {
        private string connectionString = "Server=DESKTOP-5KQACGN\\SQLEXPRESS;Database=kitapokuma;Integrated Security=True;";

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void kayitbt_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sorgu = "INSERT INTO Kayit (KullaniciAdi, Sifre, E_Posta, TelefonNumarasi) VALUES (@kullanici, @sifre, @eposta, @telefonno)";
                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    komut.Parameters.AddWithValue("@kullanici", kullaniciaditxt.Text);
                    komut.Parameters.AddWithValue("@sifre", sifretxt.Text);
                    komut.Parameters.AddWithValue("@eposta", epostatxt.Text);
                    komut.Parameters.AddWithValue("@telefonno", telefonnotxt.Text);
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
    }
    }

