﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Auto.Core.Enums;
using Auto.Core.Models;
using Auto.Core.Services.Interfaces;

namespace Auto.Core.Services.Stubs
{
    public class ModelServiceStub : IModelService
    {
        public Vehicle SaveVehicle(Vehicle input)
        {
            input.Make.Name = "BMW";
            return input;
        }

        public Vehicle GetVehicle(int id)
        {
            return new Vehicle() { Id = 1009, Mpg = 22, Make = new Make() { Id = 56, Name = "Cadillac" } };
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
            return true;
        }

        public Make SaveMake(Make input)
        {
            return input;
        }

        public Make GetMake(int id)
        {
            return new Make() { Id = 56, Name = "Cadillac" };
        }

        public Make[] GetMakes()
        {
            var output = new List<Make>();

            output.Add(new Make() { Id = 56, Name = "Cadillac" });
            output.Add(new Make() { Id = 25, Name = "Toyota" });
            output.Add(new Make() { Id = 32, Name = "Mercedes" });
            output.Add(new Make() { Id = 99, Name = "Volkswagen" });
            output.Add(new Make() { Id = 77, Name = "Aston Martin" });

            return output.ToArray();
        }

        public bool DeleteMake(int makeId)
        {
            return true;
        }

        public User GetUser(int id)
        {
            return new User() 
            { 
                Id = 23, 
                Name = "Standard Guy", 
                Password = "sunshine", 
                Username = "std", 
                UserType = UserType.Standard 
            };
        }
    }
}
