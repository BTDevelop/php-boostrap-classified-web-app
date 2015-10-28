<%@ Page Title="Home" Language="C#" MasterPageFile="~/Management/MainMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Management_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="panel panel-red">
        <div class="panel-heading">
            <i class="fa fa-bar-chart-o fa-fw"></i>Blog Statistics
               <div class="pull-right"></div>
        </div>
        <!-- /.panel-heading -->
        <div class="panel-body">
            <canvas id="buyers" width="650" height="400"></canvas>
            <script>
                // line chart data
                var buyerData = {
                    labels: ["January", "February", "March", "April", "May", "June"],
                    datasets: [
                    {
                        fillColor: "rgba(172,194,132,0.4)",
                        strokeColor: "#ACC26D",
                        pointColor: "#fff",
                        pointStrokeColor: "#9DB86D",
                        data: [203, 156, 99, 251, 305, 247]
                    }
                    ]
                }
                // get line chart canvas
                var buyers = document.getElementById('buyers').getContext('2d');
                // draw line chart
                new Chart(buyers).Line(buyerData);
                // pie chart data

            </script>
        </div>
        <!-- /.panel-body -->
    </div>
    <!-- /.panel -->
<div class="chat-panel panel panel-green">
                            <div class="panel-heading">
                                <i class="fa fa-comments fa-fw"></i>Chat
                                
                            </div>
                            <!-- /.panel-heading -->
                            <div class="panel-body">
                                <ul class="chat">
                                    <asp:Repeater ID="Repeater1" runat="server">
                                        <ItemTemplate>
                                            <li class="left clearfix"><span class="chat-img pull-left">
                                                <img src="http://placehold.it/50/55C1E7/fff" alt="User Avatar" class="img-circle" />
                                            </span>
                                                <div class="chat-body clearfix">
                                                    <div class="header">
                                                        <strong class="primary-font">
                                                            <%#Eval("Ad") %> <%#Eval("Soyad") %></strong> <small class="pull-right text-muted"><i
                                                                class="fa fa-clock-o fa-fw"></i> <%#Eval("Tarih") %></small>
                                                    </div>
                                                    <p>
                                                        <%#Eval("Icerik") %>
                                                    </p>
                                                </div>
                                            </li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                   <%-- <li class="right clearfix"><span class="chat-img pull-right">
                                        <img src="http://placehold.it/50/FA6F57/fff" alt="User Avatar" class="img-circle" />
                                    </span>
                                        <div class="chat-body clearfix">
                                            <div class="header">
                                                <small class=" text-muted"><i class="fa fa-clock-o fa-fw"></i>13 mins ago</small>
                                                <strong class="pull-right primary-font">Bhaumik Patel</strong>
                                            </div>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur bibendum ornare
                                                dolor, quis ullamcorper ligula sodales.
                                            </p>
                                        </div>
                                    </li>
                                    
                                   --%>
                                </ul>
                            </div>
                            <!-- /.panel-body -->
                            <div class="panel-footer">
                                <div class="input-group">
                                    <input id="btn-input" type="text" class="form-control input-sm" placeholder="Type your message here..." />
                                    <span class="input-group-btn">
                                        <button class="btn btn-warning btn-sm" id="btn-chat">
                                            Send
                                        </button>
                                    </span>
                                </div>
                            </div>
                            <!-- /.panel-footer -->
                        </div>
                        <!-- /.panel .chat-panel -->
    <!-- /.panel-body -->
</asp:Content>

