using BL.Models.Repositories;
using DomainModel.Models.EntityModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calorimeter
{
    public partial class Registration : System.Web.UI.Page
    {
        RegistrationRepository rr = new RegistrationRepository();
        RegistrationModel rm = new RegistrationModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {

                loadSex();
                loadDiabetTypes();
                loadCookingLevel();
                loadReligion();
                loadMeatPreference();
                loadVegtablePreference();
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
            list1.Insert(0,"beef");
            list1.Insert(1,"chicken");
            list1.Insert(2,"pork");
            list1.Insert(3,"seafood");
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


        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Password.Text != ConfirmPassword.Text)
            {
                string message = "Passwords are not same";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "')};";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                //ScriptManager
            }
            else
            {

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
                rm.UserName = UserName.Text.ToString();
                rm.Password = Password.Text.ToString();

                DataTable dtt = new DataTable();
                dtt = rr.CHeckUser(rm);
                if (dtt.Rows.Count == 0)
                {
                    if (Convert.ToInt32(rm.MaximumCalery) < 800 || Convert.ToInt32(rm.MaximumCalery) > 3000)
                    {
                        string message = "MaximumCalery is not in correct range 800-3000!";
                        string script = "window.onload = function(){ alert('";
                        script += message;
                        script += "')};";
                        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                        //ScriptManager.RegisterClientScrip
                    }
                    else if (rm.Religion == "Islam" && rm.UserPreferencesMeat == "pork")
                    {
                        string message = "Error! You are muslim but you have chosen PORK";
                        string script = "window.onload = function(){ alert('";
                        script += message;
                        script += "')};";
                        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                    }
                    else if (Convert.ToInt32(rm.BirthDate) < 18)
                    {
                        string message = "Error! You are under 18";
                        string script = "window.onload = function(){ alert('";
                        script += message;
                        script += "')};";
                        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
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
                            emptyFields();
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
            }

        }


        public void emptyFields()
        {
            FirstName.Text = string.Empty;
            LastName.Text = string.Empty;
            // rm.BirthDate = BirthDate.SelectedDate.ToString();
            BirthDate.Text = string.Empty;
           
            //Religion.Text = string.Empty;
          //  UserPreferences.Text = string.Empty;
            MaximumCalery.Text.ToString();
            //Allergy.Text = string.Empty;
           // FoodHistory.Text = string.Empty;
           // SportHistory.Text = string.Empty;
            UserName.Text = string.Empty;
            Password.Text = string.Empty;
        }
    }
}