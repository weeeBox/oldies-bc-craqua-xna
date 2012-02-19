using System;
 
using bc.flash;
using bc.flash.error;
 
namespace bc.flash.error
{
	public class AsNotImplementedError : Exception
	{
		public AsNotImplementedError(String message) : base(message)
		{
		}
		public AsNotImplementedError() : this("")
		{
		}
	}
}
