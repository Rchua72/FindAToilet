using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace FindAToilet.ModuleManagers
{
    public class CachingManager
    {

        private static XmlDocument cachedToiletMapXMLDocument = null;

        static CachingManager()
        {
        }

        public static void PerformXMLDocumentCaching()
        {
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
                    }
                    catch (Exception ex)
                    {
                        cachedToiletMapXMLDocument = null;
                    }
                }
            }
        }

        public static XmlDocument CachedToiletMapXmlDocument
        {
            get
            {
                if (cachedToiletMapXMLDocument == null)
                {
                    CacheToiletMapXmlDocument();
                }

                return cachedToiletMapXMLDocument;
            }
        }
    }
}