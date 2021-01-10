using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Currency.Converter.BNR.Utils
{
    internal static class XmlHelpers<T> where T:class
    {
        public static T DeserializeFromXmlText(string xmlContent)
        {
            var deserializer = new DataContractSerializer(typeof(T));

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes("\ufeff" + xmlContent ?? "")))
                return (T)deserializer.ReadObject(stream);
        }
    }
}
