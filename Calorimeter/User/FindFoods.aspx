<%@ Page Title="" Language="C#" MasterPageFile="UserThem.Master" AutoEventWireup="true" CodeBehind="FindFoods.aspx.cs" Inherits="Calorimeter.User.FindFoods" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="about">
      <div class="container">
        <div class="card mt-3" style="width: 100%">
            <h5 class="card-header">Find Recipe</h5>
            <div class="card-body">
                <asp:Label ID="UserId" runat="server" Text="Label" Visible="false"></asp:Label>
                <div class="form-group">
                     <label for="FoodGroupDropDown" >FoodGroup:</label>
                     <asp:DropDownList ID="FoodGroupDropDown" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="FoodGroupDropDown_SelectedIndexChanged"></asp:DropDownList>
                </div>
                <div class="form-group">
                    <label for="Materials">Ingredients :</label>
                    <asp:TextBox ID="Materials" runat="server" class="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="Materials" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </div> 

                <div class="form-group">
                        <asp:Button ID="btnSave" runat="server" Text="Find" class="btn btn-primary" OnClick="btnSave_Click" />
                      <%--  <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-primary" OnClick="btnUpdate_Click" CausesValidation="false"/>
                        <asp:Button ID="btnBack" runat="server" Text="Back" class="btn btn-primary" OnClick="btnBack_Click" CausesValidation="false"/>--%>
                </div>


               
                <div>
                 

                </div>
            </div>
        </div>
    </div>





      <asp:panel id="FoundedFood" runat="server" >
                     <div class="row">
        <asp:Repeater runat="server" ID="FoodRepeater1" OnItemDataBound="FoodRepeater_ItemDataBound">
            <ItemTemplate>
                <div class="col-md-11" style="border:1px gray solid;padding:35px;background-color:White;margin:0 auto;">
                     
                      <div class="row">
                      <div class="col-md-12">
                           <div class="form-group">
                                    <label style="float: left; font-weight: bold;">FoodGroup :  </label>
                                    <asp:Label ID="Label1" runat="server"  Text='<%# Eval("FoodGroup") %>'></asp:Label>
                           </div>
                      </div>
                                <div class="col-md-12">
                                <div class="form-group" style="border:0px red solid;">
                                    <label style="float: left; font-weight: bold;">FoodName : </label>
                                    <asp:Label ID="Label13" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                                </div>
                                </div>
                         <div class="col-md-12">
                            <div class="form-group">
                                <div class="col-md-12" style="border:0px red solid;">
                                     <label style="float: left; font-weight: bold;margin-left:-15px">Calorie :  </label>

                                     <asp:Label ID="Label15" runat="server" Text='<%# Eval("Calorie") %>'></asp:Label>
                                </div>
                            </div>
                            </div>
                           <div class="col-md-12">
                            <div class="form-group">
                                <div class="col-md-12" style="border:0px red solid;">
                                     <label style="float: left; font-weight: bold;margin-left:-15px">CookingLevel :  </label>

                                     <asp:Label ID="Label2" runat="server" Text='<%# Eval("CookingLevel") %>'></asp:Label>
                                </div>
                            </div>
                            </div>
                           <div class="col-md-12">
                            <div class="form-group">
                                <div class="col-md-12" style="border:0px red solid;">
                                     <label style="float: left; font-weight: bold;margin-left:-15px">Servings :  </label>

                                     <asp:Label ID="Label3" runat="server" Text='<%# Eval("Servings") %>'></asp:Label>
                                </div>
                            </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group" style="border:0px red solid;">
                                   <label style="float: left;font-weight: bold;">Materials :</label>
                                   <asp:Label ID="Label14" runat="server" Text='<%# Eval("Materials") %>'></asp:Label>
                                </div>
                                </div>
                                   <div class="col-md-12">
                                <div class="form-group" style="border:0px red solid;">
                                     <label style="float: left;font-weight: bold;">Recipe :</label>
                                     <asp:Label ID="Label6" runat="server" Text='<%# Eval("Recipe") %>'></asp:Label>
                                </div>
                            </div>

                            

                        </div>
                       
                </div>
            </ItemTemplate>
        </asp:Repeater>
        </div>
    
                </asp:panel>
        </section>
</asp:Content>
