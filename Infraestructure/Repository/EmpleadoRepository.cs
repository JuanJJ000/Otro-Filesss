using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class EmpleadoRepository 
    {


        private RAFContext context;
        private const int SIZE = 568;


        public EmpleadoRepository()
        {
            context = new RAFContext("Empleado", SIZE);
        }










    }
}
