using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD.Hoofdstuk_1
{
    public class Collection : CollectionBase
    {
        public Int16 this[int index]
        {
            get
            {
                return ((Int16)List[index]);
            }
            set
            {
                List[index] = value;
            }
        }

        public void Add(Object item)
        {
            InnerList.Add(item);
        }

        public void Remove(Object item)
        {
            InnerList.Remove(item);
        }

        public new void Clear()
        {
            InnerList.Clear();
        }
        public new int Count()
        {
            return InnerList.Count;
        }

        public void Insert(int index, Object item)
        {
            InnerList.Insert(index, item);
        }

        public int IndexOf(Object item)
        {
            return (List.IndexOf(item));
        }

        public bool Contains(Object item)
        {
            return (List.Contains(item));
        }

        public void RemoveAt()
        {
            int index;
        }

        class chapter1
        {
            static void Main()
            {
                Collection names = new Collection();
                names.Add("David");
                names.Add("Bernica");
                names.Add("Raymond");
                names.Add("Clayton");
                foreach (Object name in names)
                    Console.WriteLine(name);
                Console.WriteLine("Number of names: " + names.
                Count());
                names.Remove("Raymond");
                Console.WriteLine("Number of names: " + names.
                Count());
                names.Clear();
                Console.WriteLine("Number of names: " + names.
                Count());
            }
        }

    }
}
