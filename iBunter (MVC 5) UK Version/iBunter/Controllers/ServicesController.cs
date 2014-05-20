using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iBunter.Controllers
{
    public class ServicesController : Controller
    {
       // private Database.IDatabase db = null;

        //protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        //{
        //   //if (db == null) db = new Database.Database();

        //    base.Initialize(requestContext);
        //}

        public ActionResult RateProduct(int id, int rate)
        {
            int userId = 142; // WebSecurity.CurrentUserId;
            bool success = true;
            string error = "";

            //try
            //{
            //    success = db.RegisterProductVote(userId, id, rate);
            //}
            //catch (System.Exception ex)
            //{
            //    // get last error
            //    if (ex.InnerException != null)
            //        while (ex.InnerException != null)
            //            ex = ex.InnerException;

            //    error = ex.Message;
            //}

            return Json(new { error = error, success = success, pid = id }, JsonRequestBehavior.AllowGet);
        }
    }
}