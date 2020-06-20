using BL.Models.Repositories;
using DomainModel.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calorimeter.User
{
    public partial class SavedFoodOffer : System.Web.UI.Page
    {
        FoodRepository fr = new FoodRepository();
        FoodOfferModel fo = new FoodOfferModel();
        DataTable table1 = new DataTable();
        public int res ;
        public int res1;
        public int res2;


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
                    DataTable dt = new DataTable();
                    dt = fr.SelectSavedFood(Convert.ToInt32(UserIdTxt.Text));


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DataRow row = dt.Rows[i];
                        string[] tt0 = row[1].ToString().Split('#');
                        SatB0.Text = tt0[0].ToString();
                        SatB0.CommandArgument = tt0[1].ToString() + "#" + tt0[2].ToString() + "#" + tt0[3].ToString() + "#" + tt0[4].ToString() + "#" + tt0[5].ToString();
                        // SatB0.Text = row[1].ToString();



                        string[] tt1 = row[2].ToString().Split('#');
                        SatB1.Text = tt1[0].ToString();
                        SatB1.CommandArgument = tt1[1].ToString() + "#" + tt1[2].ToString() + "#" + tt1[3].ToString() + "#" + tt1[4].ToString() + "#" + tt1[5].ToString() ;
                        //SatB1.Text = row[2].ToString();

                        //string[] tt2 = row[3].ToString().Split('#');
                        //SatB2.Text = tt2[0].ToString();
                        //SatB2.CommandArgument = tt2[1].ToString() + "#" + tt2[2].ToString();
                        ////SatB2.Text = row[3].ToString();


                        string[] tt3 = row[4].ToString().Split('#');
                        SatL0.Text = tt3[0].ToString();
                        SatL0.CommandArgument = tt3[1].ToString() + "#" + tt3[2].ToString() + "#" + tt3[3].ToString() + "#" + tt3[4].ToString() + "#" + tt3[5].ToString();
                        // SatD0.Text = row[4].ToString();

                        string[] tt4 = row[5].ToString().Split('#');
                        SatL1.Text = tt4[0].ToString();
                        SatL1.CommandArgument = tt4[1].ToString() + "#" + tt4[2].ToString() + "#" + tt4[3].ToString() + "#" + tt4[4].ToString() + "#" + tt4[5].ToString();
                        // SatD1.Text = row[5].ToString();

                        string[] tt5 = row[6].ToString().Split('#');
                        SatL2.Text = tt5[0].ToString();
                        SatL2.CommandArgument = tt5[1].ToString() + "#" + tt5[2].ToString() + "#" + tt5[3].ToString() + "#" + tt5[4].ToString() + "#" + tt5[5].ToString();
                        //SatD2.Text = row[6].ToString();

                        string[] tt6 = row[7].ToString().Split('#');
                        SatD0.Text = tt6[0].ToString();
                        SatD0.CommandArgument = tt6[1].ToString() + "#" + tt6[2].ToString() + "#" + tt6[3].ToString() + "#" + tt6[4].ToString() + "#" + tt6[5].ToString();
                        //SatL0.Text = row[7].ToString();

                        string[] tt7 = row[8].ToString().Split('#');
                        SatD1.Text = tt7[0].ToString();
                        SatD1.CommandArgument = tt7[1].ToString() + "#" + tt7[2].ToString() + "#" + tt7[3].ToString() + "#" + tt7[4].ToString() + "#" + tt7[5].ToString();

                        
                        // SatL1.Text = row[8].ToString();

                        //string[] tt8 = row[9].ToString().Split('#');
                        //SatD2.Text = tt8[0].ToString();
                        //SatD2.CommandArgument = tt8[1].ToString() + "#" + tt8[2].ToString();
                        //SatL2.Text = row[9].ToString();

                        string[] tt9 = row[10].ToString().Split('#');
                        SunB0.Text = tt9[0].ToString();
                        SunB0.CommandArgument = tt9[1].ToString() + "#" + tt9[2].ToString() + "#" + tt9[3].ToString() + "#" + tt9[4].ToString() + "#" + tt9[5].ToString();
                        //SunB0.Text = row[10].ToString();

                        string[] tt10 = row[11].ToString().Split('#');
                        SunB1.Text = tt10[0].ToString();
                        SunB1.CommandArgument = tt10[1].ToString() + "#" + tt10[2].ToString() + "#" + tt10[3].ToString() + "#" + tt10[4].ToString() + "#" + tt10[5].ToString();
                        // SunB1.Text = row[11].ToString();

                        // string[] tt11 = row[12].ToString().Split('#');
                        // SunB2.Text = tt11[0].ToString();
                        // SunB2.CommandArgument = tt11[1].ToString() + "#" + tt11[2].ToString();
                        //// SunB2.Text = row[12].ToString();

                        string[] tt12 = row[13].ToString().Split('#');
                        SunL0.Text = tt12[0].ToString();
                        SunL0.CommandArgument = tt12[1].ToString() + "#" + tt12[2].ToString() + "#" + tt12[3].ToString() + "#" + tt12[4].ToString() + "#" + tt12[5].ToString();
                        //  SunD0.Text = row[13].ToString();

                        string[] tt13 = row[14].ToString().Split('#');
                        SunL1.Text = tt13[0].ToString();
                        SunL1.CommandArgument = tt13[1].ToString() + "#" + tt13[2].ToString() + "#" + tt13[3].ToString() + "#" + tt13[4].ToString() + "#" + tt13[5].ToString();
                        // SunD1.Text = row[14].ToString();

                        string[] tt14 = row[15].ToString().Split('#');
                        SunL2.Text = tt14[0].ToString();
                        SunL2.CommandArgument = tt14[1].ToString() + "#" + tt14[2].ToString() + "#" + tt14[3].ToString() + "#" + tt14[4].ToString() + "#" + tt14[5].ToString();
                        //SunD2.Text = row[15].ToString();

                        string[] tt15 = row[16].ToString().Split('#');
                        SunD0.Text = tt15[0].ToString();
                        SunD0.CommandArgument = tt15[1].ToString() + "#" + tt15[2].ToString() + "#" + tt15[3].ToString() + "#" + tt15[4].ToString() + "#" + tt15[5].ToString();
                        // SunL0.Text = row[16].ToString();

                        string[] tt16 = row[17].ToString().Split('#');
                        SunD1.Text = tt16[0].ToString();
                        SunD1.CommandArgument = tt16[1].ToString() + "#" + tt16[2].ToString() + "#" + tt16[3].ToString() + "#" + tt16[4].ToString() + "#" + tt16[5].ToString();
                        // SunL1.Text = row[17].ToString();

                        //string[] tt17 = row[18].ToString().Split('#');
                        //SunD2.Text = tt17[0].ToString();
                        //SunD2.CommandArgument = tt17[1].ToString() + "#" + tt17[2].ToString();
                        //// SunL2.Text = row[18].ToString();


                        string[] tt18 = row[19].ToString().Split('#');
                        MonB0.Text = tt18[0].ToString();
                        MonB0.CommandArgument = tt18[1].ToString() + "#" + tt18[2].ToString() + "#" + tt18[3].ToString() + "#" + tt18[4].ToString() + "#" + tt18[5].ToString();
                        //MonB0.Text = row[19].ToString();

                        string[] tt19 = row[20].ToString().Split('#');
                        MonB1.Text = tt19[0].ToString();
                        MonB1.CommandArgument = tt19[1].ToString() + "#" + tt19[2].ToString() + "#" + tt19[3].ToString() + "#" + tt19[4].ToString() + "#" + tt19[5].ToString();
                        //  MonB1.Text = row[20].ToString();

                        //string[] tt20 = row[21].ToString().Split('#');
                        //MonB2.Text = tt20[0].ToString();
                        //MonB2.CommandArgument = tt20[1].ToString() + "#" + tt20[2].ToString();
                        ////MonB2.Text = row[21].ToString();

                        string[] tt21 = row[22].ToString().Split('#');
                        MonL0.Text = tt21[0].ToString();
                        MonL0.CommandArgument = tt21[1].ToString() + "#" + tt21[2].ToString() + "#" + tt21[3].ToString() + "#" + tt21[4].ToString() + "#" + tt21[5].ToString();
                        //MonD0.Text = row[22].ToString();

                        string[] tt22 = row[23].ToString().Split('#');
                        MonL1.Text = tt22[0].ToString();
                        MonL1.CommandArgument = tt22[1].ToString() + "#" + tt22[2].ToString() + "#" + tt22[3].ToString() + "#" + tt22[4].ToString() + "#" + tt22[5].ToString();
                        //MonD1.Text = row[23].ToString();

                        string[] tt23 = row[24].ToString().Split('#');
                        MonL2.Text = tt23[0].ToString();
                        MonL2.CommandArgument = tt23[1].ToString() + "#" + tt23[2].ToString() + "#" + tt23[3].ToString() + "#" + tt23[4].ToString() + "#" + tt23[5].ToString();
                        //MonD2.Text = row[24].ToString();

                        string[] tt24 = row[25].ToString().Split('#');
                        SunD2.Text = tt24[0].ToString();
                        SunD2.CommandArgument = tt24[1].ToString() + "#" + tt24[2].ToString() + "#" + tt24[3].ToString() + "#" + tt24[4].ToString() + "#" + tt24[5].ToString();
                        // MonL0.Text = row[25].ToString();

                        string[] tt25 = row[26].ToString().Split('#');
                        MonD1.Text = tt25[0].ToString();
                        MonD1.CommandArgument = tt25[1].ToString() + "#" + tt25[2].ToString() + "#" + tt25[3].ToString() + "#" + tt25[4].ToString() + "#" + tt25[5].ToString();
                        //MonL1.Text = row[26].ToString();

                        //string[] tt26 = row[27].ToString().Split('#');
                        //MonD2.Text = tt26[0].ToString();
                        //MonD2.CommandArgument = tt26[1].ToString() + "#" + tt26[2].ToString();
                        //// MonL2.Text = row[27].ToString();

                        string[] tt27 = row[28].ToString().Split('#');
                        TuesB0.Text = tt27[0].ToString();
                        TuesB0.CommandArgument = tt27[1].ToString() + "#" + tt27[2].ToString() + "#" + tt27[3].ToString() + "#" + tt27[4].ToString() + "#" + tt27[5].ToString();
                        //TuesB0.Text = row[28].ToString();

                        string[] tt28 = row[29].ToString().Split('#');
                        TuesB1.Text = tt28[0].ToString();
                        TuesB1.CommandArgument = tt28[1].ToString() + "#" + tt28[2].ToString() + "#" + tt28[3].ToString() + "#" + tt28[4].ToString() + "#" + tt28[5].ToString();
                        //TuesB1.Text = row[29].ToString();

                        //string[] tt29 = row[30].ToString().Split('#');
                        //TuesB2.Text = tt29[0].ToString();
                        //TuesB2.CommandArgument = tt29[1].ToString() + "#" + tt29[2].ToString();
                        ////TuesB2.Text = row[30].ToString();

                        string[] tt30 = row[31].ToString().Split('#');
                        TuesL0.Text = tt30[0].ToString();
                        TuesL0.CommandArgument = tt30[1].ToString() + "#" + tt30[2].ToString() + "#" + tt30[3].ToString() + "#" + tt30[4].ToString() + "#" + tt30[5].ToString();
                        //TuesD0.Text = row[31].ToString();

                        string[] tt31 = row[32].ToString().Split('#');
                        TuesL1.Text = tt31[0].ToString();
                        TuesL1.CommandArgument = tt31[1].ToString() + "#" + tt31[2].ToString() + "#" + tt31[3].ToString() + "#" + tt31[4].ToString() + "#" + tt31[5].ToString();
                        //TuesD1.Text = row[32].ToString();

                        string[] tt32 = row[33].ToString().Split('#');
                        TuesL2.Text = tt32[0].ToString();
                        TuesL2.CommandArgument = tt32[1].ToString() + "#" + tt32[2].ToString() + "#" + tt32[3].ToString() + "#" + tt32[4].ToString() + "#" + tt32[5].ToString();
                        //TuesD2.Text = row[33].ToString();

                        string[] tt33 = row[34].ToString().Split('#');
                        TuesD0.Text = tt33[0].ToString();
                        TuesD0.CommandArgument = tt33[1].ToString() + "#" + tt33[2].ToString() + "#" + tt33[3].ToString() + "#" + tt33[4].ToString() + "#" + tt33[5].ToString();
                        //TuesL0.Text = row[34].ToString();

                        string[] tt34 = row[35].ToString().Split('#');
                        TuesD1.Text = tt34[0].ToString();
                        TuesD1.CommandArgument = tt34[1].ToString() + "#" + tt34[2].ToString() + "#" + tt34[3].ToString() + "#" + tt34[4].ToString() + "#" + tt34[5].ToString();
                        // TuesL1.Text = row[35].ToString();

                        //string[] tt35 = row[36].ToString().Split('#');
                        //TuesD2.Text = tt35[0].ToString();
                        //TuesD2.CommandArgument = tt35[1].ToString() + "#" + tt35[2].ToString();
                        ////TuesL2.Text = row[36].ToString();

                        string[] tt36 = row[37].ToString().Split('#');
                        WedB0.Text = tt36[0].ToString();
                        WedB0.CommandArgument = tt36[1].ToString() + "#" + tt36[2].ToString() + "#" + tt36[3].ToString() + "#" + tt36[4].ToString() + "#" + tt36[5].ToString();
                        // WedB0.Text = row[37].ToString();

                        string[] tt37 = row[38].ToString().Split('#');
                        WedB1.Text = tt37[0].ToString();
                        WedB1.CommandArgument = tt37[1].ToString() + "#" + tt37[2].ToString() + "#" + tt37[3].ToString() + "#" + tt37[4].ToString() + "#" + tt37[5].ToString();
                        //  WedB1.Text = row[38].ToString();

                        // string[] tt38 = row[39].ToString().Split('#');
                        // WedB2.Text = tt38[0].ToString();
                        // WedB2.CommandArgument = tt38[1].ToString() + "#" + tt38[2].ToString();
                        //// WedB2.Text = row[39].ToString();

                        string[] tt39 = row[40].ToString().Split('#');
                        WedL0.Text = tt39[0].ToString();
                        WedL0.CommandArgument = tt39[1].ToString() + "#" + tt39[2].ToString() + "#" + tt39[3].ToString() + "#" + tt39[4].ToString() + "#" + tt39[5].ToString();
                        // WedD0.Text = row[40].ToString();

                        string[] tt40 = row[41].ToString().Split('#');
                        WedL1.Text = tt40[0].ToString();
                        WedL1.CommandArgument = tt40[1].ToString() + "#" + tt40[2].ToString() + "#" + tt40[3].ToString() + "#" + tt40[4].ToString() + "#" + tt40[5].ToString();
                        // WedD1.Text = row[41].ToString();

                        string[] tt41 = row[42].ToString().Split('#');
                        WedL2.Text = tt41[0].ToString();
                        WedL2.CommandArgument = tt41[1].ToString() + "#" + tt41[2].ToString() + "#" + tt41[3].ToString() + "#" + tt41[4].ToString() + "#" + tt41[5].ToString();
                        // WedD2.Text = row[42].ToString();

                        string[] tt42 = row[43].ToString().Split('#');
                        WedD0.Text = tt42[0].ToString();
                        WedD1.CommandArgument = tt42[1].ToString() + "#" + tt42[2].ToString() + "#" + tt42[3].ToString() + "#" + tt42[4].ToString() + "#" + tt42[5].ToString();
                        //WedL0.Text = row[43].ToString();

                        string[] tt43 = row[44].ToString().Split('#');
                        WedD1.Text = tt43[0].ToString();
                        WedD1.CommandArgument = tt43[1].ToString() + "#" + tt43[2].ToString() + "#" + tt43[3].ToString() + "#" + tt43[4].ToString() + "#" + tt43[5].ToString();
                        //WedL1.Text = row[44].ToString();

                        //string[] tt44 = row[45].ToString().Split('#');
                        //WedD2.Text = tt44[0].ToString();
                        //WedD2.CommandArgument = tt44[1].ToString() + "#" + tt44[2].ToString();
                        ////WedL2.Text = row[45].ToString();

                        string[] tt45 = row[46].ToString().Split('#');
                        ThursB0.Text = tt45[0].ToString();
                        ThursB0.CommandArgument = tt45[1].ToString() + "#" + tt45[2].ToString() + "#" + tt45[3].ToString() + "#" + tt45[4].ToString() + "#" + tt45[5].ToString();
                        // ThursB0.Text = row[46].ToString();

                        string[] tt46 = row[47].ToString().Split('#');
                        ThursB1.Text = tt46[0].ToString();
                        ThursB1.CommandArgument = tt46[1].ToString() + "#" + tt46[2].ToString() + "#" + tt46[3].ToString() + "#" + tt46[4].ToString() + "#" + tt46[5].ToString();
                        // ThursB1.Text = row[47].ToString();

                        //string[] tt47 = row[48].ToString().Split('#');
                        //ThursB2.Text = tt47[0].ToString();
                        //ThursB2.CommandArgument = tt47[1].ToString() + "#" + tt47[2].ToString();
                        ////ThursB2.Text = row[48].ToString();

                        string[] tt48 = row[49].ToString().Split('#');
                        ThursL0.Text = tt48[0].ToString();
                        ThursL0.CommandArgument = tt48[1].ToString() + "#" + tt48[2].ToString() + "#" + tt48[3].ToString() + "#" + tt48[4].ToString() + "#" + tt48[5].ToString();
                        // ThursD0.Text = row[49].ToString();

                        string[] tt49 = row[50].ToString().Split('#');
                        ThursL1.Text = tt49[0].ToString();
                        ThursL1.CommandArgument = tt49[1].ToString() + "#" + tt49[2].ToString() + "#" + tt49[3].ToString() + "#" + tt49[4].ToString() + "#" + tt49[5].ToString();
                        //ThursD1.Text = row[50].ToString();

                        string[] tt50 = row[51].ToString().Split('#');
                        ThursL2.Text = tt50[0].ToString();
                        ThursL2.CommandArgument = tt50[1].ToString() + "#" + tt50[2].ToString() + "#" + tt50[3].ToString() + "#" + tt50[4].ToString() + "#" + tt50[5].ToString();
                        //ThursD2.Text = row[51].ToString();

                        string[] tt51 = row[52].ToString().Split('#');
                        ThursD0.Text = tt51[0].ToString();
                        ThursD0.CommandArgument = tt51[1].ToString() + "#" + tt51[2].ToString() + "#" + tt51[3].ToString() + "#" + tt51[4].ToString() + "#" + tt51[5].ToString();
                        // ThursL0.Text = row[52].ToString();

                        string[] tt52 = row[53].ToString().Split('#');
                        ThursD1.Text = tt52[0].ToString();
                        ThursD1.CommandArgument = tt52[1].ToString() + "#" + tt52[2].ToString() + "#" + tt52[3].ToString() + "#" + tt52[4].ToString() + "#" + tt52[5].ToString();
                        //ThursL1.Text = row[53].ToString();

                        //string[] tt53 = row[54].ToString().Split('#');
                        //ThursD2.Text = tt53[0].ToString();
                        //ThursD2.CommandArgument = tt53[1].ToString() + "#" + tt53[2].ToString();
                        //// ThursL2.Text = row[54].ToString();

                        string[] tt54 = row[55].ToString().Split('#');
                        FriB0.Text = tt54[0].ToString();
                        FriB0.CommandArgument = tt54[1].ToString() + "#" + tt54[2].ToString() + "#" + tt54[3].ToString() + "#" + tt54[4].ToString() + "#" + tt54[5].ToString();
                        //FriB0.Text = row[55].ToString();

                        string[] tt55 = row[56].ToString().Split('#');
                        FriB1.Text = tt55[0].ToString();
                        FriB1.CommandArgument = tt55[1].ToString() + "#" + tt55[2].ToString() + "#" + tt55[3].ToString() + "#" + tt0[4].ToString() + "#" + tt0[5].ToString();
                        // FriB1.Text = row[56].ToString();

                        //string[] tt56 = row[57].ToString().Split('#');
                        //FriB2.Text = tt53[0].ToString();
                        //FriB2.CommandArgument = tt56[1].ToString() + "#" + tt56[2].ToString();
                        ////FriB2.Text = row[57].ToString();

                        string[] tt57 = row[58].ToString().Split('#');
                        FriL0.Text = tt57[0].ToString();
                        FriL0.CommandArgument = tt57[1].ToString() + "#" + tt57[2].ToString() + "#" + tt57[3].ToString() + "#" + tt57[4].ToString() + "#" + tt57[5].ToString();
                        // FriD0.Text = row[58].ToString();

                        string[] tt58 = row[59].ToString().Split('#');
                        FriL1.Text = tt58[0].ToString();
                        FriL1.CommandArgument = tt58[1].ToString() + "#" + tt58[2].ToString() + "#" + tt58[3].ToString() + "#" + tt58[4].ToString() + "#" + tt58[5].ToString();
                        // FriD1.Text = row[59].ToString();

                        string[] tt59 = row[60].ToString().Split('#');
                        FriL2.Text = tt59[0].ToString();
                        FriL2.CommandArgument = tt59[1].ToString() + "#" + tt59[2].ToString() + "#" + tt59[3].ToString() + "#" + tt59[4].ToString() + "#" + tt59[5].ToString();
                        // FriD2.Text = row[60].ToString();

                        string[] tt60 = row[61].ToString().Split('#');
                        FriD0.Text = tt60[0].ToString();
                        FriD0.CommandArgument = tt60[1].ToString() + "#" + tt60[2].ToString() + "#" + tt60[3].ToString() + "#" + tt60[4].ToString() + "#" + tt60[5].ToString();
                        // FriL0.Text = row[61].ToString();

                        string[] tt61 = row[62].ToString().Split('#');
                        FriD1.Text = tt61[0].ToString();
                        FriD1.CommandArgument = tt61[1].ToString() + "#" + tt61[2].ToString() + "#" + tt61[3].ToString() + "#" + tt61[4].ToString() + "#" + tt61[5].ToString();
                        //FriL1.Text = row[62].ToString();

                        // string[] tt62 = row[63].ToString().Split('#');
                        // FriD2.Text = tt62[0].ToString();
                        // FriD2.CommandArgument = tt62[1].ToString() + "#" + tt62[2].ToString();
                        //// FriL2.Text = row[63].ToString();
                        string[] total1 = row[65].ToString().Split('#');
                        TotalSat.Text = total1[0].ToString();
                        TotalSat.CommandArgument = total1[0].ToString();
                        string[] total2 = row[66].ToString().Split('#');
                        TotalSun.Text = total2[0].ToString();
                        TotalSun.CommandArgument = total2[0].ToString();
                        string[] total3 = row[67].ToString().Split('#');
                        TotalMon.Text = total3[0].ToString();
                        TotalMon.CommandArgument = total3[0].ToString();
                        string[] total4 = row[68].ToString().Split('#');
                        TotalTue.Text = total4[0].ToString();
                        TotalTue.CommandArgument = total4[0].ToString();
                        string[] total5 = row[69].ToString().Split('#');
                        TotalWed.Text = total5[0].ToString();
                        TotalWed.CommandArgument = total5[0].ToString();
                        string[] total6 = row[70].ToString().Split('#');
                        TotalThurs.Text = total6[0].ToString();
                        TotalThurs.CommandArgument = total6[0].ToString();
                        string[] total7 = row[71].ToString().Split('#');
                        TotalFri.Text = total7[0].ToString();
                        TotalFri.CommandArgument = total7[0].ToString();
                    }
                    


                }

            }
        }


      

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;

            LinkButton ImgBtn = (LinkButton)sender;
            string path = ((LinkButton)sender).CommandArgument;
            string[] commandArgs = path.ToString().Split(new char[] { '#' });
            

            //IdTxt.Text = commandArgs[0].ToString();
            MaterialsTxt.Text = commandArgs[0].ToString();
            RecipeTxt.Text = commandArgs[1].ToString();
            ServingsTxt.Text = commandArgs[2].ToString();
            CookingLevelTxt.Text = commandArgs[3].ToString();
            CalorieTxt.Text = commandArgs[4].ToString();

            





        }


    }
}