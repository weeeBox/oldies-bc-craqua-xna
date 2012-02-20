using Microsoft.Xna.Framework.Graphics;

namespace bc.flash.resources
{
    public class BcTexture2D : BcManagedResource
    {
        private Texture2D texture;

        public BcTexture2D(Texture2D texture)
        {
            this.texture = texture;
        }

        public int Width
        {
            get { return texture.Width; }
        }

        public int Height
        {
            get { return texture.Height; }
        }

        public override void Dispose()
        {
            if (texture != null)
            {
                texture.Dispose();
                texture = null;
            }
        }
    }
}
