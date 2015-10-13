using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        if (alt.Value == "sıfıra bölünemez")
        {
            alt.Value = "";
        }
        if (alt.Value == "0")
        {
            alt.Value = "";
        }
        LinkButton btn = (LinkButton)sender;
        alt.Value += btn.Text;

    }

    protected void bntHepsi_Click(object sender, EventArgs e)
    {
        LinkButton btn = (LinkButton)sender;


        if ((ust.Value.IndexOf("+") > -1) || (ust.Value.IndexOf("-") > -1) || (ust.Value.IndexOf("*") > -1) || (ust.Value.IndexOf("/") > -1))
        {
            ust.Value = ust.Value + alt.Value;
            alt.Value = "";

        }

        else
        {
            alt.Value += alt.Value.Substring(0, btn.Text.Length - 1);
            ust.Value = alt.Value + btn.Text;
            alt.Value = "";
        }
        if ((ust.Value.IndexOf(">") > -1))
        {
            ust.Value = ust.Value.Substring(0, ust.Value.Length - 1);
            alt.Value = "";
        }

    }

    protected void btnEsittir_Click(object sender, EventArgs e)
    {
        if (ust.Value.IndexOf("+") > -1)
        {

            string[] sayilar = ust.Value.Split('+');

            if (sayilar.Length > 1)
            {
                double sayi1 = Convert.ToDouble(sayilar[0]);
                double sayi2 = Convert.ToDouble(sayilar[1]);
                alt.Value = Convert.ToString(sayi1 + sayi2);
                ust.Value = "";
            }
        }
        else if (ust.Value.IndexOf("-") > -1)
        {
            string[] sayilar = ust.Value.Split('-');
            if (sayilar.Length > 1)
            {
                double sayi1 = Convert.ToDouble(sayilar[0]);
                double sayi2 = Convert.ToDouble(sayilar[1]);
                alt.Value = Convert.ToString(sayi1 - sayi2);

                ust.Value = "";
            }
        }
        else if (ust.Value.IndexOf("*") > -1)
        {
            string[] sayilar = ust.Value.Split('*');
            if (sayilar.Length > 1)
            {
                double sayi1 = Convert.ToDouble(sayilar[0]);
                double sayi2 = Convert.ToDouble(sayilar[1]);
                alt.Value = Convert.ToString(sayi1 * sayi2);
                ust.Value = "";
            }
        }
        else if (ust.Value.IndexOf(">") == -1)
        {

            int sayi = Convert.ToInt32(ust.Value);
            alt.Value = Convert.ToString(Math.Sqrt(sayi));
            ust.Value = "";
        }
        else if (ust.Value.IndexOf("/") > -1)
        {
            string[] sayilar = ust.Value.Split('/');

            if (sayilar.Length > 1)
            {
                double sayi1 = Convert.ToDouble(sayilar[0]);
                double sayi2 = Convert.ToDouble(sayilar[1]);
                if (sayi2 == 0)
                {
                    alt.Value = "Sıfıra bölünemez";
                    Console.Beep();
                }
                else
                {
                    alt.Value = Convert.ToString(sayi1 / sayi2);
                }
            }
            ust.Value = "";
        }
    }
    protected void btnVirgul_Click(object sender, EventArgs e)
    {

        if (alt.Value.IndexOf(",") == -1)
        {
            alt.Value += ",";
        }
    }

    protected void btnGeri_Click(object sender, EventArgs e)
    {
        if (alt.Value.Length > 0)
        {
            alt.Value = alt.Value.Substring(0, alt.Value.Length - 1);
        }
    }

    protected void btnSil_Click(object sender, EventArgs e)
    {
        ust.Value = "";
        alt.Value = "";
    }
}