using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Auto.Core.Models;
using Auto.Core.Services.Concrete;

namespace Auto.Test.Core.Services.Concrete
{
    [TestClass]
    public class ModelServiceTests
    {
        private ModelService svc = new ModelService();

        [TestMethod]
        public void TestSaveMake()
        {
            var m = new Make() { Name = "Cadillac" };

            var result = svc.SaveMake(m);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Id != 0);
        }

        [TestMethod]
        public void TestGetVehicles()
        {
            var result = svc.GetVehicles(1);

            Assert.IsNotNull(result);
        }
    }
}
