using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0160
{
    /// <summary>
    /// File path containing text data.
    /// </summary>
    [StrongTypeMarker]
    public class TextFilePath : TypedString, IStrongTypeMarker, ITextFilePath
    {
        public TextFilePath(string value)
            : base(value)
        {
        }
    }
}
