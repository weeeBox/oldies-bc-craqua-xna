using System;

using bc.flash;
using bc.flash.error;
using bc.flash.geom;
using bc.flash.utils;
using Microsoft.Xna.Framework;

namespace bc.flash.geom
{
    public sealed class AsVector3D : AsObject
    {
        public static AsVector3D X_AXIS = new AsVector3D(1, 0, 0);
        public static AsVector3D Y_AXIS = new AsVector3D(0, 1, 0);
        public static AsVector3D Z_AXIS = new AsVector3D(0, 0, 1);

        public Vector3 internalVector;

        public float w;
        public AsVector3D(float x, float y, float z, float w)
        {
            internalVector = new Vector3(x, y, z);
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
        public AsVector3D _add(AsVector3D a)
        {
            return new AsVector3D((x + a.x), (y + a.y), (z + a.z));
        }
        public static float angleBetween(AsVector3D a, AsVector3D b)
        {
            float aLen = a.getLength();
            if (epsilonEquals(aLen, 0))
            {
                throw new AsArgumentError();
            }
            float bLen = b.getLength();
            if (epsilonEquals(bLen, 0))
            {
                throw new AsArgumentError();
            }
            float dotProd = (((a.x * b.x) + (a.y * b.y)) + (a.z * b.z));
            if (epsilonEquals(dotProd, 0))
            {
                return (0.5f * AsMath.PI);
            }
            return AsMath.acos(((dotProd / aLen) / bLen));
        }
        public AsVector3D clone()
        {
            return new AsVector3D(x, y, z, w);
        }
        public void copyFrom(AsVector3D sourceVector3D)
        {
            x = sourceVector3D.x;
            y = sourceVector3D.y;
            z = sourceVector3D.z;
            w = sourceVector3D.w;
        }
        public AsVector3D crossProduct(AsVector3D a)
        {
            return new AsVector3D(((y * a.z) - (z * a.y)), ((z * a.x) - (x * a.z)), ((x * a.y) - (y * a.x)), 1);
        }
        public void decrementBy(AsVector3D a)
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
        public float dotProduct(AsVector3D a)
        {
            return (((x * a.x) + (y * a.y)) + (z * a.z));
        }
        public bool equals(AsVector3D toCompare, bool allFour)
        {
            return ((((x == toCompare.x) && (y == toCompare.y)) && (z == toCompare.z)) && (!(allFour) || (w == toCompare.w)));
        }
        public bool equals(AsVector3D toCompare)
        {
            return equals(toCompare, false);
        }
        public void incrementBy(AsVector3D a)
        {
            x = (x + a.x);
            y = (y + a.y);
            z = (z + a.z);
        }
        public float getLength()
        {
            return AsMath.sqrt((((x * x) + (y * y)) + (z * z)));
        }
        public float getLengthSquared()
        {
            return (((x * x) + (y * y)) + (z * z));
        }
        public bool nearEquals(AsVector3D toCompare, float tolerance, bool allFour)
        {
            return ((((AsMath.abs((x - toCompare.x)) <= tolerance) && (AsMath.abs((y - toCompare.y)) <= tolerance)) && (AsMath.abs((z - toCompare.z)) <= tolerance)) && (!(allFour) || (AsMath.abs((w - toCompare.w)) <= tolerance)));
        }
        public bool nearEquals(AsVector3D toCompare, float tolerance)
        {
            return nearEquals(toCompare, tolerance, false);
        }
        public void negate()
        {
            x = -x;
            y = -y;
            z = -z;
        }
        public float normalize()
        {
            float len = getLength();
            if (epsilonEquals(len, 0.0f))
            {
                throw new AsIllegalOperationError("Unable to normalize vector with zero length");
            }
            float lenInv = (1.0f / getLength());
            x = (x * lenInv);
            y = (y * lenInv);
            z = (z * lenInv);
            return getLength();
        }
        public void project()
        {
            if (((w != 0) && (w != 1)))
            {
                float invW = (1.0f / w);
                x = (x * invW);
                y = (y * invW);
                z = (z * invW);
            }
        }
        public void scaleBy(float s)
        {
            x = (x * s);
            y = (y * s);
            z = (z * s);
        }
        public void setTo(float xa, float ya, float za)
        {
            x = xa;
            y = ya;
            z = za;
        }
        public AsVector3D subtract(AsVector3D a)
        {
            return new AsVector3D((x - a.x), (y - a.y), (z - a.z));
        }
        public override String toString()
        {
            return (((((("[" + x) + ", ") + y) + ", ") + z) + "]");
        }
        private static bool epsilonEquals(float a, float b)
        {
            return AsMathHelper.epsilonEquals(a, b);
        }

        public float x
        {
            get { return internalVector.X; }
            set { internalVector.X = value; }
        }

        public float y
        {
            get { return internalVector.Y; }
            set { internalVector.Y = value; }
        }

        public float z
        {
            get { return internalVector.Z; }
            set { internalVector.Z = value; }
        }
    }
}
