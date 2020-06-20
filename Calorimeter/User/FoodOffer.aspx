
<%@ Page Title="" Language="C#" MasterPageFile="UserThem.Master" AutoEventWireup="true" CodeBehind="FoodOffer.aspx.cs" Inherits="Calorimeter.User.FoodOffer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="about">
    <div class="container">
        <div class="card mt-3" style="width: 100%">
    <%--<asp:Label ID="Label2" runat="server" Text="Description" style="font-weight:bold;text-align:center"></asp:Label>--%>
    <asp:Label ID="UserIdTxt" runat="server" Text="Label" Visible="false"></asp:Label>

    <asp:Panel ID="Panel1" runat="server" Visible="false">
	        <div style="width: 100%;min-height: 50px;border: 0px red solid;padding: 10px;"><span style="font-weight:bold;">Ingredients:  </span> <asp:Label ID="RecipeTxt" runat="server" Text=""></asp:Label><br /></div>
        <div style="width: 100%;min-height: 50px;border: 0px red solid;padding: 10px;"><span style="font-weight:bold;">Calorie:  </span> <asp:Label ID="MaterialsTxt" runat="server" Text=""></asp:Label><br /></div>
        <div style="width: 100%;min-height: 50px;border: 0px red solid;padding: 10px;"><span style="font-weight:bold;">Servings:  </span> <asp:Label ID="CookingLevelTxt" runat="server" Text="" ></asp:Label><br /></div>
        <div style="width: 100%;min-height: 50px;border: 0px red solid;padding: 10px;"><span style="font-weight:bold;">Recipe:  </span> <asp:Label ID="ServingsTxt" runat="server" Text="" ></asp:Label><br /></div>
        <div style="width: 100%;min-height: 50px;border: 0px red solid;padding: 10px;"><span style="font-weight:bold;">Difficulty:  </span> <asp:Label ID="CalorieTxt" runat="server" Text="" ></asp:Label><br /></div>
        <%--<div style="width: 100%;min-height: 50px;border: 0px red solid;padding: 10px;"><span style="font-weight:bold;">NotFriendlyFor:  </span> <asp:Label ID="NotFriendlyTxt" runat="server" Text="" ></asp:Label><br /></div>--%>

         <div style="width: 100%;min-height: 50px;border: 0px red solid;padding: 10px;"><asp:Label ID="IdTxt" runat="server" Text="" Visible="false"></asp:Label></div>


      <%--  <table style="margin-top:20px;">
             <tr>
                <td></td>
                <td>
                    <asp:Label ID="IdTxt" runat="server" Text="" Visible="false"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="font-weight:bold">Servings:</td>
                <td>
                    <asp:Label ID="ServingssTxt" runat="server" Text="" Visible="false"></asp:Label>
                </td>
            </tr>
            <tr></tr>
            <tr>
                <td style="font-weight:bold">Materials:</td>
                <td>
                    <asp:Label ID="MaterialsTxt" runat="server" Text=""></asp:Label>
                </td>
            </tr>
             <tr>
                <td style="font-weight:bold">Recipe:</td>
                <td>
                    <asp:Label ID="RecipeTxt" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>--%>
    </asp:Panel>

    <table class="table table-bordered" id="dietplan-css">
        <thead>
            <tr>
                <th>Days of Week</th>
                <th>Breakfast</th>
                <th>Lunch</th>
                <th>Dinner</th>
                <th>Total</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Saturday"></asp:Label>
                </td>
                <td>
                    <%--<asp:Label ID="b0" runat="server" Text=""></asp:Label>--%>
                    <asp:LinkButton ID="SatB0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="SatB1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    <asp:LinkButton ID="SatB2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
   
                  
                </td>
                <td>
                    <%--<asp:Label ID="d0" runat="server" Text=""></asp:Label>--%>
                     <asp:LinkButton ID="SatL0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="SatL1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="SatL2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="SatL3" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <%--<asp:Label ID="l0" runat="server" Text=""></asp:Label>--%>
                     <asp:LinkButton ID="SatD0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="SatD1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="SatD2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>

                <td>
                    <asp:Label ID="TotalSat" runat="server" Text="" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Sunday</td>
                
                <td>
                    <%--<asp:Label ID="b0" runat="server" Text=""></asp:Label>--%>
                     <asp:LinkButton ID="SunB0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="SunB1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="SunB2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <%--<asp:Label ID="d0" runat="server" Text=""></asp:Label>--%>
                     <asp:LinkButton ID="SunL0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="SunL1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="SunL2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="SunL3" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <%--<asp:Label ID="l0" runat="server" Text=""></asp:Label>--%>
                     <asp:LinkButton ID="SunD0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="SunD1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="SunD2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <asp:Label ID="TotalSun" runat="server" Text="" ></asp:Label>
                </td>


            </tr>
            <tr>
                <td>
                    Monday</td>
               
                   <td>
                    <%--<asp:Label ID="b0" runat="server" Text=""></asp:Label>--%>
                    <asp:LinkButton ID="MonB0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    |<asp:LinkButton ID="MonB1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    <asp:LinkButton ID="MonB2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <%--<asp:Label ID="d0" runat="server" Text=""></asp:Label>--%>
                     <asp:LinkButton ID="MonL0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="MonL1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="MonL2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="MonL3" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <%--<asp:Label ID="l0" runat="server" Text=""></asp:Label>--%>
                    <asp:LinkButton ID="MonD0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="MonD1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="MonD2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <asp:Label ID="TotalMon" runat="server" Text="" ></asp:Label>
                </td>


            </tr>
            <tr>
                <td>
                    Tuesday</td>
               
                   <td>
                    <%--<asp:Label ID="b0" runat="server" Text=""></asp:Label>--%>
                    <asp:LinkButton ID="TuesB0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="TuesB1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="TuesB2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <%--<asp:Label ID="d0" runat="server" Text=""></asp:Label>--%>
                     <asp:LinkButton ID="TuesL0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="TuesL1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="TuesL2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="TuesL3" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <%--<asp:Label ID="l0" runat="server" Text=""></asp:Label>--%>
                    <asp:LinkButton ID="TuesD0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="TuesD1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="TuesD2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <asp:Label ID="TotalTue" runat="server" Text="" ></asp:Label>
                </td>

            </tr>
            
            <tr>
                <td>
                    Wednesday</td>
               


                   <td>
                    <%--<asp:Label ID="b0" runat="server" Text=""></asp:Label>--%>
                    <asp:LinkButton ID="WedB0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="WedB1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="WedB2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <%--<asp:Label ID="d0" runat="server" Text=""></asp:Label>--%>
                     <asp:LinkButton ID="WedL0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="WedL1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="WedL2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="WedL3" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <%--<asp:Label ID="l0" runat="server" Text=""></asp:Label>--%>
                     <asp:LinkButton ID="WedD0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="WedD1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="WedD2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <asp:Label ID="TotalWed" runat="server" Text="" ></asp:Label>
                </td>



            </tr>
            <tr>
                <td>
                    Thursday</td>
               

                   <td>
                    <%--<asp:Label ID="b0" runat="server" Text=""></asp:Label>--%>
                    <asp:LinkButton ID="ThursB0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="ThursB1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="ThursB2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <%--<asp:Label ID="d0" runat="server" Text=""></asp:Label>--%>
                     <asp:LinkButton ID="ThursL0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="ThursL1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="ThursL2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="ThursL3" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <%--<asp:Label ID="l0" runat="server" Text=""></asp:Label>--%>
                    <asp:LinkButton ID="ThursD0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="ThursD1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    <asp:LinkButton ID="ThursD2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <asp:Label ID="TotalThurs" runat="server" Text="" ></asp:Label>
                </td>



            </tr>
             <tr>
                <td>
                    Friday</td>
               

                    <td>
                    <%--<asp:Label ID="b0" runat="server" Text=""></asp:Label>--%>
                    <asp:LinkButton ID="FriB0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="FriB1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="FriB2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <%--<asp:Label ID="d0" runat="server" Text=""></asp:Label>--%>
                     <asp:LinkButton ID="FriL0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="FriL1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="FriL2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="FriL3" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                <td>
                    <%--<asp:Label ID="l0" runat="server" Text=""></asp:Label>--%>
                    <asp:LinkButton ID="FriD0" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                    | <asp:LinkButton ID="FriD1" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                     <asp:LinkButton ID="FriD2" runat="server" OnClientClick="MyFunction(test); return false;"   style="color:black;"   onclick="LinkButton2_Click" ForeColor="#FF0066" ></asp:LinkButton>
                  
                </td>
                 <td>
                    <asp:Label ID="TotalFri" runat="server" Text="" ></asp:Label>
                </td>



            </tr>
        </tbody>
    </table>


     <div class="form-group">
        <asp:Button ID="btnSave" runat="server" Text="Save" class="btn btn-primary"   OnClick="btnSave_Click"/>
     </div>



        </div>
        </div>
        </section>
</asp:Content>
