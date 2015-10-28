using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

public partial class Contact : System.Web.UI.Page
{
    IletisimBLL _iletisim = new IletisimBLL();

    protected void Page_Load(object sender, EventArgs e)
    {
        Kullanici _uye = (Kullanici)Session["Uye"];
        if ((Kullanici)Session["Uye"] != null)
        {

            isimCon.Value = _uye.Ad;
            emailCon.Value = _uye.EPosta;
            soyCon.Value = _uye.Soyad;
        }

 
    }
    public void gonder_Click(Object sender,EventArgs e)
    {
        _iletisim.Insert(emailCon.Value, isimCon.Value, soyCon.Value, DateTime.Now, message.Value);
    }

    public void geri_Click(Object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }

   
}