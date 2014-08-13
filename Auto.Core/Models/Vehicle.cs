using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Core.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public Make Make { get; set; }
        public int Mpg { get; set; }
        public int UserId { get; set; }

        public Vehicle()
        {
            Make = new Make();
        }
    }
}
