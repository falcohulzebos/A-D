using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD.Hoofdstuk_1.oefeningen
{
    class GenericCollection
    {
            public interface ICollection<T> : IEnumerable<T>
        {
            public void Add(T item);
            public bool Remove(T item);
            public void Clear();
            public bool Contains(T item);
             public int Count { get; }
        }
    }
}
