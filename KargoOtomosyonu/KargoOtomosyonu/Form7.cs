using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123456")
            {
                Form6 adminform = new Form6();
                this.Hide();
                adminform.Show();
            }
            else
            {
                MessageBox.Show("Kullancı adı veya şifre hatalı lütfen tekrar deneyiniz!");
            }
        }
    }
}
