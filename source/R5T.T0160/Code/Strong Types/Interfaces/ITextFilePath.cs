using System;

using R5T.T0150;
using R5T.T0175;


namespace R5T.T0160
{
    /// <summary>
    /// File path for JSON format data.
    /// </summary>
    [StrongTypeMarker]
    public interface ITextFilePath : IStrongTypeMarker,
        IFilePath
    {
    }
}
