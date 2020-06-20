using DL;
using DomainModel.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BL.Models.Repositories
{
    public class CaloriesRepository : DataAccessLayer
    {
        public bool Insert(CaloriesModel cm) //method for adding item
        {
            base.DataAccess();
            base.Connect();
            string Query = "insert into Calories (UserId,FoodId,Quantity,Calorie,Date) values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')";
            Query = string.Format(Query,cm.UserId,cm.FoodId,cm.Quantity,cm.Calorie,cm.Date);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;
        }


        public bool Delete(CaloriesModel cm)//method for delet
        {
            base.DataAccess();
            base.Connect();
            string Query = "delete from Calories where Id={0}";
            Query = string.Format(Query, cm.Id);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;

        }

        public bool Update(CaloriesModel cm)//method for update
        {
            base.DataAccess();
            base.Connect();
            string Query = "update Calories set FoodId=N'{0}',Quantity=N'{1}',Calorie=N'{2}',Date=N'{3}' where Id={4}";
            Query = string.Format(Query, cm.FoodId, cm.Quantity, cm.Calorie, cm.Date, cm.Id);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;

        }

        public DataTable Select()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select * from Calories order by Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable SelectByDate(CaloriesModel cm)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select Calories.Id,FoodsGroup.Name as 'Food Group',Foods.Name as 'Food Name',Foods.Calorie as 'Food Calorie',Calories.Quantity,Calories.Calorie as 'Usage Calorie',Calories.Date,Calories.FoodId,Foods.FoodGroupId,Foods.Calorie from Calories,Foods,FoodsGroup where Calories.FoodId = Foods.Id and Foods.FoodGroupId =  FoodsGroup.Id and Calories.Date = '" + cm.Date + "' and Calories.UserId = '"+cm.UserId+"' order by Calories.Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        public string SelectSumCalorie(CaloriesModel cm)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select sum(Calorie) from Calories where Date='"+ cm.Date +"' and UserId='"+cm.UserId+"'";
            string b = base.ExecuteSelect(Query);
            base.DisConnect();
            return b;
        }
    }
}