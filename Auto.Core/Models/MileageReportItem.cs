using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Core.Models
{
    public class MileageReportItem
    {
        public string Make { get; set; }
        public double MinMpg { get; set; }
        public double MaxMpg { get; set; }
        public double AveMpg { get; set; }

        public MileageReportItem()
        {
        }
    }
}
