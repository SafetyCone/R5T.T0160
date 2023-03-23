using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0160
{
    /// <summary>
    /// File path for JSON format data.
    /// </summary>
    [StrongTypeMarker]
    public class JsonFilePath : TypedString, IStrongTypeMarker, IJsonFilePath
    {
        public JsonFilePath(string value)
            : base(value)
        {
        }
    }
}
