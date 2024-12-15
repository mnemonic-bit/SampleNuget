using YamlDotNet.Serialization;

namespace SampleApi.Controllers.Extensions
{
    public static class ObjectExtensions
    {

        public static string SerializeToYaml<TObject>(this TObject obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }

            StringWriter stringWriter = new StringWriter();
            Serializer serializer = new Serializer();
            serializer.Serialize(stringWriter, obj);
            return stringWriter.ToString();
        }

    }
}
