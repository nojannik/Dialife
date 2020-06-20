using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomainModel.Models.EntityModel
{
    public class RegistrationModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Sex { get; set; }
        public string DiabetesType { get; set; }
        public string Religion { get; set; }
        public string Allergy { get; set; }
        public string CookingLevel { get; set; }
        public string UserPreferencesMeat { get; set; }
        public string UserPreferencesVegtable { get; set; }
        public string MaximumCalery { get; set; }
        //public string FoodHistory { get; set; }
        //public string SportHistory { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}