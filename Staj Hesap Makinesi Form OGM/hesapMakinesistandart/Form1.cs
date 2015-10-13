using System;
using System.Drawing;
using System.Windows.Forms;

namespace hesapMakinesistandart
{
    public partial class Form1 : Form
    {
        Double sonucDeger = 0;
        String ustBilgi = "";
        bool isustBilgi = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isustBilgi))
                textBox1.Clear();

            isustBilgi = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;

        }

        private void buttonOperator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ustBilgi = button.Text;
            sonucDeger = Double.Parse(textBox1.Text);
            isustBilgi = true;

            switch (ustBilgi)
            {
                case "1/x":
                    textBox1.Text = (1 / sonucDeger).ToString();
                    label1.Text = "reciproc(" + sonucDeger.ToString() + ")";
                    break;
                case "±":
                    textBox1.Text = (sonucDeger * -1).ToString();
                    break;
                case "kök":
                    textBox1.Text = Math.Sqrt(sonucDeger).ToString();
                    break;
            }


        }


        private void operator_click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            Button button = (Button)sender;

            if (sonucDeger != 0)
            {
                button28.PerformClick();
                ustBilgi = button.Text;
                label1.Text = sonucDeger + " " + ustBilgi;
                isustBilgi = true;
            }
            else
            {
                ustBilgi = button.Text;
                sonucDeger = Double.Parse(textBox1.Text);
                label1.Text = sonucDeger + " " + ustBilgi;
                isustBilgi = true;
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            sonucDeger = 0;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            switch (ustBilgi)
            {
                case "+":
                    textBox1.Text = (sonucDeger + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (sonucDeger - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (sonucDeger * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (sonucDeger / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }

            sonucDeger = Double.Parse(textBox1.Text);
            label1.Text = "";
        }


        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            textBox1.Text = "0";
            label1.Text = "";
            sonucDeger = 0;
            button6.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pnl.Width = 213;
            textBox1.Width = 200;
            this.Width = 247;
        }

        private void programcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl.Width = 321;
            textBox1.Width = 301;
            this.Width = 356;
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl.Width = 213;
            textBox1.Width = 200;
            this.Width = 247;

        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl.BackColor = Color.LightSalmon;
            textBox1.BackColor = Color.LightSalmon;
            panel1.BackColor = Color.LightSalmon;
            panel2.BackColor = Color.LightSalmon;

        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl.BackColor = Color.LightGreen;
            textBox1.BackColor = Color.LightGreen;
            panel1.BackColor = Color.LightGreen;
            panel2.BackColor = Color.LightGreen;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl.BackColor = Color.LemonChiffon;
            textBox1.BackColor = Color.LemonChiffon;
            panel1.BackColor = Color.LemonChiffon;
            panel2.BackColor = Color.LemonChiffon;
        }




        private void tabanHesapla(int fromBase, int toBase)
        {
            String number = textBox1.Text;
            textBox1.Text = Convert.ToString(Convert.ToInt64(number, fromBase), toBase);
        }

        private void rdOnaltılı_CheckedChanged(object sender, EventArgs e)
        {
            button.Enabled = true;
            button13.Enabled = true;
            button11.Enabled = true;
            button18.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            if (rdSekizli.Checked)
            {
                tabanHesapla(16, 8);
            }
            if (rdIkili.Checked)
            {
                tabanHesapla(16, 2);
            }
            if (rdOnlu.Checked)
            {
                tabanHesapla(16, 10);
            }

        }

        private void rdOnlu_CheckedChanged(object sender, EventArgs e)
        {
            button.Enabled = true;
            button13.Enabled = true;
            button11.Enabled = true;
            button18.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            if (rdOnaltılı.Checked)
            {
                tabanHesapla(10, 16);
            }
            if (rdSekizli.Checked)
            {
                tabanHesapla(10, 8);
            }
            if (rdIkili.Checked)
            {
                tabanHesapla(10, 2);
            }
        }

        private void rdSekizli_CheckedChanged(object sender, EventArgs e)
        {
            button11.Enabled = true;
            button18.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button.Enabled = false;
            button13.Enabled = false;
            if (rdOnaltılı.Checked)
            {
                tabanHesapla(8, 16);
            }
            if (rdOnlu.Checked)
            {
                tabanHesapla(8, 10);
            }
            if (rdIkili.Checked)
            {
                tabanHesapla(8, 2);
            }
        }

        private void rdIkili_CheckedChanged(object sender, EventArgs e)
        {
            button.Enabled = false;
            button13.Enabled = false;
            button11.Enabled = false;
            button18.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            if (rdOnaltılı.Checked)
            {
                tabanHesapla(2, 16);
            }
            if (rdOnlu.Checked)
            {
                tabanHesapla(2, 10);
            }
            if (rdSekizli.Checked)
            {
                tabanHesapla(2, 8);
            }
        }

    }
}
