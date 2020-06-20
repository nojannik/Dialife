using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomainModel.Models.EntityModel
{
    public class MobilitiesModel
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int UserId { get; set; }
        public string Time { get; set; }
        public int Mobility { get; set; }
        public DateTime Date { get; set; }

    }
}