using System;
 
using bc.flash;
using bc.flash.error;
using bc.flash.xml;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
 
namespace bc.flash.xml
{
    public class AsXMLList : AsObject, IEnumerable
	{
        private AsVector<AsXML> elements = new AsVector<AsXML>();

        public AsXML this[int i]
        {
            get
            {                
                return elements[i];
            }            
        }

		public virtual AsXML appendChild(AsXML child)
		{
            elements.push(child);
            return child;
		}
		public virtual AsVector<AsXML> list()
		{
            return elements;
		}
		public virtual AsXMLList attribute(String arg)
		{
			throw new AsNotImplementedError();
		}
		public virtual AsXMLList attributes()
		{
			throw new AsNotImplementedError();
		}
		public virtual AsXMLList child(String propertyName)
		{
			throw new AsNotImplementedError();
		}
		public virtual int childIndex()
		{
			throw new AsNotImplementedError();
		}
		public virtual AsXMLList children()
		{
			throw new AsNotImplementedError();
		}
		public virtual AsXMLList copy()
		{
			throw new AsNotImplementedError();
		}		
		public virtual String name()
		{
			throw new AsNotImplementedError();
		}
		public virtual String nodeKind()
		{
			throw new AsNotImplementedError();
		}

        public IEnumerator GetEnumerator()
        {
            return elements.GetEnumerator();
        }
	}
}
