using System;
 
using bc.flash;
using bc.flash.core;
using bc.flash.core.natives;
using bc.flash.display;
using bc.flash.error;
using bc.flash.events;
using bc.flash.geom;
using bc.flash.ui;
 
namespace bc.flash.core
{
	public class AsStarling : AsEventDispatcher
	{
		public static String VERSION = "0.9.1";
		private AsStage mStage;
		private AsDisplayObject mRootObject;
		private bool mStarted;
		private AsRenderSupport mSupport;
		private AsTouchProcessor mTouchProcessor;
		private int mAntiAliasing;
		private bool mSimulateMultitouch;
		private bool mEnableErrorChecking;
		private float mLastFrameTimestamp;
		private AsRectangle mViewPort;
		private bool mLeftMouseDown;
		private AsBcNativeStage mNativeStage;
		private static AsStarling sCurrent;
		private static bool sHandleLostContext;
		public AsStarling(AsBcNativeStage stage, AsDisplayObject rootObject)
		{
			if((stage == null))
			{
				throw new AsArgumentError("Native stage must not be null");
			}
			makeCurrent();
			mRootObject = rootObject;
			mStage = new AsStage(stage.getWidth(), stage.getHeight());
			mTouchProcessor = new AsTouchProcessor(mStage);
			mAntiAliasing = 0;
			mSimulateMultitouch = false;
			mEnableErrorChecking = false;
			mLastFrameTimestamp = (AsGlobal.getTimer() / 1000.0f);
			mSupport = new AsRenderSupport();
			foreach (String touchEventType in getTouchEventTypes())
			{
				stage.addEventListener(touchEventType, onTouch);
			}
			stage.addEventListener(AsEvent.ENTER_FRAME, onEnterFrame);
			stage.addEventListener(AsKeyboardEvent.KEY_DOWN, onKey);
			stage.addEventListener(AsKeyboardEvent.KEY_UP, onKey);
		}
		public virtual void dispose()
		{
			mNativeStage.removeEventListener(AsEvent.ENTER_FRAME, onEnterFrame);
			mNativeStage.removeEventListener(AsKeyboardEvent.KEY_DOWN, onKey);
			mNativeStage.removeEventListener(AsKeyboardEvent.KEY_UP, onKey);
			foreach (String touchEventType in getTouchEventTypes())
			{
				mNativeStage.removeEventListener(touchEventType, onTouch);
			}
			if((mTouchProcessor) != null)
			{
				mTouchProcessor.dispose();
			}
			if((sCurrent == this))
			{
				sCurrent = null;
			}
		}
		private void render()
		{
			float now = (AsGlobal.getTimer() / 1000.0f);
			float passedTime = (now - mLastFrameTimestamp);
			mLastFrameTimestamp = now;
			mStage.advanceTime(passedTime);
			mTouchProcessor.advanceTime(passedTime);
			mStage.render(mSupport, 1.0f);
		}
		public virtual void makeCurrent()
		{
			sCurrent = this;
		}
		public virtual void start()
		{
			mStarted = true;
		}
		public virtual void stop()
		{
			mStarted = false;
		}
		private void onEnterFrame(AsEvent _event)
		{
			makeCurrent();
			if(mStarted)
			{
				render();
			}
		}
		private void onKey(AsEvent evt)
		{
			AsKeyboardEvent _event = ((AsKeyboardEvent)(evt));
			makeCurrent();
			mStage.dispatchEvent(_event);
		}
		private void onTouch(AsEvent _event)
		{
			float globalX = 0;
			float globalY = 0;
			int touchID = 0;
			String phase = null;
			if(_event is AsMouseEvent)
			{
				AsMouseEvent mouseEvent = ((AsMouseEvent)(_event));
				globalX = mouseEvent.getStageX();
				globalY = mouseEvent.getStageY();
				touchID = 0;
				if((_event.getType() == AsMouseEvent.MOUSE_DOWN))
				{
					mLeftMouseDown = true;
				}
				else
				{
					if((_event.getType() == AsMouseEvent.MOUSE_UP))
					{
						mLeftMouseDown = false;
					}
				}
			}
			if((_event.getType() == AsTouchEvent.TOUCH_BEGIN))
			{
				phase = AsTouchPhase.BEGAN;
			}
			else
			{
				if((_event.getType() == AsTouchEvent.TOUCH_MOVE))
				{
					phase = AsTouchPhase.MOVED;
				}
				else
				{
					if((_event.getType() == AsTouchEvent.TOUCH_END))
					{
						phase = AsTouchPhase.ENDED;
					}
					else
					{
						if((_event.getType() == AsMouseEvent.MOUSE_DOWN))
						{
							phase = AsTouchPhase.BEGAN;
						}
						else
						{
							if((_event.getType() == AsMouseEvent.MOUSE_UP))
							{
								phase = AsTouchPhase.ENDED;
							}
							else
							{
								if((_event.getType() == AsMouseEvent.MOUSE_MOVE))
								{
									phase = ((mLeftMouseDown) ? (AsTouchPhase.MOVED) : (AsTouchPhase.HOVER));
								}
							}
						}
					}
				}
			}
			globalX = ((mStage.getStageWidth() * (globalX - mViewPort.x)) / mViewPort.width);
			globalY = ((mStage.getStageHeight() * (globalY - mViewPort.y)) / mViewPort.height);
			mTouchProcessor.enqueue(touchID, phase, globalX, globalY);
		}
		private AsArray getTouchEventTypes()
		{
			return new AsArray(AsTouchEvent.TOUCH_BEGIN, AsTouchEvent.TOUCH_MOVE, AsTouchEvent.TOUCH_END);
		}
		public virtual bool getIsStarted()
		{
			return mStarted;
		}
		public virtual AsStage getStage()
		{
			return mStage;
		}
		public virtual AsBcNativeStage getNativeStage()
		{
			return mNativeStage;
		}
		public static AsStarling getCurrent()
		{
			return sCurrent;
		}
		public static bool getMultitouchEnabled()
		{
			return (AsMultitouch.getInputMode() == AsMultitouchInputMode.TOUCH_POINT);
		}
		public static void setMultitouchEnabled(bool _value)
		{
			AsMultitouch.setInputMode(((_value) ? (AsMultitouchInputMode.TOUCH_POINT) : (AsMultitouchInputMode.NONE)));
		}
		public static bool getHandleLostContext()
		{
			return sHandleLostContext;
		}
		public static void setHandleLostContext(bool _value)
		{
			if((sCurrent != null))
			{
				throw new AsIllegalOperationError("Setting must be changed before Starling instance is created");
			}
			else
			{
				sHandleLostContext = _value;
			}
		}
	}
}
