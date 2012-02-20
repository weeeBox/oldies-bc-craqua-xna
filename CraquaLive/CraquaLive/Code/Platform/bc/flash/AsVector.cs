using System;

using bc.flash;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;

namespace bc.flash
{
    public delegate float AsVectorSorter<T>(T a, T b);

    public class AsVector<T> : AsObject, IEnumerable<T>
    {
        private List<T> mData;

        public AsVector(params T[] elements)
        {
            mData = new List<T>(elements.Length);
            init(elements);
        }

        public AsVector(uint length, bool _fixed)
        {
            mData = new List<T>((int)length);
        }

        public AsVector(uint length)
            : this(length, false)
        {
        }

        public AsVector()
        {
            mData = new List<T>();
        }

        public void init(params T[] values)
        {
            foreach (T obj in values)
            {
                mData.Add(obj);
            }
        }

        public T this[int i]
        {
            get
            {
                Debug.Assert(i >= 0 && i < mData.Count, i + ">=" + 0 + "&&" + i + "<" + mData.Count);
                return mData[i];
            }
            set
            {
                Debug.Assert(i >= 0 && i < mData.Count, i + ">=" + 0 + "&&" + i + "<" + mData.Count);
                mData[i] = value;
            }
        }

        public T this[uint i]
        {
            get
            {
                Debug.Assert(i >= 0 && i < mData.Count, i + ">=" + 0 + "&&" + i + "<" + mData.Count);
                return mData[(int)i];
            }
            set
            {
                Debug.Assert(i >= 0 && i < mData.Count, i + ">=" + 0 + "&&" + i + "<" + mData.Count);
                mData[(int)i] = value;
            }
        }

        public virtual uint getLength()
        {
            return (uint)mData.Count;
        }

        public virtual void setLength(uint newLength)
        {
            if (mData.Count > newLength)
            {
                List<T> newData = new List<T>((int)newLength);
                for (int i = 0; i < newLength; ++i)
                {
                    newData.Add(mData[i]);
                }
                mData = newData;
            }
            else if (mData.Count < newLength)
            {
                int diff = ((int)newLength) - mData.Count;
                for (int i = 0; i < diff; ++i)
                {
                    mData.Add(default(T));
                }
            }
        }

        public virtual int indexOf(T searchElement, int fromIndex)
        {
            return mData.IndexOf(searchElement, fromIndex);
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
            return mData.LastIndexOf(searchElement, fromIndex);
        }

        public virtual int lastIndexOf(T searchElement)
        {
            return lastIndexOf(searchElement);
        }

        public virtual T pop()
        {
            Debug.Assert(mData.Count > 0);
            int lastIndex = mData.Count - 1;
            T lastElement = mData[lastIndex];
            mData.RemoveAt(lastIndex);
            return lastElement;
        }
        public virtual int push(T arg)
        {
            mData.Add(arg);
            return mData.Count;
        }
        public virtual AsVector<T> reverse()
        {
            throw new NotImplementedException();
        }
        public virtual AsVector<T> slice(int startIndex, int endIndex)
        {
            int count = endIndex - startIndex;
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            T[] data = new T[count];
            for (int i = startIndex; i < endIndex; ++i)
            {
                data[i] = mData[i];
            }

            return new AsVector<T>(data);
        }
        public virtual AsVector<T> slice(int startIndex)
        {
            return slice(0, (int)getLength());
        }
        public virtual AsVector<T> slice()
        {
            return new AsVector<T>(mData.ToArray());
        }
        public AsVector<T> concat()
        {
            throw new NotImplementedException();
        }
        public virtual AsVector<T> sort(AsVectorSorter<T> sorter)
        {
            throw new NotImplementedException();
        }
        public virtual AsVector<T> splice(int startIndex)
        {
            return splice(startIndex, (uint)(getLength() - startIndex));
        }

        public virtual AsVector<T> splice(int startIndex, uint deleteCount)
        {
            if (startIndex < 0)
            {
                throw new NotImplementedException();
            }

            if (deleteCount > 0)
            {
                mData.RemoveRange(startIndex, (int)deleteCount);
            }            
            return this;
        }
        public virtual AsVector<T> splice(int startIndex, uint deleteCount, params T[] elements)
        {
            if (startIndex < 0)
            {
                throw new NotImplementedException();
            }

            if (deleteCount > 0)
            {
                mData.RemoveRange(startIndex, (int)deleteCount);
            }

            if (elements.Length > 0)
            {
                mData.InsertRange(startIndex, elements);
            }

            return this;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return mData.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
