using System;
 
using bc.flash;
 
namespace bc.flash.input
{
	public class AsThumbStick : AsObject
	{
		private float mx;
		private float my;
		public virtual void update(float x, float y)
		{
			mx = x;
			my = y;
		}
		public virtual float getX()
		{
			return mx;
		}
		public virtual float getY()
		{
			return my;
		}
	}
}
