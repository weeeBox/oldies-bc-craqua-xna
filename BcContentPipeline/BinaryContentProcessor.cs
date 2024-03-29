using Microsoft.Xna.Framework.Content.Pipeline;

// TODO: replace these with the processor input and output types.
//using TInput = fp.BinaryContent;
//using TOutput = fp.BinaryContent;

namespace bc.content
{
    /// <summary>
    /// This class will be instantiated by the XNA Framework Content Pipeline
    /// to apply custom processing to content data, converting an object of
    /// type TInput to TOutput. The input and output types may be the same if
    /// the processor wishes to alter data without changing its type.
    ///
    /// This should be part of a Content Pipeline Extension Library project.
    ///
    /// TODO: change the ContentProcessor attribute to specify the correct
    /// display name for this processor.
    /// </summary>
    [ContentProcessor(DisplayName = "Binary Processor")]
    class BinaryContentProcessor : ContentProcessor<BinaryContent, BinaryContent>
    {
        public override BinaryContent Process(BinaryContent input, ContentProcessorContext context)
        {
            return input;
        }
    }
}