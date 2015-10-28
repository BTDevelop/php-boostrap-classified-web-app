<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Update.ascx.cs" Inherits="Management_Makale_Update" %>
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

                <div class="checkbox">
                    <label>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="News?" />
                    </label>
                </div>
            </div>
        </div>
        <button id="Button1" type="button" class="btn btn-info btn-circle btn-lg fa fa-check" runat="server" onserverclick="Button2_Click">
        </button>
    </div>

</div>
