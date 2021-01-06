using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetCuoiKy.Controllers
{
    public class ProductController : Controller
    {
        // GET: Productdddđđđssssss
        public ActionResult Index()
        {
            
            return View();
        }
        public PartialViewResult ProductCategory()
        {
            var model = new ProductCategoryDao().ListAll();
            return PartialView(model);
        }
        public ActionResult Category(long cateid)
        {
            var category = new CategoryDao().ViewDetail(cateid);
            return View(category);
        }

        public ActionResult Detail( long id,string code)
        {
            var product = new ProductDao().ViewDetail(id,code);
            return View(product);
        }
    }
}