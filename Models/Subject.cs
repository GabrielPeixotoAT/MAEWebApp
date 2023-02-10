using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MAEWebApp.Models
{   
    public class Subject
    {
        [Key]
        [Required]
        public int SubjectID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int TotalClasses { get; set; }
    }
}