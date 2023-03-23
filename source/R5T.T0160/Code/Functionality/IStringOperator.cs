using System;

using R5T.T0132;


namespace R5T.T0160
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public JsonFilePath ToJsonFilePath(string value)
        {
            var output = new JsonFilePath(value);
            return output;
        }

        public TextFilePath ToTextFilePath(string value)
        {
            var output = new TextFilePath(value);
            return output;
        }

        public XmlFilePath ToXmlFilePath(string value)
        {
            var output = new XmlFilePath(value);
            return output;
        }
    }
}
