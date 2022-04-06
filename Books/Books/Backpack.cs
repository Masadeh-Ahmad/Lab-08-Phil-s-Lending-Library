using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> list = new List<T>();
        public int Count { get { return list.Count; } }

        public void Pack(T item)
        {
            list.Add(item);
        }

        public T Unpack(int index)
        {
            T item = list[index];
            list.RemoveAt(index);
            return item;
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
