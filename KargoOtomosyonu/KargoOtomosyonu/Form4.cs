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
    public partial class Form4 : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=kargootomosyonu;user=root;Pwd=Berkay.ercn1;Sslmode=none");
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO kargootomosyonu.users(ad,soyad,kullanıcıadı,Şifre) VALUES('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Oluştu");
                }
                else
                {
                    MessageBox.Show("Kayıdınız oluşturlamadı");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            connection.Close();
        }
    }
}
