using System;
using bc.core.display;
using bc.flash.resources;
using bc.flash.native;

namespace bc.flash.display
{
    public class AsBcRenderSupport : AsObject
    {
        public static void beginFill(uint color, float alpha)
        {

        }
        public static void clear()
        {

        }
        public static void curveTo(float controlX, float controlY, float anchorX, float anchorY)
        {

        }
        public static void drawCircle(float x, float y, float radius)
        {

        }
        public static void drawEllipse(float x, float y, float width, float height)
        {

        }
        public static void drawRect(float x, float y, float width, float height)
        {

        }
        public static void drawRoundRect(float x, float y, float width, float height, float ellipseWidth, float ellipseHeight)
        {

        }
        public static void drawBitmap(AsBitmapData bitmapData, float x, float y)
        {
            if (bitmapData.Texture != null)
            {
                BcRenderSupport.DrawImage(bitmapData.Texture, x, y);
            }
        }
        public static void endFill()
        {

        }
        public static void lineStyle(float thickness, uint color, float alpha, bool pixelHinting, String scaleMode, String caps, String joints, float miterLimit)
        {

        }
        public static void lineTo(float x, float y)
        {

        }
        public static void moveTo(float x, float y)
        {

        }
        public static void scale(float scaleX, float scaleY)
        {
            BcRenderSupport.Scale(scaleX, scaleY);
        }
        public static void rotate(float a)
        {
            BcRenderSupport.Rotate(a);
        }
        public static void translate(float x, float y)
        {
            BcRenderSupport.Translate(x, y);
        }
        public static void pushMatrix()
        {
            BcRenderSupport.PushMatrix();
        }
        public static void popMatrix()
        {
            BcRenderSupport.PopMatrix();
        }
    }
}
