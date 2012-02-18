using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bc.flash.native
{
    public class NativeApplication
    {
        private int width;
        private int height;

        public NativeApplication(int width, int height)
        {            
            this.width = width;
            this.height = height;
        }

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return Height; }
        }

        public void tick(float deltaTime)
        {
            Console.WriteLine(deltaTime);
        }
    }
}
