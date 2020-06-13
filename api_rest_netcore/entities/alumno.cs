using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rest_netcore.entities
{
    public class alumno
    {
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string curso { get; set; }
        public string año { get; set; }

    }
}
