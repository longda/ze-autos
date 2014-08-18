using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Auto.Core.Models;

namespace Auto.Core.Services.Interfaces
{
    public interface IReportService
    {
        MileageReportItem[] GetMileageReport();
    }
}
