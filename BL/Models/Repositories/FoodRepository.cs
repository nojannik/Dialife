using DL;
using DomainModel.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BL.Models.Repositories
{
    public class FoodRepository : DataAccessLayer
    {
        public bool Insert(FoodModel fm) //method for adding item
        {
            base.DataAccess();
            base.Connect();
            string Query = "insert into Foods (FoodGroupId,Name,Calorie,Materials,Recipe,CookingLevel,Servings,IslamUse,INCUse) values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')";
            Query = string.Format(Query, fm.FoodGroupId, fm.Name, fm.Calorie,fm.Materials,fm.Recipe,fm.CookingLevel,fm.Servings,fm.IslamUse,fm.INCUse);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;
        }


        public bool Delete(FoodModel fm)//method for delete
        {
            base.DataAccess();
            base.Connect();
            string Query = "delete from Foods where Id={0}";
            Query = string.Format(Query, fm.Id);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;

        }
        public bool Update(FoodModel fm)//method for update
        {
            base.DataAccess();
            base.Connect();
            string Query = "update Foods set Name=N'{0}',Calorie=N'{1}',FoodGroupId=N'{2}',Materials=N'{3}',Recipe=N'{4}',CookingLevel=N'{5}',Servings=N'{6}',IslamUse=N'{7}',INCUse=N'{8}' where Id={9}";
            Query = string.Format(Query, fm.Name, fm.Calorie, fm.FoodGroupId, fm.Materials, fm.Recipe,fm.CookingLevel,fm.Servings,fm.IslamUse,fm.INCUse, fm.Id);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;

        }

        public DataTable SelectAll()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select * from Foods order by Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        public DataTable SelectByGroupId(FoodModel fm)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select * from Foods where Foods.FoodGroupId = '"+ fm.FoodGroupId +"' order by Foods.Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        public DataTable Select()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select Foods.Id,Foods.Name,Foods.Calorie,Foods.FoodGroupId,FoodsGroup.Name as 'FoodGroup',Foods.CookingLevel,Foods.Materials,Foods.Recipe,Foods.Servings,Foods.IslamUse,Foods.INCUse from Foods,FoodsGroup where Foods.FoodGroupId = FoodsGroup.Id order by Foods.Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        public string SelectCalorie(FoodModel fm)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select Calorie from Foods where Id = '" + fm.Id + "'";
            string b = base.ExecuteSelect(Query);
            base.DisConnect();
            return b;
        }

        public DataTable FindFood(FoodModel fm)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select Foods.Id,Foods.Name,Foods.Calorie,Foods.FoodGroupId,FoodsGroup.Name as 'FoodGroup',Foods.Materials,Foods.Recipe,Foods.CookingLevel,Foods.Servings from Foods,FoodsGroup where Foods.FoodGroupId = FoodsGroup.Id and Foods.Materials like '%" + fm.Materials+"%' order by Foods.Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }


        public DataTable FindFoodWithGroup(FoodModel fm)
        {
            base.DataAccess();
            base.Connect();
            //string Query = "select Foods.Id,Foods.Name,Foods.Calorie,Foods.FoodGroupId,FoodsGroup.Name as 'FoodGroup',Foods.Materials,Foods.Recipe,Foods.CookingLevel from Foods,FoodsGroup where Foods.FoodGroupId = FoodsGroup.Id and Foods.Materials like '%" + fm.Materials + "%' and Foods.FoodGroupId = '"+fm.FoodGroupId +"'order by Foods.Id desc";
            string Query = "select Foods.Id,Foods.Name,Foods.Calorie,Foods.FoodGroupId,FoodsGroup.Name as 'FoodGroup',Foods.Materials,Foods.Recipe,Foods.CookingLevel,Foods.Servings from Foods,FoodsGroup where Foods.FoodGroupId = FoodsGroup.Id and Foods.FoodGroupId = '" + fm.FoodGroupId +"'order by Foods.Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        //No reference until{
        public DataTable Recipe()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select Foods.Recipe,Foods.Name from Foods order by Foods.Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        public DataTable SelectFoodOffer()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 7 * from Foods order by NEWID()";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectBreakFastFoodOffer()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 7 * from Foods where FoodGroupId=15  and Name like '%tea%' or Name like '%coffee%'or Name like '%milk%' or Name like '%juice%' or Name like '%nescafe%' order by NEWID()";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }


        public DataTable SelectBreakFastFoodOfferBreads()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 7 * from Foods where FoodGroupId=10  and Name like '%sangak%' or Name like '%barbari%' or Name like '%toast%' or Name like '%sokhari%' or Name like '%lavash%' or Name like '%taftoon%'or Name like '%baget%' order by NEWID()";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
         // here }
        public DataTable SelectData()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36 or FoodGroupId= 39 or FoodGroupId= 40 or FoodGroupId= 41 or FoodGroupId= 19 or FoodGroupId= 23 or FoodGroupId= 20 or FoodGroupId= 37 order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        //AZ INJAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        //ISLAM CHICKEN                                                                  CHICKEN
        public DataTable SelectDataForIslamChickenLEAFS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamChickenROOTS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamChickenFRUITS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 19 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamChickenLEGUME()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 23 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamChickenMARROW()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 20 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamChickenCRUCIFEROUS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 37 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        // ISLAM BEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEFFF                             BEEF

        public DataTable SelectDataForIslamBeefLEAFS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamBeefROOTS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamBeefFRUITS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 19 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamBeefLEGUME()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 23 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamBeefMARROW()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 20 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamBeefCRUCIFEROUS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 37 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        // ISLAM SEAFOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOODD                      SEAFOOD
        public DataTable SelectDataForIslamSeafoodLEAFS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamSeafoodROOTS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamSeafoodFRUITS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 19 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamSeafoodLEGUME()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 23 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamSeafoodMARROW()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 20 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForIslamSeafoodCRUCIFEROUS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 37 or FoodGroupId = 35 or FoodGroupId = 36) and IslamUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }



        //AZ INJAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        //INC CHICKEN                                                                  CHICKEN
        public DataTable SelectDataForINCChickenLEAFS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCChickenROOTS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCChickenFRUITS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 19 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCChickenLEGUME()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 23 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCChickenMARROW()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 20 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCChickenCRUCIFEROUS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 37 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        // INC BEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEFFF                             BEEF

        public DataTable SelectDataForINCBeefLEAFS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCBeefROOTS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCBeefFRUITS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 19 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCBeefLEGUME()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 23 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCBeefMARROW()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 20 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCBeefCRUCIFEROUS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 37 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        // INC SEAFOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOODD                      SEAFOOD
        public DataTable SelectDataForINCSeafoodLEAFS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCSeafoodROOTS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCSeafoodFRUITS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 19 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCSeafoodLEGUME()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 23 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCSeafoodMARROW()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 20 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCSeafoodCRUCIFEROUS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 37 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        //INC Pork                                                                  Pork
        public DataTable SelectDataForINCPorkLEAFS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 39 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCPorkROOTS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 39 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCPorkFRUITS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 39 or FoodGroupId = 33 or FoodGroupId = 19 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCPorkLEGUME()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 39 or FoodGroupId = 33 or FoodGroupId = 23 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCPorkMARROW()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 39 or FoodGroupId = 33 or FoodGroupId = 20 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForINCPorkCRUCIFEROUS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 39 or FoodGroupId = 33 or FoodGroupId = 37 or FoodGroupId = 35 or FoodGroupId = 36) and INCUse = 1   order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        //AZ INJAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        //INC CHICKEN                                                                  CHICKEN
        public DataTable SelectDataForChickenLEAFS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForChickenROOTS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForChickenFRUITS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 19 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForChickenLEGUME()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 23 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForChickenMARROW()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 20 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForChickenCRUCIFEROUS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 41 or FoodGroupId = 33 or FoodGroupId = 37 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        // INC BEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEFFF                             BEEF

        public DataTable SelectDataForBeefLEAFS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForBeefROOTS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForBeefFRUITS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 19 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForBeefLEGUME()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 23 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForBeefMARROW()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 20 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForBeefCRUCIFEROUS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 29 or FoodGroupId = 33 or FoodGroupId = 37 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        // INC SEAFOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOODD                      SEAFOOD
        public DataTable SelectDataForSeafoodLEAFS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForSeafoodROOTS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForSeafoodFRUITS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 19 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForSeafoodLEGUME()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 23 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForSeafoodMARROW()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 20 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForSeafoodCRUCIFEROUS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 40 or FoodGroupId = 33 or FoodGroupId = 37 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        //INC Pork                                                                  Pork
        public DataTable SelectDataForPorkLEAFS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 39 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForPorkROOTS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 39 or FoodGroupId = 33 or FoodGroupId = 34 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForPorkFRUITS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 39 or FoodGroupId = 33 or FoodGroupId = 19 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForPorkLEGUME()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 39 or FoodGroupId = 33 or FoodGroupId = 23 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForPorkMARROW()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 39 or FoodGroupId = 33 or FoodGroupId = 20 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectDataForPorkCRUCIFEROUS()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 with ties Id,FoodGroupId,Name,Calorie,Materials,Recipe,Servings,CookingLevel,IslamUse,INCUse  from Foods where (FoodGroupId = 27 or FoodGroupId = 32 or FoodGroupId = 39 or FoodGroupId = 33 or FoodGroupId = 37 or FoodGroupId = 35 or FoodGroupId = 36)  order by row_number() over(partition by FoodGroupId order by NEWID())";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }


        public bool InsertFoodOffer(FoodOfferModel fo) //method for adding item
        {
            base.DataAccess();
            base.Connect();
            string Query = "insert into OfferProgram (SatB0,SatB1,SatB2,SatD0,SatD1,SatD2,SatL0,SatL1,SatL2,SunB0,SunB1,SunB2,SunD0,SunD1,SunD2,SunL0,SunL1,SunL2,MonB0,MonB1,MonB2,MonD0,MonD1,MonD2,MonL0,MonL1,MonL2,TuesB0,TuesB1,TuesB2,TuesD0,TuesD1,TuesD2,TuesL0,TuesL1,TuesL2,WedB0,WedB1,WedB2,WedD0,WedD1,WedD2,WedL0,WedL1,WedL2,ThursB0,ThursB1,ThursB2,ThursD0,ThursD1,ThursD2,ThursL0,ThursL1,ThursL2,FriB0,FriB1,FriB2,FriD0,FriD1,FriD2,FriL0,FriL1,FriL2,UserId,TotalSat,TotalSun,TotalMon,TotalTue,TotalWed,TotalThurs,TotalFri) values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}',N'{13}',N'{14}',N'{15}',N'{16}',N'{17}',N'{18}',N'{19}',N'{20}',N'{21}',N'{22}',N'{23}',N'{24}',N'{25}',N'{26}',N'{27}',N'{28}',N'{29}',N'{30}',N'{31}',N'{32}',N'{33}',N'{34}',N'{35}',N'{36}',N'{37}',N'{38}',N'{39}',N'{40}',N'{41}',N'{42}',N'{43}',N'{44}',N'{45}',N'{46}',N'{47}',N'{48}',N'{49}',N'{50}',N'{51}',N'{52}',N'{53}',N'{54}',N'{55}',N'{56}',N'{57}',N'{58}',N'{59}',N'{60}',N'{61}',N'{62}',N'{63}',N'{64}',N'{65}',N'{66}',N'{67}',N'{68}',N'{69}',N'{70}')";
            Query =  string.Format(Query, fo.SatB0, fo.SatB1, fo.SatB2, fo.SatD0, fo.SatD1, fo.SatD2, fo.SatL0, fo.SatL1, fo.SatL2, fo.SunB0, fo.SunB1, fo.SunB2, fo.SunD0, fo.SunD1, fo.SunD2, fo.SunL0, fo.SunL1, fo.SunL2, fo.MonB0, fo.MonB1, fo.MonB2, fo.MonD0, fo.MonD1, fo.MonD2, fo.MonL0, fo.MonL1, fo.MonL2, fo.TuesB0, fo.TuesB1, fo.TuesB2, fo.TuesD0, fo.TuesD1, fo.TuesD2, fo.TuesL0, fo.TuesL1, fo.TuesL2, fo.WedB0, fo.WedB1, fo.WedB2, fo.WedD0, fo.WedD1, fo.WedD2, fo.WedL0, fo.WedL1, fo.WedL2, fo.ThursB0, fo.ThursB1, fo.ThursB2, fo.ThursD0, fo.ThursD1, fo.ThursD2, fo.ThursL0, fo.ThursL1, fo.ThursL2, fo.FriB0, fo.FriB1, fo.FriB2, fo.FriD0, fo.FriD1, fo.FriD2, fo.FriL0, fo.FriL1, fo.FriL2, fo.UserId,fo.TotalSat,fo.TotalSun,fo.TotalMon,fo.TotalTue,fo.TotalWed,fo.TotalThurs,fo.TotalFri);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;
        }


    

        public string SelectAllergy(int UserId)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select Allergy from Users where Id='" + UserId + "'";
            string b = base.ExecuteSelect(Query);
            base.DisConnect();
            return b;
        }


        public DataTable SelectSavedFood(int UserId)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select top 1 * from OfferProgram where UserId ='"+ UserId +"' ORDER BY ID DESC";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }


        public string SelectMaxCalorie(int UserId)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select MaximumCalery from Users where Id = '" + UserId + "'";
            string b = base.ExecuteSelect(Query);
            base.DisConnect();
            return b;
        }

    }
}