using System;
 
using bc.flash;
using bc.flash.display;
 
namespace bc.flash.display
{
	public sealed class AsGraphics : AsObject
	{
		public void beginFill(uint color, float alpha)
		{
			AsBcRenderSupport.beginFill(color, alpha);
		}
		public void beginFill(uint color)
		{
			beginFill(color, 1.0f);
		}
		public void clear()
		{
			AsBcRenderSupport.clear();
		}
		public void curveTo(float controlX, float controlY, float anchorX, float anchorY)
		{
			AsBcRenderSupport.curveTo(controlX, controlY, anchorX, anchorY);
		}
		public void drawCircle(float x, float y, float radius)
		{
			AsBcRenderSupport.drawCircle(x, y, radius);
		}
		public void drawEllipse(float x, float y, float width, float height)
		{
			AsBcRenderSupport.drawEllipse(x, y, width, height);
		}
		public void drawRect(float x, float y, float width, float height)
		{
			AsBcRenderSupport.drawRect(x, y, width, height);
		}
		public void drawRoundRect(float x, float y, float width, float height, float ellipseWidth, float ellipseHeight)
		{
			AsBcRenderSupport.drawRoundRect(x, y, width, height, ellipseWidth, ellipseHeight);
		}
		public void drawBitmap(AsBitmapData bitmap, float x, float y)
		{
			AsBcRenderSupport.drawBitmap(bitmap, x, y);
		}
		public void endFill()
		{
			AsBcRenderSupport.endFill();
		}
		public void lineStyle(float thickness, uint color, float alpha, bool pixelHinting, String scaleMode, String caps, String joints, float miterLimit)
		{
			AsBcRenderSupport.lineStyle(thickness, color, alpha, pixelHinting, scaleMode, caps, joints, miterLimit);
		}
		public void lineStyle(float thickness, uint color, float alpha, bool pixelHinting, String scaleMode, String caps, String joints)
		{
			lineStyle(thickness, color, alpha, pixelHinting, scaleMode, caps, joints, 3);
		}
		public void lineStyle(float thickness, uint color, float alpha, bool pixelHinting, String scaleMode, String caps)
		{
			lineStyle(thickness, color, alpha, pixelHinting, scaleMode, caps, null, 3);
		}
		public void lineStyle(float thickness, uint color, float alpha, bool pixelHinting, String scaleMode)
		{
			lineStyle(thickness, color, alpha, pixelHinting, scaleMode, null, null, 3);
		}
		public void lineStyle(float thickness, uint color, float alpha, bool pixelHinting)
		{
			lineStyle(thickness, color, alpha, pixelHinting, "normal", null, null, 3);
		}
		public void lineStyle(float thickness, uint color, float alpha)
		{
			lineStyle(thickness, color, alpha, false, "normal", null, null, 3);
		}
		public void lineStyle(float thickness, uint color)
		{
			lineStyle(thickness, color, 1.0f, false, "normal", null, null, 3);
		}
		public void lineStyle(float thickness)
		{
			lineStyle(thickness, (uint)(0), 1.0f, false, "normal", null, null, 3);
		}
		public void lineStyle()
		{
			lineStyle(0, (uint)(0), 1.0f, false, "normal", null, null, 3);
		}
		public void lineTo(float x, float y)
		{
			AsBcRenderSupport.lineTo(x, y);
		}
		public void moveTo(float x, float y)
		{
			AsBcRenderSupport.moveTo(x, y);
		}
		public void scale(float scaleX, float scaleY)
		{
			AsBcRenderSupport.scale(scaleX, scaleY);
		}
		public void rotate(float a)
		{
			AsBcRenderSupport.rotate(a);
		}
		public void translate(float x, float y)
		{
			AsBcRenderSupport.translate(x, y);
		}
		public void pushMatrix()
		{
			AsBcRenderSupport.pushMatrix();
		}
		public void popMatrix()
		{
			AsBcRenderSupport.popMatrix();
		}
	}
}
