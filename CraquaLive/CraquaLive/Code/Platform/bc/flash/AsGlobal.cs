using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flash
{
    public class AsGlobal
    {
        public static int getTimer() 
        {
            return System.DateTime.Now.Millisecond; 
        }

        public static int parseInt(String s)
        {
            int val = 0;
            int.TryParse(s, out val);
            return val;
        }

        public static int parseInt(String s, int radix)
        {
            throw new NotImplementedException();
        }

        public static float parseFloat(String s)
        {
            float val = 0;
            float.TryParse(s, out val);
            return val;
        }

        public static void trace(String s)
        {
            Console.WriteLine(s);
        }
    }
}
