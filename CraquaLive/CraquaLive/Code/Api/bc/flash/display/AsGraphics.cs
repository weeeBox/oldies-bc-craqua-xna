using System;
 
using bc.flash;
using bc.flash.error;
 
namespace bc.flash.display
{
	public class AsGraphics : AsObject
	{
		public virtual void beginFill(uint color, float alpha)
		{
			throw new AsAbstractClassError();
		}
		public virtual void beginFill(uint color)
		{
			beginFill(color, 1.0f);
		}
		public virtual void clear()
		{
			throw new AsAbstractClassError();
		}
		public virtual void curveTo(float controlX, float controlY, float anchorX, float anchorY)
		{
			throw new AsAbstractClassError();
		}
		public virtual void drawCircle(float x, float y, float radius)
		{
			throw new AsAbstractClassError();
		}
		public virtual void drawEllipse(float x, float y, float width, float height)
		{
			throw new AsAbstractClassError();
		}
		public virtual void drawRect(float x, float y, float width, float height)
		{
			throw new AsAbstractClassError();
		}
		public virtual void drawRoundRect(float x, float y, float width, float height, float ellipseWidth, float ellipseHeight)
		{
			throw new AsAbstractClassError();
		}
		public virtual void endFill()
		{
			throw new AsAbstractClassError();
		}
		public virtual void lineStyle(float thickness, uint color, float alpha, bool pixelHinting, String scaleMode, String caps, String joints, float miterLimit)
		{
			throw new AsAbstractClassError();
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
			throw new AsAbstractClassError();
		}
		public virtual void moveTo(float x, float y)
		{
			throw new AsAbstractClassError();
		}
	}
}
