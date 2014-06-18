using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using FindAToilet.Models;
using System.Xml.Serialization;

namespace FindAToilet.ModuleManagers
{
    public class CachingManager
    {

        private static XmlDocument cachedToiletMapXMLDocument = null;
        private static HttpApplicationState applicationState = null;

        static CachingManager()
        {
        }

        public static void PerformXMLDocumentCaching(HttpApplicationState application)
        {
            applicationState = application;
            CacheToiletMapXmlDocument();
        }

        private static void CacheToiletMapXmlDocument()
        {
            object obj = new object();
            lock (obj)
            {
                if (cachedToiletMapXMLDocument == null)
                {
                    try
                    {
                        cachedToiletMapXMLDocument = new XmlDocument();
                        string toiletMapConfigPath = System.Web.Hosting.HostingEnvironment.MapPath("~/XML/ToiletMapExport.xml");
                        cachedToiletMapXMLDocument.Load(toiletMapConfigPath);
                        var ser = new XmlSerializer(typeof(ToiletMapExport));
                        applicationState["ToiletMapExport"] = (ToiletMapExport)ser.Deserialize(new XmlNodeReader(cachedToiletMapXMLDocument.DocumentElement));
                    }
                    catch (Exception ex)
                    {
                        cachedToiletMapXMLDocument = null;
                    }
                }
            }
        }

        public static ToiletMapExport CachedToiletMapExport
        {
            get
            {
                if (applicationState["ToiletMapExport"] == null)
                {
                    CacheToiletMapXmlDocument();
                }

                return (ToiletMapExport)applicationState["ToiletMapExport"];
            }
        }
    }
}