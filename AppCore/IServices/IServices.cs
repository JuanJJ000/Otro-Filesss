using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IServices<T>
    {

        void Add(T t);
        void Update(T t, int g);
        void Delete(int g);
        List<T> Read();
    }
}
