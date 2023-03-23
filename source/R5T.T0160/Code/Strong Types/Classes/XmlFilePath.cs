using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0160
{
    /// <summary>
    /// File path containing XML format data.
    /// </summary>
    [StrongTypeMarker]
    public class XmlFilePath : TypedString, IStrongTypeMarker, IXmlFilePath
    {
        public XmlFilePath(string value)
            : base(value)
        {
        }
    }
}
