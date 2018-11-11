using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppNew2.Models;

namespace AppNew2.Controllers
{
    public class SidebarController : Controller
    {
        EntityModel dbContext = new EntityModel();
        // GET: Different
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetOrders()
        {
            IEnumerable<CustomerOrderModel> model = dbContext.CustomerOrderModels.ToList();
            
            return Json(model, JsonRequestBehavior.AllowGet);
          
        }
    }
}