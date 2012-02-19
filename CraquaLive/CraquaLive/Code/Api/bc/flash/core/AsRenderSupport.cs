using System;
 
using bc.flash;
using bc.flash.core;
using bc.flash.display;
using bc.flash.events;
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
		private int mCurrentQuadBatchID;
		private static AsVector<float> sMatrixCoords = new AsVector<float>(16, true);
		public AsRenderSupport()
		{
			mProjectionMatrix = new AsMatrix3D();
			mModelViewMatrix = new AsMatrix3D();
			mMvpMatrix = new AsMatrix3D();
			mMatrixStack = new AsVector<AsMatrix3D>();
			mMatrixStackSize = 0;
			mCurrentQuadBatchID = 0;
			loadIdentity();
			setOrthographicProjection(400, 300);
			AsStarling.getCurrent().addEventListener(AsEvent.CONTEXT3D_CREATE, onContextCreated);
		}
		public virtual void dispose()
		{
			AsStarling.getCurrent().removeEventListener(AsEvent.CONTEXT3D_CREATE, onContextCreated);
		}
		private void onContextCreated(AsEvent _event)
		{
		}
		public virtual void setOrthographicProjection(float width, float height, float near, float far)
		{
		}
		public virtual void setOrthographicProjection(float width, float height, float near)
		{
			setOrthographicProjection(width, height, -1.0f, 1.0f);
		}
		public virtual void setOrthographicProjection(float width, float height)
		{
			setOrthographicProjection(width, height, -1.0f);
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
			resetMatrix();
			mCurrentQuadBatchID = 0;
		}
	}
}
