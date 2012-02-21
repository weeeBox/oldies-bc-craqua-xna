using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bc.flash.display;
using bc.flash.geom;
using System.Diagnostics;

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

        public static uint parseUInt(String s)
        {
            uint val = 0;
            uint.TryParse(s, out val);
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

        public static long parseLong(String s)
        {
            long val = 0;
            long.TryParse(s, out val);
            return val;
        }

        public static bool parseBool(string s)
        {
            bool val = false;
            bool.TryParse(s, out val);
            return val;
        }

        public static void trace(String s)
        {
            Console.WriteLine(s);
        }

        public static String getQualifiedClassName(AsObject obj)
        {
            return obj.GetType().Name;
        }

        public static AsPoint transformCoords(AsMatrix matrix, float x, float y, AsPoint resultPoint)
        {
            if (resultPoint == null) resultPoint = new AsPoint();

            resultPoint.x = matrix.a * x + matrix.c * y + matrix.tx;
            resultPoint.y = matrix.d * y + matrix.b * x + matrix.ty;

            return resultPoint;
        }

        public static void assert(bool condition)
        {
            Debug.Assert(condition);
        }

        public static void assert(bool condition, String message)
        {
            Debug.Assert(condition, message);
        }
    }
}
