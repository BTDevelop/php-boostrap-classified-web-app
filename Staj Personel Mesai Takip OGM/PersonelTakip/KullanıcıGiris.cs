using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace PersonelTakip
{
    public partial class KullanıcıGiris : MetroForm
    {
        public KullanıcıGiris()
        {
            InitializeComponent();
        }

        private void KullanıcıGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKulAdi.Text == "admin" && txtParola.Text == "753357")
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show(this);
            }
            else 
            {
                MetroMessageBox.Show(this,"Hatalı Kullanıcı adı veya parola","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
        }

        private void txtKulAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtParola.Enabled = true;
                txtParola.Focus();
            }
        }

        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.Enabled = true;
                btnGiris.Focus();
            }
        }
    }
}
