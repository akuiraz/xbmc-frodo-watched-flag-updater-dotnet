using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XbmcWatchedFlagUpdater
{
    /// <summary>
    /// Reads a watched.xml file, creating XbmcFile objects for each entry and placing it in a collection
    /// </summary>
    static class XMLConnector
    {
        static public List<XbmcFile> ReadFiles(string XmlPathLocation)
        {
            List<XbmcFile> files = new List<XbmcFile>();

            //read files, place into collection
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XmlPathLocation);

           

            foreach (XmlNode xmlNode in xmlDoc.ChildNodes[0].ChildNodes)
            {
                
                if (xmlNode.Name.ToString() == "file")
                {                 
                    string lastWatched = xmlNode.Attributes["lastPlayed"].Value.ToString();
                    int count = Convert.ToInt32(xmlNode.Attributes["Count"].Value);
                    string fileName = xmlNode.InnerText.ToString();
                    fileName = fileName.Replace("'", "''"); //replace a single quote with a double-single quote - this stops an error

                    files.Add(new XbmcFile(fileName, count, lastWatched));
                }
            }
            return files;
        }

        static public void WriteFiles(string XmlPathLocation, List<XbmcFile> files)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", null, null);
            XmlElement rootNode = xmlDoc.CreateElement("watched");
            //xmlDoc.InsertBefore(xmlDeclaration, xmlDoc.DocumentElement);
            

            foreach (XbmcFile file in files)
            {
                XmlElement fileNode = xmlDoc.CreateElement("file");
                fileNode.SetAttribute("Count", file.WatchedCount.ToString());
                fileNode.SetAttribute("lastPlayed", file.LastWatchedDate);

                fileNode.InnerText = file.FileName;
                rootNode.AppendChild(fileNode);
            }
            xmlDoc.AppendChild(rootNode);
            xmlDoc.Save(XmlPathLocation);
        }
    }
}
