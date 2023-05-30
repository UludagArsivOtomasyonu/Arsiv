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
    }
}
