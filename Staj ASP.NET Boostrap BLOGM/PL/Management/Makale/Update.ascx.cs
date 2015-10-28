using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

public partial class Management_Makale_Update : System.Web.UI.UserControl
{
    MakaleBLL _makale = new MakaleBLL();
    KategoriBLL _kategori = new KategoriBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MakaleGetir();
            drpKategori.DataSource = _kategori.Listele();
            drpKategori.DataTextField = "KategoriAd";
            drpKategori.DataValueField = "KategoriId";
            drpKategori.DataBind();
        }
    }
    private void MakaleGetir()
    {
        try
        {
            Makale mkl = _makale.Bul(Convert.ToInt32(Request.QueryString["MakaleId"]));
            baslik.Value = mkl.Baslik;
            CKEditorControl1.Text = mkl.MakaleYazi;
            drpKategori.Value = mkl.KategoriId.ToString();
            CheckBox1.Checked = mkl.HaberMi;
        }
        catch (Exception)
        {
            Response.Redirect("~/Management/Hata.aspx");
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        _makale.Guncelle(Convert.ToInt32(Request.QueryString["MakaleId"]), baslik.Value, Convert.ToInt32(drpKategori.Value), CheckBox1.Checked, CKEditorControl1.Text, "my.jpg");
        Response.Redirect("~/Management/Makale/Default2.aspx?sayfaGetir=Listed");
    }
}