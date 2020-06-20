<%@ Page Title="" Language="C#" MasterPageFile="UserThem.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Calorimeter.User.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="about">
   <div class="container">

        <div class="card mt-3" style="width: 100%">

            
            <div class="inner-body">
                 <asp:Label ID="UserId" runat="server" Text="Label" Visible="false"></asp:Label>
                 <asp:Panel ID="addNew" runat="server">
                
           
                     <h5>Profile</h5>

                    <div class="form-group">
                        <label for="FirstName">First Name :</label>
                        <asp:TextBox ID="FirstName" runat="server" class="form-control"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="FirstName" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  


                    <div class="form-group">
                        <label for="LastName">Last Name :</label>
                        <asp:TextBox ID="LastName" runat="server" class="form-control"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="LastName" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                    <div class="form-group">
                        <label for="BirthDate">Age :</label>
                        <%--<asp:Calendar ID="BirthDate" runat="server" ></asp:Calendar>--%>
                       <asp:TextBox ID="BirthDate" runat="server" class="form-control"></asp:TextBox>

                    </div>  

                    <div class="form-group">
                        <label for="Sex">Sex :</label>
                        <asp:DropDownList ID="SexDropDown" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                    </div>  

                    <div class="form-group">
                        <label for="DiabetesType">Diabetes Type :</label>
                        <asp:DropDownList ID="DiabetesTypeDropDown" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                    </div>  

                    <div class="form-group">
                        <label for="Religion">Religion :</label>
                        <asp:DropDownList ID="ReligionDropDown" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                    </div>  

                    <div class="form-group">
                        <label for="CookingLevel">Cooking Level :</label>
                        <asp:DropDownList ID="CookingLevelDropDown" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                    
                    </div>  

                    <div class="form-group">
                        <label for="UserPreferences">Preferences :</label><br />
                        <label for="MeatDropDownList">Meat :</label>
                        <asp:DropDownList ID="MeatDropDownList" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                        <label for="VegtableDropDownList">Vegetable :</label>
                        <asp:DropDownList ID="VegtableDropDownList" runat="server" class="form-control" AutoPostBack="true" ></asp:DropDownList>
                    </div>  

                    <div class="form-group">
                        <label for="MaximumCalery">Maximum Calorie :</label>
                        <asp:TextBox ID="MaximumCalery" runat="server" class="form-control" TextMode="Number"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="MaximumCalery" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                    <div class="form-group">
                        <label for="Allergy">Allergies :</label>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="eggs"/>
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

                  

                    
                    <div class="form-group">
                        <asp:Button ID="btnSave" runat="server" Text="Update" class="btn btn-primary" OnClick="btnSave_Click" />
                    </div>
                     
                </asp:Panel>
            </div>
        </div>
    </div>
    </section>
</asp:Content>
