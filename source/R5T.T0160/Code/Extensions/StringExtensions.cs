using System;


namespace R5T.T0160.Extensions
{
    public static class StringExtensions
    {
        public static JsonFilePath ToJsonFilePath(this string value)
        {
            return Instances.StringOperator.ToJsonFilePath(value);
        }

        public static TextFilePath ToTextFilePath(this string value)
        {
            return Instances.StringOperator.ToTextFilePath(value);
        }

        public static XmlFilePath ToXmlFilePath(this string value)
        {
            return Instances.StringOperator.ToXmlFilePath(value);
        }
    }
}
