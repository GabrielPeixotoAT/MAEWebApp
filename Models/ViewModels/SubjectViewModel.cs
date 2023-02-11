using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAEWebApp.Models;

namespace MAEWebApp.Models.ViewModels
{
    public class SubjectViewModel
    {
        public string subjectName { get; set; }
        public int totalClasses { get; set; }
        public int abstencesCount { get; set; }
        public Decimal presencePercent { get; set; }
    }
}