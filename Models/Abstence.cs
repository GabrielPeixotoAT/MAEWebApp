using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAEWebApp.Models
{
    public class Abstence
    {
        public int abstenceID { get; set; }
        public string description { get; set; }
        public int classSheduleIDFK { get; set; }
        public int subjectIDFK { get; set; }
        public int classCount { get; set; }
    }
}