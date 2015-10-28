using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class Management_Kategori_Add : System.Web.UI.UserControl
{
    KategoriBLL _kategori = new KategoriBLL();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Ekle_Click(object sender, EventArgs e)
    {
        _kategori.Ekle(categori.Value);
        Response.Redirect("~/Management/Kategori/Default2.aspx?sayfaGetir=Listed");
    
    }
   
}