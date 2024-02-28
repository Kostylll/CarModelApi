using CarModelRegister.Application.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModelRegister.Application.Domain.Aggregates
{
    public class Car : Entity
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public string Type { get; set; }

        public string Price { get; set; }

        public string Description { get; set; }


    }
}
