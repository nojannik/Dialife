<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminThem.Master" AutoEventWireup="true" CodeBehind="Food.aspx.cs" Inherits="Calorimeter.Admin.Food" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="about">
     <div class="container">
        <div class="card mt-3" style="width: 100%">
            <h5 class="card-header">Foods</h5>
            <div class="card-body">
                <asp:panel id="addNew" runat="server" Visible="false">
                     <asp:Label ID="FoodId" runat="server" Text="Label" Visible="false"></asp:Label>
                    <div class="form-group">
                        <label for="FoodGroupDropDown" >FoodGroup:</label>
                        <asp:DropDownList ID="FoodGroupDropDown" runat="server" class="form-control" AutoPostBack="true"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="Name">Name :</label>
                        <asp:TextBox ID="Name" runat="server" class="form-control"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="Name" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                    <div class="form-group">
                        <label for="Calorie">Calorie :</label>
                        <asp:TextBox ID="Calorie" runat="server" class="form-control" TextMode="Number"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="Calorie" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div> 
                    <div class="form-group">
                        <label for="Servings">Servings :</label>
                        <asp:TextBox ID="Servings" runat="server" class="form-control" ></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="Servings" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div> 

                     <div class="form-group">
                        <label for="Calorie">Materials :</label>
                        <asp:TextBox ID="Materials" runat="server" class="form-control"></asp:TextBox>
                    </div> 

                     <div class="form-group">
                        <label for="Recipe">Recipe :</label>
                        <asp:TextBox ID="Recipe" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>
                    </div> 
                      <div class="form-group">
                        <label for="CookingLevel">CookingLevel :</label>
                         <asp:DropDownList ID="CookingLevelDropDown" runat="server" class="form-control" AutoPostBack="true"></asp:DropDownList>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="CookingLevelDropDown" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="ForIslam">ForIslam :</label>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked="true"/>
                    </div>   
                    <div class="form-group">
                        <label for="ForINC">ForINC :</label>
                        <asp:CheckBox ID="CheckBox2" runat="server" Checked="true"/>
                    </div>       
                    <%--<div class="form-group">
                        <label for="NotFriendlyFor">NotFriendlyFor :</label>
                         <asp:DropDownList ID="NotFriendlyForDropDown" runat="server" class="form-control" AutoPostBack="true"></asp:DropDownList>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="NotFriendlyForDropDown" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
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
                            <asp:GridView ID="FoodList" autogeneratecolumns="true" allowpaging="false" runat="server" CellPadding="5" CellSpacing="5" ForeColor="#333333" GridLines="Horizontal"  style="width: 100%; word-wrap:break-word; table-layout: fixed;" 
                                OnRowCommand="Food_RowCommand" OnRowDataBound="Food_RowDataBound" OnPageIndexChanging="SubmitAppraisalGrid_PageIndexChanging">
                                <pagersettings mode="Numeric" position="Bottom" pagebuttoncount="10"/>
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
