using Domain.Entities;
using Domain.Enum;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class ListActivoRepository : BaseRepositoy<ActivoFijo>, IActivoModel
    {
        public ActivoFijo GetById(int id)
        {
            return data.Where(x => x.Id == id).FirstOrDefault();

            //foreach(ActivoFijo activo in data)
            //{
            //    if (activo.Id == id)
            //    {
            //        return activo;
                   
            //    }
               
            //}
            //return null;
        }
    }
}
