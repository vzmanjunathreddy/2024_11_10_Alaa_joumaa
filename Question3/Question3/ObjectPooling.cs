using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public interface IObjectPooling<T>
    {
        T CreateInstance(T model);
        void Dipose(T model);
    }

    public class ObjectPooling<T> : IObjectPooling<T> where T : class
    {
        List<T> _objects { get; set; }

        public T CreateInstance(T model)
        {
            var obj = _objects.FirstOrDefault(x => x.Equals(model));
            if (obj != null)
            {
                return obj;
            }
            _objects.Add(model);
            return model;
        }

        public void Dipose(T model)
        {
            var obj = _objects.FirstOrDefault(x => x.Equals(model));
            if (obj != null)
            {
                _objects.Remove(obj);
                //GC.Collect(obj.GetHashCode()); Not sure about it.
            }
        }
    }
}
