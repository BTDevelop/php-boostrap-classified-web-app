using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

public partial class Management_Kullanici_Listed : System.Web.UI.UserControl
{
    KullaniciBLL _kullanici = new KullaniciBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataYukle();
        }
    }

    private int PageNumber
    {
        get
        {
            if (ViewState["PageNumber"] != null)
                return Convert.ToInt32(ViewState["PageNumber"]);
            return 0;
        }
        set
        {
            ViewState["PageNumber"] = value;
        }
    }
    private int PageCount
    {
        get
        {
            if (ViewState["PageCount"] != null)
                return Convert.ToInt32(ViewState["PageCount"]);
            return 0;
        }
        set { ViewState["PageCount"] = value; }
    }
    public PagedDataSource SayfadakiVeri { get; set; }


    private void DataYukle(string _income = "")
    {

        SayfadakiVeri = new PagedDataSource()
        {
            DataSource = _kullanici.Listed("1"),
            AllowPaging = true,
            PageSize = 5,
            CurrentPageIndex = PageNumber
        };

        Repeater1.DataSource = SayfadakiVeri;
        Repeater1.DataBind();

        PageCount = SayfadakiVeri.PageCount - 1;

        previous.Visible = !SayfadakiVeri.IsFirstPage;
        next.Visible = !SayfadakiVeri.IsLastPage;

    }

    private void DataYukle_2()
    {
        SayfadakiVeri = new PagedDataSource()
        {
            DataSource = _kullanici.Listed("null"),
            AllowPaging = true,
            PageSize = 10,
            CurrentPageIndex = PageNumber
        };

        Repeater1.DataSource = SayfadakiVeri;
        Repeater1.DataBind();

        PageCount = SayfadakiVeri.PageCount - 1;

        previous.Visible = !SayfadakiVeri.IsFirstPage;
        next.Visible = !SayfadakiVeri.IsLastPage;

    }


    protected void btGeri_Click(object sender, EventArgs e)
    {
        PageNumber -= 1;
        DataYukle();
    }

    protected void btIleri_Click(object sender, EventArgs e)
    {
        PageNumber += 1;
        DataYukle();
    }

    protected void btnKayitSil_Click(object sender, EventArgs e)
    {

        foreach (RepeaterItem kategoriItem in Repeater1.Items)
        {
            CheckBox chc = (CheckBox)kategoriItem.FindControl("CheckBox1");
            if (chc.Checked)
            {
                HiddenField gelenData = (HiddenField)kategoriItem.FindControl("hfGizli");
             
                _kullanici.Sil(Convert.ToInt32(gelenData.Value));
            }
        }
        DataYukle();

    }
    public void search_Click(object sender, EventArgs e)
    {
        DataYukle(search_table.Value);
    }
}




