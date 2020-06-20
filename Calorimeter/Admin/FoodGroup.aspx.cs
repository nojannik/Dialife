using BL.Models.Repositories;
using DomainModel.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL.Models.Utility;

namespace Calorimeter.Admin
{
    public partial class FoodGroup : System.Web.UI.Page
    {
        FoodGroupModel fm = new FoodGroupModel();
        FoodGroupRepository fr = new FoodGroupRepository();
        LogError le = new LogError();
        protected void Page_Load(object sender, EventArgs e)
        {

            if ((string.IsNullOrEmpty(Session["RoleName"] as string)) || (Session["RoleName"].ToString() != "Admin"))
            {

                Response.Redirect("~/Login.aspx");
            }
            else
            {
                if (IsPostBack == false)
                {

                    GetData();

                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try {
               // int a = Convert.ToInt32("fff");
                fm.Name = Name.Text.ToString();
                bool res = fr.Insert(fm);
                if (res)
                {
                    string message = "Saving info was successfully";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                    //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                }
                else
                {
                    string message = "Saving info was not successfully";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                }
                GetData();
                addNew.Visible = false;
                showList.Visible = true;
                
            }
            catch(Exception ex)
            {
                le.SaveLogError(ex);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                fm.Name = Name.Text.ToString();
                fm.Id = Convert.ToInt32(FoodGroupId.Text.ToString());
                bool res = fr.Update(fm);
                if (res)
                {
                    string message = "Updating info was successfully";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                    //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                }
                else
                {
                    string message = "Updating info was not successfully";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                }
                GetData();
                addNew.Visible = false;
                showList.Visible = true;
            
            }
            catch(Exception ex)
            {
                le.SaveLogError(ex);
            }
        }

        private void GetData()
        {
            try
            {
                FoodGroupList.DataSource = fr.Select();
                FoodGroupList.DataBind();
            }
            catch(Exception ex)
            {
                le.SaveLogError(ex);
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            addNew.Visible = false;
            showList.Visible = true;
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Name.Text = string.Empty;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            addNew.Visible = true;
            showList.Visible = false;
        }

        protected void FoodGroup_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            fm = new FoodGroupModel();
            int index = Convert.ToInt32(e.CommandArgument);
            fm.Id = Convert.ToInt32(FoodGroupList.Rows[index].Cells[3].Text);

            if (e.CommandName == "DeleteRow")
            {
                //re.Id = Convert.ToInt32(RealEstateList.Rows[index].Cells[3].Text); 
                bool res = fr.Delete(fm);
                if (res)
                {
                    string message = "Deleting info was successfully";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                    //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                }
                else
                {
                    string message = "Deleting info was not successfully";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                }
                GetData();
            }
            if (e.CommandName == "EditRow")
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                addNew.Visible = true;
                showList.Visible = false;
                FoodGroupId.Text = FoodGroupList.Rows[index].Cells[3].Text.ToString();
                Name.Text = FoodGroupList.Rows[index].Cells[4].Text.ToString();



            }
        }

        protected void FoodGroup_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
            {

                e.Row.Cells[3].Visible = false;

            }
        }
    }
}