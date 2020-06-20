using BL.Models.Repositories;
using DomainModel.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calorimeter
{
    public partial class Login : System.Web.UI.Page
    {
        RegistrationRepository rr = new RegistrationRepository();
        RegistrationModel rm = new RegistrationModel();
        DataTable dt = new DataTable();
        string UserNameStr, PasswordStr;
        int UserId;
        int RowCount;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserNameStr = "";
            PasswordStr = "";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            dt = rr.Select();
            RowCount = dt.Rows.Count;
            for (int i = 0; i < RowCount; i++)
            {
                UserNameStr = dt.Rows[i]["UserName"].ToString();
                PasswordStr = dt.Rows[i]["Password"].ToString();
                UserId = Convert.ToInt32(dt.Rows[i]["Id"]);
                if (UserNameStr == UserName.Text && PasswordStr == Password.Text)
                {

                    if (Convert.ToInt32(dt.Rows[i]["RoleId"]) == 1)
                    {
                        Session["RoleName"] = "Admin";
                        Response.Redirect("~/Admin/Admin.aspx");
                    }
                    else if (Convert.ToInt32(dt.Rows[i]["RoleId"]) == 2)
                    {
                        Session["RoleName"] = "User";
                        Session["UserId"] = UserId;
                        Response.Redirect("~/User/User.aspx");
                    }
                       
                }
                //else
                //{
                //    // lb1.Text = "Invalid User Name or Password! Please try again!";
                //    Response.Redirect("~/Login.aspx");
                //}
            }
        }
    }
}