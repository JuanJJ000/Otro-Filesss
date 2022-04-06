using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Detalle_Activo_Empleado
    {
        public int Id{get;set; }
        public ActivoFijo activo { get; set; }
        public Empleado empleado { get; set; }
        public DateTime Fecha { get; set; }
        public byte Esatdo { get; set; }
    }
}
