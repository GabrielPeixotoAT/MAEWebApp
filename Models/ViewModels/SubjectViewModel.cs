using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAEWebApp.Models;

namespace MAEWebApp.Models.ViewModels
{
    public class SubjectViewModel
    {
        public string Name { get; set; }
        public int TotalClasses { get; set; }
        public int TotalAbstences { get; set; }
        public Decimal Percent { get; set; }
    }
}