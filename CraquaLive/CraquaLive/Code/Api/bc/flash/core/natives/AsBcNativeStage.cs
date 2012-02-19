using System;
 
using bc.flash;
using bc.flash.events;
 
namespace bc.flash.core.natives
{
	public delegate void AsEventListenerCallback(AsEvent _event);
	public class AsBcNativeStage : AsObject
	{
		private AsDictionary mEventListeners;
		private int mWidth;
		private int mHeight;
		public AsBcNativeStage(int width, int height)
		{
			mWidth = width;
			mHeight = height;
		}
		public virtual int getWidth()
		{
			return mWidth;
		}
		public virtual int getHeight()
		{
			return mHeight;
		}
		public virtual void addEventListener(String type, AsEventListenerCallback listener)
		{
			if((mEventListeners == null))
			{
				mEventListeners = new AsDictionary();
			}
			AsVector<AsEventListenerCallback> listeners = (AsVector<AsEventListenerCallback>)(mEventListeners[type]);
			if((listeners == null))
			{
				listeners = new AsVector<AsEventListenerCallback>();
				mEventListeners[type] = listeners;
			}
			listeners.push(listener);
		}
		public virtual void removeEventListener(String type, AsEventListenerCallback listener)
		{
			if((mEventListeners) != null)
			{
				AsVector<AsEventListenerCallback> listeners = (AsVector<AsEventListenerCallback>)(mEventListeners[type]);
				if((listeners) != null)
				{
					AsVector<AsEventListenerCallback> remainListeners = new AsVector<AsEventListenerCallback>();
					foreach (AsEventListenerCallback eventListener in listeners)
					{
						if((eventListener != listener))
						{
							remainListeners.push(eventListener);
						}
					}
					if((remainListeners.getLength() > 0))
					{
						mEventListeners[type] = remainListeners;
					}
					else
					{
						mEventListeners.remove(type);
					}
				}
			}
		}
		public virtual void removeEventListeners(String type)
		{
			if(((type != null) && (mEventListeners != null)))
			{
				mEventListeners.remove(type);
			}
			else
			{
				mEventListeners = null;
			}
		}
		public virtual void removeEventListeners()
		{
			removeEventListeners(null);
		}
		public virtual void dispatchEvent(AsEvent _event)
		{
			AsVector<AsEventListenerCallback> listeners = (AsVector<AsEventListenerCallback>)((((mEventListeners) != null) ? (mEventListeners[_event.getType()]) : (null)));
			if((listeners == null))
			{
				return;
			}
			int numListeners = (int)(listeners.getLength());
			if((numListeners != 0))
			{
				int i = 0;
				for (; (i < numListeners); ++i)
				{
					AsEventListenerCallback listener = listeners[i];
					listener(_event);
				}
			}
		}
		public virtual bool hasEventListener(String type)
		{
			return ((mEventListeners != null) && (mEventListeners[type] != null));
		}
		public virtual void tick(float dt)
		{
			dispatchEvent(new AsEnterFrameEvent(AsEvent.ENTER_FRAME, dt));
		}
		public virtual void keyPressed(uint code)
		{
			dispatchEvent(new AsKeyboardEvent(AsKeyboardEvent.KEY_DOWN, code));
		}
		public virtual void keyReleased(uint code)
		{
			dispatchEvent(new AsKeyboardEvent(AsKeyboardEvent.KEY_UP, code));
		}
		public virtual void touchDown(float x, float y, int touchId)
		{
		}
		public virtual void touchMove(float x, float y, int touchId)
		{
		}
		public virtual void touchDragged(float x, float y, int touchId)
		{
		}
		public virtual void touchUp(float x, float y, int touchId)
		{
		}
	}
}
