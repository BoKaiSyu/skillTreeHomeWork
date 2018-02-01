using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace skillTreeMvcHomeWork.Controllers
{
    public class ValidController : Controller
    {
        public ActionResult checkDateTime(DateTime time)
        {
            bool isValidate = time <= DateTime.Now;
            return Json(isValidate ? "true" : "輸入的日期不能大於今天!", JsonRequestBehavior.AllowGet);
        }
    }
}