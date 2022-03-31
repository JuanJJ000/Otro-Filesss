using AppCore.IServices;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class ActivoServices:BaseServices<ActivoFijo>,IActivoServices
    {

        IActivoModel activoModel;
        public ActivoServices(IActivoModel model) : base(model)
        {
            this.activoModel = model;
        }

        public ActivoFijo GetById(int id)
        {
            return activoModel.GetById(id);
        }
    }

}
