using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomainModel.Models.EntityModel
{
    public class FoodOfferModel
    {

        public int Id { get; set; }

        public string SatB0 { get; set; }
        public string SatB1 { get; set; }
        public string SatB2 { get; set; }
        public string SatD0 { get; set; }
        public string SatD1 { get; set; }
        public string SatD2 { get; set; }
        public string SatL0 { get; set; }
        public string SatL1 { get; set; }
        public string SatL2 { get; set; }
        public string SunB0 { get; set; }
        public string SunB1 { get; set; }
        public string SunB2 { get; set; }
        public string SunD0 { get; set; }
        public string SunD1 { get; set; }
        public string SunD2 { get; set; }
        public string SunL0 { get; set; }
        public string SunL1 { get; set; }
        public string SunL2 { get; set; }
        public string MonB0 { get; set; }
        public string MonB1 { get; set; }
        public string MonB2 { get; set; }
        public string MonD0 { get; set; }
        public string MonD1 { get; set; }
        public string MonD2 { get; set; }
        public string MonL0 { get; set; }
        public string MonL1 { get; set; }
        public string MonL2 { get; set; }
        public string TuesB0 { get; set; }
        public string TuesB1 { get; set; }
        public string TuesB2 { get; set; }
        public string TuesD0 { get; set; }
        public string TuesD1 { get; set; }
        public string TuesD2 { get; set; }
        public string TuesL0 { get; set; }
        public string TuesL1 { get; set; }
        public string TuesL2 { get; set; }
        public string WedB0 { get; set; }
        public string WedB1 { get; set; }
        public string WedB2 { get; set; }
        public string WedD0 { get; set; }
        public string WedD1 { get; set; }
        public string WedD2 { get; set; }
        public string WedL0 { get; set; }
        public string WedL1 { get; set; }
        public string WedL2 { get; set; }
        public string ThursB0 { get; set; }
        public string ThursB1 { get; set; }
        public string ThursB2 { get; set; }
        public string ThursD0 { get; set; }
        public string ThursD1 { get; set; }
        public string ThursD2 { get; set; }
        public string ThursL0 { get; set; }
        public string ThursL1 { get; set; }
        public string ThursL2 { get; set; }
        public string FriB0 { get; set; }
        public string FriB1 { get; set; }
        public string FriB2 { get; set; }
        public string FriD0 { get; set; }
        public string FriD1 { get; set; }
        public string FriD2 { get; set; }
        public string FriL0 { get; set; }
        public string FriL1 { get; set; }
        public string FriL2 { get; set; }

        public string TotalSat { get; set; }
        public string TotalSun { get; set; }
        public string TotalMon { get; set; }
        public string TotalTue { get; set; }
        public string TotalWed { get; set; }
        public string TotalThurs { get; set; }
        public string TotalFri { get; set; }

        //public int SatB0 { get; set; }
        //public int SatB1 { get; set; }
        //public int SatB2 { get; set; }
        //public int SatD0 { get; set; }
        //public int SatD1 { get; set; }
        //public int SatD2 { get; set; }
        //public int SatL0 { get; set; }
        //public int SatL1 { get; set; }
        //public int SatL2 { get; set; }
        //public int SunB0 { get; set; }
        //public int SunB1 { get; set; }
        //public int SunB2 { get; set; }
        //public int SunD0 { get; set; }
        //public int SunD1 { get; set; }
        //public int SunD2 { get; set; }
        //public int SunL0 { get; set; }
        //public int SunL1 { get; set; }
        //public int SunL2 { get; set; }
        //public int MonB0 { get; set; }
        //public int MonB1 { get; set; }
        //public int MonB2 { get; set; }
        //public int MonD0 { get; set; }
        //public int MonD1 { get; set; }
        //public int MonD2 { get; set; }
        //public int MonL0 { get; set; }
        //public int MonL1 { get; set; }
        //public int MonL2 { get; set; }
        //public int TuesB0 { get; set; }
        //public int TuesB1 { get; set; }
        //public int TuesB2 { get; set; }
        //public int TuesD0 { get; set; }
        //public int TuesD1 { get; set; }
        //public int TuesD2 { get; set; }
        //public int TuesL0 { get; set; }
        //public int TuesL1 { get; set; }
        //public int TuesL2 { get; set; }
        //public int WedB0 { get; set; }
        //public int WedB1 { get; set; }
        //public int WedB2 { get; set; }
        //public int WedD0 { get; set; }
        //public int WedD1 { get; set; }
        //public int WedD2 { get; set; }
        //public int WedL0 { get; set; }
        //public int WedL1 { get; set; }
        //public int WedL2 { get; set; }
        //public int ThursB0 { get; set; }
        //public int ThursB1 { get; set; }
        //public int ThursB2 { get; set; }
        //public int ThursD0 { get; set; }
        //public int ThursD1 { get; set; }
        //public int ThursD2 { get; set; }
        //public int ThursL0 { get; set; }
        //public int ThursL1 { get; set; }
        //public int ThursL2 { get; set; }
        //public int FriB0 { get; set; }
        //public int FriB1 { get; set; }
        //public int FriB2 { get; set; }
        //public int FriD0 { get; set; }
        //public int FriD1 { get; set; }
        //public int FriD2 { get; set; }
        //public int FriL0 { get; set; }
        //public int FriL1 { get; set; }
        //public int FriL2 { get; set; }
        public int UserId { get; set; }


    }
}