using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilim4444
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kul, sifre;
            kul = textBox1.Text;
            sifre = textBox2.Text;
            if (string.IsNullOrEmpty(kul))
            {
                MessageBox.Show("Kullanıcı Adı Boş Geçilemez", "Login Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else if (string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Şifre Boş Geçilemez", "Login Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else
            {
                if (kul == "Admin" && sifre == "123")
                {
                    Form3 anasayfa= new Form3();
                    anasayfa.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı ve Şifre Hatalı", "Login Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
        }
    }
}