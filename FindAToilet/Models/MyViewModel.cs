using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindAToilet.Models
{
    public class MyViewModel
    {
        public IEnumerable<ToiletMapExportToiletDetails> toiletMap{ get; set; }
        public ToiletMapExportToiletDetails toiletDetail { get; set; }
        public string jsonFlag { get; set; }
        public string searchString { get; set; }
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public int totalRecords { get; set; }
    }
}