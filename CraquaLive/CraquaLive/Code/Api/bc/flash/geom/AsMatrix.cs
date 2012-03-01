using System;

using bc.flash;
using bc.flash.error;
using bc.flash.geom;
using Microsoft.Xna.Framework;

namespace bc.flash.geom
{
    public sealed class AsMatrix : AsObject
    {
        public Matrix internalMatrix;

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
        public AsMatrix clone()
        {
            return new AsMatrix(a, b, c, d, tx, ty);
        }
        public void concat(AsMatrix m)
        {
            concatValues(m.a, m.b, m.c, m.d, m.tx, m.ty);
        }
        public void concatValues(float a, float b, float c, float d, float tx, float ty)
        {
            float na = this.a * a + this.c * b;
            float nb = this.b * a + this.d * b;
            float nc = this.a * c + this.c * d;
            float nd = this.b * c + this.d * d;
            float ntx = this.tx * a + this.ty * b + tx;
            float nty = this.tx * c + this.ty * d + ty;
            setTo(na, nb, nc, nd, ntx, nty);
        }
        public void copyColumnFrom(uint column, AsVector3D vector3D)
        {
            throw new AsNotImplementedError();
        }
        public void copyColumnTo(uint column, AsVector3D vector3D)
        {
            throw new AsNotImplementedError();
        }
        public void copyFrom(AsMatrix sourceMatrix)
        {
            setTo(sourceMatrix.a, sourceMatrix.b, sourceMatrix.c, sourceMatrix.d, sourceMatrix.tx, sourceMatrix.ty);
        }
        public void copyRowFrom(uint row, AsVector3D vector3D)
        {
            throw new AsNotImplementedError();
        }
        public void copyRowTo(uint row, AsVector3D vector3D)
        {
            throw new AsNotImplementedError();
        }
        public void createBox(float scaleX, float scaleY, float rotation, float tx, float ty)
        {
            identity();
            rotate(rotation);
            scale(scaleX, scaleY);
            translate(tx, ty);
        }
        public void createBox(float scaleX, float scaleY, float rotation, float tx)
        {
            createBox(scaleX, scaleY, rotation, tx, 0);
        }
        public void createBox(float scaleX, float scaleY, float rotation)
        {
            createBox(scaleX, scaleY, rotation, 0, 0);
        }
        public void createBox(float scaleX, float scaleY)
        {
            createBox(scaleX, scaleY, 0, 0, 0);
        }
        public void createGradientBox(float width, float height, float rotation, float tx, float ty)
        {
            throw new AsNotImplementedError();
        }
        public void createGradientBox(float width, float height, float rotation, float tx)
        {
            createGradientBox(width, height, rotation, tx, 0);
        }
        public void createGradientBox(float width, float height, float rotation)
        {
            createGradientBox(width, height, rotation, 0, 0);
        }
        public void createGradientBox(float width, float height)
        {
            createGradientBox(width, height, 0, 0, 0);
        }
        public AsPoint deltaTransformPoint(AsPoint point)
        {
            float nx = point.x * a + point.y * b;
            float ny = point.x * c + point.y * d;
            return new AsPoint(nx, ny);
        }
        public void identity()
        {
            setTo(1, 0, 0, 1, 0, 0);
        }
        public void invert()
        {
            throw new AsNotImplementedError();
        }
        public void rotate(float angle)
        {
            float cosA = AsMath.cos(angle);
            float sinA = AsMath.sin(angle);
            concatValues(cosA, sinA, -sinA, cosA, 0, 0);
        }
        public void scale(float sx, float sy)
        {
            concatValues(sx, 0, 0, sy, 0, 0);
        }
        public void setTo(float a, float b, float c, float d, float tx, float ty)
        {
            internalMatrix.M11 = a;
            internalMatrix.M12 = c;
            internalMatrix.M13 = 0;
            internalMatrix.M14 = 0;

            internalMatrix.M21 = b;
            internalMatrix.M22 = d;
            internalMatrix.M23 = 0;
            internalMatrix.M24 = 0;

            internalMatrix.M31 = 0;
            internalMatrix.M32 = 0;
            internalMatrix.M33 = 1;
            internalMatrix.M34 = 0;

            internalMatrix.M41 = tx;
            internalMatrix.M42 = ty;
            internalMatrix.M43 = 0;
            internalMatrix.M44 = 1;
        }
        public AsPoint transformPoint(AsPoint point)
        {
            float nx = point.x * a + point.y * b + tx;
            float ny = point.x * c + point.y * d + ty;
            return new AsPoint(nx, ny);
        }
        public void translate(float dx, float dy)
        {
            concatValues(1, 0, 0, 1, dx, dy);
        }

        public float a
        {
            get { return internalMatrix.M11; }
            set { internalMatrix.M11 = value; }
        }

        public float b
        {
            get { return internalMatrix.M21; }
            set { internalMatrix.M21 = value; }
        }

        public float c
        {
            get { return internalMatrix.M12; }
            set { internalMatrix.M12 = value; }
        }

        public float d
        {
            get { return internalMatrix.M22; }
            set { internalMatrix.M22 = value; }
        }

        public float tx
        {
            get { return internalMatrix.M41; }
            set { internalMatrix.M41 = value; }
        }

        public float ty
        {
            get { return internalMatrix.M42; }
            set { internalMatrix.M42 = value; }
        }
    }
}
