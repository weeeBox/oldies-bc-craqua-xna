using System;
 
using bc.flash;
using bc.flash.error;
using bc.flash.media;
 
namespace bc.flash.media
{
	public class AsSoundChannel : AsObject
	{
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
			throw new AsNotImplementedError();
		}
		public virtual void setSoundTransform(AsSoundTransform sndTransform)
		{
			throw new AsNotImplementedError();
		}
		public virtual void stop()
		{
			throw new AsNotImplementedError();
		}
	}
}
