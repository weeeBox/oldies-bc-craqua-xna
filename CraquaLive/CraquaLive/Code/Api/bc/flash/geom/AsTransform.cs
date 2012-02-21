using System;
 
using bc.flash;
using bc.flash.display;
using bc.flash.error;
using bc.flash.geom;
 
namespace bc.flash.geom
{
	public class AsTransform : AsObject
	{
		private AsDisplayObject mDisplayObject;
		private AsColorTransform mColorTransform;
		public AsTransform(AsDisplayObject displayObject)
		{
			mDisplayObject = displayObject;
			mColorTransform = new AsColorTransform();
		}
		public virtual AsColorTransform getColorTransform()
		{
			return mColorTransform;
		}
		public virtual void setColorTransform(AsColorTransform _value)
		{
			mColorTransform = _value;
		}
		public virtual AsColorTransform getConcatenatedColorTransform()
		{
			throw new AsNotImplementedError();
		}
		public virtual AsMatrix getConcatenatedMatrix()
		{
			throw new AsNotImplementedError();
		}
		public virtual AsMatrix getMatrix()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setMatrix(AsMatrix _value)
		{
			throw new AsNotImplementedError();
		}
	}
}
