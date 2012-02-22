using System;
 
using bc.flash;
using bc.flash.display;
using bc.flash.geom;
 
namespace bc.flash.display
{
	public class AsBitmap : AsDisplayObject
	{
		private AsBitmapData mBitmapData;
		private String mPixelSnapping;
		private bool mSmoothing;
		private static AsMatrix sHelperMatrix = new AsMatrix();
		private static AsPoint sHelperPoint = new AsPoint();
		public AsBitmap(AsBitmapData bitmapData, String pixelSnapping, bool smoothing)
		{
			mBitmapData = bitmapData;
			mPixelSnapping = pixelSnapping;
			mSmoothing = smoothing;
		}
		public AsBitmap(AsBitmapData bitmapData, String pixelSnapping)
		 : this(bitmapData, pixelSnapping, false)
		{
		}
		public AsBitmap(AsBitmapData bitmapData)
		 : this(bitmapData, "auto", false)
		{
		}
		public AsBitmap()
		 : this(null, "auto", false)
		{
		}
		public override AsRectangle getBounds(AsDisplayObject targetSpace, AsRectangle resultRect)
		{
			if((resultRect == null))
			{
				resultRect = new AsRectangle();
			}
			getTransformationMatrix(targetSpace, sHelperMatrix);
			sHelperPoint.x = getX();
			sHelperPoint.y = getY();
			AsGlobal.transformCoords(sHelperMatrix, 0.0f, 0.0f, sHelperPoint);
			resultRect.x = sHelperPoint.x;
			resultRect.y = sHelperPoint.y;
			sHelperPoint.x = (getX() + mBitmapData.getWidth());
			sHelperPoint.y = (getY() + mBitmapData.getHeight());
			AsGlobal.transformCoords(sHelperMatrix, 0.0f, 0.0f, sHelperPoint);
			resultRect.width = sHelperPoint.x;
			resultRect.height = sHelperPoint.y;
			return resultRect;
		}
		public virtual AsRectangle getBounds(AsDisplayObject targetSpace)
		{
			return getBounds(targetSpace, null);
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
