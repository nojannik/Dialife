<%@ Page Title="" Language="C#" MasterPageFile="UserThem.Master" AutoEventWireup="true" CodeBehind="CalorieCal.aspx.cs" Inherits="Calorimeter.User.CalorieCal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function txtOnKeyPress(txt1) {
            txt3 = document.getElementById('<%= FoodCalorieText.ClientID %>');
            txt2 = document.getElementById('<%= UsageCalorie.ClientID %>');
            a = parseInt(txt1.value);
            b = parseInt(txt3.innerText);       
            txt2.innerText = (a*b).toString();
        }
    </script>
     <div class="container">
        <div class="card mt-3" style="width: 100%">
            <h5 class="card-header">Foods</h5>
            <div class="card-body">
                <asp:panel id="ShowList" runat="server" >
                     <div class="form-group">
                        <label for="MyDate">Select the Date :</label>
                        <asp:Calendar ID="MyDate" runat="server"></asp:Calendar>
                    </div>  
                    <div class="form-group">
                        <asp:Button ID="btnSelect" runat="server" Text="Show" class="btn btn-primary" OnClick="btnSelect_Click" CausesValidation="false"/>
                        <asp:Button ID="btnNew" runat="server" Text="+" class="btn btn-primary" OnClick="btnNew_Click" />

                    </div>
                </asp:panel>




                <asp:panel id="addNew" runat="server"  Visible="false">
                     <asp:Label ID="UserIdTxt" runat="server" Text="Label" Visible="false"></asp:Label>
                     <asp:Label ID="CalorieIdTxt" runat="server" Text="Label" Visible="false"></asp:Label>
                     <asp:Label ID="FoodId" runat="server" Text="Label" Visible="false"></asp:Label>
                    
                     <div class="form-group">
                        <label for="Calender">Calendar :</label>
                        <asp:Calendar ID="Calender" runat="server"></asp:Calendar>
                    </div>  

                       <div class="form-group">
                        <label for="FoodGroupDropDown" >FoodGroup:</label>
                        <asp:DropDownList ID="FoodGroupDropDown" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="FoodGroupDropDown_SelectedIndexChanged"></asp:DropDownList>
                    </div>

                    <div class="form-group">
                        <label for="FoodDropDown" >Food:</label>
                        <asp:DropDownList ID="FoodDropDown" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="FoodDropDown_SelectedIndexChanged"></asp:DropDownList>
                         <p class="ml-1 mt-2 alert-warning">Your Food Calorie is : <asp:Label ID="FoodCalorieText" runat="server"></asp:Label></p>
                    </div>
                    <div class="form-group">
                        <label for="Quantity">Portion :</label>
                        <asp:TextBox ID="Quantity" runat="server" class="form-control" TextMode="Number"  onchange="txtOnKeyPress(this);"></asp:TextBox>
                        <p class="ml-1 mt-2 alert-warning">Your Usage Calorie is : <asp:Label ID="UsageCalorie" runat="server"></asp:Label></p>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="Quantity" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                   

                    <div class="form-group">
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-primary" OnClick="btnUpdate_Click" Visible="false"/>
                        <asp:Button ID="btnSave" runat="server" Text="Save" class="btn btn-primary" OnClick="btnSave_Click" />
                        <asp:Button ID="btnBack" runat="server" Text="Back" class="btn btn-primary" OnClick="btnBack_Click" CausesValidation="false"/>
                    </div>


                  



                </asp:panel>


                  <asp:panel id="ListView" runat="server"  Visible="false">
                   <div class="container">
                        <div class="row">
                        
                            <p class="ml-1 mt-2 alert-warning">The total Calorie is : <asp:Label ID="SumCalorie" runat="server"></asp:Label></p>
                            <asp:GridView ID="CalorieList" runat="server" CellPadding="5" CellSpacing="5" ForeColor="#333333" GridLines="Horizontal"  style="width: 100%; word-wrap:break-word; table-layout: fixed;" OnRowCommand="Calorie_RowCommand" OnRowDataBound="Calorie_RowDataBound">
                                <Columns>
                                    <asp:TemplateField >
                                        <ItemTemplate><%# Container.DataItemIndex + 1 %></ItemTemplate>
                                        <HeaderStyle Width="20px" />
                                    </asp:TemplateField>
                                    <asp:ButtonField CommandName="DeleteRow" Text="Delete" >
                                    <HeaderStyle Width="60px" />
                                    </asp:ButtonField>
                                    <asp:ButtonField CommandName="EditRow" Text="Edit" >
                                    <HeaderStyle Width="60px" />
                                    </asp:ButtonField>
                                </Columns>
                                <AlternatingRowStyle BackColor="White" />
                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                <SortedDescendingHeaderStyle BackColor="#4870BE" />

                            </asp:GridView>
                            
                        </div>
                    </div>
                      </asp:panel>


          <%--      <asp:Panel ID="showList" runat="server">
                    <div class="row">
                        <%--<div class="form-group ml-3">
                            <asp:Button ID="btnNew" runat="server" Text="+" class="btn btn-primary" OnClick="btnNew_Click" />
                        </div>--%>
                   <%--   </div>
                   
                </asp:Panel>--%>


            </div>
        </div>
    </div>
</asp:Content>
