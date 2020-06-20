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
    public partial class FoodOffer : System.Web.UI.Page
    {
        FoodRepository fr = new FoodRepository();
        FoodOfferModel fo = new FoodOfferModel();
        RegistrationModel rm = new RegistrationModel();
        RegistrationRepository rr = new RegistrationRepository();
        FoodModel fm = new FoodModel();

        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        public int res ;
        public int res1;
        public int res2;
        public int res3;
        public int res4;
        public int res5;
        public int res6;

        public int meatmeal;
        public int vegmeal;
        //public static int a0,a1, a2, a3, a4, a5, a6, a7;
        //public static int b0,b1, b2, b3, b4, b5, b6, b7;
        //public static int c0,c1, c2, c3, c4, c5, c6, c7;
        //public static int d0,d1, d2, d3, d4, d5, d6, rmd7;
        //public static int e0,e1, e2, e3, e4, e5, e6, e7;
        //public static int f0,f1, f2, f3, f4, f5, f6, f7;
        //public static int g0,g1, g2, g3, g4, g5, g6, g7;


        public static string a0, a1, a2, a3, a4, a5, a6, a7;
        public static string b0, b1, b2, b3, b4, b5, b6, b7;
        public static string c0, c1, c2, c3, c4, c5, c6, c7;
        public static string d0, d1, d2, d3, d4, d5, d6, d7;
        public static string e0, e1, e2, e3, e4, e5, e6, e7;
        public static string f0, f1, f2, f3, f4, f5, f6, f7;
        public static string g0, g1, g2, g3, g4, g5, g6, g7;

        public static string t1,t2,t3,t4,t5,t6,t7;



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
                    GetOfferData();
                   // GetOfferData();
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {

                        DataRow row = table1.Rows[i];
                        if (Convert.ToInt32(row[1]) == 27)
                        {
                            //a0 = Convert.ToInt32(row[0]);
                            a0 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SatB0.Text = row[2].ToString();
                            SatB0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 32))
                        {
                            //a1 = Convert.ToInt32(row[0]);
                            a1 = row[2].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SatB1.Text = row[2].ToString();
                            SatB1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }

                        else if (Convert.ToInt32(row[1]) == meatmeal)
                        {
                            //a2 = Convert.ToInt32(row[0]);
                            a2 = row[2].ToString() + "#" + row[3].ToString() + "#"+ row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SatL0.Text = row[2].ToString();
                            SatL0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 33))
                        {
                            //a3 = Convert.ToInt32(row[0]);
                            a3 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SatL1.Text = row[2].ToString();
                            SatL1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == vegmeal))
                        {
                            //a4 = Convert.ToInt32(row[0]);
                            a4 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SatL2.Text = row[2].ToString();
                            SatL2.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 35))
                        {
                            //a5 = Convert.ToInt32(row[0]);
                            a5 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SatD0.Text = row[2].ToString();
                            SatD0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 36))
                        {
                            //a6 = Convert.ToInt32(row[0]);
                            a6 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SatD1.Text = row[2].ToString();
                            SatD1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        //else if ((Convert.ToInt32(row[1]) == 19))
                        //{
                        //    //a7 = Convert.ToInt32(row[0]);
                        //    a7 = row[2].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //    SatD2.Text = row[2].ToString();
                        //    SatD2.CommandArgument = row[0].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //}
                        res = res + Convert.ToInt32(row[3].ToString());
                        TotalSat.Text = res.ToString();
                        t1 = TotalSat.Text;

                    }


                    GetOfferData();
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {

                        DataRow row = table1.Rows[i];
                        if ((Convert.ToInt32(row[1]) == 27))
                        {
                           // b0 = Convert.ToInt32(row[0]);
                           b0 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SunB0.Text = row[2].ToString();
                            SunB0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 32))
                        {
                            //b1 = Convert.ToInt32(row[0]);
                            b1 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SunB1.Text = row[2].ToString();
                            SunB1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }

                        else if (Convert.ToInt32(row[1]) == meatmeal)
                        {
                           // b2 = Convert.ToInt32(row[0]);
                           b2 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SunL0.Text = row[2].ToString();
                            SunL0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 33))
                        {
                            //b3 = Convert.ToInt32(row[0]);
                            b3 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SunL1.Text = row[2].ToString();
                            SunL1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == vegmeal))
                        {
                           // b4 = Convert.ToInt32(row[0]);
                           b4 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SunL2.Text = row[2].ToString();
                            SunL2.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 35))
                        {
                           // b5 = Convert.ToInt32(row[0]);
                            b5 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SunD0.Text = row[2].ToString();
                            SunD0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 36))
                        {
                           // b6 = Convert.ToInt32(row[0]);
                            b6 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            SunD1.Text = row[2].ToString();
                            SunD1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }

                        //else if ((Convert.ToInt32(row[1]) == 19))
                        //{
                        //   // b7 = Convert.ToInt32(row[0]);
                        //   b7= row[2].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //    SunD2.Text = row[2].ToString();
                        //    SunD2.CommandArgument = row[0].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //}
                        res1 = res1 + Convert.ToInt32(row[3].ToString());
                        TotalSun.Text = res1.ToString();
                        t2 = TotalSun.Text;
                    }



                    GetOfferData();
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {

                        DataRow row = table1.Rows[i];
                        if ((Convert.ToInt32(row[1]) == 27))
                        {
                            //c0 = Convert.ToInt32(row[0]);
                            c0 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            MonB0.Text = row[2].ToString();
                            MonB0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 32))
                        {
                            //c1 = Convert.ToInt32(row[0]);
                            c1 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            MonB1.Text = row[2].ToString();
                            MonB1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }

                        else if (Convert.ToInt32(row[1]) == meatmeal)
                        {
                            //c2 = Convert.ToInt32(row[0]);
                            c2 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            MonL0.Text = row[2].ToString();
                            MonL0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 33))
                        {
                            //c3 = Convert.ToInt32(row[0]);
                            c3= row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            MonL1.Text = row[2].ToString();
                            MonL1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == vegmeal))
                        {
                            //c4 = Convert.ToInt32(row[0]);
                            c4 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            MonL2.Text = row[2].ToString();
                            MonL2.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 35))
                        {
                            //c5 = Convert.ToInt32(row[0]);
                            c5 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            MonD0.Text = row[2].ToString();
                            MonD0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 36))
                        {
                            //c6 = Convert.ToInt32(row[0]);
                            c6 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            MonD1.Text = row[2].ToString();
                            MonD1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        //else if ((Convert.ToInt32(row[1]) == 19))
                        //{
                        //    //c7 = Convert.ToInt32(row[0]);
                        //    c7 = row[2].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //    MonD2.Text = row[2].ToString();
                        //    MonD2.CommandArgument = row[0].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //}
                        res2 = res2 + Convert.ToInt32(row[3].ToString());
                        TotalMon.Text = res2.ToString();
                        t3 = TotalMon.Text;
                    }



                    GetOfferData();
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {

                        DataRow row = table1.Rows[i];
                        if ((Convert.ToInt32(row[1]) == 27))
                        {
                           // d0 = Convert.ToInt32(row[0]);
                            d0 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            TuesB0.Text = row[2].ToString();
                            TuesB0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 32))
                        {
                            //d1 = Convert.ToInt32(row[0]);
                            d1 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            TuesB1.Text = row[2].ToString();
                            TuesB1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }

                        else if (Convert.ToInt32(row[1]) == meatmeal)
                        {
                            //d2 = Convert.ToInt32(row[0]);
                            d2 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            TuesL0.Text = row[2].ToString();
                            TuesL0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 33))
                        {
                            //d3 = Convert.ToInt32(row[0]);
                            d3 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            TuesL1.Text = row[2].ToString();
                            TuesL1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == vegmeal))
                        {
                            //d4 = Convert.ToInt32(row[0]);
                            d4 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            TuesL2.Text = row[2].ToString();
                            TuesL2.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 35))
                        {
                            //d5 = Convert.ToInt32(row[0]);
                            d5 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            TuesD0.Text = row[2].ToString();
                            TuesD0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 36))
                        {
                            //d6 = Convert.ToInt32(row[0]);
                            d6 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            TuesD1.Text = row[2].ToString();
                            TuesD1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        //else if ((Convert.ToInt32(row[1]) == 19))
                        //{
                        //    //d7 = Convert.ToInt32(row[0]);
                        //    d7 = row[2].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //    TuesD2.Text = row[2].ToString();
                        //    TuesD2.CommandArgument = row[0].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //}
                        res3 = res3 + Convert.ToInt32(row[3].ToString());
                        TotalTue.Text = res3.ToString();
                        t4 = TotalTue.Text;
                    }


                    GetOfferData();
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {

                        DataRow row = table1.Rows[i];
                        if ((Convert.ToInt32(row[1]) == 27))
                        {
                            //e0 = Convert.ToInt32(row[0]);
                            e0 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            WedB0.Text = row[2].ToString();
                            WedB0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 32))
                        {
                           // e1 = Convert.ToInt32(row[0]);
                           e1 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            WedB1.Text = row[2].ToString();
                            WedB1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }

                        else if (Convert.ToInt32(row[1]) == meatmeal)
                        {
                           // e2 = Convert.ToInt32(row[0]);
                           e2 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            WedL0.Text = row[2].ToString();
                            WedL0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 33))
                        {
                           // e3 = Convert.ToInt32(row[0]);
                           e3 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            WedL1.Text = row[2].ToString();
                            WedL1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == vegmeal))
                        {
                            //e4 = Convert.ToInt32(row[0]);
                            e4 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            WedL2.Text = row[2].ToString();
                            WedL2.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 35))
                        {
                            //e5 = Convert.ToInt32(row[0]);
                            e5 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            WedD0.Text = row[2].ToString();
                            WedD0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 36))
                        {
                            //e6 = Convert.ToInt32(row[0]);
                            e6 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            WedD1.Text = row[2].ToString();
                            WedD1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        //else if ((Convert.ToInt32(row[1]) == 19))
                        //{
                        //   // e7 = Convert.ToInt32(row[0]);
                        //   e7 = row[2].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //    WedD2.Text = row[2].ToString();
                        //    WedD2.CommandArgument = row[0].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //}
                        res4 = res4 + Convert.ToInt32(row[3].ToString());
                        TotalWed.Text = res4.ToString();
                        t5 = TotalWed.Text;
                    }
                    



                    GetOfferData();
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {

                        DataRow row = table1.Rows[i];
                        if ((Convert.ToInt32(row[1]) == 27))
                        {
                            //f0 = Convert.ToInt32(row[0]);
                            f0 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            ThursB0.Text = row[2].ToString();
                            ThursB0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 32))
                        {
                            //f1 = Convert.ToInt32(row[0]);
                            f1 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            ThursB1.Text = row[2].ToString();
                            ThursB1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }

                        else if (Convert.ToInt32(row[1]) == meatmeal)
                        {
                            //f2 = Convert.ToInt32(row[0]);
                            f2 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            ThursL0.Text = row[2].ToString();
                            ThursL0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 33))
                        {
                            //f3 = Convert.ToInt32(row[0]);
                            f3 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            ThursL1.Text = row[2].ToString();
                            ThursL1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == vegmeal))
                        {
                            //f4 = Convert.ToInt32(row[0]);
                            f4 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            ThursL2.Text = row[2].ToString();
                            ThursL2.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 35))
                        {
                            //f5 = Convert.ToInt32(row[0]);
                            f5 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            ThursD0.Text = row[2].ToString();
                            ThursD0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 36))
                        {
                            //f6 = Convert.ToInt32(row[0]);
                            f6 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            ThursD1.Text = row[2].ToString();
                            ThursD1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        //else if ((Convert.ToInt32(row[1]) == 19))
                        //{
                        //    //f7 = Convert.ToInt32(row[0]);
                        //    f7= row[2].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //    ThursD2.Text = row[2].ToString();
                        //    ThursD2.CommandArgument = row[0].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //}
                        res5 = res5 + Convert.ToInt32(row[3].ToString());
                        TotalThurs.Text = res5.ToString();
                        t6 = TotalThurs.Text;
                    }




                    GetOfferData();
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {

                        DataRow row = table1.Rows[i];
                        if ((Convert.ToInt32(row[1]) == 27))
                        {
                            //g0 = Convert.ToInt32(row[0]);
                            g0 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            FriB0.Text = row[2].ToString();
                            FriB0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 32))
                        {
                            //g1 = Convert.ToInt32(row[0]);
                            g1 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            FriB1.Text = row[2].ToString();
                            FriB1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }

                        else if (Convert.ToInt32(row[1]) == meatmeal)
                        {
                            //g2 = Convert.ToInt32(row[0]);
                            g2 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            FriL0.Text = row[2].ToString();
                            FriL0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 33))
                        {
                            //g3 = Convert.ToInt32(row[0]);
                            g3 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            FriL1.Text = row[2].ToString();
                            FriL1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == vegmeal))
                        {
                            //g4 = Convert.ToInt32(row[0]);
                            g4 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            FriL2.Text = row[2].ToString();
                            FriL2.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 35))
                        {
                            //g5 = Convert.ToInt32(row[0]);
                            g5 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            FriD0.Text = row[2].ToString();
                            FriD0.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        else if ((Convert.ToInt32(row[1]) == 36))
                        {
                            //g6 = Convert.ToInt32(row[0]);
                            g6 = row[2].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                            FriD1.Text = row[2].ToString();
                            FriD1.CommandArgument = row[0].ToString() + "#" + row[3].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString() + "#" + row[6].ToString() + "#" + row[7].ToString() + "#" + row[8].ToString();
                        }
                        //else if ((Convert.ToInt32(row[1]) == 19))
                        //{
                        //    //g7 = Convert.ToInt32(row[0]);
                        //    g7 = row[2].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //    FriD2.Text = row[2].ToString();
                        //    FriD2.CommandArgument = row[0].ToString() + "#" + row[4].ToString() + "#" + row[5].ToString();
                        //}
                        res6 = res6 + Convert.ToInt32(row[3].ToString());
                        TotalFri.Text = res6.ToString();
                        t7 = TotalFri.Text;

                    }



                }



            }
           
        }


        //public void GetOfferData()
        //{
        //    string allergy = fr.SelectAllergy(Convert.ToInt32(UserIdTxt.Text));
        //    string lowerAllergy = allergy.ToLower();
        //    int maxCalorie =Convert.ToInt32(fr.SelectMaxCalorie(Convert.ToInt32(UserIdTxt.Text)));
        //    table1 = new DataTable();

        //    int res = 0 ; 
        //    while ((res < (maxCalorie-200)) || (res > maxCalorie))
        //    {
        //        res = 0;
        //        table1 = new DataTable();
        //        table1 = fr.SelectData();
        //        for (int i = 0; i < table1.Rows.Count; i++)
        //        {

        //            DataRow row = table1.Rows[i];
        //            //if (row[2].ToString() == allergy)
        //            if (Regex.IsMatch(lowerAllergy, row[2].ToString() ))
        //            {
        //                break;
        //            }
        //            else
        //            {
        //                res = res + Convert.ToInt32(row[3].ToString());
        //                //arr1[i].Text = row[1].ToString();
        //            }

        //        }
        //    }



        //}





        public void GetOfferData()
        {
           

            string allergy = fr.SelectAllergy(Convert.ToInt32(UserIdTxt.Text));
            string lowerAllergy = allergy.ToLower();
            string allergies = lowerAllergy.Replace(" ", "");
            string finalAllergy = allergies;
            string[] allergyList = finalAllergy.Split(',');

            int maxCalorie = Convert.ToInt32(fr.SelectMaxCalorie(Convert.ToInt32(UserIdTxt.Text)));

            rm.Id = Convert.ToInt32(UserIdTxt.Text);
            string reg = rr.SelectReligion(rm);
            // az inja vase preferences e
            string meatp = rr.SelectMeatPrefer(rm);
            string vegp = rr.SelectVegPrefer(rm);




             

            table1 = new DataTable();

            
            int res = 0;
            while ((res < (maxCalorie - 300)) || (res >(maxCalorie + 300)))
            {
                res = 0;
                table1 = new DataTable();

                if (reg == "Islam")
                {
                    if(meatp == "chicken" && vegp=="leafs")
                    {
                        table1 = fr.SelectDataForIslamChickenLEAFS();
                    }
                    else if(meatp == "chicken" && vegp == "roots")
                    {
                        table1 = fr.SelectDataForIslamChickenROOTS();
                    }
                    else if (meatp == "chicken" && vegp == "fruits")
                    {
                        table1 = fr.SelectDataForIslamChickenFRUITS();
                    }
                    else if (meatp == "chicken" && vegp == "legume")
                    {
                        table1 = fr.SelectDataForIslamChickenLEGUME();
                    }
                    else if (meatp == "chicken" && vegp == "marrow")
                    {
                        table1 = fr.SelectDataForIslamChickenMARROW();
                    }
                    else if (meatp == "chicken" && vegp == "cruciferous")
                    {
                        table1 = fr.SelectDataForIslamBeefCRUCIFEROUS();
                    }
                    else if (meatp == "beef" && vegp == "leafs")
                    {
                        table1 = fr.SelectDataForIslamBeefLEAFS();
                    }
                    else if (meatp == "beef" && vegp == "roots")
                    {
                        table1 = fr.SelectDataForIslamBeefROOTS();
                    }
                    else if (meatp == "beef" && vegp == "fruits")
                    {
                        table1 = fr.SelectDataForIslamBeefFRUITS();
                    }
                    else if (meatp == "beef" && vegp == "legume")
                    {
                        table1 = fr.SelectDataForIslamBeefLEGUME();
                    }
                    else if (meatp == "beef" && vegp == "marrow")
                    {
                        table1 = fr.SelectDataForIslamBeefMARROW();
                    }
                    else if (meatp == "beef" && vegp == "cruciferous")
                    {
                        table1 = fr.SelectDataForIslamBeefCRUCIFEROUS();
                    }
                    else if (meatp == "seafood" && vegp == "leafs")
                    {
                        table1 = fr.SelectDataForIslamSeafoodLEAFS();
                    }
                    else if (meatp == "seafood" && vegp == "roots")
                    {
                        table1 = fr.SelectDataForIslamSeafoodROOTS();
                    }
                    else if (meatp == "seafood" && vegp == "fruits")
                    {
                        table1 = fr.SelectDataForIslamSeafoodFRUITS();
                    }
                    else if (meatp == "seafood" && vegp == "legume")
                    {
                        table1 = fr.SelectDataForIslamSeafoodLEGUME();
                    }
                    else if (meatp == "seafood" && vegp == "marrow")
                    {
                        table1 = fr.SelectDataForIslamSeafoodMARROW();
                    }
                    else if (meatp == "seafood" && vegp == "cruciferous")
                    {
                        table1 = fr.SelectDataForIslamSeafoodCRUCIFEROUS();
                    }
                    else
                    {
                        table1 = fr.SelectDataForIslamBeefLEAFS();
                    }
                    
                }
                else if(reg == "INC")
                {
                    if (meatp == "chicken" && vegp == "leafs")
                    {
                        table1 = fr.SelectDataForINCChickenLEAFS();
                    }
                    else if (meatp == "chicken" && vegp == "roots")
                    {
                        table1 = fr.SelectDataForINCChickenROOTS();
                    }
                    else if (meatp == "chicken" && vegp == "fruits")
                    {
                        table1 = fr.SelectDataForINCChickenFRUITS();
                    }
                    else if (meatp == "chicken" && vegp == "legume")
                    {
                        table1 = fr.SelectDataForINCChickenLEGUME();
                    }
                    else if (meatp == "chicken" && vegp == "marrow")
                    {
                        table1 = fr.SelectDataForINCChickenMARROW();
                    }
                    else if (meatp == "chicken" && vegp == "cruciferous")
                    {
                        table1 = fr.SelectDataForINCBeefCRUCIFEROUS();
                    }
                    else if (meatp == "beef" && vegp == "leafs")
                    {
                        table1 = fr.SelectDataForINCBeefLEAFS();
                    }
                    else if (meatp == "beef" && vegp == "roots")
                    {
                        table1 = fr.SelectDataForINCBeefROOTS();
                    }
                    else if (meatp == "beef" && vegp == "fruits")
                    {
                        table1 = fr.SelectDataForINCBeefFRUITS();
                    }
                    else if (meatp == "beef" && vegp == "legume")
                    {
                        table1 = fr.SelectDataForINCBeefLEGUME();
                    }
                    else if (meatp == "beef" && vegp == "marrow")
                    {
                        table1 = fr.SelectDataForINCBeefMARROW();
                    }
                    else if (meatp == "beef" && vegp == "cruciferous")
                    {
                        table1 = fr.SelectDataForINCBeefCRUCIFEROUS();
                    }
                    else if (meatp == "seafood" && vegp == "leafs")
                    {
                        table1 = fr.SelectDataForINCSeafoodLEAFS();
                    }
                    else if (meatp == "seafood" && vegp == "roots")
                    {
                        table1 = fr.SelectDataForINCSeafoodROOTS();
                    }
                    else if (meatp == "seafood" && vegp == "fruits")
                    {
                        table1 = fr.SelectDataForINCSeafoodFRUITS();
                    }
                    else if (meatp == "seafood" && vegp == "legume")
                    {
                        table1 = fr.SelectDataForINCSeafoodLEGUME();
                    }
                    else if (meatp == "seafood" && vegp == "marrow")
                    {
                        table1 = fr.SelectDataForINCSeafoodMARROW();
                    }
                    else if (meatp == "seafood" && vegp == "cruciferous")
                    {
                        table1 = fr.SelectDataForINCSeafoodCRUCIFEROUS();
                    }
                }
                else
                {
                    if (meatp == "chicken" && vegp == "leafs")
                    {
                        table1 = fr.SelectDataForChickenLEAFS();
                    }
                    else if (meatp == "chicken" && vegp == "roots")
                    {
                        table1 = fr.SelectDataForChickenROOTS();
                    }
                    else if (meatp == "chicken" && vegp == "fruits")
                    {
                        table1 = fr.SelectDataForChickenFRUITS();
                    }
                    else if (meatp == "chicken" && vegp == "legume")
                    {
                        table1 = fr.SelectDataForChickenLEGUME();
                    }
                    else if (meatp == "chicken" && vegp == "marrow")
                    {
                        table1 = fr.SelectDataForChickenMARROW();
                    }
                    else if (meatp == "chicken" && vegp == "cruciferous")
                    {
                        table1 = fr.SelectDataForBeefCRUCIFEROUS();
                    }
                    else if (meatp == "beef" && vegp == "leafs")
                    {
                        table1 = fr.SelectDataForBeefLEAFS();
                    }
                    else if (meatp == "beef" && vegp == "roots")
                    {
                        table1 = fr.SelectDataForBeefROOTS();
                    }
                    else if (meatp == "beef" && vegp == "fruits")
                    {
                        table1 = fr.SelectDataForBeefFRUITS();
                    }
                    else if (meatp == "beef" && vegp == "legume")
                    {
                        table1 = fr.SelectDataForBeefLEGUME();
                    }
                    else if (meatp == "beef" && vegp == "marrow")
                    {
                        table1 = fr.SelectDataForBeefMARROW();
                    }
                    else if (meatp == "beef" && vegp == "cruciferous")
                    {
                        table1 = fr.SelectDataForBeefCRUCIFEROUS();
                    }
                    else if (meatp == "seafood" && vegp == "leafs")
                    {
                        table1 = fr.SelectDataForSeafoodLEAFS();
                    }
                    else if (meatp == "seafood" && vegp == "roots")
                    {
                        table1 = fr.SelectDataForSeafoodROOTS();
                    }
                    else if (meatp == "seafood" && vegp == "fruits")
                    {
                        table1 = fr.SelectDataForSeafoodFRUITS();
                    }
                    else if (meatp == "seafood" && vegp == "legume")
                    {
                        table1 = fr.SelectDataForSeafoodLEGUME();
                    }
                    else if (meatp == "seafood" && vegp == "marrow")
                    {
                        table1 = fr.SelectDataForSeafoodMARROW();
                    }
                    else if (meatp == "seafood" && vegp == "cruciferous")
                    {
                        table1 = fr.SelectDataForSeafoodCRUCIFEROUS();
                    }
                }
                // MEAT PREFERENCES
                

                if (meatp == "beef")
                {
                   meatmeal = 29;
                }
                else if(meatp == "chicken")
                {
                    meatmeal = 41;
                }
                else if (meatp == "seafood")
                {
                    meatmeal = 40;
                }
                else if (meatp == "pork")
                {
                    meatmeal = 43;
                }
                else
                {
                    var rMeat = new Random();
                    var randommeat = new List<int> { 29, 41, 40, 39 };
                    int countMeat = randommeat.Count;
                    int meatVal = rMeat.Next(countMeat);
                    meatmeal = randommeat[meatVal];
                }
                // VEG PREFERENCES
                if (vegp == "fruits")
                {
                    vegmeal = 19;
                }
                else if (vegp == "marrow")
                {
                    vegmeal = 20;
                }
                else if (vegp == "cruciferous")
                {
                    vegmeal = 37;
                }
                else if (vegp == "roots")
                {
                    vegmeal = 38;
                }
                else if (vegp == "leafs")
                {
                    vegmeal = 34;
                }
                else if (vegp == "legume")
                {
                    vegmeal = 23;
                }
                else
                {
                    var rVeg = new Random();
                    var randomVeg = new List<int> { 19,20,37,38,34,23 };
                    int countVeg = randomVeg.Count;
                    int vegVal = rVeg.Next(countVeg);
                    meatmeal = randomVeg[vegVal];
                }



                for (int i = 0; i < table1.Rows.Count; i++)
                {

                    DataRow row = table1.Rows[i];

                    string newString = row[4].ToString().Replace(" ", "");
                    string t = newString;
                    string[] wordsItem = t.Split(',');


                    for (int k = 0; k <= allergyList.Length - 1; k++)
                    {
                        for (int j = 0; j <= wordsItem.Length - 1; j++)
                        {
                            if (allergyList[k] == wordsItem[j])
                            {
                                GetOfferData();
                            }
                        }
                    }
                    //else
                    //{
                    //    DataRow drNew = table2.NewRow();
                    //    drNew.ItemArray = row.ItemArray;
                    //    table2.Rows.Add(drNew);
                    //}


                    res = res + Convert.ToInt32(row[3].ToString());
                    
                }

            }
        }

        

        //public void GetOfferData()
        //{


        //    string allergy = fr.SelectAllergy(Convert.ToInt32(UserIdTxt.Text));
        //    string lowerAllergy = allergy.ToLower();
        //    string allergies = lowerAllergy.Replace(" ", "");
        //    string finalAllergy = allergies;
        //    string[] allergyList = finalAllergy.Split(',');

        //    int maxCalorie = Convert.ToInt32(fr.SelectMaxCalorie(Convert.ToInt32(UserIdTxt.Text)));

        //    rm.Id = Convert.ToInt32(UserIdTxt.Text);
        //    string reg = rr.SelectReligion(rm);


        //    table1 = new DataTable();

        //    int res = 0;
        //    while ((res < (maxCalorie - 200)) || (res > maxCalorie))
        //    {
        //        res = 0;
        //        table1 = new DataTable();
        //        table2 = new DataTable();

        //        table1 = fr.SelectData();
        //        table2 = table1.Clone();



        //        for (int i = 0; i < table1.Rows.Count; i++)
        //        {

        //            DataRow row = table1.Rows[i];

        //            string newString = row[4].ToString().Replace(" ", "");
        //            string t = newString;
        //            string[] wordsItem = t.Split(',');


        //            for (int k = 0; k <= allergyList.Length - 1; k++)
        //            {
        //                for (int j = 0; j <= wordsItem.Length - 1; j++)
        //                {
        //                    if (allergyList[k] != wordsItem[j])
        //                    {
        //                        if (reg == "Islam" || reg == "INC")
        //                        {
        //                            if (wordsItem[j] != "pork" || wordsItem[j] != "blood")
        //                            {
        //                                break;
        //                            }
        //                            else
        //                            {
        //                                DataRow drNew = table2.NewRow();
        //                                drNew.ItemArray = row.ItemArray;
        //                                table2.Rows.Add(drNew);
        //                            }
        //                        }
        //                    }

        //                    //if (reg == "Islam" || reg == "INC")
        //                    //{
        //                    //    if (wordsItem[j] == "pork" || wordsItem[j] == "blood")
        //                    //    {
        //                    //        break;
        //                    //    }
        //                    //}
        //                }

        //                // else
        //                // {
        //                //    table1.ImportRow(row);
        //                // res = res + Convert.ToInt32(row[3].ToString());
        //                //}
        //                //}
        //            }
        //            res = res + Convert.ToInt32(row[3].ToString());

        //        }
        //    }

        //}

            



        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;

            LinkButton ImgBtn = (LinkButton)sender;
            string path = ((LinkButton)sender).CommandArgument;
            string[] commandArgs = path.ToString().Split(new char[] { '#' });

            IdTxt.Text = commandArgs[0].ToString();
            MaterialsTxt.Text = commandArgs[1].ToString();
            RecipeTxt.Text = commandArgs[2].ToString();
            ServingsTxt.Text = commandArgs[3].ToString();
            CookingLevelTxt.Text = commandArgs[4].ToString();
            CalorieTxt.Text = commandArgs[5].ToString();
            
           // NotFriendlyTxt.Text = commandArgs[5].ToString();


        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            fo = new FoodOfferModel();



            fo.SatB0 = (a0);
            fo.SatB1 = (a1);
            fo.SatL0 = (a2);
            fo.SatL1 = (a3);
            fo.SatL2 = (a4);
            fo.SatD0 = (a5);
            fo.SatD1 = (a6);
           // fo.SatD2 = (a7);


            fo.SunB0 = (b0);
            fo.SunB1 = (b1);
            fo.SunL0 = (b2);
            fo.SunL1 = (b3);
            fo.SunL2 = (b4);
            fo.SunD0 = (b5);
            fo.SunD1 = (b6);
           // fo.SunD2 = (b7);


            fo.MonB0 = (c0);
            fo.MonB1 = (c1);
            fo.MonL0 = (c2);
            fo.MonL1 = (c3);
            fo.MonL2 = (c4);
            fo.MonD0 = (c5);
            fo.MonD1 = (c6);
          //  fo.MonD2 = (c7);



            fo.TuesB0 = (d0);
            fo.TuesB1 = (d1);
            fo.TuesL0 = (d2);
            fo.TuesL1 = (d3);
            fo.TuesL2 = (d4);
            fo.TuesD0 = (d5);
            fo.TuesD1 = (d6);
          //  fo.TuesD2 = (d7);


            fo.WedB0 = (e0);
            fo.WedB1 = (e1);
            fo.WedL0 = (e2);
            fo.WedL1 = (e3);
            fo.WedL2 = (e4);
            fo.WedD0 = (e5);
            fo.WedD1 = (e6);
          //  fo.WedD2 = (e7);



            fo.ThursB0 = (f0);
            fo.ThursB1 = (f1);
            fo.ThursL0 = (f2);
            fo.ThursL1 = (f3);
            fo.ThursL2 = (f4);
            fo.ThursD0 = (f5);
            fo.ThursD1 = (f6);
          //  fo.ThursD2 = (f7);


            fo.FriB0 = (g0);
            fo.FriB1 = (g1);
            fo.FriL0 = (g2);
            fo.FriL1 = (g3);
            fo.FriL2 = (g4);
            fo.FriD0 = (g5);
            fo.FriD1 = (g6);
            //   fo.FriD2 = (g7);

            fo.TotalSat = (t1);
            fo.TotalSun = (t2);
            fo.TotalMon = (t3);
            fo.TotalTue = (t4);
            fo.TotalWed = (t5);
            fo.TotalThurs = (t6);
            fo.TotalFri = (t7);





            fo.UserId = Convert.ToInt32(UserIdTxt.Text);
            





            bool res = fr.InsertFoodOffer(fo);
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


        }
    }
}