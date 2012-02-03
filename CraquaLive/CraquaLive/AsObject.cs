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
            throw new NotImplementedException();
        }

        public AsObject getOwnProperty(String name)
        {
            throw new NotImplementedException();
        }

        public void setOwnProperty(String name, AsObject value)
        {
            throw new NotImplementedException();
        }

        public void deleteOwnProperty(String name)
        {
            throw new NotImplementedException();
        }

        public virtual String toString()
        {
            throw new NotImplementedException();
        }
    }
}
