using System;
 
using bc.flash;
using bc.flash.error;
 
namespace bc.flash.media
{
	public class AsSoundTransform : AsObject
	{
		public AsSoundTransform(float vol, float panning)
		{
			throw new AsNotImplementedError();
		}
		public AsSoundTransform(float vol)
		 : this(1, 0)
		{
		}
		public AsSoundTransform()
		 : this(1)
		{
		}
		public virtual float getLeftToLeft()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setLeftToLeft(float leftToLeft)
		{
			throw new AsNotImplementedError();
		}
		public virtual float getLeftToRight()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setLeftToRight(float leftToRight)
		{
			throw new AsNotImplementedError();
		}
		public virtual float getPan()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setPan(float panning)
		{
			throw new AsNotImplementedError();
		}
		public virtual float getRightToLeft()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setRightToLeft(float rightToLeft)
		{
			throw new AsNotImplementedError();
		}
		public virtual float getRightToRight()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setRightToRight(float rightToRight)
		{
			throw new AsNotImplementedError();
		}
		public virtual float getVolume()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setVolume(float volume)
		{
			throw new AsNotImplementedError();
		}
	}
}
