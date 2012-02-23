using System;
 
using bc.flash;
using bc.flash.display;
using bc.flash.geom;
 
namespace bc.flash.core
{
	public class AsRenderSupport : AsObject
	{
		private AsMatrix3D mProjectionMatrix;
		private AsMatrix3D mModelViewMatrix;
		private AsMatrix3D mMvpMatrix;
		private AsVector<AsMatrix3D> mMatrixStack;
		private int mMatrixStackSize;
		private static AsVector<float> sMatrixCoords = new AsVector<float>(16, true);
		public AsRenderSupport()
		{
			mProjectionMatrix = new AsMatrix3D();
			mModelViewMatrix = new AsMatrix3D();
			mMvpMatrix = new AsMatrix3D();
			mMatrixStack = new AsVector<AsMatrix3D>();
			mMatrixStackSize = 0;
			loadIdentity();
		}
		public virtual void dispose()
		{
		}
		public virtual void setOrthographicProjection(float width, float height, float near, float far)
		{
			sMatrixCoords[0] = (2.0f / width);
			sMatrixCoords[1] = sMatrixCoords[2] = sMatrixCoords[3] = sMatrixCoords[4] = 0.0f;
			sMatrixCoords[5] = (-2.0f / height);
			sMatrixCoords[6] = sMatrixCoords[7] = sMatrixCoords[8] = sMatrixCoords[9] = 0.0f;
			sMatrixCoords[10] = (-2.0f / (far - near));
			sMatrixCoords[11] = 0.0f;
			sMatrixCoords[12] = -1.0f;
			sMatrixCoords[13] = 1.0f;
			sMatrixCoords[14] = (-(far + near) / (far - near));
			sMatrixCoords[15] = 1.0f;
			mProjectionMatrix.copyRawDataFrom(sMatrixCoords);
		}
		public virtual void setOrthographicProjection(float width, float height, float near)
		{
			setOrthographicProjection(width, height, near, 1.0f);
		}
		public virtual void setOrthographicProjection(float width, float height)
		{
			setOrthographicProjection(width, height, -1.0f, 1.0f);
		}
		public virtual void loadIdentity()
		{
			mModelViewMatrix.identity();
		}
		public virtual void translateMatrix(float dx, float dy, float dz)
		{
			mModelViewMatrix.prependTranslation(dx, dy, dz);
		}
		public virtual void translateMatrix(float dx, float dy)
		{
			translateMatrix(dx, dy, 0);
		}
		public virtual void rotateMatrix(float angle, AsVector3D axis)
		{
			mModelViewMatrix.prependRotation(((angle / AsMath.PI) * 180.0f), (((axis == null)) ? (AsVector3D.Z_AXIS) : (axis)));
		}
		public virtual void rotateMatrix(float angle)
		{
			rotateMatrix(angle, null);
		}
		public virtual void scaleMatrix(float sx, float sy, float sz)
		{
			mModelViewMatrix.prependScale(sx, sy, sz);
		}
		public virtual void scaleMatrix(float sx, float sy)
		{
			scaleMatrix(sx, sy, 1.0f);
		}
		public virtual void transformMatrix(AsDisplayObject _object)
		{
			transformMatrixForObject(mModelViewMatrix, _object);
		}
		public virtual void pushMatrix()
		{
			if((mMatrixStack.getLength() < (mMatrixStackSize + 1)))
			{
				mMatrixStack.push(new AsMatrix3D());
			}
			mMatrixStack[mMatrixStackSize++].copyFrom(mModelViewMatrix);
		}
		public virtual void popMatrix()
		{
			mModelViewMatrix.copyFrom(mMatrixStack[--mMatrixStackSize]);
		}
		public virtual void resetMatrix()
		{
			mMatrixStackSize = 0;
			loadIdentity();
		}
		public virtual AsMatrix3D getMvpMatrix()
		{
			mMvpMatrix.identity();
			mMvpMatrix.append(mModelViewMatrix);
			mMvpMatrix.append(mProjectionMatrix);
			return mMvpMatrix;
		}
		public static void transformMatrixForObject(AsMatrix3D matrix, AsDisplayObject _object)
		{
			float x = _object.getX();
			float y = _object.getY();
			float rotation = _object.getRotation();
			float scaleX = _object.getScaleX();
			float scaleY = _object.getScaleY();
			float pivotX = _object.getPivotX();
			float pivotY = _object.getPivotY();
			if(((x != 0) || (y != 0)))
			{
				matrix.prependTranslation(x, y, 0.0f);
			}
			if((rotation != 0))
			{
				matrix.prependRotation(((rotation / AsMath.PI) * 180.0f), AsVector3D.Z_AXIS);
			}
			if(((scaleX != 1) || (scaleY != 1)))
			{
				matrix.prependScale(scaleX, scaleY, 1.0f);
			}
			if(((pivotX != 0) || (pivotY != 0)))
			{
				matrix.prependTranslation(-pivotX, -pivotY, 0.0f);
			}
		}
		public virtual void nextFrame()
		{
		}
		public static void setDefaultBlendFactors(bool premultipliedAlpha)
		{
		}
		public static void clear(uint rgb, float alpha)
		{
		}
		public static void clear(uint rgb)
		{
			clear(rgb, 0.0f);
		}
		public static void clear()
		{
			clear((uint)(0), 0.0f);
		}
	}
}
