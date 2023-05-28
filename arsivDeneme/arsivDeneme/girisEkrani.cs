using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace arsivDeneme
{
    public partial class girisEkrani : Form
    {
        public girisEkrani()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitEkrani frm = new kayitEkrani();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre doğrulaması
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            string server = "172.21.54.3"; // MySQL sunucu adresi
            string database = "Grup1-2023"; // Veritabanı adı
            string uid = "Grup1-2023"; // MySQL kullanıcı adı
            string password = "NyP:974.cc"; // MySQL şifresi

            string connectionString = $"server={server};database={database};uid={uid};password={password};";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kullanıcı adı ve şifre kontrolü
                    string sql = "SELECT COUNT(*) FROM kullanici WHERE kullanici_adi = @username AND sifre = @password";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", kullaniciAdi);
                        command.Parameters.AddWithValue("@password", sifre);
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            // Doğru kullanıcı adı ve şifre
                            MessageBox.Show("Giriş başarılı!");

                            // İşlemleri gerçekleştir
                        }
                        else
                        {
                            // Yanlış kullanıcı adı veya şifre
                            MessageBox.Show("Hatalı giriş!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            menuEkrani frm = new menuEkrani();
            frm.Show();
            this.Hide();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.Text = "";
                txtSifre.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Şifre";
                txtSifre.PasswordChar = '\0';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Kullanıcı Adı")
            {
                txtKullaniciAdi.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                txtKullaniciAdi.Text = "Kullanıcı Adı";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void girisEkrani_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "Kullanıcı Adı";
            txtSifre.Text = "Şifre";
        }
    }
}
