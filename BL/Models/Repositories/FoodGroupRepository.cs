using DL;
using DomainModel.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BL.Models.Repositories
{
    public class FoodGroupRepository : DataAccessLayer
    {
        public bool Insert(FoodGroupModel fm) //method for adding item
        {
            base.DataAccess();
            base.Connect();
            string Query = "insert into FoodsGroup (Name) values (N'{0}')";
            Query = string.Format(Query, fm.Name);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;
        }


        public bool Delete(FoodGroupModel fm)//method for delet
        {
            base.DataAccess();
            base.Connect();
            string Query = "delete from FoodsGroup where Id={0}";
            Query = string.Format(Query, fm.Id);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;

        }
        public bool Update(FoodGroupModel fm)//method for update
        {
            base.DataAccess();
            base.Connect();
            string Query = "update FoodsGroup set Name=N'{0}' where ID={1}";
            Query = string.Format(Query, fm.Name, fm.Id);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;

        }

        public DataTable Select()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select * from FoodsGroup order by Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

    }
}