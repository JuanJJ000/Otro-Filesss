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
        public void Add(Activo t)
        {
            try
            {
                context.Create<Activo>(t);
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

        public Activo GetById(int id)
        {
            try
            {
                return context.Get<Activo>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Activo> Read()
        {
            try
            {
                return context.GetAll<Activo>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Activo t, int g)
        {
            try
            {
                context.Actualizar<Activo>(t, g);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
