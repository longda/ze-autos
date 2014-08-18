using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Auto.Core.Models;
using Auto.Core.Services.Interfaces;
using Dapper;

namespace Auto.Core.Services.Concrete
{
    public class ReportService : IReportService
    {
        public MileageReportItem[] GetMileageReport()
        {
            var output = new List<MileageReportItem>();

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AUTO_CORE"].ConnectionString))
            {
                connection.Open();
                var result = connection.Query<MileageReportItem>("Report_Mileage", new { }, commandType: CommandType.StoredProcedure);
                output.AddRange(result);
            }

            return output.ToArray();
        }
    }
}
