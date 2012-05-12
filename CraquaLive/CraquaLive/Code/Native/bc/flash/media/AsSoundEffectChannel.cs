using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Audio;

namespace bc.flash.media
{
    public class AsSoundEffectChannel : AsSoundChannel
    {
        private SoundEffectInstance mInstance;        

        public AsSoundEffectChannel(SoundEffect effect, AsSoundTransform transform) : base(transform)
        {
            mInstance = effect.CreateInstance();
        }

        public override float getLeftPeak()
        {
            return 0.0f;
        }

        public override float getPosition()
        {
            return 0.0f;
        }

        public override float getRightPeak()
        {
            return 0.0f;
        }

        public override void play(int loopsCount)
        {
            mInstance.IsLooped = loopsCount != 0;
            mInstance.Play();
        }

        public override void stop()
        {
            if (mInstance != null)
            {
                mInstance.Stop();
                mInstance.Dispose();
                mInstance = null;
            }
        }
    }
}
