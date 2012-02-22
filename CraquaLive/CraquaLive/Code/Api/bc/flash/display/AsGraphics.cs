using System;
 
using bc.flash;
using bc.flash.display;
 
namespace bc.flash.display
{
	public class AsGraphics : AsObject
	{
		public virtual void beginFill(uint color, float alpha)
		{
			AsBcRenderSupport.beginFill(color, alpha);
		}
		public virtual void beginFill(uint color)
		{
			beginFill(color, 1.0f);
		}
		public virtual void clear()
		{
			AsBcRenderSupport.clear();
		}
		public virtual void curveTo(float controlX, float controlY, float anchorX, float anchorY)
		{
			AsBcRenderSupport.curveTo(controlX, controlY, anchorX, anchorY);
		}
		public virtual void drawCircle(float x, float y, float radius)
		{
			AsBcRenderSupport.drawCircle(x, y, radius);
		}
		public virtual void drawEllipse(float x, float y, float width, float height)
		{
			AsBcRenderSupport.drawEllipse(x, y, width, height);
		}
		public virtual void drawRect(float x, float y, float width, float height)
		{
			AsBcRenderSupport.drawRect(x, y, width, height);
		}
		public virtual void drawRoundRect(float x, float y, float width, float height, float ellipseWidth, float ellipseHeight)
		{
			AsBcRenderSupport.drawRoundRect(x, y, width, height, ellipseWidth, ellipseHeight);
		}
		public virtual void endFill()
		{
			AsBcRenderSupport.endFill();
		}
		public virtual void lineStyle(float thickness, uint color, float alpha, bool pixelHinting, String scaleMode, String caps, String joints, float miterLimit)
		{
			AsBcRenderSupport.lineStyle(thickness, color, alpha, pixelHinting, scaleMode, caps, joints, miterLimit);
		}
		public virtual void lineStyle(float thickness, uint color, float alpha, bool pixelHinting, String scaleMode, String caps, String joints)
		{
			lineStyle(thickness, color, alpha, pixelHinting, scaleMode, caps, joints, 3);
		}
		public virtual void lineStyle(float thickness, uint color, float alpha, bool pixelHinting, String scaleMode, String caps)
		{
			lineStyle(thickness, color, alpha, pixelHinting, scaleMode, caps, null, 3);
		}
		public virtual void lineStyle(float thickness, uint color, float alpha, bool pixelHinting, String scaleMode)
		{
			lineStyle(thickness, color, alpha, pixelHinting, scaleMode, null, null, 3);
		}
		public virtual void lineStyle(float thickness, uint color, float alpha, bool pixelHinting)
		{
			lineStyle(thickness, color, alpha, pixelHinting, "normal", null, null, 3);
		}
		public virtual void lineStyle(float thickness, uint color, float alpha)
		{
			lineStyle(thickness, color, alpha, false, "normal", null, null, 3);
		}
		public virtual void lineStyle(float thickness, uint color)
		{
			lineStyle(thickness, color, 1.0f, false, "normal", null, null, 3);
		}
		public virtual void lineStyle(float thickness)
		{
			lineStyle(thickness, (uint)(0), 1.0f, false, "normal", null, null, 3);
		}
		public virtual void lineStyle()
		{
			lineStyle(0, (uint)(0), 1.0f, false, "normal", null, null, 3);
		}
		public virtual void lineTo(float x, float y)
		{
			AsBcRenderSupport.lineTo(x, y);
		}
		public virtual void moveTo(float x, float y)
		{
			AsBcRenderSupport.moveTo(x, y);
		}
		public virtual void scale(float scaleX, float scaleY)
		{
			AsBcRenderSupport.scale(scaleX, scaleY);
		}
		public virtual void rotate(float a)
		{
			AsBcRenderSupport.rotate(a);
		}
		public virtual void translate(float x, float y)
		{
			AsBcRenderSupport.translate(x, y);
		}
		public virtual void pushMatrix()
		{
			AsBcRenderSupport.pushMatrix();
		}
		public virtual void popMatrix()
		{
			AsBcRenderSupport.popMatrix();
		}
	}
}
