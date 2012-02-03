using System;
 
using flash;
 
namespace flash
{
	public class AsObject
	{
		public static AsObject prototype;
		public AsObject constructor;
		
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
