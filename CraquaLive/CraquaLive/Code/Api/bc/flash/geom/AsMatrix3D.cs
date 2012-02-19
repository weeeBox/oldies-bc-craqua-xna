using System;
 
using bc.flash;
using bc.flash.error;
using bc.flash.geom;
 
namespace bc.flash.geom
{
	public class AsMatrix3D : AsObject
	{
		public float n11;
		public float n12;
		public float n13;
		public float n14;
		public float n21;
		public float n22;
		public float n23;
		public float n24;
		public float n31;
		public float n32;
		public float n33;
		public float n34;
		public float n41;
		public float n42;
		public float n43;
		public float n44;
		public AsMatrix3D(AsVector<float> v)
		{
		}
		public AsMatrix3D()
		 : this(null)
		{
		}
		private void setData(float n11, float n12, float n13, float n14, float n21, float n22, float n23, float n24, float n31, float n32, float n33, float n34, float n41, float n42, float n43, float n44)
		{
			this.n11 = n11;
			this.n12 = n12;
			this.n13 = n13;
			this.n14 = n14;
			this.n21 = n21;
			this.n22 = n22;
			this.n23 = n23;
			this.n24 = n24;
			this.n31 = n31;
			this.n32 = n32;
			this.n33 = n33;
			this.n34 = n34;
			this.n41 = n41;
			this.n42 = n42;
			this.n43 = n43;
			this.n44 = n44;
		}
		public virtual AsMatrix3D append(AsMatrix3D m)
		{
			float o11 = n11;
			float o12 = n12;
			float o13 = n13;
			float o14 = n14;
			float o21 = n21;
			float o22 = n22;
			float o23 = n23;
			float o24 = n24;
			float o31 = n31;
			float o32 = n32;
			float o33 = n33;
			float o34 = n34;
			float o41 = n41;
			float o42 = n42;
			float o43 = n43;
			float o44 = n44;
			n11 = ((((m.n11 * o11) + (m.n12 * o21)) + (m.n13 * o31)) + (m.n14 * o41));
			n12 = ((((m.n11 * o12) + (m.n12 * o22)) + (m.n13 * o32)) + (m.n14 * o42));
			n13 = ((((m.n11 * o13) + (m.n12 * o23)) + (m.n13 * o33)) + (m.n14 * o43));
			n14 = ((((m.n11 * o14) + (m.n12 * o24)) + (m.n13 * o34)) + (m.n14 * o44));
			n21 = ((((m.n21 * o11) + (m.n22 * o21)) + (m.n23 * o31)) + (m.n24 * o41));
			n22 = ((((m.n21 * o12) + (m.n22 * o22)) + (m.n23 * o32)) + (m.n24 * o42));
			n23 = ((((m.n21 * o13) + (m.n22 * o23)) + (m.n23 * o33)) + (m.n24 * o43));
			n24 = ((((m.n21 * o14) + (m.n22 * o24)) + (m.n23 * o34)) + (m.n24 * o44));
			n31 = ((((m.n31 * o11) + (m.n32 * o21)) + (m.n33 * o31)) + (m.n34 * o41));
			n32 = ((((m.n31 * o12) + (m.n32 * o22)) + (m.n33 * o32)) + (m.n34 * o42));
			n33 = ((((m.n31 * o13) + (m.n32 * o23)) + (m.n33 * o33)) + (m.n34 * o43));
			n34 = ((((m.n31 * o14) + (m.n32 * o24)) + (m.n33 * o34)) + (m.n34 * o44));
			n41 = ((((m.n41 * o11) + (m.n42 * o21)) + (m.n43 * o31)) + (m.n44 * o41));
			n42 = ((((m.n41 * o12) + (m.n42 * o22)) + (m.n43 * o32)) + (m.n44 * o42));
			n43 = ((((m.n41 * o13) + (m.n42 * o23)) + (m.n43 * o33)) + (m.n44 * o43));
			n44 = ((((m.n41 * o14) + (m.n42 * o24)) + (m.n43 * o34)) + (m.n44 * o44));
			return this;
		}
		public virtual void appendRotation(float degrees, AsVector3D axis, AsVector3D pivotPoint)
		{
			throw new AsNotImplementedError();
		}
		public virtual void appendRotation(float degrees, AsVector3D axis)
		{
			appendRotation(degrees, axis, null);
		}
		public virtual void appendScale(float xScale, float yScale, float zScale)
		{
			throw new AsNotImplementedError();
		}
		public virtual void appendTranslation(float x, float y, float z)
		{
			throw new AsNotImplementedError();
		}
		public virtual AsMatrix3D clone()
		{
			throw new AsNotImplementedError();
		}
		public virtual void copyColumnFrom(uint column, AsVector3D vector3D)
		{
			throw new AsNotImplementedError();
		}
		public virtual void copyColumnTo(uint column, AsVector3D vector3D)
		{
			throw new AsNotImplementedError();
		}
		public virtual void copyFrom(AsMatrix3D sourceMatrix3D)
		{
			throw new AsNotImplementedError();
		}
		public virtual void copyRawDataFrom(AsVector<float> vector, uint index, bool transpose)
		{
			throw new AsNotImplementedError();
		}
		public virtual void copyRawDataFrom(AsVector<float> vector, uint index)
		{
			copyRawDataFrom(vector, (uint)(0), false);
		}
		public virtual void copyRawDataFrom(AsVector<float> vector)
		{
			copyRawDataFrom(vector, (uint)(0));
		}
		public virtual void copyRawDataTo(AsVector<float> vector, uint index, bool transpose)
		{
			throw new AsNotImplementedError();
		}
		public virtual void copyRawDataTo(AsVector<float> vector, uint index)
		{
			copyRawDataTo(vector, (uint)(0), false);
		}
		public virtual void copyRawDataTo(AsVector<float> vector)
		{
			copyRawDataTo(vector, (uint)(0));
		}
		public virtual void copyRowFrom(uint row, AsVector3D vector3D)
		{
			throw new AsNotImplementedError();
		}
		public virtual void copyRowTo(uint row, AsVector3D vector3D)
		{
			throw new AsNotImplementedError();
		}
		public virtual void copyToMatrix3D(AsMatrix3D dest)
		{
			throw new AsNotImplementedError();
		}
		public virtual AsVector<AsVector3D> decompose(String orientationStyle)
		{
			throw new AsNotImplementedError();
		}
		public virtual AsVector<AsVector3D> decompose()
		{
			return decompose("eulerAngles");
		}
		public virtual AsVector3D deltaTransformVector(AsVector3D v)
		{
			throw new AsNotImplementedError();
		}
		public virtual float getDeterminant()
		{
			throw new AsNotImplementedError();
		}
		public virtual void identity()
		{
			throw new AsNotImplementedError();
		}
		public static AsMatrix3D interpolate(AsMatrix3D thisMat, AsMatrix3D toMat, float percent)
		{
			throw new AsNotImplementedError();
		}
		public virtual void interpolateTo(AsMatrix3D toMat, float percent)
		{
			throw new AsNotImplementedError();
		}
		public virtual bool invert()
		{
			throw new AsNotImplementedError();
		}
		public virtual void pointAt(AsVector3D pos, AsVector3D at, AsVector3D up)
		{
			throw new AsNotImplementedError();
		}
		public virtual void pointAt(AsVector3D pos, AsVector3D at)
		{
			pointAt(pos, null, null);
		}
		public virtual void pointAt(AsVector3D pos)
		{
			pointAt(pos, null);
		}
		public virtual AsVector3D getPosition()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setPosition(AsVector3D pos)
		{
			throw new AsNotImplementedError();
		}
		public virtual void prepend(AsMatrix3D rhs)
		{
			throw new AsNotImplementedError();
		}
		public virtual void prependRotation(float degrees, AsVector3D axis, AsVector3D pivotPoint)
		{
			throw new AsNotImplementedError();
		}
		public virtual void prependRotation(float degrees, AsVector3D axis)
		{
			prependRotation(degrees, axis, null);
		}
		public virtual void prependScale(float xScale, float yScale, float zScale)
		{
			throw new AsNotImplementedError();
		}
		public virtual void prependTranslation(float x, float y, float z)
		{
			throw new AsNotImplementedError();
		}
		public virtual AsVector<float> getRawData()
		{
			throw new AsNotImplementedError();
		}
		public virtual void setRawData(AsVector<float> v)
		{
			throw new AsNotImplementedError();
		}
		public virtual bool recompose(AsVector<AsVector3D> components, String orientationStyle)
		{
			throw new AsNotImplementedError();
		}
		public virtual bool recompose(AsVector<AsVector3D> components)
		{
			return recompose(components, "eulerAngles");
		}
		public virtual AsVector3D transformVector(AsVector3D v)
		{
			throw new AsNotImplementedError();
		}
		public virtual void transformVectors(AsVector<float> vin, AsVector<float> vout)
		{
			throw new AsNotImplementedError();
		}
		public virtual void transpose()
		{
			throw new AsNotImplementedError();
		}
	}
}
