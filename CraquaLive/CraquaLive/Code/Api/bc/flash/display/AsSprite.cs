using System;
 
using bc.flash.display;
using bc.flash.error;
using bc.flash.events;
using bc.flash.ui;
 
namespace bc.flash.display
{
	public class AsSprite : AsDisplayObjectContainer
	{
		private bool mUseHandCursor;
		public AsSprite()
		 : base()
		{
		}
		public override void dispose()
		{
			base.dispose();
		}
		public virtual bool getUseHandCursor()
		{
			return mUseHandCursor;
		}
		public virtual void setUseHandCursor(bool _value)
		{
			if((_value == mUseHandCursor))
			{
				return;
			}
			mUseHandCursor = _value;
			if(mUseHandCursor)
			{
				addEventListener(AsTouchEvent.TOUCH, onTouch);
			}
			else
			{
				removeEventListener(AsTouchEvent.TOUCH, onTouch);
			}
		}
		public virtual AsGraphics getGraphics()
		{
			throw new AsNotImplementedError();
		}
		private void onTouch(AsEvent evt)
		{
			AsTouchEvent _event = ((AsTouchEvent)(evt));
			AsMouse.setCursor(((_event.interactsWith(this)) ? (AsMouseCursor.BUTTON) : (AsMouseCursor.AUTO)));
		}
		public virtual bool getMouseChildren()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setMouseChildren(bool enable)
		{
			throw new AsNotImplementedError();
		}
		public virtual bool getTabChildren()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setTabChildren(bool enable)
		{
			throw new AsNotImplementedError();
		}
	}
}
