using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Auto.Core.Models;

namespace Auto.Web.Models
{
    public class VehicleViewModel
    {
        public List<Vehicle> Vehicles { get; set; }
        public List<Make> Makes { get; set; }

        public VehicleViewModel()
        {
            Vehicles = new List<Vehicle>();
            Makes = new List<Make>();
        }
    }
}