using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomainModel.Models.EntityModel
{
    public class PinboardModel
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public int Title { get; set; }
        public DateTime Date { get; set; }
        public string Ingredients { get; set; }
        public string Recipe { get; set; }

    }
}