using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

public partial class Management_Kategori_Update : System.Web.UI.UserControl
{
    KategoriBLL _kategori = new KategoriBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            KategoriGetir();
        }
    }

    private void KategoriGetir()
    {
        try
        {

            Kategori ktg = _kategori.Bul(Convert.ToInt32(Request.QueryString["KategoriId"]));
            yeniKategori.Value = ktg.KategoriAd;
        }
        catch (Exception)
        {

            Response.Redirect("~/Management/Hata.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        _kategori.Guncelle(Convert.ToInt32(Request.QueryString["KategoriId"]), yeniKategori.Value);
        Response.Redirect("~/Management/Kategori/Default2.aspx?sayfaGetir=Listed");
    }

}