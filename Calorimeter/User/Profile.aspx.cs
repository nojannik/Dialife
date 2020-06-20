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

namespace Calorimeter.User
{
    public partial class Profile : System.Web.UI.Page
    {
        RegistrationRepository rr = new RegistrationRepository();
        RegistrationModel rm = new RegistrationModel();

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


                    loadSex();
                    loadDiabetTypes();
                    loadCookingLevel();
                    loadReligion();
                    loadMeatPreference();
                    loadVegtablePreference();


                    rm = new RegistrationModel();
                    UserId.Text = Session["UserId"].ToString();
                    rm.Id = Convert.ToInt32(Session["UserId"]);
                    DataTable dt = new DataTable();
                    dt = rr.SelectUser(rm);
                    foreach (DataRow dtRow in dt.Rows)
                    {

                        FirstName.Text = dtRow[1].ToString();
                        LastName.Text = dtRow[2].ToString();
                        //BirthDate.SelectedDate = Convert.ToDateTime(dtRow[3].ToString());
                        BirthDate.Text =dtRow[3].ToString();
                        //SexDropDown.SelectedItem.Text = SexDropDown.Items.FindByText(dtRow[4].ToString()).ToString();
                        string a = dtRow[4].ToString();
                        SexDropDown.SelectedIndex = SexDropDown.Items.IndexOf(SexDropDown.Items.FindByValue(a));

                        string b = dtRow[5].ToString();
                        DiabetesTypeDropDown.SelectedIndex = DiabetesTypeDropDown.Items.IndexOf(DiabetesTypeDropDown.Items.FindByValue(b));

                        string c = dtRow[6].ToString();
                        ReligionDropDown.SelectedIndex = ReligionDropDown.Items.IndexOf(ReligionDropDown.Items.FindByValue(c));


                        string d = dtRow[7].ToString();
                        CookingLevelDropDown.SelectedIndex = CookingLevelDropDown.Items.IndexOf(CookingLevelDropDown.Items.FindByValue(d));

                        // CookingLevelDropDown.SelectedItem.Text = CookingLevelDropDown.Items.FindByText(dtRow[7].ToString()).ToString();

                        string f = dtRow[9].ToString();
                        MeatDropDownList.SelectedIndex = MeatDropDownList.Items.IndexOf(MeatDropDownList.Items.FindByValue(f));

                        string g = dtRow[8].ToString();
                        VegtableDropDownList.SelectedIndex = VegtableDropDownList.Items.IndexOf(VegtableDropDownList.Items.FindByValue(g));


                        //UserPreferences.Text = dtRow[8].ToString();
                        MaximumCalery.Text = dtRow[10].ToString();

                        string h = dtRow[11].ToString();
                        string[] words = h.Split(',');

                        for(int i = 0; i <= words.Length-1; i++)
                        {
                            if(CheckBox1.Text == words[i].ToString()) { CheckBox1.Checked = true; }
                            if(CheckBox2.Text == words[i].ToString()) { CheckBox2.Checked = true; }
                            if(CheckBox3.Text == words[i].ToString()) { CheckBox3.Checked = true; }
                            if(CheckBox4.Text == words[i].ToString()) { CheckBox4.Checked = true; }
                            if(CheckBox5.Text == words[i].ToString()) { CheckBox5.Checked = true; }
                            if(CheckBox6.Text == words[i].ToString()) { CheckBox6.Checked = true; }
                            if(CheckBox7.Text == words[i].ToString()) { CheckBox7.Checked = true; }
                            if(CheckBox8.Text == words[i].ToString()) { CheckBox8.Checked = true; }
                            if(CheckBox9.Text == words[i].ToString()) { CheckBox9.Checked = true; }
                        }
                        
                        //  Allergy.Text = dtRow[10].ToString();
                        //  FoodHistory.Text = dtRow[11].ToString();
                        // SportHistory.Text = dtRow[12].ToString();
                    }
                }
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


        protected void btnSave_Click(object sender, EventArgs e)
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
                    string message = "Please select in range of 800-4200!";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                    //ScriptManager.RegisterClientScrip
                }
                else if (rm.Religion == "Islam" && rm.UserPreferencesMeat =="pork")
                {
                    string message = "Error! You are muslim but you have chosen PORK";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                }
                else
                {
                    bool res = rr.Update(rm);
                    if (res)
                    {
                        string message = "saving info was successful";
                        string script = "window.onload = function(){ alert('";
                        script += message;
                        script += "')};";
                        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                        //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                    }
                    else
                    {
                        string message = "saving info was not successful";
                        string script = "window.onload = function(){ alert('";
                        script += message;
                        script += "')};";
                        ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                    }
                }
            }
            catch(Exception ex)
            {
                le.SaveLogError(ex);
            }
        }
    }
}