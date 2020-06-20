<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="UserThem.Master" CodeBehind="FoodRecipe.aspx.cs" Inherits="Calorimeter.User.FoodRecipe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="card mt-3" style="width: 100%">
            <h5 class="card-header">Find Recipe</h5>
            <div class="card-body">
                <div class="form-group">
                     <label for="FoodGroupDropDown" >FoodGroup:</label>
                     <asp:DropDownList ID="FoodGroupDropDown" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="FoodGroupDropDown_SelectedIndexChanged"></asp:DropDownList>
                </div>

                <asp:panel id="addNew" runat="server" >
                    <div class="row">
                        <div class="col-md-3">
                               <%--<ul style="background-color:#fff;">--%>
                         
                     <asp:Repeater runat="server" ID="FoodRecipeList">
            <ItemTemplate>

                    <%--<li>--%>
                       <%--<asp:Label ID="Label1" runat="server"  Text='<%# Eval("Name") %>'></asp:Label>--%>
                       <asp:LinkButton ID="LinkButton1" runat="server" OnCommand="LinkButton1_Command" CommandName="ShowRecipe" CommandArgument='<%# Eval("Recipe") %>' style="display:block;color:#000"> <%# Eval("Name") %> </asp:LinkButton>
                    <%--</li>--%>


                       
                       
                
            </ItemTemplate>
        </asp:Repeater>
                         <%--</ul>--%>
                        </div>
                        <div class="col-md-9 " style="margin-left:-20px;">
                             <h5><asp:Label ID="Label2" runat="server" Visible="false">Food Recipe is:</asp:Label></h5>
                             <asp:Label ID="Label1" runat="server" ></asp:Label>
                        </div>
                    </div>
                  
                </asp:panel>
                <div>
                 

                </div>
            </div>
        </div>
    </div>
                           
</asp:Content>



