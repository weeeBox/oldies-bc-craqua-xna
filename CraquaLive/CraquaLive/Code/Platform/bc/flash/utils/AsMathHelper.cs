using System;
 
using bc.flash;
 
namespace bc.flash.utils
{
	public class AsMathHelper : AsObject
	{
		private const float epsilon = 0.00001f;
		public static bool epsilonEquals(float a, float b)
		{
			return (AsMath.abs((a - b)) < epsilon);
		}
	}
}
