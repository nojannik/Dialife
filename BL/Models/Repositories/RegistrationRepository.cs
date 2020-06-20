using DL;
using DomainModel.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BL.Models.Repositories
{
    public class RegistrationRepository : DataAccessLayer
    {
        public bool Insert(RegistrationModel rm) //method for adding item
        {
            base.DataAccess();
            base.Connect();
            string Query = "insert into Users (FirstName,LastName,BirthDate,Sex,DiabetesType,Religion,CookingLevel,UserPreferencesMeat,UserPreferencesVegtable,MaximumCalery,Allergy,RoleId,UserName,Password) values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}',N'{13}')";
            Query = string.Format(Query, rm.FirstName,rm.LastName,rm.BirthDate,rm.Sex,rm.DiabetesType,rm.Religion,rm.CookingLevel,rm.UserPreferencesMeat,rm.UserPreferencesVegtable,rm.MaximumCalery,rm.Allergy,rm.RoleId,rm.UserName,rm.Password);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;
        }


        public bool Delete(RegistrationModel rm)//method for delet
        {
            base.DataAccess();
            base.Connect();
            string Query = "delete from Users where Id={0}";
            Query = string.Format(Query, rm.Id);
            bool res = base.DoCommand(Query);
            base.DisConnect();
            return res;

        }
        public bool Update(RegistrationModel rm)//method for update
        {
            base.DataAccess();
            base.Connect();
            string Query = "update Users set FirstName=N'{0}',LastName=N'{1}',BirthDate=N'{2}',Sex=N'{3}',DiabetesType=N'{4}',Religion=N'{5}',CookingLevel=N'{6}',UserPreferencesMeat=N'{7}',MaximumCalery=N'{8}',Allergy=N'{9}',UserPreferencesVegtable=N'{10}' where Id={11}";
            Query = string.Format(Query, rm.FirstName,rm.LastName,rm.BirthDate,rm.Sex,rm.DiabetesType,rm.Religion,rm.CookingLevel,rm.UserPreferencesMeat,rm.MaximumCalery,rm.Allergy,rm.UserPreferencesVegtable, rm.Id);
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
        public DataTable SelectUser(RegistrationModel rm)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select * from Users where Id='"+ rm.Id +"'  order by Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }
        public DataTable CHeckUser(RegistrationModel rm)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select * from Users where UserName='" + rm.UserName + "'  order by Id desc";
            DataTable dt = base.Select(Query);
            base.DisConnect();
            return dt;
        }

        public string SelectReligion(RegistrationModel rm)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select Religion from Users where Id='" + rm.Id + "'";
            string b = base.ExecuteSelect(Query);
            base.DisConnect();
            return b;
        }

        // in vase user preferences e
        public string SelectMeatPrefer(RegistrationModel rm)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select UserPreferencesMeat from Users where Id='" + rm.Id + "'";
            string b = base.ExecuteSelect(Query);
            base.DisConnect();
            return b;
        }
        public string SelectVegPrefer(RegistrationModel rm)
        {
            base.DataAccess();
            base.Connect();
            string Query = "select UserPreferencesVegtable from Users where Id='" + rm.Id + "'";
            string b = base.ExecuteSelect(Query);
            base.DisConnect();
            return b;
        }

    }
}