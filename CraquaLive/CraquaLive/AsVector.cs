using System;

using flash;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;

namespace flash
{
    public delegate float AsVectorSorter<T>(T a, T b);

    public class AsVector<T> : AsObject, IEnumerable<T>
    {
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
                Debug.Assert(i >= 0 && i < data.Count, i + ">=" + 0 + "&&" + i + "<" + data.Count);
                return data[i];
            }
            set
            {
                Debug.Assert(i >= 0 && i < data.Count, i + ">=" + 0 + "&&" + i + "<" + data.Count);
                data[i] = value;
            }
        }

        public T this[uint i]
        {
            get
            {
                Debug.Assert(i >= 0 && i < data.Count, i + ">=" + 0 + "&&" + i + "<" + data.Count);
                return data[(int)i];
            }
            set
            {
                Debug.Assert(i >= 0 && i < data.Count, i + ">=" + 0 + "&&" + i + "<" + data.Count);
                data[(int)i] = value;
            }
        }

        public virtual int getLength()
        {
            return data.Count;
        }

        public virtual void setLength(int newLength)
        {
            if (data.Count > newLength)
            {
                List<T> newData = new List<T>(newLength);
                for (int i = 0; i < newLength; ++i)
                {
                    newData.Add(data[i]);
                }
                data = newData;
            }
            else if (data.Count < newLength)
            {
                int diff = newLength - data.Count;
                for (int i = 0; i < diff; ++i)
                {
                    data.Add(default(T));
                }
            }
        }

        public virtual int indexOf(T searchElement, int fromIndex)
        {
            return data.IndexOf(searchElement, fromIndex);
        }

        public virtual int indexOf(T searchElement)
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

        public virtual int lastIndexOf(T searchElement, int fromIndex)
        {
            return data.LastIndexOf(searchElement, fromIndex);
        }

        public virtual int lastIndexOf(T searchElement)
        {
            return lastIndexOf(searchElement);
        }

        public virtual T pop()
        {
            Debug.Assert(data.Count > 0);
            int lastIndex = data.Count - 1;
            T lastElement = data[lastIndex];
            data.RemoveAt(lastIndex);
            return lastElement;
        }
        public virtual int push(T arg)
        {
            data.Add(arg);
            return data.Count;
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
