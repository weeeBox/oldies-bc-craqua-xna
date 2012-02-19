using System;
 
using bc.flash;
using bc.flash.error;
using bc.flash.geom;
 
namespace bc.flash.geom
{
	public class AsRectangle : AsObject
	{
		public float x;
		public float y;
		public float width;
		public float height;
		public AsRectangle(float x, float y, float width, float height)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
		}
		public AsRectangle(float x, float y, float width)
		 : this(0, 0, 0, 0)
		{
		}
		public AsRectangle(float x, float y)
		 : this(0, 0, 0)
		{
		}
		public AsRectangle(float x)
		 : this(0, 0)
		{
		}
		public AsRectangle()
		 : this(0)
		{
		}
		public virtual float getBottom()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setBottom(float _value)
		{
			throw new AsNotImplementedError();
		}
		public virtual AsPoint getBottomRight()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setBottomRight(AsPoint _value)
		{
			throw new AsNotImplementedError();
		}
		public virtual AsRectangle clone()
		{
			throw new AsNotImplementedError();
		}
		public virtual bool contains(float x, float y)
		{
			throw new AsNotImplementedError();
		}
		public virtual bool containsPoint(AsPoint point)
		{
			throw new AsNotImplementedError();
		}
		public virtual bool containsRect(AsRectangle rect)
		{
			throw new AsNotImplementedError();
		}
		public virtual bool equals(AsRectangle toCompare)
		{
			throw new AsNotImplementedError();
		}
		public virtual void inflate(float dx, float dy)
		{
			throw new AsNotImplementedError();
		}
		public virtual void inflatePoint(AsPoint point)
		{
			throw new AsNotImplementedError();
		}
		public virtual AsRectangle intersection(AsRectangle toIntersect)
		{
			throw new AsNotImplementedError();
		}
		public virtual bool intersects(AsRectangle toIntersect)
		{
			throw new AsNotImplementedError();
		}
		public virtual bool isEmpty()
		{
			throw new AsNotImplementedError();
		}
		public virtual float getLeft()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setLeft(float _value)
		{
			throw new AsNotImplementedError();
		}
		public virtual void offset(float dx, float dy)
		{
			throw new AsNotImplementedError();
		}
		public virtual void offsetPoint(AsPoint point)
		{
			throw new AsNotImplementedError();
		}
		public virtual float getRight()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setRight(float _value)
		{
			throw new AsNotImplementedError();
		}
		public virtual void setEmpty()
		{
			throw new AsNotImplementedError();
		}
		public virtual AsPoint getSize()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setSize(AsPoint _value)
		{
			throw new AsNotImplementedError();
		}
		public virtual float getTop()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setTop(float _value)
		{
			throw new AsNotImplementedError();
		}
		public virtual AsPoint getTopLeft()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setTopLeft(AsPoint _value)
		{
			throw new AsNotImplementedError();
		}
		public virtual AsRectangle union(AsRectangle toUnion)
		{
			throw new AsNotImplementedError();
		}
	}
}
