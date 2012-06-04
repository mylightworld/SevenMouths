using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SevenMouths.Models;

namespace SevenMouths.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<Share> shares = context.Shares1.ToList();

            return View(shares);
        }

        //获取所有视频分享
        [HttpPost]
        public ActionResult GetVedios()
        { 
            int categoryId = context.Categories1.FirstOrDefault(x => x.Name == "vedio").CategoryId;
            List<int> shareIds = context.ShareCategories1.Where(x => x.CategoryId == categoryId).Select(x => x.ShareId).ToList();
            List<Share> vedios = context.Shares1.Where(x => shareIds.Contains(x.ShareId)).ToList();

            return View(vedios);
        }

        //获取所有书分享
        [HttpPost]
        public ActionResult GetBooks()
        {
            int categoryId = context.Categories1.FirstOrDefault(x => x.Name == "book").CategoryId;
            List<int> shareIds = context.ShareCategories1.Where(x => x.CategoryId == categoryId).Select(x => x.ShareId).ToList();
            List<Share> books = context.Shares1.Where(x => shareIds.Contains(x.ShareId)).ToList();

            return View(books);
        }

    }
}
