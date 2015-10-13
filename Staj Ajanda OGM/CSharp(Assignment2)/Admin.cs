using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MetroFramework;
using MetroFramework.Forms;

namespace CSharp_Assignment2_
{
    public partial class Admin : MetroForm
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\basitveritabanı.txt");
                while (sr.Peek() != -1)
                {
                    string dosya = sr.ReadLine();

                    string[] split = dosya.Split(' ');

                    if (txtKulAdi.Text == split[0] && txtParola.Text == split[1] && txtDogKodGor.Text == txtDogKodGir.Text)
                    {
                        this.Hide();
                        frmAgenda frame2 = new frmAgenda();
                        frame2.Show(this);

                    }

                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("" + hata);
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Random rsay = new Random();
            txtDogKodGor.Text = rsay.Next(100, 1000).ToString();

        }

    }
}
