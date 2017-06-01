using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EndToEnd.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Vogel { get; set; }
        public string Beschrijving { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Location { get; set; }
        public int Count { get; set; }
        
        [NotMapped]
        public HttpPostedFileBase File { get; set; }
        [NotMapped]
        public string ImageUrl { get { return Id.ToString() + ".jpg"; } }

       
        public IList<Bird> Birds { get; set; }
    }
}