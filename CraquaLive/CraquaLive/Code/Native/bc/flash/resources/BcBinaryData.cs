using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bc.flash.resources
{
    public class BcBinaryData
    {
        private byte[] data;

        public BcBinaryData(byte[] data)
        {
            this.data = data;
        }

        public byte[] Data
        {
            get { return data; }
            set { data = value; }
        }

        public int Lenght
        {
            get { return data.Length; }
        }
    }
}
