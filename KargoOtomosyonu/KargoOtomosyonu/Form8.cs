using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KargoOtomosyonu
{
    public partial class Form8 : Form
    {

        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=kargootomosyonu;user=root;Pwd=Berkay.ercn1;Sslmode=none");
        //proje veritabanımıza bağlantımızı gerçekleştirdik
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToLongDateString();
            groupBox4.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int takipno = rastgele.Next(11111, 99999);
            label6.Text = takipno.ToString();


            string insertQuery = "INSERT INTO kargootomosyonu.kargoyolla(kullanıcı_adı,takip_no,teslimat_tipi,gönderilecek_tarih,ödeme_tipi,alıcı_adres) VALUES('" + textBox2.Text +"','" + takipno.ToString()  + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + comboBox2.Text + "','" + richTextBox1.Text + "')";
            //veri tabanımızın tablosuyla ilişkilendirme ysaptık
            connection.Open();
            // bbağlantı açıldı
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try //programda hata varmı diye kontrol ediyor
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Gönderiniz Kaydedildi Kargonuz Ekiplerimizce Kapınızdan Alınacak ");
                }
                else
                {
                    MessageBox.Show("Kargonuz oluşturulamadı!"); // işlemlerde bi sıkıntı olursa verilecek mesaj
                }

            }
            catch (Exception ex) // hata varsa çıkacak mesaj
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
           
        }

        private void destekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox4.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox4.Hide();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
