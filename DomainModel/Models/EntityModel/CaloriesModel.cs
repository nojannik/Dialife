using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomainModel.Models.EntityModel
{
    public class CaloriesModel
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public int UserId { get; set; }
        public string Quantity { get; set; }
        public int Calorie { get; set; }
        public DateTime Date { get; set; }

    }
}