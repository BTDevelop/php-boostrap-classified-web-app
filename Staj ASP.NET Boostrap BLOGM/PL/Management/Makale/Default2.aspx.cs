using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Management_Makale_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["sayfaGetir"] == "Add")
        {
            PlaceHolder1.Controls.Add(Page.LoadControl("~/Management/Makale/Add.ascx"));
        }
        if (Request.QueryString["sayfaGetir"] == "Listed")
        {
            PlaceHolder1.Controls.Add(Page.LoadControl("~/Management/Makale/Listed.ascx"));
        }
        if (Request.QueryString["sayfaGetir"] == "Update")
        {
            PlaceHolder1.Controls.Add(Page.LoadControl("~/Management/Makale/Update.ascx"));
        }

    }
}