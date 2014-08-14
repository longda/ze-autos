using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Auto.Core.Models;

namespace Auto.Core.Services.Interfaces
{
    public interface IModelService
    {
        Vehicle SaveVehicle(Vehicle input);
        Vehicle GetVehicle(int id);
        Vehicle[] GetVehicles(int userId);
        bool DeleteVehicle(int vehicleId);

        Make SaveMake(Make input);
        Make GetMake(int id);
        Make[] GetMakes();
        bool DeleteMakes(int makeId);

        User GetUser(int id);
    }
}
