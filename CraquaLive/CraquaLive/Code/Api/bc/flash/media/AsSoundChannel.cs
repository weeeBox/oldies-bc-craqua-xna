using System;
 
using bc.flash;
using bc.flash.error;
using bc.flash.media;
 
namespace bc.flash.media
{
	public class AsSoundChannel : AsObject
	{
		private AsSoundTransform mSoundTransform;
		public virtual float getLeftPeak()
		{
			throw new AsNotImplementedError();
		}
		public virtual float getPosition()
		{
			throw new AsNotImplementedError();
		}
		public virtual float getRightPeak()
		{
			throw new AsNotImplementedError();
		}
		public virtual AsSoundTransform getSoundTransform()
		{
			return mSoundTransform;
		}
		public virtual void setSoundTransform(AsSoundTransform sndTransform)
		{
			mSoundTransform = sndTransform;
		}
		public virtual void stop()
		{
			
		}
	}
}
