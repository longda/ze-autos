using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Auto.Core.Models;
using Auto.Core.Services.Interfaces;

namespace Auto.Core.Services.Stubs
{
    public class ModelServiceStub : IModelService
    {
        public Vehicle SaveVehicle(Vehicle input)
        {
            throw new NotImplementedException();
        }

        public Vehicle[] GetVehicles(int userId)
        {
            var output = new List<Vehicle>();

            output.Add(new Vehicle() { Id = 1009, Mpg = 22, Make = new Make() { Id = 56, Name = "Cadillac" } });
            output.Add(new Vehicle() { Id = 2014, Mpg = 45, Make = new Make() { Id = 25, Name = "Toyota" } });
            output.Add(new Vehicle() { Id = 7893, Mpg = 29, Make = new Make() { Id = 32, Name = "Mercedes" } });
            output.Add(new Vehicle() { Id = 8931, Mpg = 31, Make = new Make() { Id = 99, Name = "Volkswagen" } });
            output.Add(new Vehicle() { Id = 6839, Mpg = 19, Make = new Make() { Id = 77, Name = "Aston Martin" } });

            return output.ToArray();
        }

        public bool DeleteVehicle(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public Make SaveMake(Make input)
        {
            throw new NotImplementedException();
        }

        public Make[] GetMakes()
        {
            throw new NotImplementedException();
        }

        public bool DeleteMakes(int makeId)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
