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
    public partial class FoodRecipe : System.Web.UI.Page
    {
        FoodRepository fr = new FoodRepository();
        FoodGroupRepository fgr = new FoodGroupRepository();
        FoodModel fm = new FoodModel();

        LogError le = new LogError();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(Session["RoleName"] as string)) || (Session["RoleName"].ToString() != "User"))
            {

                Response.Redirect("~/Login.aspx");
            }
            else
            {
                if (IsPostBack == false)
                {
                    
                    LoadFoodGroupDropDown();
                }
            }
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "ShowRecipe")
            {
                Label2.Visible = true;
                Label1.Text = e.CommandArgument.ToString();
            }
        }
        public void LoadFoodGroupDropDown()
        {
            try {
                FoodGroupDropDown.DataSource = fgr.Select();
                FoodGroupDropDown.DataBind();
                FoodGroupDropDown.DataTextField = "Name";
                FoodGroupDropDown.DataValueField = "Id";
                FoodGroupDropDown.DataBind();
                FoodGroupDropDown.Items.Insert(0, new ListItem("-- please select --", "0"));
            }
            catch(Exception ex)
            {
                le.SaveLogError(ex);
            }
        }

        protected void FoodGroupDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            fm = new FoodModel();
            fm.FoodGroupId = Convert.ToInt32(FoodGroupDropDown.SelectedItem.Value);
            FoodRecipeList.DataSource = fr.SelectByGroupId(fm);
            FoodRecipeList.DataBind();
          
        }
    }

}