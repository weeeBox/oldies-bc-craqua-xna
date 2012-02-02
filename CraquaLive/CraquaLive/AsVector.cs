using System;
 
using flash;
using System.Collections.Generic;
 
namespace flash
{
	public class AsVector<T> : AsObject, IEnumerable<T>
	{
		public bool _fixed;
		public uint length;

        public AsVector(params T[] elements)
        {
        }

		public AsVector(uint length, bool _fixed)
		{
		}
		public AsVector(uint length)
		{
		}
		public AsVector()
		{
		}

        public void init(params T[] values)
        {
        }

        public T this[int i]
        {
            get
            {
                return default(T);
            }
            set
            {                
            }
        }

		public virtual int indexOf(AsObject searchElement, int fromIndex)
		{
			return -1;
		}
		public virtual int indexOf(AsObject searchElement)
		{
			return indexOf(searchElement, 0);
		}
		public virtual String _join(String sep)
		{
			return null;
		}
		public virtual String _join()
		{
			return _join(",");
		}
		public virtual int lastIndexOf(AsObject searchElement, int fromIndex)
		{
			return -1;
		}
		public virtual int lastIndexOf(AsObject searchElement)
		{
			return lastIndexOf(searchElement, 0x7fffffff);
		}
		public virtual AsObject pop()
		{
			return null;
		}
		public virtual int push(AsObject arg)
		{
			return -1;
		}
		public virtual AsVector<T> reverse()
		{
			return null;
		}
		public virtual AsVector<T> slice(int startIndex, int endIndex)
		{
			return null;
		}
		public virtual AsVector<T> slice(int startIndex)
		{
			return slice(0, 16777215);
		}
		public virtual AsVector<T> slice()
		{
			return slice(0);
		}
		public virtual AsVector<T> sort(AsFunction compareFunction)
		{
			return null;
		}
		public virtual AsVector<T> splice(int startIndex, int deleteCount)
		{
			return null;
		}

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
