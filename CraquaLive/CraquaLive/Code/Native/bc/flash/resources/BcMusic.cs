using System;
using bc.flash.media;
using Microsoft.Xna.Framework.Media;

namespace bc.flash.resources
{
    public class BcMusic : BcSound
    {
        private Song mSong;

        public BcMusic(Song song)
        {
            mSong = song;
        }
        public override float Length
        {
            get { return (float)mSong.Duration.TotalSeconds; }
        }

        public override AsSoundChannel Play(float startTime, int loops, AsSoundTransform sndTransform)
        {
            return new AsSoundChannel();
        }

        public override void Close()
        {
            
        }

        public override void Dispose()
        {
            base.Dispose();

            if (mSong != null)
            {
                mSong.Dispose();
                mSong = null;
            }
        }
    }
}
