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
    public partial class giris : Form
    {
        SQLBağlantim bgl = new SQLBağlantim();
        public class Baglanti
        {
            public SqlConnection baglanti()
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5KQACGN\SQLEXPRESS;Initial Catalog=kitapokuma;Integrated Security=True");
                return conn;
            }
        }
        public giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void girisbtn_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();

                string sorgu = "SELECT COUNT(*) FROM Kayit WHERE  KullaniciAdi=@kullanici AND Sifre=@sifre";

                using (SqlCommand kontrol = new SqlCommand(sorgu, conn))
                {
                    kontrol.Parameters.AddWithValue("@kullanici", kullaniciaditxt.Text);
                    kontrol.Parameters.AddWithValue("@sifre", sifretxt.Text);

                    int sonuc = (int)kontrol.ExecuteScalar();

                    if (sonuc > 0)
                    {
                        anasayfa Anasayfa = new anasayfa();
                        Anasayfa.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
            
            
       
        private void kayitbtn_Click(object sender, EventArgs e)
        {

            {
                Form2 kayitFormu = new Form2();
                kayitFormu.Show();
                this.Hide();
            }
        }
    }
}
     
        
