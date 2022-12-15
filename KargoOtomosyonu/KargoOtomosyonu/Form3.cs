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
using MySql.Data;


namespace KargoOtomosyonu
{
    public partial class Form3 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Form3()
        {
            InitializeComponent();

            con = new MySqlConnection("Server=localhost;Database=kargootomosyonu;user=root;Pwd=Berkay.ercn1;Sslmode=none");
            //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM users where kullanıcıadı='" + textBox1.Text + "' AND Şifre='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Form8 uyekontrol = new Form8();
                this.Hide();
                uyekontrol.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz veya lütfen ÜYE olunuz.");
            }
            con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void Form3_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }
    }
}
