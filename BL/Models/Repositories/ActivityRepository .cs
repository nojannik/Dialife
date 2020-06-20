using DL;
using DomainModel.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BL.Models.Repositories
{
    public class ActivityRepository : DataAccessLayer
    {
        public bool Insert(ActivityModel am) //method for adding item
        {
            base.DataAccess();
            base.Connect();
            string Query = "insert into Activities (Name,Metabolism) values (N'{0}',N'{1}')";
            Query = string.Format(Query, am.Name, am.Metabolism);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;
        }


        public bool Delete(ActivityModel am)//method for delet
        {
            base.DataAccess();
            base.Connect();
            string Query = "delete from Activities where Id={0}";
            Query = string.Format(Query, am.Id);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;

        }
        public bool Update(ActivityModel am)//method for update
        {
            base.DataAccess();
            base.Connect();
            string Query = "update Activities set Name=N'{0}',Metabolism=N'{1}' where Id={2}";
            Query = string.Format(Query, am.Name,am.Metabolism, am.Id);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;

        }

        public DataTable Select()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select * from Activities order by Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        public string SelectActivity(ActivityModel am)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select Metabolism from Activities where Id = '" + am.Id + "'";
            string b = base.ExecuteSelect(Query);
            base.DisConnect();
            return b;
        }

    }
}