using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DronePhotographerWebSite.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectImage { get; set; }
        public string ProjetTitle { get; set; }
        public string ProjectDescription { get; set; }
        public int ProjectDetailId { get; set; }

        public ICollection<ProjectDetail>ProjectDetails { get; set; }
       
    }
}