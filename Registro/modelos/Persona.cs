using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.modelos
{
    public struct Persona
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
