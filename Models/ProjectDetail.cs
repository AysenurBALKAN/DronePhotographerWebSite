using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DronePhotographerWebSite.Models
{
    public class ProjectDetail
    {
        [Key]
        public int ProjectDetailId { get; set; }
        public string ProjectDetailImage { get; set; }
        public string ProjetDetailTitle { get; set; }
        public string ProjectDetailDescription { get; set; }
        public Project Project {get;set;}
    }
}