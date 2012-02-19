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
			lineStyle(0, (uint)(0), 1.0f, false, "normal", null, null, 3);
		}
		public virtual void lineStyle(float thickness, uint color, float alpha, bool pixelHinting, String scaleMode, String caps)
		{
			lineStyle(0, (uint)(0), 1.0f, false, "normal", null, null);
		}
		public virtual void lineStyle(float thickness, uint color, float alpha, bool pixelHinting, String scaleMode)
		{
			lineStyle(0, (uint)(0), 1.0f, false, "normal", null);
		}
		public virtual void lineStyle(float thickness, uint color, float alpha, bool pixelHinting)
		{
			lineStyle(0, (uint)(0), 1.0f, false, "normal");
		}
		public virtual void lineStyle(float thickness, uint color, float alpha)
		{
			lineStyle(0, (uint)(0), 1.0f, false);
		}
		public virtual void lineStyle(float thickness, uint color)
		{
			lineStyle(0, (uint)(0), 1.0f);
		}
		public virtual void lineStyle(float thickness)
		{
			lineStyle(0, (uint)(0));
		}
		public virtual void lineStyle()
		{
			lineStyle(0);
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
