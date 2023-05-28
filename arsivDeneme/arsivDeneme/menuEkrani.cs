﻿using System;
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
    public partial class menuEkrani : Form
    {
        public menuEkrani()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aramaEkrani frm = new aramaEkrani();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dokumanEkle frm = new dokumanEkle();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dokumanKaldir frm = new dokumanKaldir();
            frm.Show();
            this.Hide();
        }
    }
}
