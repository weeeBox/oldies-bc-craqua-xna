using System;

using bc.flash;
using bc.flash.error;
using bc.flash.geom;
using Microsoft.Xna.Framework;

namespace bc.flash.geom
{
    public sealed class AsMatrix3D : AsObject
    {
        public Matrix innerMatrix;

        public AsMatrix3D(AsVector<float> v)
        {
            innerMatrix.M11 = v[0];
            innerMatrix.M12 = v[1];
            innerMatrix.M13 = v[2];
            innerMatrix.M14 = 0;

            innerMatrix.M21 = v[4];
            innerMatrix.M22 = v[5];
            innerMatrix.M23 = v[6];
            innerMatrix.M24 = 0;

            innerMatrix.M31 = v[8];
            innerMatrix.M32 = v[9];
            innerMatrix.M33 = v[10];
            innerMatrix.M34 = 0;

            innerMatrix.M41 = v[12];
            innerMatrix.M42 = v[13];
            innerMatrix.M43 = v[14];
            innerMatrix.M44 = 1;
        }

        public AsMatrix3D()
        {
            innerMatrix = Matrix.Identity;
        }

        private AsMatrix3D(ref Matrix matrix)
        {
            innerMatrix = matrix;
        }

        public void append(AsMatrix3D lhs)
        {
            append(ref lhs.innerMatrix);
        }

        private void append(ref Matrix matrix)
        {
            Matrix.Multiply(ref innerMatrix, ref matrix, out innerMatrix);
        }

        public void appendRotation(float degrees, AsVector3D axis, AsVector3D pivotPoint)
        {
            bool hasPivot = pivotPoint != null && (pivotPoint.x != 0.0f || pivotPoint.y != 0.0f || pivotPoint.z != 0.0f);
            if (hasPivot)
            {
                appendTranslation(-pivotPoint.x, -pivotPoint.y, -pivotPoint.z);
            }

            float ax = axis.x;
            float ay = axis.y;
            float az = axis.z;

            float radians = MathHelper.ToRadians(degrees);

            if (ax == 0.0f && ay == 0.0f && az == 1.0f)
            {
                appendRotationZ(radians);
            }
            else if (ax == 0.0f && ay == 1.0f && az == 0.0f)
            {
                appendRotationY(radians);
            }
            else if (ax == 1.0f && ay == 0.0f && az == 0.0f)
            {
                appendRotationX(radians);
            }
            else
            {
                throw new AsNotImplementedError();
            }

            if (hasPivot)
            {
                appendTranslation(pivotPoint.x, pivotPoint.y, pivotPoint.z);
            }
        }

        public void appendRotation(float degrees, AsVector3D axis)
        {
            appendRotation(degrees, axis, null);
        }

        private void appendRotationX(float radians)
        {
            Matrix rotationMatrix = Matrix.CreateRotationX(radians);
            append(ref rotationMatrix);
        }

        private void appendRotationY(float radians)
        {
            Matrix rotationMatrix = Matrix.CreateRotationY(radians);
            append(ref rotationMatrix);
        }

        private void appendRotationZ(float radians)
        {
            Matrix rotationMatrix = Matrix.CreateRotationZ(radians);
            append(ref rotationMatrix);
        }

        public void appendScale(float xScale, float yScale, float zScale)
        {
            Matrix scaleMatrix = Matrix.CreateScale(xScale, yScale, zScale);
            append(ref scaleMatrix);
        }

        public void appendTranslation(float x, float y, float z)
        {
            Matrix translationMatrix = Matrix.CreateTranslation(x, y, z);
            append(ref translationMatrix);
        }

        public AsMatrix3D clone()
        {
            return new AsMatrix3D(ref innerMatrix);
        }

        public void copyColumnFrom(uint column, AsVector3D vector3D)
        {
            throw new NotImplementedException();
        }

        public void copyColumnTo(uint column, AsVector3D vector3D)
        {
            throw new NotImplementedException();
        }

        public void copyFrom(AsMatrix3D sourceMatrix3D)
        {
            innerMatrix = sourceMatrix3D.innerMatrix;
        }

        public void copyRawDataFrom(AsVector<float> vector, uint index, bool transpose)
        {
            throw new NotImplementedException();
        }

        public void copyRawDataFrom(AsVector<float> vector, uint index)
        {
            copyRawDataFrom(vector, index, false);
        }

        public void copyRawDataFrom(AsVector<float> vector)
        {
            copyRawDataFrom(vector, (uint)(0), false);
        }

        public void copyRawDataTo(AsVector<float> vector, uint index, bool transpose)
        {
            throw new NotImplementedException();
        }

        public void copyRawDataTo(AsVector<float> vector, uint index)
        {
            copyRawDataTo(vector, index, false);
        }

        public void copyRawDataTo(AsVector<float> vector)
        {
            copyRawDataTo(vector, (uint)(0), false);
        }

        public void copyRowFrom(uint row, AsVector3D vector3D)
        {
            throw new NotImplementedException();
        }

        public void copyRowTo(uint row, AsVector3D vector3D)
        {
            throw new NotImplementedException();
        }

        public void copyToMatrix3D(AsMatrix3D dest)
        {
            dest.innerMatrix = innerMatrix;
        }

        public AsVector<AsVector3D> decompose(String orientationStyle)
        {
            throw new AsNotImplementedError();
        }

        public AsVector<AsVector3D> decompose()
        {
            return decompose("eulerAngles");
        }

