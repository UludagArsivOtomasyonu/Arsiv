using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace arsivDeneme
{
    public partial class dokumanEkle : Form
    {
        string connectionString = "server=172.21.54.3;user id=Grup1-2023;password=NyP:974.cc;database=Grup1-2023";
        string query = "INSERT INTO mytable (evrak) VALUES (@evrak)";
        public dokumanEkle()
        {
            InitializeComponent();
        }


        private void dokumanEkle_Load(object sender, EventArgs e)
        {
            

            
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string dokumanAdi = textBox1.Text;
        }
      
      
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string hazırlayan = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int sayfaSayisi = Convert.ToInt32(textBox3.Text);
        }

       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string bırakan = textBox4.Text;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            //tring connectionstring = "server=172.21.54.3 ; database=Grup1-2023 ; uid=Grup1-2023 ; password=NyP:974.cc;";
            //var connection = new MySqlConnection(connectionstring);

            //MessageBox.Show("döküman eklendi");
        }
    }
}
