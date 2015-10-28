<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Add.ascx.cs" Inherits="Management_Kategori_Add" %>
<div class="row">
    <div class="col-lg-12">
        <div role="form">
            <div class="form-group">
                <label>
                    Category Name:</label>
                <input class="form-control" runat="server" id="categori" />
            </div>
        </div>
        <ul class="pager">
            <li runat="server" id="search_table_button">
                <asp:LinkButton ID="LinkButton3" runat="server" OnClick="Ekle_Click"><i class="fa fa-check fa-fw"></i>Add</asp:LinkButton>
            </li>
        </ul>
       
    </div>
</div>
