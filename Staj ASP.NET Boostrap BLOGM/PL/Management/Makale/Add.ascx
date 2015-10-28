<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Add.ascx.cs" Inherits="Management_Makale_Add" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<div class="row">
    <div class="col-lg-12">
        <div role="form">
            <div class="form-group">
                <label>
                    Header:</label>
                <input class="form-control" runat="server" id="baslik" />
            </div>
            <div class="form-group">
                <label>Categori Name:</label>
                <select class="form-control" runat="server" id="drpKategori">
                    <option>1</option>
                </select>
            </div>
            <div class="form-group">
                <CKEditor:CKEditorControl ID="CKEditorControl1" runat="server"></CKEditor:CKEditorControl>
            </div>

            <div class="form-group">
                <label>Image input</label>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </div>

            <div class="form-group">
                <img src="#" class="img-thumbnail" width="304" height="236" runat="server" id="file_img" />
            </div>
            <div class="form-group">

                <div class="checkbox">
                    <label>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="News?" />
                    </label>
                </div>
            </div>
        </div>
        <ul class="pager">
            <li runat="server" id="Li1">
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Button_Click"><i class="fa fa-times fa-fw"></i>Cancel</asp:LinkButton>
            </li>
            <li runat="server" id="search_table_button">
                <asp:LinkButton ID="LinkButton3" runat="server" OnClick="Button2_Click"><i class="fa fa-check fa-fw"></i>Add</asp:LinkButton>
            </li>

        </ul>
    </div>
</div>
