using System.Xml;

namespace AdapterPattern.interfaces;

public interface ILumiaXMLTarget
{
    XmlDocument GetLumiaMobilesXMLSpecifications();
}