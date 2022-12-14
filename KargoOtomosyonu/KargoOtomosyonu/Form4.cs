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
        //mySql ile bağlantı gerçekleştirdik
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
            //veri tabanımızın tablosuyla ilişkilendirme ysaptık
            connection.Open();
            // bbağlantı açıldı
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try //programda hata varmı diye kontrol ediyor
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Oluştu"); //herşey düzenli bir şekilde çalışırsa verilecek messageboxu
                }
                else
                {
                    MessageBox.Show("Kayıdınız oluşturlamadı"); // işlemlerde bi sıkıntı olursa verilecek mesaj
                }

            }
            catch(Exception ex) // hata varsa çıkacak mesaj
            {
                MessageBox.Show(ex.Message);
            }
            
            connection.Close();
        }
    }
}
