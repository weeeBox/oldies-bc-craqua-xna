using System;
 
using flash;
 
namespace flash
{
	public class AsXML : AsObject
	{
		public virtual String attributeValue(String arg)
		{
			return null;
		}
		public virtual String attribute(String arg)
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
			return -1;
		}
		public virtual AsXMLList children()
		{
			return null;
		}
		public virtual AsXMLList comments()
		{
			return null;
		}
		public virtual bool contains(String _value)
		{
			return false;
		}
		public virtual AsXML copy()
		{
			return null;
		}
		public virtual AsXMLList elements(String name)
		{
			return null;
		}
		public virtual AsXMLList elements()
		{
			return elements("*");
		}
		public virtual int length()
		{
			return -1;
		}
		public virtual String name()
		{
			return null;
		}
		public virtual String nodeKind()
		{
			return null;
		}
		public virtual AsObject parent()
		{
			return null;
		}
		public virtual AsXMLList text()
		{
			return null;
		}
	}
}
