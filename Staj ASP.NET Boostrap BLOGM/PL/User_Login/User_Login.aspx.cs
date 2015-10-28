using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;

public partial class User_Login : System.Web.UI.Page
{
    KullaniciBLL _kullanici = new KullaniciBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        mail.Attributes["type"] = "email";

    }

    public void Login_Click(object sender, EventArgs e)
    {
        if (!_kullanici.UyeGirisYapsinMi(mail.Value, password.Value))
        {
            Response.Redirect("~/Default.aspx");
        }
    }


}