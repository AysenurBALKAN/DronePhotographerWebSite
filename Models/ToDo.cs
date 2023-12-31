using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DronePhotographerWebSite.Models
{
    public class ToDo
    {
        [Key]
        public int ToDoId { get; set; }
        public string ToDoDescription { get; set; }
    }
}