﻿using bc.flash.native.input;
using bc.flash.resources;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using bc.core.device;
using bc.flash.display;
using bc.core.resources.loaders;
using bc.core.data;
using System;
using bc.ui;
using bc.game;
using bc.flash.core;

namespace bc.flash.native
{
    public class NativeApplication : GamePadListener, KeyboardListener, TouchListener
    {
        // private Application application;        
        private AsRenderSupport renderSupport;

        private NativeInput input;
        private BcResFactory resFactory;
        private AsStage stage;

        private bool running;

        public NativeApplication(int width, int height, ContentManager content)
        {
            resFactory = new BcResFactory(content);

            renderSupport = new AsRenderSupport();

            input = new NativeInput();
            input.AddGamePadListener(this);
            input.AddKeyboardListener(this);
            input.AddTouchListener(this);            
            running = true;

            stage = new AsStage(width, height);

            // TODO: remove the shit
            new AsBcResLoaderFactory();
            AsBcDevice.initialize(stage);

            AsBcAsset.loadPath("../asset/preloader.xml", null);
            AsBcData.load(new AsVector<String>("data"));

            new AsBcGameUI();
            AsBcAsset.loadPath("../asset/game.xml", null);

            new AsBcGame();
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
            BcRenderSupport.Begin(device, stage.getStageWidth(), stage.getStageHeight());
            stage.render(renderSupport, 1.0f);
            BcRenderSupport.End();
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
