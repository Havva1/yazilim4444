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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Form4 stok = new Form4();

            stok.MdiParent = this;

              stok.Show();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteri.MdiParent = this;

            musteri.Show();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap=MessageBox.Show("uygulamdam çıkmak ")
        }
    }
}
