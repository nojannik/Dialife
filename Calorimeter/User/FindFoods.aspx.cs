using BL.Models.Repositories;
using BL.Models.Utility;
using DomainModel.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calorimeter.User
{
    public partial class FindFoods : System.Web.UI.Page
    {
       
        FoodRepository fr = new FoodRepository();
        RegistrationRepository rr = new RegistrationRepository();
        RegistrationModel rm = new RegistrationModel();
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
                    UserId.Text = Session["UserId"].ToString();
                }
            }
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            fm = new FoodModel();
            string h = Materials.Text.ToString();
            string[] words = h.Split(',');

            rm.Id = Convert.ToInt32(UserId.Text);
            string reg = rr.SelectReligion(rm);



            string allergy = fr.SelectAllergy(Convert.ToInt32(UserId.Text));
            string lowerAllergy = allergy.ToLower();
            string allergies = lowerAllergy.Replace(" ", "");
            string finalAllergy = allergies;
            string[] allergyList = finalAllergy.Split(',');


            if (reg == "Islam" || reg == "INC")
            {
                for (int i = 0; i <= words.Length - 1; i++)
                {
                    if (words[i] == "pork" || words[i] == "blood")
                    {
                        words = words.Where(w => w != words[i]).ToArray();
                    }
                }
            }

            // fm.Materials = words.t;
            fm.FoodGroupId = Convert.ToInt32(FoodGroupDropDown.SelectedItem.Value);
            fr = new FoodRepository();
            DataTable dt = new DataTable();
            
            dt = fr.FindFoodWithGroup(fm);
            DataTable dtt = dt.Clone();
            
            List<string> rows = new List<string>();
            bool ex = false;
            foreach (DataRow row in dt.Rows)
            {
                string newString = row[5].ToString().Replace(" ", "");
                string t = newString;
                string[] wordsItem = t.Split(',');
               
                for (int k = 0; k <= wordsItem.Length - 1; k++)
                {
                    if (reg == "Islam" || reg == "INC")
                    {
                        if (wordsItem[k] == "pork" || wordsItem[k] == "blood")
                        {
                            row.Delete();
                            break;
                        }
                    }       
               }  
            }

            dt.AcceptChanges();





            foreach (DataRow row in dt.Rows)
            {
                string newString = row[5].ToString().Replace(" ", "");
                string t = newString;
                string[] wordsItem = t.Split(',');

                for (int k = 0; k <= wordsItem.Length - 1; k++)
                {
                    for(int y=0; y<= allergyList.Length - 1; y++)
                    {

                        if (wordsItem[k] == allergyList[y])
                        {
                            row.Delete();
                            break;
                        }
                    }
                }
            }
            dt.AcceptChanges();




            foreach (DataRow row in dt.Rows)
            {
                string newString = row[5].ToString().Replace(" ", "");
                string t = newString;
                string[] wordsItem = t.Split(',');
                string hh = row[0].ToString();

                for (int j = 0; j <= words.Length - 1; j++)
                {
                    for (int k = 0; k <= wordsItem.Length - 1; k++)
                    {
                        if (words[j] == wordsItem[k])
                        {
                            if(dtt.Rows.Count > 0)
                            {
                                ex = false;
                                foreach (var item in rows)
                                {
                                    
                                    if (item == hh)
                                    {
                                        ex = true;
                                    }
                                }

                                if(ex != true)
                                {
                                    dtt.ImportRow(row);
                                    rows.Add(row[0].ToString());
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                dtt.ImportRow(row);
                                rows.Add(row[0].ToString());
                            }
                        }
                    }
                }
            }






            //FoodRepeater1.DataSource = fr.FindFoodWithGroup(fm);
            FoodRepeater1.DataSource = dtt;
            FoodRepeater1.DataBind();
            Materials.Text = string.Empty;
            

        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            fm = new FoodModel();
            fm.Materials = Materials.Text.ToString();
            fm.FoodGroupId = Convert.ToInt32(FoodGroupDropDown.SelectedItem.Value);
            fr = new FoodRepository();
            FoodRepeater1.DataSource = fr.FindFoodWithGroup(fm);
            FoodRepeater1.DataBind();
            Materials.Text = string.Empty;

            //if (e.CommandName == "ShowRecipe")
            //{
            //    Label2.Visible = true;
            //    Label1.Text = e.CommandArgument.ToString();
            //}
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
        protected void FoodGroupDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            fm = new FoodModel();
            fm.FoodGroupId = Convert.ToInt32(FoodGroupDropDown.SelectedItem.Value);
            //FoodRecipeList.DataSource = fr.SelectByGroupId(fm);
            //FoodRecipeList.DataBind();

        }

        protected void FoodRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }

    }
}