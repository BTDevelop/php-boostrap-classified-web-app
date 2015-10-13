using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace _081599TuranEmreKÖKSALHW2_HANGMAN_
{
    public partial class HangForm : MetroForm
    {

        public string data = File.ReadAllText(Application.StartupPath + "\\words.txt");
        string[] kelimeler = new string[] { };
        string harfDizim = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string kelimem;
        int sayac;
        char[] n = new char[15];
        private MetroButton[] btn;

        public HangForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = imglHangman.Images[8];
            pictureBox1.Image = imglHangman.Images[6];

            metroLabel1.Text = "";
            kelimeler = data.Split(' ', '\n');
            int r;
            sayac = 0;
            Random random = new Random();
            r = random.Next() % 9 + 1;
            kelimem = kelimeler[r];
            for (int i = 0; i < kelimem.Length; i++)
                metroLabel1.Text += "*";
            n = metroLabel1.Text.ToCharArray();

            btn = new MetroButton[26];
            int x = 25, y = 10;
            int with = 20, height = 30;
            for (int i = 0; i < 26; i++)
            {

                btn[i] = new MetroButton();
                btn[i].Enabled = true;
                btn[i].Visible = true;
                btn[i].Text = harfDizim.Substring(i, 1);
                btn[i].Size = new Size(with, height);
                btn[i].Location = new Point(x, y);

                btn[i].Click += new EventHandler(hangisi);

                x += 20;
                this.panel1.Controls.Add(btn[i]);
            }

        }

        private void hangisi(object sender, EventArgs e)
        {
            string bbtn;
          
            int i, j;

            bbtn = (sender as MetroButton).Text;
            (sender as MetroButton).Enabled = false;
            j = kelimem.IndexOf(bbtn);
            if (j >= 0)
            {
                for (i = 0; i < n.Length; i++)
                    if (kelimem.Substring(i, 1) == bbtn) n[i] = bbtn[0];

                metroLabel1.Text = "";
                for (i = 0; i < n.Length; i++)
                    metroLabel1.Text += n[i].ToString();

                j = metroLabel1.Text.IndexOf("*");
                if (j == -1)
                {
                    MetroMessageBox.Show(this,"Başarıyla Tamamladın.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Question);


                    pictureBox1.Image = imglHangman.Images[5];


                }
            }
            else
            {
                sayac++;
                switch (sayac)
                {
                    case 1: pictureBox1.Image = imglHangman.Images[sayac - 1]; break;
                    case 2: pictureBox1.Image = imglHangman.Images[sayac - 1]; break;
                    case 3: pictureBox1.Image = imglHangman.Images[sayac - 1]; break;
                    case 4: pictureBox1.Image = imglHangman.Images[sayac - 1]; break;
                    case 5: pictureBox1.Image = imglHangman.Images[sayac - 1];
                        MetroMessageBox.Show(this, "ADAM ASILDI","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        pictureBox1.Image = imglHangman.Images[7];
                        break;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form1_Load(null, null);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }


}

