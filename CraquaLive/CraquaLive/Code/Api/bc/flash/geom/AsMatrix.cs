using System;
 
using bc.flash;
using bc.flash.error;
using bc.flash.geom;
 
namespace bc.flash.geom
{
	public class AsMatrix : AsObject
	{
		public float a;
		public float b;
		public float c;
		public float d;
		public float tx;
		public float ty;
		public AsMatrix(float a, float b, float c, float d, float tx, float ty)
		{
			setTo(a, b, c, d, tx, ty);
		}
		public AsMatrix(float a, float b, float c, float d, float tx)
		 : this(a, b, c, d, tx, 0)
		{
		}
		public AsMatrix(float a, float b, float c, float d)
		 : this(a, b, c, d, 0, 0)
		{
		}
		public AsMatrix(float a, float b, float c)
		 : this(a, b, c, 1, 0, 0)
		{
		}
		public AsMatrix(float a, float b)
		 : this(a, b, 0, 1, 0, 0)
		{
		}
		public AsMatrix(float a)
		 : this(a, 0, 0, 1, 0, 0)
		{
		}
		public AsMatrix()
		 : this(1, 0, 0, 1, 0, 0)
		{
		}
		public virtual AsMatrix clone()
		{
			return new AsMatrix(a, b, c, d, tx, ty);
		}
		public virtual void concat(AsMatrix m)
		{
			concatValues(m.a, m.b, m.c, m.d, m.tx, m.ty);
		}
		public virtual void concatValues(float a, float b, float c, float d, float tx, float ty)
		{
			setTo(((this.a * a) + (this.b * c)), ((this.a * b) + (this.b * d)), ((this.c * a) + (this.d * c)), ((this.c * b) + (this.d * d)), (((this.tx * a) + (this.ty * c)) + tx), (((this.tx * b) + (this.ty * d)) + ty));
		}
		public virtual void copyColumnFrom(uint column, AsVector3D vector3D)
		{
			throw new AsNotImplementedError();
		}
		public virtual void copyColumnTo(uint column, AsVector3D vector3D)
		{
			throw new AsNotImplementedError();
		}
		public virtual void copyFrom(AsMatrix sourceMatrix)
		{
			setTo(sourceMatrix.a, sourceMatrix.b, sourceMatrix.c, sourceMatrix.d, sourceMatrix.tx, sourceMatrix.ty);
		}
		public virtual void copyRowFrom(uint row, AsVector3D vector3D)
		{
			throw new AsNotImplementedError();
		}
		public virtual void copyRowTo(uint row, AsVector3D vector3D)
		{
			throw new AsNotImplementedError();
		}
		public virtual void createBox(float scaleX, float scaleY, float rotation, float tx, float ty)
		{
			identity();
			rotate(rotation);
			scale(scaleX, scaleY);
			translate(tx, ty);
		}
		public virtual void createBox(float scaleX, float scaleY, float rotation, float tx)
		{
			createBox(scaleX, scaleY, rotation, tx, 0);
		}
		public virtual void createBox(float scaleX, float scaleY, float rotation)
		{
			createBox(scaleX, scaleY, rotation, 0, 0);
		}
		public virtual void createBox(float scaleX, float scaleY)
		{
			createBox(scaleX, scaleY, 0, 0, 0);
		}
		public virtual void createGradientBox(float width, float height, float rotation, float tx, float ty)
		{
			throw new AsNotImplementedError();
		}
		public virtual void createGradientBox(float width, float height, float rotation, float tx)
		{
			createGradientBox(width, height, rotation, tx, 0);
		}
		public virtual void createGradientBox(float width, float height, float rotation)
		{
			createGradientBox(width, height, rotation, 0, 0);
		}
		public virtual void createGradientBox(float width, float height)
		{
			createGradientBox(width, height, 0, 0, 0);
		}
		public virtual AsPoint deltaTransformPoint(AsPoint point)
		{
			return new AsPoint(((a * point.x) + (c * point.y)), ((b * point.x) + (d * point.y)));
		}
		public virtual void identity()
		{
			setTo(1, 0, 0, 1, 0, 0);
		}
		public virtual void invert()
		{
			throw new AsNotImplementedError();
		}
		public virtual void rotate(float angle)
		{
			float cosA = AsMath.cos(angle);
			float sinA = AsMath.sin(angle);
			concatValues(cosA, sinA, -sinA, cosA, 0, 0);
		}
		public virtual void scale(float sx, float sy)
		{
			concatValues(sx, 0, 0, sy, 0, 0);
		}
		public virtual void setTo(float a, float b, float c, float d, float tx, float ty)
		{
			this.a = a;
			this.b = b;
			this.c = c;
			this.d = d;
			this.tx = tx;
			this.ty = ty;
		}
		public virtual AsPoint transformPoint(AsPoint point)
		{
			return new AsPoint((((a * point.x) + (c * point.y)) + tx), (((b * point.x) + (d * point.y)) + ty));
		}
		public virtual void translate(float dx, float dy)
		{
			concatValues(1, 0, 0, 1, dx, dy);
		}
	}
}
