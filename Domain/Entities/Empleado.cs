﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Empleado
    {
        public string Id { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dirección {get;set;}
        public string Telefono {get;set;}
        public string Email {get;set;}
        public string Estado {get;set;}

      
    }
}
