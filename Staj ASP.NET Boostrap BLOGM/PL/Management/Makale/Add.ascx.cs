using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
public partial class Management_Makale_Add : System.Web.UI.UserControl
{
    KategoriBLL _kategori = new KategoriBLL();
    MakaleBLL _makale = new MakaleBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        drpKategori.DataSource = _kategori.Listele();
        drpKategori.DataTextField = "KategoriAd";
        drpKategori.DataValueField = "KategoriId";
        drpKategori.DataBind();

        //if (FileUpload1.FileName!=null)
        //{
        //    file_img.Attributes["src"] = FileUpload1.FileName;
           
        //}
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        _makale.Ekle(baslik.Value, Convert.ToInt32(drpKategori.Value),CheckBox1.Checked , CKEditorControl1.Text, FileUpload1.FileName);
        Response.Redirect("~/Management/Makale/Default2.aspx?sayfaGetir=Listed");
    }
    protected void Button_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Management/Default.aspx");

    }
}