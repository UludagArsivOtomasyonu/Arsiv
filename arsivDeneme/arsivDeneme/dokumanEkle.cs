using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arsivDeneme
{
    public partial class dokumanEkle : Form
    {
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Items.Add("diploma");
            comboBox2.Items.Add("öğrenci belgesi");
            comboBox2.Items.Add("sınav kağıtları");
            comboBox2.Items.Add("transkript belgesi");
            comboBox2.Items.Add("a");
           // comboBox2.Items.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string hazırlayan = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int sayfaSayisi = Convert.ToInt32(textBox3.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox1.Items.Add("öğrenci işleri");
            comboBox1.Items.Add("muhasebe");
            comboBox1.Items.Add("gibi");
            comboBox1.Items.Add("benzeri");
            comboBox1.Items.Add("a");
           // comboBox1.Items.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string bırakan = textBox4.Text;
        }
    }
}
