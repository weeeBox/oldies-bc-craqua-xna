using System;
 
using bc.flash;
using bc.flash.display;
using bc.flash.error;
using bc.flash.geom;
 
namespace bc.flash.geom
{
	public class AsTransform : AsObject
	{
		public AsTransform(AsDisplayObject displayObject)
		{
		}
		public virtual AsColorTransform getColorTransform()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setColorTransform(AsColorTransform _value)
		{
			throw new AsNotImplementedError();
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
