using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Activo : Empleado
    {
        
        public int Id { get; set; }
        public String Nombre { get; set; }
        public string Descripción { get; set; }
        public double Valor { get; set; }
        public int VidaUtil { get; set; }
        public double ValorResidual { get; set; }      
        public string codigo { get; set; }



    }
}
