using System;
 
using bc.flash;
using bc.flash.display;
 
namespace bc.flash.display
{
	public class AsInteractiveObject : AsDisplayObject
	{
		private bool m_mouseEnabled;
		private bool m_doubleClickEnabled;
		public virtual bool getDoubleClickEnabled()
		{
			return m_doubleClickEnabled;
		}
		public virtual void setDoubleClickEnabled(bool enabled)
		{
			m_doubleClickEnabled = enabled;
		}
		public virtual AsObject getFocusRect()
		{
			AsDebug.implementMe("get focusRect");
			return null;
		}
		public virtual void setFocusRect(bool focusRect)
		{
			AsDebug.implementMe("set focusRect");
		}
		public virtual bool getMouseEnabled()
		{
			return m_mouseEnabled;
		}
		public virtual void setMouseEnabled(bool enabled)
		{
			m_mouseEnabled = enabled;
		}
	}
}
