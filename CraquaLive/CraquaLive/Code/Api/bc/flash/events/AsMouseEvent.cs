using System;
 
using bc.flash;
using bc.flash.error;
using bc.flash.events;
 
namespace bc.flash.events
{
	public class AsMouseEvent : AsEvent
	{
		public static String CLICK = "click";
		public static String DOUBLE_CLICK = "doubleClick";
		public static String MOUSE_DOWN = "mouseDown";
		public static String MOUSE_MOVE = "mouseMove";
		public static String MOUSE_OUT = "mouseOut";
		public static String MOUSE_OVER = "mouseOver";
		public static String MOUSE_UP = "mouseUp";
		public static String MOUSE_WHEEL = "mouseWheel";
		public static String ROLL_OUT = "rollOut";
		public static String ROLL_OVER = "rollOver";
		public AsMouseEvent(String type, bool bubbles)
		 : base(type, bubbles)
		{
		}
		public AsMouseEvent(String type)
		 : this(type, false)
		{
		}
		public virtual float getStageX()
		{
			throw new AsNotImplementedError();
		}
		public virtual float getStageY()
		{
			throw new AsNotImplementedError();
		}
	}
}
