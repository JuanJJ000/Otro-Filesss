using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class ActivoRepository : IActivoModel
    {


        private RAFContext context;
        private const int SIZE = 119;


        public ActivoRepository()
        { 
             context = new RAFContext("activo", SIZE);
        }


        public void Add(Activo t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int g)
        {
            throw new NotImplementedException();
        }

        public Activo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Activo> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(Activo t, int g)
        {
            throw new NotImplementedException();
        }


        
    }
}
