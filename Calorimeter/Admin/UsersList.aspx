<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminThem.Master" AutoEventWireup="true" CodeBehind="UsersList.aspx.cs" Inherits="Calorimeter.Admin.UsersList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="about">
     <div class="container">
        <div class="card mt-3" style="width: 100%">
            <h5 class="card-header">Foods Group</h5>
            <div class="card-body">
                <asp:panel id="addNew" runat="server" Visible="false">
                     <asp:Label ID="UserId" runat="server" Text="Label" Visible="false"></asp:Label>
             
                      <div class="form-group">
                        <label for="FirstName">FirstName :</label>
                        <asp:TextBox ID="FirstName" runat="server" class="form-control"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="FirstName" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  


                    <div class="form-group">
                        <label for="LastName">LastName :</label>
                        <asp:TextBox ID="LastName" runat="server" class="form-control"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="LastName" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                    <div class="form-group">
                        <label for="BirthDate">BirthDate :</label>
                        <%--<asp:Calendar ID="BirthDate" runat="server" ></asp:Calendar>--%>
                       <asp:TextBox ID="BirthDate" runat="server" class="form-control"></asp:TextBox>

                    </div>  

                    <div class="form-group">
                        <label for="Sex">Gender :</label>
                        <asp:DropDownList ID="SexDropDown" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                    </div>  

                    <div class="form-group">
                        <label for="DiabetesType">DiabetesType :</label>
                        <asp:DropDownList ID="DiabetesTypeDropDown" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                    </div>  

                    <div class="form-group">
                        <label for="Religion">Religion :</label>
                        <asp:DropDownList ID="ReligionDropDown" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                    </div>  

                    <div class="form-group">
                        <label for="CookingLevel">CookingLevel :</label>
                        <asp:DropDownList ID="CookingLevelDropDown" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                    
                    </div>  

                    <div class="form-group">
                        <label for="UserPreferences">UserPreferences :</label><br />
                        <label for="MeatDropDownList">meat :</label>
                        <asp:DropDownList ID="MeatDropDownList" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                        <label for="VegtableDropDownList">vegtable :</label>
                        <asp:DropDownList ID="VegtableDropDownList" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                    </div>  

                    <div class="form-group">
                        <label for="MaximumCalery">Maximum Calorie :</label>
                        <asp:TextBox ID="MaximumCalery" runat="server" class="form-control" TextMode="Number"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="MaximumCalery" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                    <div class="form-group">
                        <label for="Allergy">Allergy :</label>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="egg"/>
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="milk"/>
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="peanut"/>
                        <asp:CheckBox ID="CheckBox4" runat="server" Text="wheat"/>
                        <asp:CheckBox ID="CheckBox5" runat="server" Text="soy"/>
                        <asp:CheckBox ID="CheckBox6" runat="server" Text="fruit"/>
                        <asp:CheckBox ID="CheckBox7" runat="server" Text="corn"/>
                        <asp:CheckBox ID="CheckBox8" runat="server" Text="garlic"/>
                        <asp:CheckBox ID="CheckBox9" runat="server" Text="nut"/>

                        <%--<asp:TextBox ID="Allergy" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>--%>
                         <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="Allergy" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                    </div>  

                    <%--<div class="form-group">
                        <label for="FoodHistory">FoodHistory :</label>
                        <asp:TextBox ID="FoodHistory" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="FoodHistory" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                    <div class="form-group">
                        <label for="SportHistory">SportHistory :</label>
                        <asp:TextBox ID="SportHistory" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="SportHistory" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  --%>

                   <%-- <div class="form-group">
                        <label for="UserName">UserName :</label>
                        <asp:TextBox ID="UserName" runat="server" class="form-control"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="UserName" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                    <div class="form-group">
                        <label for="Password">Password :</label>
                        <asp:TextBox ID="Password" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="Password" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                    <div class="form-group">
                        <label for="ConfirmPassword">Confirm Password :</label>
                        <asp:TextBox ID="ConfirmPassword" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="ConfirmPassword" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div> --%>

                    <div class="form-group">
                        <asp:Button ID="btnSave" runat="server" Text="Save" class="btn btn-primary" OnClick="btnSave_Click" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-primary" OnClick="btnUpdate_Click" CausesValidation="false"/>
                        <asp:Button ID="btnBack" runat="server" Text="Back" class="btn btn-primary" OnClick="btnBack_Click" CausesValidation="false"/>
                    </div>
                </asp:panel>




                   <asp:Panel ID="showList" runat="server">
                    <div class="row">
                        <div class="form-group ml-3">
                            <asp:Button ID="btnNew" runat="server" Text="+" class="btn btn-primary" OnClick="btnNew_Click" />
                        </div>
                    </div>
                    <div class="container">
                        <div class="row">
                            <asp:GridView ID="UsersListGrid" runat="server" CellPadding="5" CellSpacing="5" ForeColor="#333333" GridLines="Horizontal"  style="width: 100%; word-wrap:break-word; table-layout: fixed;" OnRowCommand="UsersList_RowCommand" OnRowDataBound="UsersList_RowDataBound">
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
                </asp:Panel>


            </div>
        </div>
    </div>
        </section>
</asp:Content>
