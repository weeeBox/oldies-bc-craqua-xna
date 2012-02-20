using System;
 
using bc.flash;
using bc.flash.geom;
 
namespace bc.flash.geom
{
	public class AsMatrix : AsObject
	{
		private const int U = 0;
		private const int V = 0;
		private const int W = 1;
		public float a;
		public float b;
		public float c;
		public float d;
		public float tx;
		public float ty;
		public AsMatrix(float a, float b, float c, float d, float tx, float ty)
		{
			setValues(a, b, c, d, tx, ty);
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
		private void setValues(float a, float b, float c, float d, float tx, float ty)
		{
			this.a = a;
			this.b = b;
			this.c = c;
			this.d = d;
			this.tx = tx;
			this.ty = ty;
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
			setValues(((a * this.a) + (c * this.b)), ((b * this.a) + (d * this.b)), ((a * this.c) + (c * this.d)), ((b * this.c) + (d * this.d)), (((a * this.tx) + (c * this.ty)) + (tx * W)), (((b * this.tx) + (d * this.ty)) + (ty * W)));
		}
		public virtual void createBox(float scaleX, float scaleY, float rotation, float tx, float ty)
		{
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
			return null;
		}
		public virtual void identity()
		{
			setValues(1, 0, 0, 1, 0, 0);
		}
		public virtual void invert()
		{
			float det = determinant();
			setValues((d / det), (-b / det), (-c / det), (a / det), (((c * ty) - (d * tx)) / det), (((b * tx) - (a * ty)) / det));
		}
		public virtual void rotate(float angle)
		{
			float cosA = AsMath.cos(angle);
			float sinA = AsMath.sin(angle);
			concatValues(cosA, sinA, -sinA, cosA, 0, 0);
		}
		public virtual void scale(float sx, float sy)
		{
			a = (a * sx);
			b = (b * sy);
			c = (c * sx);
			d = (d * sy);
			tx = (tx * sx);
			ty = (ty * sy);
		}
		public virtual void translate(float dx, float dy)
		{
			tx = (tx + dx);
			ty = (ty + dy);
		}
		public virtual AsPoint transformPoint(AsPoint point)
		{
			return new AsPoint((((a * point.x) + (c * point.y)) + tx), (((b * point.x) + (d * point.y)) + ty));
		}
		private float determinant()
		{
			return ((a * d) - (c * b));
		}
	}
}
