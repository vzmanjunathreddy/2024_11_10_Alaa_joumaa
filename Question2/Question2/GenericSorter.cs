using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public interface IGenericSorter<T>
    {
        List<T> Sort(List<T> items, Comparison<T> comparable);
    }
    public class GenericSorter<T> : IGenericSorter<T>
    {
        public List<T> Sort(List<T> items, Comparison<T> comparable)
        {
            items.Sort(comparable);

            //for(var i=0; i < items.Count; i++)
            //{
            //    for(var j=1; j < items.Count; j++)
            //    {
            //        if (items[i] < items[j])
            //        {
            //            items[i] = items[j];
            //        }
            //    }
            //}

            return items;
        }
    }
}
