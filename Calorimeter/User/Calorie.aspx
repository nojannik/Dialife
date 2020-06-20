<%@ Page Title="" Language="C#" MasterPageFile="UserThem.Master" AutoEventWireup="true" CodeBehind="Calorie.aspx.cs" Inherits="Calorimeter.User.Calorie" %>
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

         function txtOnKeyPressActivity(txtt1) {
            txtt3 = document.getElementById('<%= ActivityMetabolismText.ClientID %>');
            txtt2 = document.getElementById('<%= SumMobility.ClientID %>');
            c = parseInt(txtt1.value);
            d = parseInt(txtt3.innerText);       
            txtt2.innerText = (c*d).toString();
        }



    </script><section class="about">
     <div class="container">
        <div class="card mt-3" style="width: 100%">
            <h5 class="card-header">Daily Calorie</h5>
            <div class="card-body">
                <asp:panel id="ShowList" runat="server" >
                    <div class="row">
                         <div class="col-md-6">
                        <div class="form-group">
                        <label for="MyDate">Select Your Date :</label>
                        <asp:Calendar ID="MyDate" runat="server"></asp:Calendar>
                    </div>  
                        <div class="form-group">
                            <asp:Button ID="btnSelect" runat="server" Text="Show" class="btn btn-primary" OnClick="btnSelect_Click" CausesValidation="false"/>
                            <asp:Button ID="btnNew" runat="server" Text="Calorie+" class="btn btn-primary" OnClick="btnNew_Click" />
                            <asp:Button ID="btnNewActivity" runat="server" class="btn btn-primary" OnClick="btnNewActivity_Click" Text="Activity+" />
                        </div>
                    </div>
                         <div class="col-md-6">
                        <%--<p class="mt-5 alert-warning">Sum of the daily Calorie : <asp:Label ID="dailyCalorie" runat="server"></asp:Label></p>--%>
                    </div>
                    </div>
                </asp:panel>




                <asp:panel id="addNew" runat="server"  Visible="false">
                     <asp:Label ID="UserIdTxt" runat="server" Text="Label" Visible="false"></asp:Label>
                     <asp:Label ID="CalorieIdTxt" runat="server" Text="Label" Visible="false"></asp:Label>
                     <asp:Label ID="FoodId" runat="server" Text="Label" Visible="false"></asp:Label>
                    
                     <div class="form-group">
                        <label for="Calender">Calender :</label>
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
                        <label for="Quantity">Quantity :</label>
                        <asp:TextBox ID="Quantity" runat="server" TextMode="Number" class="form-control"  onchange="txtOnKeyPress(this);"></asp:TextBox>
                        <p class="ml-1 mt-2 alert-warning">Your Usage Calorie is : <asp:Label ID="UsageCalorie" runat="server"></asp:Label></p>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="Quantity" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                   

                    <div class="form-group">
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-primary" OnClick="btnUpdate_Click" Visible="false"/>
                        <asp:Button ID="btnSave" runat="server" Text="Save" class="btn btn-primary" OnClick="btnSave_Click" />
                        <asp:Button ID="btnBack" runat="server" Text="Back" class="btn btn-primary" OnClick="btnBack_Click" CausesValidation="false"/>
                    </div>


                  



                </asp:panel>


                <asp:panel id="AddActivity" runat="server"  Visible="false">
                     <asp:Label ID="UserIdActivity" runat="server" Text="Label" Visible="false"></asp:Label>
                     <asp:Label ID="MobilityIdTxt" runat="server" Text="Label" Visible="false"></asp:Label>
                     <asp:Label ID="ActivityId" runat="server" Text="Label" Visible="false"></asp:Label>
                    
                     <div class="form-group">
                        <label for="CalenderActivity">Calender :</label>
                        <asp:Calendar ID="CalenderActivity" runat="server"></asp:Calendar>
                    </div>  

                       <div class="form-group">
                        <label for="ActivitiesDropDown" >Activity:</label>
                        <asp:DropDownList ID="ActivitiesDropDown" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="ActivitiesDropDown_SelectedIndexChanged"></asp:DropDownList>
                         <p class="ml-1 mt-2 alert-warning">Your Activity Metabolism is : <asp:Label ID="ActivityMetabolismText" runat="server"></asp:Label></p>

                       </div>

        
                    <div class="form-group">
                        <label for="Time">Time :</label>
                        <asp:TextBox ID="Time" runat="server" class="form-control"  onchange="txtOnKeyPressActivity(this);"></asp:TextBox>
                        <p class="ml-1 mt-2 alert-warning">Your Mobility is : <asp:Label ID="SumMobility" runat="server"></asp:Label></p>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="Time" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                   

                    <div class="form-group">
                        <asp:Button ID="btnActivityUpdate" runat="server" Text="Update" class="btn btn-primary" OnClick="btnActivityUpdate_Click" Visible="false"/>
                        <asp:Button ID="btnActivitySave" runat="server" Text="Save" class="btn btn-primary" OnClick="btnActivitySave_Click" />
                        <asp:Button ID="btnActivityBack" runat="server" Text="Back" class="btn btn-primary" OnClick="btnActivityBack_Click" CausesValidation="false"/>
                    </div>


                  



                </asp:panel>
               


                <asp:panel id="ListView" runat="server"  Visible="false">
                   <div class="container">
                        <div class="row">
                            <div class="col-md-6">
                                <p class="ml-1 mt-2 alert-warning">Your Sum Calorie is : <asp:Label ID="SumCalorie" runat="server"></asp:Label></p>
                                <asp:GridView ID="CalorieList" runat="server" CellPadding="5" CellSpacing="5" ForeColor="#333333" GridLines="Horizontal"  style="width: 100%; word-wrap:break-word; table-layout: fixed;" OnRowCommand="Calorie_RowCommand" OnRowDataBound="Calorie_RowDataBound">
                                <Columns>
                                    <asp:TemplateField >
                                        <ItemTemplate><%# Container.DataItemIndex + 1 %></ItemTemplate>
                                        <HeaderStyle Width="20px" />
                                    </asp:TemplateField>
                                    <asp:ButtonField CommandName="DeleteRow" Text="Del" >
                                    <HeaderStyle Width="60px" />
                                    </asp:ButtonField>
                                    <asp:ButtonField CommandName="EditRow" Text="Edt" >
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
                            <div class="col-md-6">
                                <p class="ml-1 mt-2 alert-warning">Your Sum Mobility is : <asp:Label ID="SumMobilityTxt" runat="server"></asp:Label></p>
                                <asp:GridView ID="ActivityList" runat="server" CellPadding="5" CellSpacing="5" ForeColor="#333333" GridLines="Horizontal"  style="width: 100%; word-wrap:break-word; table-layout: fixed;" OnRowCommand="Activity_RowCommand" OnRowDataBound="Activity_RowDataBound">
                                <Columns>
                                    <asp:TemplateField >
                                        <ItemTemplate><%# Container.DataItemIndex + 1 %></ItemTemplate>
                                        <HeaderStyle Width="20px" />
                                    </asp:TemplateField>
                                    <asp:ButtonField CommandName="DeleteRow" Text="Del" >
                                    <HeaderStyle Width="60px" />
                                    </asp:ButtonField>
                                    <asp:ButtonField CommandName="EditRow" Text="Edt" >
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
     </section>
</asp:Content>
