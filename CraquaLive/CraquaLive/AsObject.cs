using System;
 
using flash;
 
namespace flash
{
	public class AsObject
	{
		public static AsObject prototype;
		public AsObject constructor;
		
        public Object this[Object name]
        {
            get
            {
                // This indexer is very simple, and just returns or sets
                // the corresponding element from the internal array.
                return null;
            }
            set
            {                
            }
        }

		public bool hasOwnProperty(String name)
		{
			return false;
		}

        public Object getOwnProperty(String name)
        {
            return null;
        }

		public virtual String toString()
		{
			return null;
		}
	}
}
