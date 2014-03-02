﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FindAToilet.ModuleManagers;
using System.Xml;
using FindAToilet.Models;
using System.Xml.Serialization;

namespace FindAToilet
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            LoadData();
        }

        private void LoadData()
        {
            CachingManager.PerformXMLDocumentCaching();

            XmlDocument cachedToiletMapXmlDocument = CachingManager.CachedToiletMapXmlDocument;

            var ser = new XmlSerializer(typeof(ToiletMapExport));

            var toiletMapExport = (ToiletMapExport)ser.Deserialize(new XmlNodeReader(cachedToiletMapXmlDocument.DocumentElement));

            Application["ToiletMapExport"] = toiletMapExport;
        }
    }
}