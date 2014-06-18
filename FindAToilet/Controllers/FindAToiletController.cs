using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindAToilet.Models;
using System.Collections;
using FindAToilet.ModuleManagers;

namespace FindAToilet.Controllers
{
    public class FindAToiletController : Controller
    {
        //
        // GET: /FindAToilet/

        public ActionResult Index()
        {
            MyViewModel model = new MyViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Search(MyViewModel model,int? page = 1)
        {
            const int pageSize = 5;
            int totalRecords = 0;
            ToiletMapExport tmExport = CachingManager.CachedToiletMapExport;
            int skip = page.HasValue ? page.Value - 1  : 1;

            model.toiletMap = tmExport.Items.Where(x => x.Town.ToUpper() == model.searchString.ToUpper()).OrderBy(o => o.Town).Skip(skip * pageSize).Take(pageSize);
            totalRecords = tmExport.Items.Where(x => x.Town.ToUpper() == model.searchString.ToUpper()).Count();
            model.pageSize = pageSize;
            model.pageNumber = Convert.ToInt16(page);
            model.totalRecords = totalRecords;
            model.jsonFlag = "Y";
            Session["toiletMap"] = model.toiletMap;
            Session["searchString"] = model.searchString;
            return View("Index",model);
        }

        [HttpGet]
        public ActionResult Search(FormCollection form, MyViewModel model, int? page = 1)
        {
            var searchString = (string)Session["searchString"];
            const int pageSize = 5;
            int totalRecords = 0;
            ToiletMapExport tmExport = CachingManager.CachedToiletMapExport;
            int skip = page.HasValue ? page.Value - 1 : 1;

            model.toiletMap = tmExport.Items.Where(x => x.Town.ToUpper() == searchString.ToUpper()).OrderBy(o => o.Town).Skip(skip * pageSize).Take(pageSize);
            totalRecords = tmExport.Items.Where(x => x.Town.ToUpper() == searchString.ToUpper()).Count();
            model.pageSize = pageSize;
            model.pageNumber = Convert.ToInt16(page);
            model.totalRecords = totalRecords;
            model.jsonFlag = "Y";
            Session["toiletMap"] = model.toiletMap;
            return View("Index", model);
        }

        [HttpGet]
        public JsonResult GetJsonData()
        {
            ArrayList toiletMapList = new ArrayList();

            var toiletMap = (IEnumerable<ToiletMapExportToiletDetails>)Session["toiletMap"];

            foreach (var item in toiletMap)
            {
                toiletMapList.Add(
                    new {
                        latitude = item.Latitude,
                        longitude = item.Longitude,
                        text = item.Name
                });
            }

            return Json(toiletMapList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetAutoCompleteData()
        {
            ToiletMapExport tmExport = CachingManager.CachedToiletMapExport;

            var list = (from m in tmExport.Items
                       where !string.IsNullOrEmpty(m.Town)
                       select m.Town).Distinct();

            return Json(list.ToArray(), JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult Details(string name)
        {
            ToiletMapExport tmExport = CachingManager.CachedToiletMapExport;

            MyViewModel model = new MyViewModel();

            model.toiletDetail = tmExport.Items.FirstOrDefault(x => x.Name.ToUpper() == name.ToUpper());

            return Json(new { latitude = model.toiletDetail.Latitude, longitude = model.toiletDetail.Longitude, text = model.toiletDetail.Name }, JsonRequestBehavior.AllowGet);
        }
    }
}
