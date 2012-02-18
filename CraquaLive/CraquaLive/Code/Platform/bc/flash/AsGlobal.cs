using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bc.flash.display;
using bc.flash.geom;

namespace bc.flash
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

        public static String getQualifiedClassName(AsDisplayObject asDisplayObject)
        {
            throw new NotImplementedException();
        }

        public static void transformCoords(AsMatrix sHelperMatrix, float p, float p_2, AsPoint sHelperPoint)
        {
            throw new NotImplementedException();
        }
    }
}
