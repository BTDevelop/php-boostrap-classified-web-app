using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

public partial class Management_Kategori_Listelem : System.Web.UI.UserControl
{
    MakaleBLL _makale = new MakaleBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataYukle();
        }

    }
    private void DataYukle(string _income = "")
    {

        SayfadakiVeri = new PagedDataSource()
        {
            DataSource = _makale.Listele(ref _income),
            AllowPaging = true,
            PageSize = 5,
            CurrentPageIndex = PageNumber
        };

        Repeater1.DataSource = SayfadakiVeri;
        Repeater1.DataBind();

        PageCount = SayfadakiVeri.PageCount - 1;

        previous.Visible= !SayfadakiVeri.IsFirstPage;
        next.Visible = !SayfadakiVeri.IsLastPage;

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

    protected void btnKayitSil_Click(object sender, EventArgs e)
    {

        foreach (RepeaterItem kategpriItem in Repeater1.Items)
        {
            CheckBox chc = (CheckBox)kategpriItem.FindControl("CheckBox1");
            if (chc.Checked)
            {
                HiddenField gelenData = (HiddenField)kategpriItem.FindControl("hfGizli");
                // Kategorinin Id'si ile makaleleri,ni bul foreach' le önce onları sil.
                _makale.Sil(Convert.ToInt32(gelenData.Value));
            }
        }
        DataYukle();

    }

    private void DataYukle()
    {
        SayfadakiVeri = new PagedDataSource()
        {
            DataSource = _makale.Listele(),
            AllowPaging = true,
            PageSize = 5,
            CurrentPageIndex = PageNumber
        };

        Repeater1.DataSource = SayfadakiVeri;
        Repeater1.DataBind();

        PageCount = SayfadakiVeri.PageCount - 1;

        previous.Disabled = !SayfadakiVeri.IsFirstPage;
        next.Disabled = !SayfadakiVeri.IsLastPage;

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

    public void search_Click(object sender, EventArgs e)
    {
        DataYukle(search_table.Value);
    }

}

