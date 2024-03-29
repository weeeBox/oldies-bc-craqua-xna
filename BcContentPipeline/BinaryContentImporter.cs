using Microsoft.Xna.Framework.Content.Pipeline;

// TODO: replace this with the type you want to import.
using TImport = bc.content.BinaryContent;

namespace bc.content
{
    /// <summary>
    /// This class will be instantiated by the XNA Framework Content Pipeline
    /// to import a file from disk into the specified type, TImport.
    /// 
    /// This should be part of a Content Pipeline Extension Library project.
    /// 
    /// TODO: change the ContentImporter attribute to specify the correct file
    /// extension, display name, and default processor for this importer.
    /// </summary>
    [ContentImporter(".xml", DisplayName = "Binary Importer", DefaultProcessor = "BinaryContentProcessor")]
    public class BinaryContentImporter : ContentImporter<BinaryContent>
    {
        public override TImport Import(string filename, ContentImporterContext context)
        {
            byte[] data = System.IO.File.ReadAllBytes(filename);
            return new BinaryContent(data);
        }
    }
}
