using bc.flash.core.natives;
using bc.flash.native.input;
using bc.flash.resources;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace bc.flash.native
{
    public class NativeApplication : GamePadListener, KeyboardListener, TouchListener
    {
        // private Application application;        
        // private Graphics appGraphics;

        private NativeInput input;
        private ResFactory resFactory;
        private AsBcNativeStage stage;

        private bool running;

        public NativeApplication(int width, int height, ContentManager content)
        {
            resFactory = new ResFactory(content);            

            // appGraphics = new Graphics(width, height);            
            input = new NativeInput();
            input.AddGamePadListener(this);
            input.AddKeyboardListener(this);
            input.AddTouchListener(this);            
            running = true;

            stage = new AsBcNativeStage(width, height);
            // application.Start();
        }        
        
        public void Stop()
        {
            running = false;
        }                

        public void Tick(float deltaTime)
        {
            input.Tick();            
            stage.tick(deltaTime);
        }

        public void Draw(GraphicsDevice device)
        {
            // appGraphics.Begin(device);
            // application.Draw(appGraphics);
            // appGraphics.End();
        }

        public void PointerMoved(int x, int y)
        {
            stage.touchMove(x, y, 0);
        }

        public void PointerPressed(int x, int y)
        {            
            stage.touchDown(x, y, 0);
        }

        public void PointerDragged(int x, int y)
        {            
            stage.touchDragged(x, y, 0);
        }

        public void PointerReleased(int x, int y)
        {            
            stage.touchUp(x, y, 0);
        }

        public void ButtonPressed(ButtonEventArg e)
        {
            KeyCode code = InputHelper.GetKeyCode(e.button);
            // KeyAction action = InputHelper.GetKeyAction(e.button);
            // application.KeyPressed(new KeyEvent(e.playerIndex, code, action));
            stage.keyPressed((uint)code);
        }

        public void ButtonReleased(ButtonEventArg e)
        {
            KeyCode code = InputHelper.GetKeyCode(e.button);
            // KeyAction action = InputHelper.GetKeyAction(e.button);
            // application.KeyPressed(new KeyEvent(e.playerIndex, code, action));
            stage.keyReleased((uint)code);
        }

        public void GamePadConnected(int playerIndex)
        {
            // application.GamePadConnected(playerIndex);
        }

        public void GamePadDisconnected(int playerIndex)
        {
            // application.GamePadDisconnected(playerIndex);
        }

        public void KeyPressed(Keys key)
        {
            // int playerIndex = InputHelper.GetPlayerIndex(key);
            KeyCode code = InputHelper.GetKeyCode(key);
            // KeyAction action = InputHelper.GetKeyAction(key);
            // application.KeyPressed(new KeyEvent(playerIndex, code, action));
            stage.keyPressed((uint)code);
        }

        public void KeyReleased(Keys key)
        {
            // int playerIndex = InputHelper.GetPlayerIndex(key);
            KeyCode code = InputHelper.GetKeyCode(key);
            // KeyAction action = InputHelper.GetKeyAction(key);
            // application.KeyReleased(new KeyEvent(playerIndex, code, action));
            stage.keyReleased((uint)code);
        }

        public bool isRunning()
        {
            return running;
        }

        public void Dispose()
        {            
            resFactory.Dispose();
            input.Dispose();
        }
    }
}
