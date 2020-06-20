<%@ Page Title="" Language="C#" MasterPageFile="~/Them.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Calorimeter.Registration" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="card mt-3" style="width: 100%">
            <div class="row">
<div class="twelve columns">
<nav>
<ul>
<li><a href="Default.aspx">Home</a></li>
    <li><a href="Login.aspx">Login</a></li>
</ul>
</nav>
</div>
</div>
            <asp:Panel ID="addNew" runat="server">
                    <header>


                    <div class="row">
                        <div class="one-half column">

                    
                
                    <div class="form-group">
                        <label for="FirstName">First name :</label>
                        <asp:TextBox ID="FirstName" runat="server" class="input"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="FirstName" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  


                    <div class="form-group">
                        <label for="LastName">Last name :</label>
                        <asp:TextBox ID="LastName" runat="server" class="input"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="LastName" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                    <div class="form-group">
                        <label for="BirthDate">Age :</label>
                       <asp:TextBox ID="BirthDate" runat="server" class="input"></asp:TextBox>

                    </div>  

                    <div class="form-group">
                        <label for="Sex">Gender :</label>
                        <asp:DropDownList ID="SexDropDown" runat="server" class="input" AutoPostBack="true" ></asp:DropDownList>
                    </div>  

                    <div class="form-group">
                        <label for="DiabetesType">Diabetes type :</label>
                        <asp:DropDownList ID="DiabetesTypeDropDown" runat="server" class="input" AutoPostBack="true" ></asp:DropDownList>
                    </div>  

                    <div class="form-group">
                        <label for="Religion">Religion :</label>
                        <asp:DropDownList ID="ReligionDropDown" runat="server" class="input" AutoPostBack="true" ></asp:DropDownList>
                    </div>
                    </div>

                    <div class="one-half column">


                    <div class="form-group">
                        <label for="CookingLevel">Cooking level :</label>
                        <asp:DropDownList ID="CookingLevelDropDown" runat="server" class="input" AutoPostBack="true" ></asp:DropDownList>
                    
                    </div>  

                    <div class="form-group">
                        <label for="UserPreferences">UserPreferences :</label><br />
                        <label for="MeatDropDownList">meat :</label>
                        <asp:DropDownList ID="MeatDropDownList" runat="server" class="input" AutoPostBack="true" ></asp:DropDownList>
                        <label for="VegtableDropDownList">vegtable :</label>
                        <asp:DropDownList ID="VegtableDropDownList" runat="server" class="input" AutoPostBack="true" ></asp:DropDownList>
                    </div>  

                    <div class="form-group">
                        <label for="MaximumCalery">Maximum calorie (you're allowed to intake a day) :</label>
                        <asp:TextBox ID="MaximumCalery" runat="server" class="input" TextMode="Number"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="MaximumCalery" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                   <div style="margin-left: 25px;">
                        <label for="Allergy">Allergies :</label>
                        <p>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="egg" style="float: right; margin-left: 10px;"/>
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="milk" style="float: right; margin-left: 10px;"/>
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="peanut" style="float: right; margin-left: 10px;"/>
                        <asp:CheckBox ID="CheckBox4" runat="server" Text="wheat" style="float: right; margin-left: 10px;"/>
                        <asp:CheckBox ID="CheckBox5" runat="server" Text="soy" style="float: right; margin-left: 10px;"/>
                        <asp:CheckBox ID="CheckBox6" runat="server" Text="fish" style="float: right; margin-left: 10px;"/>
                        <asp:CheckBox ID="CheckBox7" runat="server" Text="corn" style="float: right; margin-left: 10px;"/>
                        <asp:CheckBox ID="CheckBox8" runat="server" Text="shellfish" style="float: right; margin-left: 10px;"/>
                        <asp:CheckBox ID="CheckBox9" runat="server" Text="nut" style="float: right; margin-left: 10px;"/>
                        </p>
                            </div>
                        </div>
                        </div>
                            <div class="one-half column">
        


                    <div class="form-group">
                        <label for="UserName">Username :</label>
                        <asp:TextBox ID="UserName" runat="server" class="input"></asp:TextBox>
                        
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="UserName" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  

                    <div class="form-group">
                        <label for="Password">Password :</label>
                        <asp:TextBox ID="Password" runat="server" class="input" TextMode="Password"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="Password" Font-Bold="True" ForeColor="Red" SetFocusOnError="True">
                            
                         </asp:RequiredFieldValidator>
                        
                    </div>  

                    <div class="form-group">
                        <label for="ConfirmPassword">Confirm Password :</label>
                        <asp:TextBox ID="ConfirmPassword" runat="server" class="input" TextMode="Password"></asp:TextBox>
                         
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="ConfirmPassword" Font-Bold="True" ForeColor="Red" SetFocusOnError="True">
                        </asp:RequiredFieldValidator>
                        
                    </div> 


                    
                    <div class="form-group">
                        <asp:Button ID="btnSave" runat="server" Text="Register" class="btn btn-primary" OnClick="btnSave_Click" />
                    </div>
                        </div>
                        
     </header>
                </asp:Panel>
            </div>
        
</asp:Content>
