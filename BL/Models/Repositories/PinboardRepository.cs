using DL;
using DomainModel.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
namespace BL.Models.Repositories
{
    public class PinboardRepository : DataAccessLayer
    {

            public bool Insert(PinboardModel pb) //method for adding item
            {
                base.DataAccess();
                base.Connect();
                string Query = "insert into Pinboard (UserId,PostId,Title,Date,Ingredients,Recipe) values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N{5)";
                Query = string.Format(Query, pb.UserId, pb.PostId, pb.Title, pb.Date, pb.Ingredients,pb.Recipe);
                bool res = base.DoCommand(Query);
                base.DisConnect();
                return res;
            }


            public bool Delete(PinboardModel pb)//method for delet
            {
                base.DataAccess();
                base.Connect();
                string Query = "delete from Pinboard where PostId={0}";
                Query = string.Format(Query, pb.PostId);
                bool res = base.DoCommand(Query);
                base.DisConnect();
                return res;

            }

            public bool Update(PinboardModel pb)//method for update
            {
                base.DataAccess();
                base.Connect();
                string Query = "update Pinboard set PostId=N'{0}',Title=N'{1}',Date=N'{2}',Ingredients=N'{3}',Recipe=N'{4}' where Id={5}";
                Query = string.Format(Query, pb.PostId, pb.Title, pb.Date, pb.Ingredients,pb.Recipe);
                bool res = base.DoCommand(Query);
                base.DisConnect();
                return res;

            }
        
    }
}
