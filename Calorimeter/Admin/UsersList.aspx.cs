using BL.Models.Repositories;
using BL.Models.Utility;
using DomainModel.Models.EntityModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calorimeter.Admin
{
    public partial class UsersList : System.Web.UI.Page
    {
        RegistrationModel rm = new RegistrationModel();
        RegistrationRepository rr = new RegistrationRepository();
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
                    loadSex();
                    loadDiabetTypes();
                    loadCookingLevel();
                    loadReligion();
                    loadMeatPreference();
                    loadVegtablePreference();

                    GetData();

                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try {
                //if (Password.Text != ConfirmPassword.Text)
                //{
                //    string message = "Passwords are not same";
                //    string script = "window.onload = function(){ alert('";
                //    script += message;
                //    script += "')};";
                //    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                //    //ScriptManager
                //}
                //else
                //{

                    rm.FirstName = FirstName.Text.ToString();
                    rm.LastName = LastName.Text.ToString();
                    // rm.BirthDate = BirthDate.SelectedDate.ToString();
                    rm.BirthDate = BirthDate.Text.ToString();
                    rm.Sex = SexDropDown.SelectedItem.Text.ToString();
                    rm.DiabetesType = DiabetesTypeDropDown.SelectedItem.Text.ToString();
                    rm.Religion = ReligionDropDown.SelectedItem.Text.ToString();
                    rm.CookingLevel = CookingLevelDropDown.SelectedItem.Text.ToString();
                    rm.UserPreferencesMeat = MeatDropDownList.SelectedItem.Text.ToString();
                    rm.UserPreferencesVegtable = VegtableDropDownList.SelectedItem.Text.ToString();
                    //rm.UserPreferences = UserPreferences.Text.ToString();
                    rm.MaximumCalery = MaximumCalery.Text.ToString();

                    List<string> allergies = new List<string>();
                    if (CheckBox1.Checked) { allergies.Add(CheckBox1.Text); }
                    if (CheckBox2.Checked) { allergies.Add(CheckBox2.Text); }
                    if (CheckBox3.Checked) { allergies.Add(CheckBox3.Text); }
                    if (CheckBox4.Checked) { allergies.Add(CheckBox4.Text); }
                    if (CheckBox5.Checked) { allergies.Add(CheckBox5.Text); }
                    if (CheckBox6.Checked) { allergies.Add(CheckBox6.Text); }
                    if (CheckBox7.Checked) { allergies.Add(CheckBox7.Text); }
                    if (CheckBox8.Checked) { allergies.Add(CheckBox8.Text); }
                    if (CheckBox9.Checked) { allergies.Add(CheckBox9.Text); }
                    string str = string.Join(",", allergies);

                    rm.Allergy = str.ToString();
                    // rm.FoodHistory = FoodHistory.Text.ToString();
                    // rm.SportHistory = SportHistory.Text.ToString();
                    rm.RoleId = 2;
                   // rm.UserName = UserName.Text.ToString();
                   // rm.Password = Password.Text.ToString();

                    DataTable dtt = new DataTable();
                    dtt = rr.CHeckUser(rm);
                    if (dtt.Rows.Count == 0)
                    {
                        if (Convert.ToInt32(rm.MaximumCalery) < 800 || Convert.ToInt32(rm.MaximumCalery) > 4200)
                        {
                            string message = "MaximumCalery is not in correct range 800-4200!";
                            string script = "window.onload = function(){ alert('";
                            script += message;
                            script += "')};";
                            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                            //ScriptManager.RegisterClientScrip
                        }
                        else
                        {

                            bool res = rr.Insert(rm);
                            if (res)
                            {
                                string message = "saving info was successfull";
                                string script = "window.onload = function(){ alert('";
                                script += message;
                                script += "')};";
                                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                                //emptyFields();
                            }
                            else
                            {
                                string message = "saving info was not successfull";
                                string script = "window.onload = function(){ alert('";
                                script += message;
                                script += "')};";
                                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                            }
                        }
                    }
                    else
                    {
                        string message = "User is repeated";
                        string script = "window.onload = function(){ alert('";
                        script += message;
                        script += "')};";
                        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                    }
                //}
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




                rm.FirstName = FirstName.Text.ToString();
                rm.LastName = LastName.Text.ToString();
                // rm.BirthDate = BirthDate.SelectedDate.ToString();
                rm.BirthDate = BirthDate.Text.ToString();
                rm.Sex = SexDropDown.SelectedItem.Text.ToString();
                rm.DiabetesType = DiabetesTypeDropDown.SelectedItem.Text.ToString();
                rm.Religion = ReligionDropDown.SelectedItem.Text.ToString();
                rm.CookingLevel = CookingLevelDropDown.SelectedItem.Text.ToString();
                rm.UserPreferencesMeat = MeatDropDownList.SelectedItem.Text.ToString();
                rm.UserPreferencesVegtable = VegtableDropDownList.SelectedItem.Text.ToString();
                //rm.UserPreferences = UserPreferences.Text.ToString();
                rm.MaximumCalery = MaximumCalery.Text.ToString();

                List<string> allergies = new List<string>();
                if (CheckBox1.Checked) { allergies.Add(CheckBox1.Text); }
                if (CheckBox2.Checked) { allergies.Add(CheckBox2.Text); }
                if (CheckBox3.Checked) { allergies.Add(CheckBox3.Text); }
                if (CheckBox4.Checked) { allergies.Add(CheckBox4.Text); }
                if (CheckBox5.Checked) { allergies.Add(CheckBox5.Text); }
                if (CheckBox6.Checked) { allergies.Add(CheckBox6.Text); }
                if (CheckBox7.Checked) { allergies.Add(CheckBox7.Text); }
                if (CheckBox8.Checked) { allergies.Add(CheckBox8.Text); }
                if (CheckBox9.Checked) { allergies.Add(CheckBox9.Text); }
                string str = string.Join(",", allergies);

                rm.Allergy = str.ToString();
                // rm.FoodHistory = FoodHistory.Text.ToString();
                // rm.SportHistory = SportHistory.Text.ToString();









                rm.Id = Convert.ToInt32(UserId.Text);
                if (Convert.ToInt32(rm.MaximumCalery) < 800 || Convert.ToInt32(rm.MaximumCalery) > 4200)
                {
                    string message = "MaximumCalery is not in correct range 800-4200!";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                    //ScriptManager.RegisterClientScrip
                }
                else
                {
                    bool res = rr.Update(rm);
                    if (res)
                    {
                        string message = "saving info was successfull";
                        string script = "window.onload = function(){ alert('";
                        script += message;
                        script += "')};";
                        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                        //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                    }
                    else
                    {
                        string message = "saving info was not successfull";
                        string script = "window.onload = function(){ alert('";
                        script += message;
                        script += "')};";
                        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                    }
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
                UsersListGrid.DataSource = rr.Select();
                UsersListGrid.DataBind();
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
            //btnSave.Visible = true;
            btnUpdate.Visible = false;
            addNew.Visible = true;
            showList.Visible = false;
        }

        protected void UsersList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            rm = new RegistrationModel();
            int index = Convert.ToInt32(e.CommandArgument);
            rm.Id = Convert.ToInt32(UsersListGrid.Rows[index].Cells[3].Text);

            if (e.CommandName == "DeleteRow")
            {
                //re.Id = Convert.ToInt32(RealEstateList.Rows[index].Cells[3].Text); 
                bool res = rr.Delete(rm);
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
                UserId.Text = UsersListGrid.Rows[index].Cells[3].Text.ToString();

                FirstName.Text = UsersListGrid.Rows[index].Cells[4].Text.ToString();
                LastName.Text = UsersListGrid.Rows[index].Cells[5].Text.ToString();
                BirthDate.Text = UsersListGrid.Rows[index].Cells[6].Text.ToString();
                //SexDropDown.SelectedItem.Text = SexDropDown.Items.FindByText(dtRow[4].ToString()).ToString();
                string a = UsersListGrid.Rows[index].Cells[7].Text.ToString();
                SexDropDown.SelectedIndex = SexDropDown.Items.IndexOf(SexDropDown.Items.FindByValue(a));

                string b = UsersListGrid.Rows[index].Cells[8].Text.ToString();
                DiabetesTypeDropDown.SelectedIndex = DiabetesTypeDropDown.Items.IndexOf(DiabetesTypeDropDown.Items.FindByValue(b));

                // Religion.Text = UsersListGrid.Rows[index].Cells[9].Text.ToString();
                string d = UsersListGrid.Rows[index].Cells[9].Text.ToString();
                ReligionDropDown.SelectedIndex = ReligionDropDown.Items.IndexOf(ReligionDropDown.Items.FindByValue(d));

                string c = UsersListGrid.Rows[index].Cells[10].Text.ToString();
                CookingLevelDropDown.SelectedIndex = CookingLevelDropDown.Items.IndexOf(CookingLevelDropDown.Items.FindByValue(c));

                // CookingLevelDropDown.SelectedItem.Text = CookingLevelDropDown.Items.FindByText(dtRow[7].ToString()).ToString();
                // UserPreferences.Text = UsersListGrid.Rows[index].Cells[11].Text.ToString();
                string r = UsersListGrid.Rows[index].Cells[11].Text.ToString();
                VegtableDropDownList.SelectedIndex = VegtableDropDownList.Items.IndexOf(VegtableDropDownList.Items.FindByValue(r));

                string t = UsersListGrid.Rows[index].Cells[12].Text.ToString();
                MeatDropDownList.SelectedIndex = MeatDropDownList.Items.IndexOf(MeatDropDownList.Items.FindByValue(t));


                MaximumCalery.Text = UsersListGrid.Rows[index].Cells[13].Text.ToString();

                string h = UsersListGrid.Rows[index].Cells[14].Text.ToString();
                string[] words = h.Split(',');

                for (int i = 0; i <= words.Length - 1; i++)
                {
                    if (CheckBox1.Text == words[i].ToString()) { CheckBox1.Checked = true; }
                    if (CheckBox2.Text == words[i].ToString()) { CheckBox2.Checked = true; }
                    if (CheckBox3.Text == words[i].ToString()) { CheckBox3.Checked = true; }
                    if (CheckBox4.Text == words[i].ToString()) { CheckBox4.Checked = true; }
                    if (CheckBox5.Text == words[i].ToString()) { CheckBox5.Checked = true; }
                    if (CheckBox6.Text == words[i].ToString()) { CheckBox6.Checked = true; }
                    if (CheckBox7.Text == words[i].ToString()) { CheckBox7.Checked = true; }
                    if (CheckBox8.Text == words[i].ToString()) { CheckBox8.Checked = true; }
                    if (CheckBox9.Text == words[i].ToString()) { CheckBox9.Checked = true; }
                }

                // Allergy.Text = UsersListGrid.Rows[index].Cells[13].Text.ToString();
                // FoodHistory.Text = UsersListGrid.Rows[index].Cells[14].Text.ToString();
                // SportHistory.Text = UsersListGrid.Rows[index].Cells[15].Text.ToString();
                //UserName.Text = UsersListGrid.Rows[index].Cells[17].Text.ToString();
                //Password.Text = UsersListGrid.Rows[index].Cells[18].Text.ToString();
                //ConfirmPassword.Text = UsersListGrid.Rows[index].Cells[18].Text.ToString();



            }
        }

        protected void UsersList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Header)
            {

                e.Row.Cells[3].Visible = false;
                e.Row.Cells[15].Visible = false;
                e.Row.Cells[16].Visible = false;
                e.Row.Cells[17].Visible = false;

            }
        }







        public void loadSex()
        {
            ArrayList list = new ArrayList();
            list.Add("Male");
            list.Add("Female");
            for (int i = 0; i <= 1; i++)
            {
                SexDropDown.Items.Add(new ListItem(list[i].ToString(), list[i].ToString()));
            }

        }
        public void loadDiabetTypes()
        {
            ArrayList list1 = new ArrayList();
            list1.Add("Type1");
            list1.Add("Type2");
            for (int j = 0; j <= 1; j++)
            {
                DiabetesTypeDropDown.Items.Add(new ListItem(list1[j].ToString(), list1[j].ToString()));
            }
        }

        public void loadCookingLevel()
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
        public void loadReligion()
        {
            ArrayList list1 = new ArrayList();
            list1.Add("Islam");
            list1.Add("INC");
            list1.Add("Christian");
            list1.Add("Other");
            for (int k = 0; k <= 3; k++)
            {
                ReligionDropDown.Items.Add(new ListItem(list1[k].ToString(), list1[k].ToString()));
            }

        }
        public void loadMeatPreference()
        {
            ArrayList list1 = new ArrayList();
            list1.Add("beef");
            list1.Add("chicken");
            list1.Add("pork");
            list1.Add("seafood");

            for (int k = 0; k <= 3; k++)
            {
                MeatDropDownList.Items.Add(new ListItem(list1[k].ToString(), list1[k].ToString()));
            }

        }
        public void loadVegtablePreference()
        {
            ArrayList list1 = new ArrayList();
            list1.Add("leafs");
            list1.Add("fruits");
            list1.Add("legume");
            list1.Add("marrow");
            list1.Add("roots");
            list1.Add("cruciferus");
            for (int k = 0; k <= 5; k++)
            {
                VegtableDropDownList.Items.Add(new ListItem(list1[k].ToString(), list1[k].ToString()));
            }

        }


    }
}