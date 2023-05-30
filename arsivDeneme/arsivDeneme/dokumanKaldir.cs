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
    public partial class dokumanKaldir : Form
    {
        public dokumanKaldir()
        {
            InitializeComponent();
        }

        private void dokumanKaldir_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string dokumanadi = textBox1.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int dosya = listBox1.SelectedIndex;
            if (dosya != -1)
            {
                listBox1.Items.RemoveAt(dosya);
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Dosya Seçiniz");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
