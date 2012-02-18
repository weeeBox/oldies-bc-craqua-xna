using Microsoft.Xna.Framework.Content;

namespace bc.flash.resources
{
    public class BinaryContentReader : ContentTypeReader<byte[]>
    {
        protected override byte[] Read(ContentReader input, byte[] existingInstance)
        {
            int size = input.ReadInt32();
            byte[] data = input.ReadBytes(size);
            return data;
        }
    }
}
