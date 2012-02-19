using System;
 
using bc.flash;
using bc.flash.error;
using bc.flash.geom;
 
namespace bc.flash.geom
{
	public class AsColorTransform : AsObject
	{
		public float redMultiplier;
		public float greenMultiplier;
		public float blueMultiplier;
		public float alphaMultiplier;
		public float redOffset;
		public float greenOffset;
		public float blueOffset;
		public float alphaOffset;
		public AsColorTransform(float redMultiplier, float greenMultiplier, float blueMultiplier, float alphaMultiplier, float redOffset, float greenOffset, float blueOffset, float alphaOffset)
		{
			throw new AsNotImplementedError();
		}
		public AsColorTransform(float redMultiplier, float greenMultiplier, float blueMultiplier, float alphaMultiplier, float redOffset, float greenOffset, float blueOffset)
		 : this(1.0f, 1.0f, 1.0f, 1.0f, 0, 0, 0, 0)
		{
		}
		public AsColorTransform(float redMultiplier, float greenMultiplier, float blueMultiplier, float alphaMultiplier, float redOffset, float greenOffset)
		 : this(1.0f, 1.0f, 1.0f, 1.0f, 0, 0, 0)
		{
		}
		public AsColorTransform(float redMultiplier, float greenMultiplier, float blueMultiplier, float alphaMultiplier, float redOffset)
		 : this(1.0f, 1.0f, 1.0f, 1.0f, 0, 0)
		{
		}
		public AsColorTransform(float redMultiplier, float greenMultiplier, float blueMultiplier, float alphaMultiplier)
		 : this(1.0f, 1.0f, 1.0f, 1.0f, 0)
		{
		}
		public AsColorTransform(float redMultiplier, float greenMultiplier, float blueMultiplier)
		 : this(1.0f, 1.0f, 1.0f, 1.0f)
		{
		}
		public AsColorTransform(float redMultiplier, float greenMultiplier)
		 : this(1.0f, 1.0f, 1.0f)
		{
		}
		public AsColorTransform(float redMultiplier)
		 : this(1.0f, 1.0f)
		{
		}
		public AsColorTransform()
		 : this(1.0f)
		{
		}
		public virtual uint getColor()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setColor(uint newColor)
		{
			throw new AsNotImplementedError();
		}
		public virtual void concat(AsColorTransform second)
		{
			throw new AsNotImplementedError();
		}
	}
}
