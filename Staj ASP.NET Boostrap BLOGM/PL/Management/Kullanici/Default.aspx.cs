using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Management_Kullanici_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["sayfaGetir"] == "Listed")
        {
            PlaceHolder1.Controls.Add(Page.LoadControl("~/Management/Kullanici/Listed.ascx"));
        }
    }
}