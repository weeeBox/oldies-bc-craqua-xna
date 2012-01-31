using System;
 
using flash;
using System.Collections;

namespace flash
{
    public class AsXMLList : AsObject, IEnumerable
	{
        public AsXML this[int i]
        {
            get
            {
                // This indexer is very simple, and just returns or sets
                // the corresponding element from the internal array.
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

		public virtual AsXMLList attribute(String arg)
		{
			return null;
		}
		public virtual AsXMLList attributes()
		{
			return null;
		}
		public virtual AsXMLList child(String propertyName)
		{
			return null;
		}
		public virtual int childIndex()
		{
			return 0;
		}
		public virtual AsXMLList children()
		{
			return null;
		}
		public virtual AsXMLList copy()
		{
			return null;
		}
		public virtual int length()
		{
			return 0;
		}
		public virtual String name()
		{
			return null;
		}
		public virtual String nodeKind()
		{
			return null;
		}

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
