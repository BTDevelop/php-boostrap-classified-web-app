using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace PersonelTakip
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        string veri = "";
        string[] veriParca;
        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            try
            {

                picStatic_2.Visible = false;
                dgwPersonel.Visible = true;
                pnlIstatistik.Visible = false;
                dosyaAc.ShowDialog();
                txtDosyaYol.Text = dosyaAc.FileName;
                string dosya_yolu = dosyaAc.FileName;

                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + dosya_yolu + "; Extended Properties=Excel 12.0");
                baglanti.Open();
                string sorgu = "select * from [PersonelGirisCikis$] ";
                OleDbDataAdapter data_adaptor = new OleDbDataAdapter(sorgu, baglanti);
                baglanti.Close();

                DataTable dt = new DataTable();
                data_adaptor.Fill(dt);
                dgwPersonel.DataSource = dt;
                btnAnaliz.Visible = true;

            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Geçerli bir dosya değildi. Lütfen .xls(Excel Formatında) bir dosya yükleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblSayac.Text = "Toplam Kişi: " + dgwPersonel.Rows.Count.ToString();
        }

        private DayOfWeek HaftaSonuSil(string incomeDate)
        {
            DateTime tarih = DateTime.ParseExact(incomeDate, "dd.MM.yyyy", null);
            return tarih.DayOfWeek;
        }

        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            try
            {
                lblSayac.Text = " ";
                tmrProg.Start();
                prgYuklen.Visible = true;

                for (int i = 0; i < dgwPersonel.Rows.Count - 1; i++)
                {

                    if (HaftaSonuSil(dgwPersonel.Rows[i].Cells[1].Value.ToString()) == DayOfWeek.Sunday)
                    {
                        dgwPersonel.Rows.RemoveAt(i);

                    } if (HaftaSonuSil(dgwPersonel.Rows[i].Cells[1].Value.ToString()) == DayOfWeek.Saturday)
                    {
                        dgwPersonel.Rows.RemoveAt(i);
                    }

                }

                this.dgwPersonel.Refresh();
                if (dgwPersonel.Columns.Contains("Sabah Giriş") != true || dgwPersonel.Columns.Contains("Sabah Çıkış") != true || dgwPersonel.Columns.Contains("Öğle Giriş") != true || dgwPersonel.Columns.Contains("Akşam Çıkış") != true)
                {

                    this.dgwPersonel.Columns.Add("Sabah Giriş", "Sabah Giriş");
                    this.dgwPersonel.Columns.Add("Sabah Çıkış", "Sabah Çıkış");
                    this.dgwPersonel.Columns.Add("Öğle Giriş", "Öğle Giriş");
                    this.dgwPersonel.Columns.Add("Akşam Çıkış", "Akşam Çıkış");
                }

                lblSayac.Text += dgwPersonel.Rows.Count.ToString();

                for (int i = 0; i < dgwPersonel.RowCount - 1; i++)
                {
                    Color renk = Renklendir(dgwPersonel.Rows[i].Cells["G"].Value.ToString(), 7, 8);
                    Color renk_1 = Renklendir(dgwPersonel.Rows[i].Cells["Ç"].Value.ToString(), 11, 12);
                    Color renk_2 = Renklendir(dgwPersonel.Rows[i].Cells["G1"].Value.ToString(), 12, 13);
                    Color renk_3 = Renklendir(dgwPersonel.Rows[i].Cells["Ç1"].Value.ToString(), 16, 17);
                    dgwPersonel.Rows[i].Cells[36].Style.BackColor = renk;
                    dgwPersonel.Rows[i].Cells[37].Style.BackColor = renk_1;
                    dgwPersonel.Rows[i].Cells[38].Style.BackColor = renk_2;
                    dgwPersonel.Rows[i].Cells[39].Style.BackColor = renk_3;

                    dgwPersonel.Rows[i].Cells[36].Value = Yazdır(renk);
                    dgwPersonel.Rows[i].Cells[37].Value = Yazdır(renk_1);
                    dgwPersonel.Rows[i].Cells[38].Value = Yazdır(renk_2);
                    dgwPersonel.Rows[i].Cells[39].Value = Yazdır(renk_3);

                }

                sutunSil();
                btnAktar.Visible = true;
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Zaten analiz edildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblSayac.Text = "Toplam Kişi: " + dgwPersonel.Rows.Count.ToString();
        }

        private string Yazdır(Color renk)
        {
            if (renk == Color.Blue)
            {
                return "Gelmedi";
            }
            if (renk == Color.Red)
            {
                return "Mesai saati dışında";
            }
            if (renk == Color.Green)
            {
                return "Mesai saati içinde";
            }
            return "";
        }

        private Color Renklendir(string incomeSaat, int saat_1, int saat_2)
        {

            string[] saatler;
            saatler = incomeSaat.Split(':');

            if ((saatler[0] == "--" && saatler[1] == "--"))
            {
                return Color.Blue;

            }
            else
            {
                if ((Convert.ToInt32(saatler[0]) <= saat_1 && Convert.ToInt32(saatler[1]) < 45) || (Convert.ToInt32(saatler[0]) >= saat_2 && Convert.ToInt32(saatler[1]) > 15))
                {
                    return Color.Red;
                }
                else
                {
                    return Color.Green;
                }
            }
        }

        private void tmrProg_Tick(object sender, EventArgs e)
        {
            if (prgYuklen.Value < 100)
            {
                prgYuklen.Value += 10;
            }

            if (prgYuklen.Value >= 100)
            {
                prgYuklen.Value = 0;
                tmrProg.Stop();
                prgYuklen.Visible = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prgYuklen.Visible = false;
            dgwPersonel.Visible = false;

        }

        private void sutunSil()
        {
            this.dgwPersonel.Columns.Remove("Fark");
            this.dgwPersonel.Columns.Remove("Fark1");
            this.dgwPersonel.Columns.Remove("Fark2");
            this.dgwPersonel.Columns.Remove("Fark3");
            this.dgwPersonel.Columns.Remove("Fark4");
            this.dgwPersonel.Columns.Remove("Fark5");
            this.dgwPersonel.Columns.Remove("Fark6");
            this.dgwPersonel.Columns.Remove("Fark7");
            this.dgwPersonel.Columns.Remove("Fark8");
            this.dgwPersonel.Columns.Remove("Fark9");
            this.dgwPersonel.Columns.Remove("Fark10");
            this.dgwPersonel.Columns.Remove("G2");
            this.dgwPersonel.Columns.Remove("Ç2");
            this.dgwPersonel.Columns.Remove("G3");
            this.dgwPersonel.Columns.Remove("Ç3");
            this.dgwPersonel.Columns.Remove("G4");
            this.dgwPersonel.Columns.Remove("Ç4");
            this.dgwPersonel.Columns.Remove("G5");
            this.dgwPersonel.Columns.Remove("Ç5");
            this.dgwPersonel.Columns.Remove("G6");
            this.dgwPersonel.Columns.Remove("Ç6");
            this.dgwPersonel.Columns.Remove("G7");
            this.dgwPersonel.Columns.Remove("Ç7");
            this.dgwPersonel.Columns.Remove("G8");
            this.dgwPersonel.Columns.Remove("Ç8");
            this.dgwPersonel.Columns.Remove("G9");
            this.dgwPersonel.Columns.Remove("Ç9");

        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            tmrProg.Start();
            prgYuklen.Visible = true;
            SaveFileDialog dosyaKayit = new SaveFileDialog();
            dosyaKayit.Filter = "Erzurum OBM Excel Belgeleri (*.xls)|*.xls";
            dosyaKayit.FileName = "Analiz Edilmiş Personel Raporu.xls";
            string dosya_yolu = dosyaKayit.FileName;
            if (dosyaKayit.ShowDialog() == DialogResult.OK)
            {
                ExcelAktar(dgwPersonel, dosyaKayit.FileName);
            }



            string temp = dgwPersonel.Rows[0].Cells["Ad Soyad"].Value.ToString();
            int blue = 0, red = 0, green = 0, calistigiGun = 0;
            string[] test = { "Sabah Giriş", "Sabah Çıkış", "Öğle Giriş", "Akşam Çıkış" };
            for (int i = 0; i < dgwPersonel.RowCount; i++)
            {
                if (dgwPersonel.Rows[i].Cells["Ad Soyad"].Value.ToString() == temp)
                {
                    string[] toplamSaat = dgwPersonel.Rows[i].Cells["TOPLAMFARK"].Value.ToString().Split(':');
                    if (Convert.ToInt32(toplamSaat[0]) >= 8)
                    {
                        calistigiGun++;
                    }
                    for (int j = 0; j < test.Length; j++)
                    {

                        if (dgwPersonel.Rows[i].Cells[test[j]].Style.BackColor == Color.Blue)
                        {
                            blue++;
                        }

                        else if (dgwPersonel.Rows[i].Cells[test[j]].Style.BackColor == Color.Red)
                        {
                            red++;
                        }
                        else if (dgwPersonel.Rows[i].Cells[test[j]].Style.BackColor == Color.Green)
                        {
                            green++;
                        }


                    }

                }

                else
                {
                    veri += temp + "#" + blue + "#" + red + "#" + green + "#" + calistigiGun + "%";
                    temp = dgwPersonel.Rows[i].Cells["Ad Soyad"].Value.ToString();
                    blue = 0; red = 0; green = 0; calistigiGun = 0;
                }
            }

            btnGrafik.Visible = true;
        }


        private void ExcelAktar(DataGridView gelenGrid, string dosyaAdi)
        {
            string basliklar = "";
            string cikti = "";

            for (int i = 0; i < gelenGrid.Columns.Count; i++)
                basliklar = basliklar.ToString() + Convert.ToString(gelenGrid.Columns[i].HeaderText) + "\t";
            cikti += basliklar + "\r\n";
            // Export data.
            for (int i = 0; i < gelenGrid.RowCount - 1; i++)
            {
                string satir = "";
                for (int j = 0; j < gelenGrid.Rows[i].Cells.Count; j++)
                    satir = satir.ToString() + Convert.ToString(gelenGrid.Rows[i].Cells[j].Value) + "\t";
                cikti += satir + "\r\n";
            }
            //Encode İşlemi
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(cikti);
            FileStream okuyucuStream = new FileStream(dosyaAdi, FileMode.Create);
            BinaryWriter yazici = new BinaryWriter(okuyucuStream);
            yazici.Write(output, 0, output.Length);
            yazici.Flush();
            yazici.Close();
            okuyucuStream.Close();
        }

        private string Verileri_Ayir(string income)
        {
            int i = 0;
            string[] kisiParca;
            kisiParca = income.Split('#');
            return kisiParca[i];
            i += 5;
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            pnlIstatistik.Visible = true;
            veriParca = veri.Split('%');

            for (int i = 0; i < veriParca.Length; i++)
            {
                lstbxkisiler.Items.Add(Verileri_Ayir(veriParca[i]));
            }
        }

        private void lstbxkisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] parcaliSaatler;
            parcaliSaatler = veriParca[lstbxkisiler.SelectedIndex].Split('#');

            string[] seriler = { "Gelmedi " + Convert.ToInt32(parcaliSaatler[1]) / 4, "Mesai Saati Dışında " + Convert.ToInt32(parcaliSaatler[2]) / 4, "Mesai Saati İçinde " + Convert.ToInt32(parcaliSaatler[3]) / 4, parcaliSaatler[4] + "/22" };
            int[] noktalar = { Convert.ToInt32(parcaliSaatler[1]) / 4, Convert.ToInt32(parcaliSaatler[2]) / 4, Convert.ToInt32(parcaliSaatler[3]) / 4, Convert.ToInt32(parcaliSaatler[4]) };
            Series series;
            chrtKisiler.Titles.Clear();
            chrtKisiler.Titles.Add(parcaliSaatler[0]);
            this.chrtKisiler.Series.Clear();

            for (int i = 0; i < seriler.Length; i++)
            {
                series = this.chrtKisiler.Series.Add(seriler[i]);
                series.Points.Add(noktalar[i]);

            }
            chrtKisiler.Series["Gelmedi " + Convert.ToInt32(parcaliSaatler[1]) / 4].Color = Color.Blue;
            chrtKisiler.Series["Mesai Saati Dışında " + Convert.ToInt32(parcaliSaatler[2]) / 4].Color = Color.Red;
            chrtKisiler.Series["Mesai Saati İçinde " + Convert.ToInt32(parcaliSaatler[3]) / 4].Color = Color.Green;
            chrtKisiler.Series[parcaliSaatler[4] + "/22"].Color = Color.MediumPurple;

        }
    }


}

