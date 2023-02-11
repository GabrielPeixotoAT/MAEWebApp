using System.ComponentModel.DataAnnotations;

namespace MAEWebApp.Models
{
    public class ClassSchedule
    {
        [Required]
        public int ClassScheduleID { get; set; }
        [Required]
        public string Shedules { get; set; }
        public int? SubjectIDFK { get; set; }
        [Required]
        public int SchoolDayIDFK { get; set; }
    }
}
