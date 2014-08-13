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
            throw new NotImplementedException();
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
