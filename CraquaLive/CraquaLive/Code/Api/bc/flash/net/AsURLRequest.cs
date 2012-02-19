using System;
 
using bc.flash;
 
namespace bc.flash.net
{
	public class AsURLRequest : AsObject
	{
		private String mUrl;
		private String mContentType;
		private AsObject mData;
		private String mDigest;
		private String mMethod;
		public AsURLRequest(String url)
		{
			mUrl = url;
		}
		public AsURLRequest()
		 : this(null)
		{
		}
		public virtual String getContentType()
		{
			return mContentType;
		}
		public virtual void setContentType(String _value)
		{
			mContentType = _value;
		}
		public virtual AsObject getData()
		{
			return (AsObject)(mData);
		}
		public virtual void setData(AsObject _value)
		{
			mData = (AsObject)(_value);
		}
		public virtual String getDigest()
		{
			return mDigest;
		}
		public virtual void setDigest(String _value)
		{
			mDigest = _value;
		}
		public virtual String getMethod()
		{
			return mMethod;
		}
		public virtual void setMethod(String _value)
		{
			mMethod = _value;
		}
		public virtual String getUrl()
		{
			return mUrl;
		}
		public virtual void setUrl(String _value)
		{
			mUrl = _value;
		}
	}
}
