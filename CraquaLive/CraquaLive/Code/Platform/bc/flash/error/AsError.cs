using System;
 
using bc.flash;
 
namespace bc.flash.error
{
	public class AsError : Exception
	{
		public String message;
		public String name;

		public AsError(String message)
		{
		}
		public AsError()
		 : this("")
		{
		}
	}
}
