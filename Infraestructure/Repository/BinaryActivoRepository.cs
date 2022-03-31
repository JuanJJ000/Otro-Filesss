using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class BinaryActivoRepository : IActivoModel
    {
        private RAFContext context;
        private const int SIZE = 119;
        public BinaryActivoRepository()
        {
            context = new RAFContext("activo", SIZE);
        }
        public void Add(ActivoFijo t)
        {
            try
            {
                context.Create<ActivoFijo>(t);
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

        public ActivoFijo GetById(int id)
        {
            try
            {
                return context.Get<ActivoFijo>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ActivoFijo> Read()
        {
            try
            {
                return context.GetAll<ActivoFijo>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(ActivoFijo t, int g)
        {
            try
            {
                context.Actualizar<ActivoFijo>(t, g);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
