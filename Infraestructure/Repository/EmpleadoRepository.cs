using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class EmpleadoRepository :IEmpleadoModel
    {


        private RAFContext context;
        private const int SIZE = 568;


        public EmpleadoRepository()
        {
            context = new RAFContext("Empleado", SIZE);
        }




        public void Add(Empleado t)
        {
            try
            {
                context.Create<Empleado>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int g)
        {
            context.Delete(g);
        }

        public Empleado GetById(int id)
        {
            try
            {
                return context.Get<Empleado>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Empleado> Read()
        {
            try
            {
                return context.GetAll<Empleado>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Empleado t, int g)
        {
            try
            {
                context.Actualizar<Empleado>(t, g);
            }
            catch (Exception)
            {
                throw;
            }
        }








    }
}
