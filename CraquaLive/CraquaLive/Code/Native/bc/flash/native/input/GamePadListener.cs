using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace bc.flash.native.input
{
    public struct ButtonEventArg
    {
        public Buttons button;
        public int playerIndex;

        public ButtonEventArg(int playerIndex, Buttons button)
        {
            this.playerIndex = playerIndex;
            this.button = button;
        }
    }

    public interface GamePadListener
    {
        void ButtonPressed(ButtonEventArg e);
        void ButtonReleased(ButtonEventArg e);
        void GamePadConnected(int playerIndex);
        void GamePadDisconnected(int playerIndex);
    }
}
