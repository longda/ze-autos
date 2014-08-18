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
    public class ModelService : IModelService
    {
        public Vehicle SaveVehicle(Vehicle input)
        {
            var p = new DynamicParameters();
            p.Add("@Id", input.Id);
            p.Add("@MakeId", input.Make.Id);
            p.Add("@Mpg", input.Mpg);
            p.Add("@UserId", input.UserId);
            p.Add("@Ide", dbType: DbType.Int32, direction: ParameterDirection.Output);
            p.Add("@c", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AUTO_CORE"].ConnectionString))
            {
                connection.Open();
                var result = connection.Execute("Vehicle_Save", p, commandType: CommandType.StoredProcedure);
                input.Id = p.Get<int>("@Ide");
            }

            // ugh
            input.Make = GetMake(input.Make.Id);

            return input;
        }

        public Vehicle GetVehicle(int id)
        {
            var output = new Vehicle();

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AUTO_CORE"].ConnectionString))
            {
                connection.Open();
                var result = connection.Query("Vehicle_Get", new { Id = id, UserId = 0 }, commandType: CommandType.StoredProcedure);
                var f = result.First();
                output.Id = f.Id;
                output.Make.Id = f.MakeId;
                output.Mpg = f.Mpg;
                output.UserId = f.UserId;
            }

            output.Make = GetMake(output.Make.Id);

            return output;
        }

        public Vehicle[] GetVehicles(int userId)
        {
            var output = new List<Vehicle>();

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AUTO_CORE"].ConnectionString))
            {
                connection.Open();
                var result = connection.Query("Vehicle_Get", new { Id = 0, UserId = userId }, commandType: CommandType.StoredProcedure);

                foreach (var i in result)
                {
                    var v = new Vehicle();
                    v.Id = i.Id;
                    v.Make.Id = i.MakeId;
                    v.Mpg = i.Mpg;
                    v.UserId = i.UserId;

                    output.Add(v);
                }
            }

            // more ugh... much better ways to do this.
            foreach (var v in output)
            {
                v.Make = GetMake(v.Make.Id);
            }

            return output.ToArray();
        }

        public bool DeleteVehicle(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public Make SaveMake(Make input)
        {
            var p = new DynamicParameters();
            p.Add("@Id", input.Id);
            p.Add("@Name", input.Name == null ? "" : input.Name);
            p.Add("@Ide", dbType: DbType.Int32, direction: ParameterDirection.Output);
            p.Add("@c", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AUTO_CORE"].ConnectionString))
            {
                connection.Open();
                var result = connection.Execute("Make_Save", p, commandType: CommandType.StoredProcedure);
                input.Id = p.Get<int>("@Ide");
            }

            return input;
        }

        public Make GetMake(int id)
        {
            var output = new Make();

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AUTO_CORE"].ConnectionString))
            {
                connection.Open();
                var result = connection.Query<Make>("Make_Get", new { Id = id }, commandType: CommandType.StoredProcedure);
                output = result.First();
            }

            return output;
        }

        public Make[] GetMakes()
        {
            var output = new List<Make>();

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AUTO_CORE"].ConnectionString))
            {
                connection.Open();
                var result = connection.Query<Make>("Make_Get", new { Id = 0 }, commandType: CommandType.StoredProcedure);
                output.AddRange(result);
            }

            return output.ToArray();
        }

        public bool DeleteMake(int makeId)
        {
            throw new NotImplementedException();
        }
    }
}
