using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Models.Repositories;
using BL.Models.Utility;
using DomainModel.Models.EntityModel;
using System.Data;

namespace Calorimeter.User
{
    public partial class PinBoard : System.Web.UI.Page
    {
        RegistrationRepository rr = new RegistrationRepository();
        RegistrationModel rm = new RegistrationModel();
        FoodModel fm = new FoodModel();
        PinboardModel pbM = new PinboardModel();
        PinboardRepository pbR = new PinboardRepository();
        
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
                    
                    UserId.Text = Session["UserId"].ToString();
                    rm.Id = Convert.ToInt32(Session["UserId"]);
                }
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
        public void LoadFoodGroupDropDown()
        {
            try
            {
                FoodGroupDropDown.DataSource = fgr.Select();
                FoodGroupDropDown.DataBind();
                FoodGroupDropDown.DataTextField = "Name";
                FoodGroupDropDown.DataValueField = "Id";
                FoodGroupDropDown.DataBind();
                FoodGroupDropDown.Items.Insert(0, new ListItem("-- please select --", "0"));
            }
            catch (Exception ex)
            {
                le.SaveLogError(ex);
            }
        }
        public void LoadFoodGroupDropDown()
        {
            try
            {
                FoodGroupDropDown.DataSource = fgr.Select();
                FoodGroupDropDown.DataBind();
                FoodGroupDropDown.DataTextField = "Name";
                FoodGroupDropDown.DataValueField = "Id";
                FoodGroupDropDown.DataBind();
                FoodGroupDropDown.Items.Insert(0, new ListItem("-- please select --", "0"));
            }
            catch (Exception ex)
            {
                le.SaveLogError(ex);
            }
        }
    }
}