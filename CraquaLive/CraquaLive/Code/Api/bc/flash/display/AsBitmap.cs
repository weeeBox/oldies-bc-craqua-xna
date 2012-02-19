using System;
 
using bc.flash;
using bc.flash.display;
 
namespace bc.flash.display
{
	public class AsBitmap : AsDisplayObject
	{
		private AsBitmapData mBitmapData;
		private String mPixelSnapping;
		private bool mSmoothing;
		public AsBitmap(AsBitmapData bitmapData, String pixelSnapping, bool smoothing)
		{
			mBitmapData = bitmapData;
			mPixelSnapping = pixelSnapping;
			mSmoothing = smoothing;
		}
		public AsBitmap(AsBitmapData bitmapData, String pixelSnapping)
		 : this(null, "auto", false)
		{
		}
		public AsBitmap(AsBitmapData bitmapData)
		 : this(null, "auto")
		{
		}
		public AsBitmap()
		 : this(null)
		{
		}
		public virtual AsBitmapData getBitmapData()
		{
			return mBitmapData;
		}
		public virtual void setBitmapData(AsBitmapData _value)
		{
			mBitmapData = _value;
		}
		public virtual String getPixelSnapping()
		{
			return mPixelSnapping;
		}
		public virtual void setPixelSnapping(String _value)
		{
			mPixelSnapping = _value;
		}
		public virtual bool getSmoothing()
		{
			return mSmoothing;
		}
		public virtual void setSmoothing(bool _value)
		{
			mSmoothing = _value;
		}
	}
}
