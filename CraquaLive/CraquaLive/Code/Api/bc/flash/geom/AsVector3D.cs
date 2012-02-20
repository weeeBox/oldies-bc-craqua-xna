using System;
 
using bc.flash;
using bc.flash.error;
using bc.flash.geom;
 
namespace bc.flash.geom
{
	public class AsVector3D : AsObject
	{
		public static AsVector3D X_AXIS;
		public static AsVector3D Y_AXIS;
		public static AsVector3D Z_AXIS;
		public float x;
		public float y;
		public float z;
		public float w;
		public AsVector3D(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}
		public AsVector3D(float x, float y, float z)
		 : this(x, y, z, 0.0f)
		{
		}
		public AsVector3D(float x, float y)
		 : this(x, y, 0.0f, 0.0f)
		{
		}
		public AsVector3D(float x)
		 : this(x, 0.0f, 0.0f, 0.0f)
		{
		}
		public AsVector3D()
		 : this(0.0f, 0.0f, 0.0f, 0.0f)
		{
		}
		public virtual AsVector3D _add(AsVector3D a)
		{
			return new AsVector3D((x + a.x), (y + a.y), (z + a.z));
		}
		public static float angleBetween(AsVector3D a, AsVector3D b)
		{
			throw new AsNotImplementedError();
		}
		public virtual AsVector3D clone()
		{
			return new AsVector3D(x, y, z, w);
		}
		public virtual void copyFrom(AsVector3D sourceVector3D)
		{
			x = sourceVector3D.x;
			y = sourceVector3D.y;
			z = sourceVector3D.z;
			w = sourceVector3D.w;
		}
		public virtual AsVector3D crossProduct(AsVector3D a)
		{
			throw new AsNotImplementedError();
		}
		public virtual void decrementBy(AsVector3D a)
		{
			x = (x - a.x);
			y = (y - a.y);
			z = (z - a.z);
		}
		public static float distance(AsVector3D pt1, AsVector3D pt2)
		{
			float dx = (pt1.x - pt2.x);
			float dy = (pt1.y - pt2.y);
			float dz = (pt1.z - pt2.z);
			return AsMath.sqrt((((dx * dx) + (dy * dy)) + (dz * dz)));
		}
		public virtual float dotProduct(AsVector3D a)
		{
			return (((x * a.x) + (y * a.y)) + (z * a.z));
		}
		public virtual bool equals(AsVector3D toCompare, bool allFour)
		{
			return ((((x == toCompare.x) && (y == toCompare.y)) && (z == toCompare.z)) && (!(allFour) || (w == toCompare.w)));
		}
		public virtual bool equals(AsVector3D toCompare)
		{
			return equals(toCompare, false);
		}
		public virtual void incrementBy(AsVector3D a)
		{
			x = (x + a.x);
			y = (y + a.y);
			z = (z + a.z);
		}
		public virtual float getLength()
		{
			return AsMath.sqrt((((x * x) + (y * y)) + (z * z)));
		}
		public virtual float getLengthSquared()
		{
			return (((x * x) + (y * y)) + (z * z));
		}
		public virtual bool nearEquals(AsVector3D toCompare, float tolerance, bool allFour)
		{
			return ((((AsMath.abs((x - toCompare.x)) <= tolerance) && (AsMath.abs((y - toCompare.y)) <= tolerance)) && (AsMath.abs((z - toCompare.z)) <= tolerance)) && (!(allFour) || (AsMath.abs((w - toCompare.w)) <= tolerance)));
		}
		public virtual bool nearEquals(AsVector3D toCompare, float tolerance)
		{
			return nearEquals(toCompare, tolerance, false);
		}
		public virtual void negate()
		{
			x = -x;
			y = -y;
			z = -z;
		}
		public virtual float normalize()
		{
			float len = getLength();
			if((len == 0))
			{
				throw new AsIllegalOperationError("Unable to normalize vector with zero lenght");
			}
			float lenInv = (1.0f / getLength());
			x = (x * lenInv);
			y = (y * lenInv);
			z = (z * lenInv);
			throw new AsNotImplementedError();
		}
		public virtual void project()
		{
			throw new AsNotImplementedError();
		}
		public virtual void scaleBy(float s)
		{
			x = (x * s);
			y = (y * s);
			z = (z * s);
		}
		public virtual void setTo(float xa, float ya, float za)
		{
			x = xa;
			y = ya;
			z = za;
		}
		public virtual AsVector3D subtract(AsVector3D a)
		{
			return new AsVector3D((x - a.x), (y - a.y), (z - a.z));
		}
		public virtual String toString()
		{
			return (((((("[" + x) + ", ") + y) + ", ") + z) + "]");
		}
	}
}
