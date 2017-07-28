using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coding_Task.Models
{
    public class NumbersModel
    {
        public List<int> allnumbers { get; set; }
        public List<int> allevennumbers { get; set; }
        public List<int> alloddnumbers { get; set; }
        public List<string> allconditionalnumbers { get; set; }
        public List<int> allfibonaccinumbers { get; set; }
    }
}