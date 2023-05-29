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
    public partial class kayitEkrani : Form
    {
        public kayitEkrani()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string adsoyad = textBox4.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("a");
            comboBox1.Items.Add("b");
            comboBox1.Items.Add("g");
            comboBox1.Items.Add("v");
            comboBox1.Items.Add("a");
            // comboBox2.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string mail = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string sifre = textBox2.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                //checkBox işaretli ise
                if (checkBox1.Checked)
                {
                    //karakteri göster.
                    textBox2.PasswordChar = '\0';
                }
                //değilse karakterlerin yerine * koy.
                else
                {
                    textBox2.PasswordChar = '*';
                }
            }
    }
}
