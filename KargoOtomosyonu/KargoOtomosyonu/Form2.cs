﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoOtomosyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 girisyapma = new Form3();
            this.Hide();
            girisyapma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 üyeolma = new Form4();
            this.Hide();
            üyeolma.Show();
        }
    }
}
