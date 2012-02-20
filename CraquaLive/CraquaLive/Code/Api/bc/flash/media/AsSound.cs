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
		private AsURLRequest mRequest;
		private AsSoundLoaderContext mContext;
		public AsSound(AsURLRequest request, AsSoundLoaderContext context)
		{
			mRequest = request;
			mContext = context;
		}
		public AsSound(AsURLRequest request)
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
		public virtual void load(AsURLRequest request, AsSoundLoaderContext context)
		{
			mRequest = request;
			mContext = context;
			throw new AsNotImplementedError();
		}
		public virtual void load(AsURLRequest request)
		{
			load(request, null);
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
			return mRequest.getUrl();
		}
	}
}
