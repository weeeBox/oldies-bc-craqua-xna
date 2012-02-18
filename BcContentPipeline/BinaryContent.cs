
namespace bc.content
{
    public class BinaryContent
    {
        private byte[] data;

        public BinaryContent(byte[] data)
        {
            this.data = data;
        }

        public byte[] Data { get { return data; } }
    }
}
