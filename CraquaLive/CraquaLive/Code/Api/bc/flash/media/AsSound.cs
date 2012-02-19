using System;
 
using bc.flash;
using bc.flash.error;
using bc.flash.events;
using bc.flash.media;
using bc.flash.net;
 
namespace bc.flash.media
{
	public class AsSound : AsEventDispatcher
	{
		public AsSound(AsURLRequest stream, AsSoundLoaderContext context)
		{
			throw new AsNotImplementedError();
		}
		public AsSound(AsURLRequest stream)
		 : this(null, null)
		{
		}
		public AsSound()
		 : this(null)
		{
		}
		public virtual uint getBytesLoaded()
		{
			throw new AsNotImplementedError();
		}
		public virtual int getBytesTotal()
		{
			throw new AsNotImplementedError();
		}
		public virtual void close()
		{
			throw new AsNotImplementedError();
		}
		public virtual float getLength()
		{
			throw new AsNotImplementedError();
		}
		public virtual void load(AsURLRequest stream, AsSoundLoaderContext context)
		{
			throw new AsNotImplementedError();
		}
		public virtual void load(AsURLRequest stream)
		{
			load(stream, null);
		}
		public virtual AsSoundChannel play(float startTime, int loops, AsSoundTransform sndTransform)
		{
			throw new AsNotImplementedError();
		}
		public virtual AsSoundChannel play(float startTime, int loops)
		{
			return play(0, 0, null);
		}
		public virtual AsSoundChannel play(float startTime)
		{
			return play(0, 0);
		}
		public virtual AsSoundChannel play()
		{
			return play(0);
		}
		public virtual String getUrl()
		{
			throw new AsNotImplementedError();
		}
	}
}
