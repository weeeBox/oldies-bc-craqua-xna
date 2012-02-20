using System;
using bc.flash.media;
using Microsoft.Xna.Framework.Audio;

namespace bc.flash.resources
{
    public class BcSoundEffect : BcSound
    {
        private SoundEffect mEffect;

        public BcSoundEffect(SoundEffect effect)
        {
            mEffect = effect;
        }
        public override float Length
        {
            get { return (float)mEffect.Duration.TotalSeconds; }
        }

        public override AsSoundChannel Play(float startTime, int loops, AsSoundTransform sndTransform)
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            base.Dispose();

            if (mEffect != null)
            {
                mEffect.Dispose();
                mEffect = null;
            }            
        }
    }
}
