using System.Xml;
using AdapterPattern.interfaces;
using Newtonsoft.Json;

namespace AdapterPattern;

public class LumiaXMLAdapter : ILumiaXMLTarget
{
    public XmlDocument GetLumiaMobilesXMLSpecifications()
    {
        LumiaJSONAdaptee lumiaJSONAdaptee = new LumiaJSONAdaptee();
        string jsonLumia = lumiaJSONAdaptee.GetLumiaMobilesJSONSpecifications();
        var doc = JsonConvert.DeserializeXmlNode(jsonLumia, "MicrosoftLumiaMobiles", true);
        return doc;
    }
}