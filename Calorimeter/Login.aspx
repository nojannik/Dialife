<%@ Page Title="" Language="C#" MasterPageFile="~/Them.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Calorimeter.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            
            <div class="card-body">
                 <asp:Panel ID="Panel1" runat="server">
                        
                </asp:Panel>
                <header>
<div class="row">
<div class="twelve columns">
<nav>
<ul>
<li><a href="Default.aspx">Home</a></li>
</ul>
</nav>
</div>
</div>
    
<div class="row">
<div class="one-half column">
                    <asp:Panel ID="addNew" runat="server">
                        <h5 >Login</h5>
                    <div class="form-group">
                        <label for="UserName">UserName :</label>
                        <asp:TextBox ID="UserName" runat="server" class="tb1"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="UserName" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  


                    <div class="form-group">
                        <label for="Password">Password :</label>
                        <asp:TextBox ID="Password" runat="server" class="tb1" TextMode="Password" ></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please fill this field!" ControlToValidate="Password" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </div>  
     
                    <div class="form-group">
                        <asp:Button ID="btnSave" runat="server" Text="Login" class="btn" OnClick="btnLogin_Click" />
                    </div>




                </asp:Panel>
        <div class="row">
</div>

    </div>
    <div class="one-half column">
        
<div class="twelve columns">
<h3>Join Us</h3>
</div>
<p>
<a href="Registration.aspx" class="btn block btn-blue">Register</a>

</p>

</div>
    </div>

</header>





            </div>
</asp:Content>

