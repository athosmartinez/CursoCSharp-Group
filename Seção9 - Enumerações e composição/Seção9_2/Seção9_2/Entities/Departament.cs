using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção9_2.Entities
{
    internal class Departament
    {
        public string Name { get; set; }

        public Departament() { }
        public Departament(string name)
        {
            Name = name;
        }

    }
}
