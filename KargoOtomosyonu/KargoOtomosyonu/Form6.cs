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

namespace KargoOtomosyonu
{
    public partial class Form6 : Form
    {
        string dbconstr = "SERVER=localhost;DATABASE=kargootomosyonu;UID=root;PWD=Berkay.ercn1";

        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(var baglan = new MySqlConnection(dbconstr))
            {
                using (var adap = new MySqlDataAdapter("SELECT * FROM kargoyolla ", baglan))
                {
                    try
                    {
                        baglan.Open();
                        DataTable dt = new DataTable();
                        adap.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var baglan = new MySqlConnection(dbconstr))
            {
                using (var adap = new MySqlDataAdapter("SELECT * FROM users", baglan))
                {
                    try
                    {
                        baglan.Open();
                        DataTable dt = new DataTable();
                        adap.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
