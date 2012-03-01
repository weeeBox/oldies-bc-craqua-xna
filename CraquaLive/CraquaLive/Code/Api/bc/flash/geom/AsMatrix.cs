using System;
 
using bc.flash;
using bc.flash.error;
using bc.flash.geom;
using Microsoft.Xna.Framework;
 
namespace bc.flash.geom
{
	public class AsMatrix : AsObject
	{
        public Matrix innerMatrix;

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
            float na = this.a * a + this.c * b;
            float nb = this.b * a + this.d * b;
            float nc = this.a * c + this.c * d;            
            float nd = this.b * c + this.d * d;
            float ntx = this.tx * a + this.ty * b + tx;
            float nty = this.tx * c + this.ty * d + ty;
            setTo(na, nb, nc, nd, ntx, nty);
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
            float nx = point.x * a + point.y * b;
            float ny = point.x * c + point.y * d;
            return new AsPoint(nx, ny);
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
            innerMatrix.M11 = a;
            innerMatrix.M12 = c;
            innerMatrix.M13 = 0;
            innerMatrix.M14 = 0;

            innerMatrix.M21 = b;
            innerMatrix.M22 = d;
            innerMatrix.M23 = 0;
            innerMatrix.M24 = 0;

            innerMatrix.M31 = 0;
            innerMatrix.M32 = 0;
            innerMatrix.M33 = 1;
            innerMatrix.M34 = 0;

            innerMatrix.M41 = tx;
            innerMatrix.M42 = ty;
            innerMatrix.M43 = 0;
            innerMatrix.M44 = 1;
		}
		public virtual AsPoint transformPoint(AsPoint point)
		{
            float nx = point.x * a + point.y * b + tx;
            float ny = point.x * c + point.y * d + ty;
            return new AsPoint(nx, ny);
		}
		public virtual void translate(float dx, float dy)
		{
			concatValues(1, 0, 0, 1, dx, dy);
		}

        public float a
        {
            get { return innerMatrix.M11; }
            set { innerMatrix.M11 = value; }
        }

        public float b
        {
            get { return innerMatrix.M21; }
            set { innerMatrix.M21 = value; }
        }

        public float c
        {
            get { return innerMatrix.M12; }
            set { innerMatrix.M12 = value; }
        }        

        public float d
        {
            get { return innerMatrix.M22; }
            set { innerMatrix.M22 = value; }
        }

        public float tx
        {
            get { return innerMatrix.M41; }
            set { innerMatrix.M41 = value; }
        }

        public float ty
        {
            get { return innerMatrix.M42; }
            set { innerMatrix.M42 = value; }
        }
	}
}
