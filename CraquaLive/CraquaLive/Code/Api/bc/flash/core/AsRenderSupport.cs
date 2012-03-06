using System;

using bc.flash;
using bc.flash.display;
using bc.flash.error;
using bc.flash.geom;
using bc.flash.native;

namespace bc.flash.core
{
    public class AsRenderSupport : AsObject
    {
        public AsRenderSupport()
        {
        }

        public virtual void dispose()
        {
        }

        public virtual void transform(AsMatrix matrix)
        {
            BcRenderSupport.Transform(ref matrix.internalMatrix);
        }

        public virtual void pushMatrix()
        {
            BcRenderSupport.PushMatrix();
        }

        public virtual void popMatrix()
        {
            BcRenderSupport.PopMatrix();
        }

        public virtual void resetMatrix()
        {
            BcRenderSupport.SetIdentity();
        }

        public virtual void drawBitmap(AsBitmapData bitmap, float alpha)
        {
            if (bitmap.Texture != null)
            {
                BcRenderSupport.DrawImage(bitmap.Texture, 0, 0);
            }
        }
    }
}
