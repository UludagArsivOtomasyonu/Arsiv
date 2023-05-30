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
    public partial class aramaEkrani : Form
    {
        public aramaEkrani()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string dokumanadi = textBox1.Text;
        }

        

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
