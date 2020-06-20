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
    public partial class Calorie : System.Web.UI.Page
    {
        CaloriesModel cm = new CaloriesModel();
        CaloriesRepository cr = new CaloriesRepository();
        FoodRepository fr = new FoodRepository();
        FoodGroupRepository fgr = new FoodGroupRepository();
        FoodModel fm = new FoodModel();




        ActivityModel am = new ActivityModel();
        ActivityRepository ar = new ActivityRepository();

        MobilitiesModel mm = new MobilitiesModel();
        MobilitiesRepository mr = new MobilitiesRepository();

        LogError le = new LogError();


        string ActivityMetabolism;
        string FoodCalorie;
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
                    UserIdActivity.Text = Session["UserId"].ToString();
                    LoadFoodGroupDropDown();
                    LoadActivitiesDropDown();
                    // GetData();
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try {
                if ((Calender.SelectedDate == Convert.ToDateTime("1 / 1 / 0001 12:00:00 AM")) || (FoodGroupDropDown.SelectedItem.Value == "0") || (FoodDropDown.SelectedItem.Value == "0"))
                {
                    string message = "Please fill all items!";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                    //Scr
                }
                else
                {
                    cm = new CaloriesModel();
                    cm.FoodId = Convert.ToInt32(FoodDropDown.SelectedItem.Value);
                    cm.UserId = Convert.ToInt32(UserIdTxt.Text);
                    cm.Quantity = Quantity.Text.ToString();
                    cm.Date = Calender.SelectedDate;
                    cm.Calorie = (Convert.ToInt32(Quantity.Text.ToString())) * (Convert.ToInt32(FoodCalorieText.Text.ToString()));
                    bool res = cr.Insert(cm);
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
                    MyDate.SelectedDate = cm.Date;
                    GetData(Calender.SelectedDate);
                    GetDataActivity(Calender.SelectedDate);
                    SumCalorie.Text = cr.SelectSumCalorie(cm).ToString();
                    //dailyCalorie.Text = (Convert.ToInt32(SumCalorie.Text) - Convert.ToInt32(SumMobilityTxt.Text)).ToString();
                }

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
            FoodGroupDropDown.Items.Insert(0, new ListItem("-- please select --", "0"));

        }



        private void GetData(DateTime dt)
        {
            try {
                cm = new CaloriesModel();
                cm.Date = dt;
                cm.UserId = Convert.ToInt32(UserIdTxt.Text);
                CalorieList.DataSource = cr.SelectByDate(cm);
                CalorieList.DataBind();
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
            LoadFoodGroupDropDown();
            Quantity.Text = string.Empty;
            FoodCalorieText.Text = string.Empty;
            UsageCalorie.Text = string.Empty;
            ShowList.Visible = false;
            addNew.Visible = true;
            ListView.Visible = false;
            btnSave.Visible = true;
            btnUpdate.Visible = false;

        }


        protected void btnNewActivity_Click(object sender, EventArgs e)
        {
            CalenderActivity.SelectedDates.Clear();
            LoadActivitiesDropDown();
            Time.Text = string.Empty;
            ActivityMetabolismText.Text = string.Empty;
            SumMobility.Text = string.Empty;
            ShowList.Visible = false;
            addNew.Visible = false;
            AddActivity.Visible = true;
            ListView.Visible = false;
            btnActivitySave.Visible = true;
            btnActivityUpdate.Visible = false;
        }

        protected void FoodDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            fm.Id = Convert.ToInt32(FoodDropDown.SelectedItem.Value);
            FoodCalorie = fr.SelectCalorie(fm);

           // FoodCalorieText.Visible = true;
            //FoodCalorieText.Text = "Food Calorie is :" + FoodCalorie.ToString();
            FoodCalorieText.Text = FoodCalorie.ToString();

        }

        protected void Calorie_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            cm = new CaloriesModel();
            int index = Convert.ToInt32(e.CommandArgument);
            cm.Id = Convert.ToInt32(CalorieList.Rows[index].Cells[3].Text);

            if (e.CommandName == "DeleteRow")
            {
                bool res = cr.Delete(cm);
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
                Quantity.Text = CalorieList.Rows[index].Cells[7].Text.ToString();
                Calender.SelectedDate = Convert.ToDateTime(CalorieList.Rows[index].Cells[9].Text);
                var foodGroupId = CalorieList.Rows[index].Cells[11].Text.ToString();
                FoodGroupDropDown.SelectedValue = FoodGroupDropDown.Items.FindByValue(foodGroupId).Value;
                LoadFoodDropDown(Convert.ToInt32(foodGroupId));
                var foodId = CalorieList.Rows[index].Cells[10].Text.ToString();
                FoodDropDown.SelectedValue = FoodDropDown.Items.FindByValue(foodId).Value;
                ListView.Visible = false;
                CalorieIdTxt.Text = CalorieList.Rows[index].Cells[3].Text.ToString();
                UsageCalorie.Text = CalorieList.Rows[index].Cells[8].Text.ToString();
                FoodCalorieText.Text = CalorieList.Rows[index].Cells[12].Text.ToString();

            }

        }

        protected void Calorie_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
            {

                e.Row.Cells[3].Visible = false;
                e.Row.Cells[9].Visible = false;
                e.Row.Cells[10].Visible = false;
                e.Row.Cells[11].Visible = false;
                e.Row.Cells[12].Visible = false;

            }
        }

        protected void FoodGroupDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            fm = new FoodModel();
            fm.FoodGroupId = Convert.ToInt32(FoodGroupDropDown.SelectedItem.Value);
            FoodDropDown.DataSource = fr.SelectByGroupId(fm);
            FoodDropDown.DataBind();
            FoodDropDown.DataTextField = "Name";
            FoodDropDown.DataValueField = "Id";
            FoodDropDown.DataBind();
            FoodDropDown.Items.Insert(0, new ListItem("-- please select --", "0"));

        }


        public void LoadFoodDropDown(int GroupId)
        {


            fm.FoodGroupId = GroupId;
            FoodDropDown.DataSource = fr.SelectByGroupId(fm);
            FoodDropDown.DataBind();
            FoodDropDown.DataTextField = "Name";
            FoodDropDown.DataValueField = "Id";
            FoodDropDown.DataBind();

        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            try {
                ListView.Visible = true;
                cm = new CaloriesModel();
                cm.Date = MyDate.SelectedDate;
                GetData(MyDate.SelectedDate);
                SumCalorie.Text = cr.SelectSumCalorie(cm).ToString();
                //  MyDate.SelectedDates.Clear();



                GetDataActivity(MyDate.SelectedDate);
                //  MyDate.SelectedDates.Clear();
                mm = new MobilitiesModel();
                mm.Date = MyDate.SelectedDate;
                SumMobilityTxt.Text = mr.SelectSumMobility(mm).ToString();


                //dailyCalorie.Text = (Convert.ToInt32(SumCalorie.Text) - Convert.ToInt32(SumMobilityTxt.Text)).ToString();
            }
            catch(Exception ex)
            {
                le.SaveLogError(ex);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                if ((Calender.SelectedDate == Convert.ToDateTime("1 / 1 / 0001 12:00:00 AM")) || (FoodGroupDropDown.SelectedItem.Value == "0") || (FoodDropDown.SelectedItem.Value == "0"))
                {
                    string message = "Please fill all items!";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                    //Scr
                }
                else
                {
                    cm = new CaloriesModel();
                    cm.FoodId = Convert.ToInt32(FoodDropDown.SelectedItem.Value);
                    cm.Quantity = Quantity.Text.ToString();
                    cm.Date = Calender.SelectedDate;
                    cm.Calorie = (Convert.ToInt32(Quantity.Text.ToString())) * (Convert.ToInt32(FoodCalorieText.Text.ToString()));
                    cm.Id = Convert.ToInt32(CalorieIdTxt.Text.ToString());
                    bool res = cr.Update(cm);
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
                    MyDate.SelectedDate = cm.Date;
                    GetData(cm.Date);
                    GetDataActivity(cm.Date);
                    SumCalorie.Text = cr.SelectSumCalorie(cm).ToString();
                   // dailyCalorie.Text = (Convert.ToInt32(SumCalorie.Text) - Convert.ToInt32(SumMobilityTxt.Text)).ToString();

                }
            }
            catch(Exception ex)
            {
                le.SaveLogError(ex);
            }
        }




































        protected void btnActivityUpdate_Click(object sender, EventArgs e)
        {
            if ((CalenderActivity.SelectedDate == Convert.ToDateTime("1 / 1 / 0001 12:00:00 AM")) || (ActivitiesDropDown.SelectedItem.Value == "0"))
            {
                string message = "Please fill all items!";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "')};";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                //Scr
            }
            else
            {
                mm = new MobilitiesModel();
                mm.ActivityId = Convert.ToInt32(ActivitiesDropDown.SelectedItem.Value);
                mm.Time = Time.Text.ToString();
                mm.Date = CalenderActivity.SelectedDate;
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
                AddActivity.Visible = false;
                ShowList.Visible = true;
                ListView.Visible = true;
                MyDate.SelectedDate = mm.Date;
                GetDataActivity(mm.Date);
                GetData(mm.Date);
                SumMobilityTxt.Text = mr.SelectSumMobility(mm).ToString();
              //  dailyCalorie.Text = (Convert.ToInt32(SumCalorie.Text) - Convert.ToInt32(SumMobilityTxt.Text)).ToString();

            }
        }

        protected void btnActivitySave_Click(object sender, EventArgs e)
        {
            if ((CalenderActivity.SelectedDate == Convert.ToDateTime("1 / 1 / 0001 12:00:00 AM")) || (ActivitiesDropDown.SelectedItem.Value == "0"))
            {
                string message = "Please fill all items!";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "')};";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                //Scr
            }
            else
            {
                mm = new MobilitiesModel();
                mm.ActivityId = Convert.ToInt32(ActivitiesDropDown.SelectedItem.Value);
                mm.UserId = Convert.ToInt32(UserIdActivity.Text);
                mm.Time = Time.Text.ToString();
                mm.Date = CalenderActivity.SelectedDate;
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
                AddActivity.Visible = false;
                ShowList.Visible = true;
                ListView.Visible = true;
                MyDate.SelectedDate = mm.Date;
                GetDataActivity(CalenderActivity.SelectedDate);
                GetData(CalenderActivity.SelectedDate);
                SumMobilityTxt.Text = mr.SelectSumMobility(mm).ToString();
               // dailyCalorie.Text = (Convert.ToInt32(SumCalorie.Text) - Convert.ToInt32(SumMobilityTxt.Text)).ToString();

            }
        }

        protected void btnActivityBack_Click(object sender, EventArgs e)
        {
            ShowList.Visible = true;
            addNew.Visible = false;
            AddActivity.Visible = false;
            ListView.Visible = false;
        }

        protected void ActivitiesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            am.Id = Convert.ToInt32(ActivitiesDropDown.SelectedItem.Value);
            ActivityMetabolism = ar.SelectActivity(am);

            // FoodCalorieText.Visible = true;
            //FoodCalorieText.Text = "Food Calorie is :" + FoodCalorie.ToString();
            ActivityMetabolismText.Text = ActivityMetabolism.ToString();

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

        private void GetDataActivity(DateTime dt)
        {
            mm = new MobilitiesModel();
            mm.Date = dt;
            mm.UserId = Convert.ToInt32(UserIdTxt.Text);
            SumMobilityTxt.Text = mr.SelectSumMobility(mm).ToString();

            ActivityList.DataSource = mr.SelectByDate(mm);
            ActivityList.DataBind();
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
                    GetDataActivity(MyDate.SelectedDate);
                }
                else
                {
                    GetDataActivity(Calender.SelectedDate);
                }

            }
            if (e.CommandName == "EditRow")
            {
                MyDate.SelectedDates.Clear();
                addNew.Visible = false;
                AddActivity.Visible = true;
                ShowList.Visible = false;
                btnActivityUpdate.Visible = true;
                btnActivitySave.Visible = false;
                Time.Text = ActivityList.Rows[index].Cells[6].Text.ToString();
                CalenderActivity.SelectedDate = Convert.ToDateTime(ActivityList.Rows[index].Cells[8].Text);
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
                e.Row.Cells[8].Visible = false;
                e.Row.Cells[9].Visible = false;
                //e.Row.Cells[11].Visible = false;
                //e.Row.Cells[12].Visible = false;

            }
        }
    }
}