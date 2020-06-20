using BL.Models.Repositories;
using BL.Models.Utility;
using DomainModel.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calorimeter.User
{
    public partial class FindFood : System.Web.UI.Page
    {
        FoodModel fm = new FoodModel();
        FoodRepository fr = new FoodRepository();

        LogError le = new LogError();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(Session["RoleName"] as string)) || (Session["RoleName"].ToString() != "User"))
            {

                Response.Redirect("~/Login.aspx");
            }
            else
            {
                
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try {
                fm = new FoodModel();
                fm.Materials = Materials.Text.ToString();
                fr = new FoodRepository();
                FoodRepeater1.DataSource = fr.FindFood(fm);
                FoodRepeater1.DataBind();
                Materials.Text = string.Empty;
            }
            catch(Exception ex)
            {
                le.SaveLogError(ex);
            }


        }

        protected void FoodRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }
    }
}