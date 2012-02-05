using System;

using flash;
using System.Collections.Generic;
using System.Collections;

namespace flash
{
    public delegate float AsVectorSorter<T>(T a, T b);

    public class AsVector<T> : AsObject, IEnumerable<T>
    {
        public bool _fixed;
        public uint length;

        private List<T> data;

        public AsVector(params T[] elements)
        {
            data = new List<T>(elements.Length);
            init(elements);
        }

        public AsVector(uint length, bool _fixed)
        {
            data = new List<T>((int)length);
        }
        public AsVector(uint length)
            : this(length, false)
        {
        }
        public AsVector()
        {
            data = new List<T>();
        }

        public void init(params T[] values)
        {
            foreach (T obj in values)
            {
                data.Add(obj);
            }
        }

        public T this[int i]
        {
            get
            {
                return data[i];
            }
            set
            {
                data[i] = value;
            }
        }

        public T this[uint i]
        {
            get
            {
                return data[(int)i];
            }
            set
            {
                data[(int)i] = value;
            }
        }

        public virtual int getLength()
        {
            throw new NotImplementedException();
        }
        public virtual void setLength(int newLength)
        {
            throw new NotImplementedException();
        }

        public virtual int indexOf(AsObject searchElement, int fromIndex)
        {
            throw new NotImplementedException();
        }
        public virtual int indexOf(AsObject searchElement)
        {
            return indexOf(searchElement, 0);
        }
        public virtual String _join(String sep)
        {
            throw new NotImplementedException();
        }
        public virtual String _join()
        {
            return _join(",");
        }
        public virtual int lastIndexOf(AsObject searchElement, int fromIndex)
        {
            throw new NotImplementedException();
        }
        public virtual int lastIndexOf(AsObject searchElement)
        {
            return lastIndexOf(searchElement, 0x7fffffff);
        }
        public virtual T pop()
        {
            throw new NotImplementedException();
        }
        public virtual int push(T arg)
        {
            throw new NotImplementedException();
        }
        public virtual AsVector<T> reverse()
        {
            throw new NotImplementedException();
        }
        public virtual AsVector<T> slice(int startIndex, int endIndex)
        {
            throw new NotImplementedException();
        }
        public virtual AsVector<T> slice(int startIndex)
        {
            return slice(0, 16777215);
        }
        public virtual AsVector<T> slice()
        {
            return slice(0);
        }
        public virtual AsVector<T> sort(AsVectorSorter<T> sorter)
        {
            throw new NotImplementedException();
        }
        public virtual AsVector<T> splice(int startIndex, uint deleteCount)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
