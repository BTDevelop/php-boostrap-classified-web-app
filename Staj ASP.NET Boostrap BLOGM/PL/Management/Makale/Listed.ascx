<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Listed.ascx.cs" Inherits="Management_Kategori_Listelem" %>
<style type="text/css">
    .auto-style1 {
        height: 52px;
    }
</style>
<div class="row">
    <div class="col-lg-12">
        <div class="panel panel-red">
            <div class="panel-heading">
                Listed Categories
            </div>
            <!-- /.panel-heading -->
            <div class="panel-body">
                <div class="dataTable_wrapper">
                    <table class="table table-striped table-bordered table-hover" id="dataTables-example">
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="dataTables_length" id="dataTables-example_length">
                                    <label>
                                        Show
                                        <select name="dataTables-example_length" aria-controls="dataTables-example" class="form-control input-sm">
                                            <option value="10">10</option>
                                            <option value="25">25</option>
                                            <option value="50">50</option>
                                            <option value="100">100
                                            </option>
                                        </select>
                                        Articles</label>
                                </div>
                            </div>
                            <div class="col-sm-5">
                                <div id="dataTables-example_filter" class="dataTables_filter">
                                    <label>Search:<input class="form-control input-sm" aria-controls="dataTables-example" id="search_table" runat="server" /></label>
                                    <ul class="pager">
                                        <li runat="server" id="search_table_button">
                                            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="search_Click">Search</asp:LinkButton>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <thead>
                            <tr>
                                <th class="auto-style1">
                                    <asp:CheckBox ID="CheckBox2" runat="server" />
                                </th>
                                <th class="auto-style1">Headers
                                </th>
                                <th class="auto-style1">Categori
                                </th>
                                <th class="auto-style1">Date
                                </th>
                                <th class="auto-style1">News?
                                </th>
                                <th class="auto-style1">Update
                                </th>

                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <tr class="odd gradeX">
                                        <td>
                                            <asp:CheckBox ID="CheckBox1" runat="server" />
                                               <asp:HiddenField ID="hfGizli" runat="server" Value='<%#Eval("MakaleId") %>' />
                                        </td>
                                        <td>
                                            <%#Eval("Baslik") %>
                                        </td>
                                        <td>
                                            <%#Eval("Kategorisi") %>
                                        </td>
                                        <td>

                                            <%#Eval("Tarih") %>
                                        </td>
                                        <td>
                                            <asp:CheckBox ID="CheckBox3" runat="server" Checked='<%#Eval("HaberMi")%>' Enabled="false" />

                                        </td>
                                        <td>
                                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("MakaleId","~/Management/Makale/Default2.aspx?sayfaGetir=Update&MakaleId={0}") %>'>Update</asp:HyperLink>

                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>

                        </tbody>
                    </table>
                    <h1 class="page-header"></h1>
                    <ul class="pager">
                        <li runat="server" id="previous">
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="btGeri_Click">Previous</asp:LinkButton>
                        </li>
                        <li runat="server" id="next">
                            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="btIleri_Click">Next</asp:LinkButton></li>
                    </ul>
                </div>
                <!-- /.table-responsive -->
                <div class="well">
                    <a class="btn btn-default btn-lg btn-block" runat="server" onserverclick="btnKayitSil_Click"><i class="fa fa-trash-o fa-fw"></i> Delete Records </a>
                </div>
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>

</div>
