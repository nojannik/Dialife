using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomainModel.Models.EntityModel
{
    public class FoodModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Calorie { get; set; }
        public string Servings { get; set; }
        public string Materials { get; set; }
        public string Recipe { get; set; }
        public string NotFriendly { get; set; }
        public bool IslamUse { get; set; }
        public bool INCUse { get; set; }
        public int FoodGroupId { get; set; }
        public string CookingLevel { get; set; }
        public virtual bool AllowPaging { get; set; }

    }
}