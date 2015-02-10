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
            void Add(T item);
            bool Remove(T item);
            void Clear();
            bool Contains(T item);
            int Count { get; }
        }
    }
}
