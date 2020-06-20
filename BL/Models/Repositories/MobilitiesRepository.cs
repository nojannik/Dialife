using DL;
using DomainModel.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BL.Models.Repositories
{
    public class MobilitiesRepository : DataAccessLayer
    {
        public bool Insert(MobilitiesModel mm) //method for adding item
        {
            base.DataAccess();
            base.Connect();
            string Query = "insert into Mobilities (UserId,ActivityId,Mobility,Time,Date) values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')";
            Query = string.Format(Query, mm.UserId,mm.ActivityId,mm.Mobility,mm.Time,mm.Date);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;
        }


        public bool Delete(MobilitiesModel mm)//method for delet
        {
            base.DataAccess();
            base.Connect();
            string Query = "delete from Mobilities where Id={0}";
            Query = string.Format(Query, mm.Id);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;

        }

        public bool Update(MobilitiesModel mm)//method for update
        {
            base.DataAccess();
            base.Connect();
            string Query = "update Mobilities set ActivityId=N'{0}',Mobility=N'{1}',Time=N'{2}',Date=N'{3}' where Id={4}";
            Query = string.Format(Query, mm.ActivityId, mm.Mobility,mm.Time,mm.Date,mm.Id);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;

        }

        public DataTable Select()
        {
            base.DataAccess();
            base.Connect();
            string Query = "select * from Users order by Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        public DataTable SelectByDate(MobilitiesModel mm)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select Mobilities.Id,Activities.Name as 'Activity',Activities.Metabolism as 'Activity Metabolism',Mobilities.Time,Mobilities.Mobility as 'Usage Mobility',Mobilities.Date,Mobilities.ActivityId from Activities,Mobilities where Activities.Id = Mobilities.ActivityId  and Mobilities.Date = '" + mm.Date + "' and  Mobilities.UserId = '"+mm.UserId+"' order by Mobilities.Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        public string SelectSumMobility(MobilitiesModel mm)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select sum(Mobility) from Mobilities where Date='" + mm.Date + "' and USerId='"+mm.UserId+"'";
            string b = base.ExecuteSelect(Query);
            base.DisConnect();
            return b;
        }

    }
}