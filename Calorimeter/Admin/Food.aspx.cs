using BL.Models.Repositories;
using BL.Models.Utility;
using DomainModel.Models.EntityModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calorimeter.Admin
{
    public partial class Food : System.Web.UI.Page
    {
        FoodModel fm = new FoodModel();
        FoodGroupRepository fgr = new FoodGroupRepository();
        FoodRepository fr = new FoodRepository();
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
                    LoadFoodGroupDropDown();
                    LoadCookingLevelDropDown();
                    LoadNotFriendlyDropDown();
                    GetData();
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try {
                fm.FoodGroupId = Convert.ToInt32(FoodGroupDropDown.SelectedItem.Value);
                fm.CookingLevel = CookingLevelDropDown.SelectedItem.Value;
                //fm.NotFriendly = NotFriendlyForDropDown.SelectedItem.Value;
                fm.Name = Name.Text.ToLower().ToString();
                fm.Calorie = Calorie.Text.ToString();
                fm.Materials = Materials.Text.ToLower().ToString();
                fm.Servings = Servings.Text.ToString();
                fm.Recipe = Recipe.Text.ToLower().ToString();
                fm.IslamUse = CheckBox1.Checked;
                fm.INCUse = CheckBox2.Checked;
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

        public void LoadFoodGroupDropDown()
        {
            FoodGroupDropDown.DataSource = fgr.Select();
            FoodGroupDropDown.DataBind();
            FoodGroupDropDown.DataTextField = "Name";
            FoodGroupDropDown.DataValueField = "Id";
            FoodGroupDropDown.DataBind();
        }

        public void LoadCookingLevelDropDown()
        {

            ArrayList list1 = new ArrayList();
            list1.Add("beginner");
            list1.Add("intermediate");
            list1.Add("expert");
            for (int k = 2; k >= 0; k--)
            {
                CookingLevelDropDown.Items.Add(new ListItem(list1[k].ToString(), list1[k].ToString()));
            }
        }


        public void LoadNotFriendlyDropDown()
        {

            //ArrayList list1 = new ArrayList();
            //list1.Add("Isalm");
            //list1.Add("INC");
            //list1.Add("none");
            //for (int k = 2; k >= 0; k--)
            //{
            //    NotFriendlyForDropDown.Items.Add(new ListItem(list1[k].ToString(), list1[k].ToString()));
            //}
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                fm.Id = Convert.ToInt32(FoodId.Text.ToString());
                fm.FoodGroupId = Convert.ToInt32(FoodGroupDropDown.SelectedItem.Value);
                fm.Name = Name.Text.ToLower().ToString();
                fm.Calorie = Calorie.Text.ToString();
                fm.Materials = Materials.Text.ToLower().ToString();
                fm.Recipe = Recipe.Text.ToLower().ToString();
                fm.Servings = Servings.Text.ToString();
                fm.CookingLevel = CookingLevelDropDown.SelectedItem.Value;
                fm.IslamUse = CheckBox1.Checked;
                fm.INCUse = CheckBox2.Checked;
                // fm.NotFriendly = NotFriendlyForDropDown.SelectedItem.Value;

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
            try {
                FoodList.DataSource = fr.Select();
                FoodList.DataBind();
            }
            catch (Exception ex)
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
            Calorie.Text = string.Empty;
            Materials.Text = string.Empty;
            Recipe.Text = string.Empty;
            Servings.Text = string.Empty;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            addNew.Visible = true;
            showList.Visible = false;
        }

        protected void Food_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            fm = new FoodModel();
            int index = Convert.ToInt32(e.CommandArgument);
            fm.Id = Convert.ToInt32(FoodList.Rows[index].Cells[3].Text);

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
                FoodId.Text = FoodList.Rows[index].Cells[3].Text.ToString();
                Name.Text = FoodList.Rows[index].Cells[4].Text.ToString();
                Calorie.Text = FoodList.Rows[index].Cells[5].Text.ToString();
                Materials.Text = FoodList.Rows[index].Cells[9].Text.ToString();
                Recipe.Text = FoodList.Rows[index].Cells[10].Text.ToString();
                var d = FoodList.Rows[index].Cells[6].Text.ToString();
                FoodGroupDropDown.SelectedValue = FoodGroupDropDown.Items.FindByValue(d).Value;
                var LID = FoodList.Rows[index].Cells[8].Text.ToString();
                CookingLevelDropDown.SelectedValue = CookingLevelDropDown.Items.FindByValue(LID).Value;
                Servings.Text = FoodList.Rows[index].Cells[11].Text.ToString();
                var dr = FoodList.Rows[index].Cells[13].Text.ToString();
               // CheckBox1.Checked =  (FoodList.Rows[index].Cells[13]) as CheckBox;
                CheckBox cbox1 = (CheckBox)FoodList.Rows[index].Cells[12].Controls[0];
                CheckBox1.Checked = cbox1.Checked;
                CheckBox cbox2 = (CheckBox)FoodList.Rows[index].Cells[13].Controls[0];
                CheckBox2.Checked = cbox2.Checked;

                //NotFriendlyForDropDown.SelectedValue = NotFriendlyForDropDown.Items.FindByValue(dr).Value;
            }
        }
        protected void SubmitAppraisalGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            FoodList.PageIndex = e.NewPageIndex;
            FoodList.DataBind();
        }
        protected void Food_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
            {

                e.Row.Cells[3].Visible = false;
                e.Row.Cells[6].Visible = false;
                e.Row.Cells[9].Visible = false;
                e.Row.Cells[10].Visible = false;

            }
        }
    }
}