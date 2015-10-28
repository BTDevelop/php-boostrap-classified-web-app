<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Update.ascx.cs" Inherits="Management_Kategori_Update" %>
<div class="row">
    <div class="col-lg-12">
        <div class="col-lg-7">
            <div role="form">
                <div class="form-group">
                    <label>
                        New Categori Name:</label>
                    <input class="form-control" runat="server" id="yeniKategori" />
                </div>
            </div>

            <button type="button" class="btn btn-warning btn-circle btn-lg fa fa-check" runat="server" onserverclick="Button1_Click" />

        </div>
    </div>
</div>