        public AsVector3D deltaTransformVector(AsVector3D v)
        {
            float x = v.x;
            float y = v.y;
            float z = v.z;
            return new AsVector3D((((m11 * x) + (m12 * y)) + (m13 * z)), (((m21 * x) + (m22 * y)) + (m23 * z)), (((m31 * x) + (m32 * y)) + (m33 * z)));
        }

        public void identity()
        {
            innerMatrix = Matrix.Identity;
        }

        public static AsMatrix3D interpolate(AsMatrix3D thisMat, AsMatrix3D toMat, float percent)
        {
            throw new AsNotImplementedError();
        }

        public void interpolateTo(AsMatrix3D toMat, float percent)
        {
            throw new AsNotImplementedError();
        }

        public bool invert()
        {
            throw new AsNotImplementedError();
        }

        public void pointAt(AsVector3D pos, AsVector3D at, AsVector3D up)
        {
            throw new AsNotImplementedError();
        }

        public void pointAt(AsVector3D pos, AsVector3D at)
        {
            pointAt(pos, at, null);
        }

        public void pointAt(AsVector3D pos)
        {
            pointAt(pos, null, null);
        }

        public void prepend(AsMatrix3D rhs)
        {
            prepend(ref rhs.innerMatrix);
        }

        private void prepend(ref Matrix matrix)
        {
            Matrix.Multiply(ref matrix, ref innerMatrix, out innerMatrix);
        }

        public void prependRotation(float degrees, AsVector3D axis, AsVector3D pivotPoint)
        {
            bool hasPivot = pivotPoint != null && (pivotPoint.x != 0.0f || pivotPoint.y != 0.0f || pivotPoint.z != 0.0f);
            if (hasPivot)
            {
                prependTranslation(-pivotPoint.x, -pivotPoint.y, -pivotPoint.z);
            }

            float ax = axis.x;
            float ay = axis.y;
            float az = axis.z;

            float radians = MathHelper.ToRadians(degrees);

            if (ax == 0.0f && ay == 0.0f && az == 1.0f)
            {
                prependRotationZ(radians);
            }
            else if (ax == 0.0f && ay == 1.0f && az == 0.0f)
            {
                prependRotationY(radians);
            }
            else if (ax == 1.0f && ay == 0.0f && az == 0.0f)
            {
                prependRotationX(radians);
            }
            else
            {
                throw new AsNotImplementedError();
            }

            if (hasPivot)
            {
                prependTranslation(pivotPoint.x, pivotPoint.y, pivotPoint.z);
            }
        }

        public void prependRotation(float degrees, AsVector3D axis)
        {
            prependRotation(degrees, axis, null);
        }

        private void prependRotationX(float radians)
        {
            Matrix rotationMatrix = Matrix.CreateRotationX(radians);
            prepend(ref rotationMatrix);
        }

        private void prependRotationY(float radians)
        {
            Matrix rotationMatrix = Matrix.CreateRotationY(radians);
            prepend(ref rotationMatrix);
        }

        private void prependRotationZ(float radians)
        {
            Matrix rotationMatrix = Matrix.CreateRotationZ(radians);
            prepend(ref rotationMatrix);
        }

        public void prependScale(float xScale, float yScale, float zScale)
        {
            Matrix scaleMatrix = Matrix.CreateScale(xScale, yScale, zScale);
            prepend(ref scaleMatrix);
        }

        public void prependTranslation(float x, float y, float z)
        {
            Matrix translationMatrix = Matrix.CreateTranslation(x, y, z);
            prepend(ref translationMatrix);
        }

        public bool recompose(AsVector<AsVector3D> components, String orientationStyle)
        {
            throw new AsNotImplementedError();
        }

        public bool recompose(AsVector<AsVector3D> components)
        {
            return recompose(components, "eulerAngles");
        }

        public AsVector3D transformVector(AsVector3D v)
        {
            float x = v.x;
            float y = v.y;
            float z = v.z;
            return new AsVector3D(((((m11 * x) + (m12 * y)) + (m13 * z)) + t.x), ((((m21 * x) + (m22 * y)) + (m23 * z)) + t.y), ((((m31 * x) + (m32 * y)) + (m33 * z)) + t.z));
        }
        public void transformVectors(AsVector<float> vin, AsVector<float> vout)
        {
            int len = (int)(vin.getLength());
            if (((len % 3) != 0))
            {
                throw new AsArgumentError();
            }
            if ((len > vout.getLength()))
            {
                throw new AsArgumentError();
            }
            int i = 0;
            for (; (i < len); i = (i + 3))
            {
                float x = vin[i];
                float y = vin[(i + 1)];
                float z = vin[(i + 2)];
                vout[i] = ((((m11 * x) + (m12 * y)) + (m13 * z)) + t.x);
                vout[(i + 1)] = ((((m21 * x) + (m22 * y)) + (m23 * z)) + t.y);
                vout[(i + 2)] = ((((m31 * x) + (m32 * y)) + (m33 * z)) + t.z);
            }
        }
        public void transpose()
        {
            throw new AsNotImplementedError();
        }
        public float getDeterminant()
        {
            throw new AsNotImplementedError();
        }
        public AsVector3D getPosition()
        {
            return t;
        }
        public AsVector<float> getRawData()
        {
            return new AsVector<float>(m11, m21, m31, 0, m12, m22, m32, 0, m13, m23, m33, 0, t.x, t.y, t.z, 1);
        }
    }
}
