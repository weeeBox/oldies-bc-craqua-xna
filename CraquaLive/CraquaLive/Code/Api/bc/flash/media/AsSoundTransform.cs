using System;
 
using bc.flash;
 
namespace bc.flash.media
{
	public class AsSoundTransform : AsObject
	{
		private float mVolume;
		private float mPanning;
		private float mLeftToLeft;
		private float mLeftToRight;
		private float mRightToLeft;
		private float mRightToRight;
		public AsSoundTransform(float vol, float panning)
		{
			mVolume = vol;
			mPanning = panning;
		}
		public AsSoundTransform(float vol)
		 : this(vol, 0)
		{
		}
		public AsSoundTransform()
		 : this(1, 0)
		{
		}
		public virtual float getLeftToLeft()
		{
			return mLeftToLeft;
		}
		public virtual void setLeftToLeft(float leftToLeft)
		{
			mLeftToLeft = leftToLeft;
		}
		public virtual float getLeftToRight()
		{
			return mLeftToRight;
		}
		public virtual void setLeftToRight(float leftToRight)
		{
			mLeftToRight = leftToRight;
		}
		public virtual float getPan()
		{
			return mPanning;
		}
		public virtual void setPan(float panning)
		{
			mPanning = panning;
		}
		public virtual float getRightToLeft()
		{
			return mRightToLeft;
		}
		public virtual void setRightToLeft(float rightToLeft)
		{
			mRightToLeft = rightToLeft;
		}
		public virtual float getRightToRight()
		{
			return mRightToRight;
		}
		public virtual void setRightToRight(float rightToRight)
		{
			mRightToRight = rightToRight;
		}
		public virtual float getVolume()
		{
			return mVolume;
		}
		public virtual void setVolume(float volume)
		{
			mVolume = volume;
		}
	}
}
