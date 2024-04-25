using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DronePhotographerWebSite.Models
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutImage { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDescription { get; set; }
        
    }
}