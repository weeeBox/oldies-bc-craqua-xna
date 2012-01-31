using System;
 
using flash;
using System.Collections;
 
namespace flash
{
	public class AsArray : AsObject, IEnumerable
	{
		public const int CASEINSENSITIVE = 1;
		public const int DESCENDING = 2;
		public const int UNIQUESORT = 4;
		public const int RETURNINDEXEDARRAY = 8;
		public const int NUMERIC = 16;
		public const int length = 1;

        public AsArray(params Object[] elements)
        {

        }

		public virtual int indexOf(AsObject searchElement, int fromIndex)
		{
			return -1;
		}
		public virtual int indexOf(AsObject searchElement)
		{
			return indexOf(searchElement, 0);
		}
		public virtual int lastIndexOf(AsObject searchElement, int fromIndex)
		{
			return -1;
		}
		public virtual int lastIndexOf(AsObject searchElement)
		{
			return lastIndexOf(searchElement, 2147483647);
		}
		public virtual int getLength()
		{
			return 0;
		}
		public virtual void setLength(int newLength)
		{
		}
		public virtual AsObject pop()
		{
			return null;
		}
		public virtual int push(AsObject arg)
		{
			return 0;
		}

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
