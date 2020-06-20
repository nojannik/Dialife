<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="UserThem.Master" CodeBehind="FindFood.aspx.cs" Inherits="Calorimeter.User.FindFood" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="card mt-3" style="width: 100%">
            <h5 class="card-header">Find Foods</h5>
            <div class="card-body">
                <asp:panel id="addNew" runat="server" >
                  
                      <div class="form-group">
                        <label for="Materials">Materials :</label>
                        <asp:TextBox ID="Materials" runat="server" class="form-control"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="Materials" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                      </div>  

                    <div class="form-group">
                        <asp:Button ID="btnSave" runat="server" Text="Find" class="btn btn-primary" OnClick="btnSave_Click" />
                      <%--  <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-primary" OnClick="btnUpdate_Click" CausesValidation="false"/>
                        <asp:Button ID="btnBack" runat="server" Text="Back" class="btn btn-primary" OnClick="btnBack_Click" CausesValidation="false"/>--%>
                    </div>
                </asp:panel>
                <asp:panel id="FoundedFood" runat="server" >
                     <div class="row">
        <asp:Repeater runat="server" ID="FoodRepeater1" OnItemDataBound="FoodRepeater_ItemDataBound">
            <ItemTemplate>
                <div class="col-md-12" style="border:1px gray solid;padding:35px;background-color:White;">
                     
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



            </div>
        </div>
    </div>
</asp:Content>

