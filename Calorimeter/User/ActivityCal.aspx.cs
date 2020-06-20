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
    public partial class ActivityCal : System.Web.UI.Page
    {
        ActivityModel am = new ActivityModel();
        ActivityRepository ar = new ActivityRepository();

        MobilitiesModel mm = new MobilitiesModel();
        MobilitiesRepository mr = new MobilitiesRepository();


        LogError le = new LogError();
        string ActivityMetabolism;
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
                    UserIdTxt.Text = Session["UserId"].ToString();
                    LoadActivitiesDropDown();
                   // GetData();
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try {
                mm.ActivityId = Convert.ToInt32(ActivitiesDropDown.SelectedItem.Value);
                mm.UserId = Convert.ToInt32(UserIdTxt.Text);
                mm.Time = Time.Text.ToString();
                mm.Date = Calender.SelectedDate;
                mm.Mobility = (Convert.ToInt32(Time.Text.ToString())) * (Convert.ToInt32(ActivityMetabolismText.Text.ToString()));
                bool res = mr.Insert(mm);
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
                addNew.Visible = false;
                ShowList.Visible = true;
                ListView.Visible = true;
                MyDate.SelectedDate = mm.Date;
                GetData(Calender.SelectedDate);
                SumMobilityTxt.Text = mr.SelectSumMobility(mm).ToString();
            }
            catch(Exception ex)
            {
                le.SaveLogError(ex);
            }
        }



        public void LoadActivitiesDropDown()
        {

            ActivitiesDropDown.DataSource = ar.Select();
            ActivitiesDropDown.DataBind();
            ActivitiesDropDown.DataTextField = "Name";
            ActivitiesDropDown.DataValueField = "Id";
            ActivitiesDropDown.DataBind();
            ActivitiesDropDown.Items.Insert(0, new ListItem("-- please select --", "0"));

        }



        private void GetData(DateTime dt)
        {
            try {
                mm = new MobilitiesModel();
                mm.Date = dt;
                ActivityList.DataSource = mr.SelectByDate(mm);
                ActivityList.DataBind();
            }
            catch(Exception ex)
            {
                le.SaveLogError(ex);
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            ShowList.Visible = true;
            addNew.Visible = false;
            ListView.Visible = false;
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Calender.SelectedDates.Clear();
            LoadActivitiesDropDown();
            Time.Text = string.Empty;
            ActivityMetabolismText.Text = string.Empty;
            SumMobility.Text = string.Empty;
            ShowList.Visible = false;
            addNew.Visible = true;
            ListView.Visible = false;
            btnSave.Visible = true;
            btnUpdate.Visible = false;

        }

        protected void ActivitiesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            am.Id = Convert.ToInt32(ActivitiesDropDown.SelectedItem.Value);
            ActivityMetabolism = ar.SelectActivity(am);

            // FoodCalorieText.Visible = true;
            //FoodCalorieText.Text = "Food Calorie is :" + FoodCalorie.ToString();
            ActivityMetabolismText.Text = ActivityMetabolism.ToString();

        }

        protected void Activity_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            mm = new MobilitiesModel();
            int index = Convert.ToInt32(e.CommandArgument);
            mm.Id = Convert.ToInt32(ActivityList.Rows[index].Cells[3].Text);

            if (e.CommandName == "DeleteRow")
            {
                bool res = mr.Delete(mm);
                if (res)
                {
                    string message = "Deleting info was successfully";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                }
                else
                {
                    string message = "Deleting info was not successfully";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                }
                if (MyDate.SelectedDate != null)
                {
                    GetData(MyDate.SelectedDate);
                }
                else
                {
                    GetData(Calender.SelectedDate);
                }

            }
            if (e.CommandName == "EditRow")
            {
                MyDate.SelectedDates.Clear();
                addNew.Visible = true;
                ShowList.Visible = false;
                btnUpdate.Visible = true;
                btnSave.Visible = false;
                addNew.Visible = true;
                Time.Text = ActivityList.Rows[index].Cells[6].Text.ToString();
                Calender.SelectedDate = Convert.ToDateTime(ActivityList.Rows[index].Cells[8].Text);
                var ActivityId = ActivityList.Rows[index].Cells[9].Text.ToString();
                ActivitiesDropDown.SelectedValue = ActivitiesDropDown.Items.FindByValue(ActivityId).Value;
                ListView.Visible = false;
                MobilityIdTxt.Text = ActivityList.Rows[index].Cells[3].Text.ToString();
                SumMobility.Text = ActivityList.Rows[index].Cells[7].Text.ToString();
                ActivityMetabolismText.Text = ActivityList.Rows[index].Cells[5].Text.ToString();

            }

        }

        protected void Activity_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
            {

                e.Row.Cells[3].Visible = false;
                e.Row.Cells[9].Visible = false;
                //e.Row.Cells[11].Visible = false;
                //e.Row.Cells[12].Visible = false;

            }
        }

 


    

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            ListView.Visible = true;
            GetData(MyDate.SelectedDate);
            //  MyDate.SelectedDates.Clear();
            mm = new MobilitiesModel();
            mm.Date = MyDate.SelectedDate;
            SumMobilityTxt.Text = mr.SelectSumMobility(mm).ToString();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                mm = new MobilitiesModel();
                mm.ActivityId = Convert.ToInt32(ActivitiesDropDown.SelectedItem.Value);
                mm.Time = Time.Text.ToString();
                mm.Date = Calender.SelectedDate;
                mm.Mobility = (Convert.ToInt32(Time.Text.ToString())) * (Convert.ToInt32(ActivityMetabolismText.Text.ToString()));
                mm.Id = Convert.ToInt32(MobilityIdTxt.Text.ToString());


                bool res = mr.Update(mm);
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
                addNew.Visible = false;
                ShowList.Visible = true;
                ListView.Visible = true;
                MyDate.SelectedDate = mm.Date;
                GetData(mm.Date);
                SumMobilityTxt.Text = mr.SelectSumMobility(mm).ToString();
            }
            catch(Exception ex)
            {
                le.SaveLogError(ex);
            }
        }
    }
}