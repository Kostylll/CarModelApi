using CarModelRegister.Application.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModelRegister.Application.Domain.Aggregates
{
    public class Financial : Entity
    {
        public string Name { get; set; }

        public string SecondName { get; set; }

        public string Document {  get; set; }

        public string Email { get; set; }

        public string Age { get; set; }

        




    }
}
