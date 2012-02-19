using System;
 
using bc.flash;
using bc.flash.events;
 
namespace bc.flash.events
{
	public class AsKeyboardEvent : AsEvent
	{
		public static String KEY_UP = "keyUp";
		public static String KEY_DOWN = "keyDown";
		private uint mCharCode;
		private uint mKeyCode;
		private uint mKeyLocation;
		private bool mAltKey;
		private bool mCtrlKey;
		private bool mShiftKey;
		public AsKeyboardEvent(String type, uint charCode, uint keyCode, uint keyLocation, bool ctrlKey, bool altKey, bool shiftKey)
		 : base(type, false)
		{
			mCharCode = charCode;
			mKeyCode = keyCode;
			mKeyLocation = keyLocation;
			mCtrlKey = ctrlKey;
			mAltKey = altKey;
			mShiftKey = shiftKey;
		}
		public AsKeyboardEvent(String type, uint charCode, uint keyCode, uint keyLocation, bool ctrlKey, bool altKey)
		 : this(type, 0, 0, 0, false, false, false)
		{
		}
		public AsKeyboardEvent(String type, uint charCode, uint keyCode, uint keyLocation, bool ctrlKey)
		 : this(type, 0, 0, 0, false, false)
		{
		}
		public AsKeyboardEvent(String type, uint charCode, uint keyCode, uint keyLocation)
		 : this(type, 0, 0, 0, false)
		{
		}
		public AsKeyboardEvent(String type, uint charCode, uint keyCode)
		 : this(type, 0, 0, 0)
		{
		}
		public AsKeyboardEvent(String type, uint charCode)
		 : this(type, 0, 0)
		{
		}
		public AsKeyboardEvent(String type)
		 : this(type, 0)
		{
		}
		public virtual uint getCharCode()
		{
			return mCharCode;
		}
		public virtual uint getKeyCode()
		{
			return mKeyCode;
		}
		public virtual uint getKeyLocation()
		{
			return mKeyLocation;
		}
		public virtual bool getAltKey()
		{
			return mAltKey;
		}
		public virtual bool getCtrlKey()
		{
			return mCtrlKey;
		}
		public virtual bool getShiftKey()
		{
			return mShiftKey;
		}
	}
}
