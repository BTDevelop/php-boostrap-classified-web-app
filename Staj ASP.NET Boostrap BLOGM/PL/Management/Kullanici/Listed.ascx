<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Listed.ascx.cs" Inherits="Management_Kullanici_Listed" %>
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
                                            <option value="100">100 </option>
                                        </select>
                                        Users</label>
                                </div>
                            </div>
                            <div class="col-sm-5">
                                <div id="dataTables-example_filter" class="dataTables_filter">
                                    <label>
                                        Search:<input class="form-control input-sm" aria-controls="dataTables-example" id="search_table"
                                            runat="server" /></label>
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
                                <th class="auto-style1">
                                    Name
                                </th>
                                <th class="auto-style1">
                                    E-Mail
                                </th>
                                <th class="auto-style1">
                                    Password
                                </th>
                                <th class="auto-style1">
                                    State
                                </th>
                                <th class="auto-style1">
                                    Detail
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <tr class="odd gradeX">
                                        <td>
                                            <asp:CheckBox ID="CheckBox1" runat="server" />
                                            <asp:HiddenField ID="hfGizli" runat="server" Value='<%#Eval("KullaniciId") %>' />
                                        </td>
                                        <td>
                                            <%#Eval("Ad") %>
                                        </td>
                                        <td>
                                            <%#Eval("EPosta") %>
                                        </td>
                                        <td>
                                            <%#Eval("Sifre") %>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="stateUser" runat="server" ForeColor="ForestGreen">Active</asp:LinkButton>
                                            <asp:HiddenField ID="hf" runat="server" Value='<%#Eval("KullaniciId") %>' />
                                        </td>
                                        <td>
                                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("urlSeoCreater","~/Management/Kullanici/Details.aspx?KullaniciId={0}")%>'>Detail User </asp:HyperLink>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                    <h1 class="page-header">
                    </h1>
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
                    <a class="btn btn-default btn-lg btn-block" runat="server" onserverclick="btnKayitSil_Click">
                        <i class="fa fa-trash-o fa-fw"></i>Delete Records </a>
                </div>
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
</div>
