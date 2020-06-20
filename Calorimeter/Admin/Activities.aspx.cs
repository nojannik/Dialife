using BL.Models.Repositories;
using DomainModel.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calorimeter.Admin
{
    public partial class Activities : System.Web.UI.Page
    {
        ActivityModel am = new ActivityModel();
        ActivityRepository ar = new ActivityRepository();
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
            am.Name = Name.Text.ToString();
            am.Metabolism = Metabolism.Text.ToString();
            bool res = ar.Insert(am);
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            am.Name = Name.Text.ToString();
            am.Metabolism = Metabolism.Text.ToString();
            am.Id = Convert.ToInt32(FoodGroupId.Text.ToString());
            bool res = ar.Update(am);
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

        private void GetData()
        {
            ActivitiesList.DataSource = ar.Select();
            ActivitiesList.DataBind();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            addNew.Visible = false;
            showList.Visible = true;
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Name.Text = string.Empty;
            Metabolism.Text = string.Empty;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            addNew.Visible = true;
            showList.Visible = false;
        }

        protected void Activities_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            am = new ActivityModel();
            int index = Convert.ToInt32(e.CommandArgument);
            am.Id = Convert.ToInt32(ActivitiesList.Rows[index].Cells[3].Text);

            if (e.CommandName == "DeleteRow")
            {
                //re.Id = Convert.ToInt32(RealEstateList.Rows[index].Cells[3].Text); 
                bool res = ar.Delete(am);
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
                FoodGroupId.Text = ActivitiesList.Rows[index].Cells[3].Text.ToString();
                Name.Text = ActivitiesList.Rows[index].Cells[4].Text.ToString();
                Metabolism.Text = ActivitiesList.Rows[index].Cells[5].Text.ToString();



            }
        }

        protected void Activities_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
            {

                e.Row.Cells[3].Visible = false;

            }
        }
    }
}