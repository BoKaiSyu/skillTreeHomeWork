using skillTreeMvcHomeWork.Controllers.Services;
using skillTreeMvcHomeWork.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace skillTreeMvcHomeWork.Controllers
{
    public class HomeController : Controller
    {
        private HomeService homeService = new HomeService();
        public ActionResult Index()
        {
            CreateMoneyDataViewModel temp = new CreateMoneyDataViewModel
            {
                selectLists = homeService.getSelectLists(),
                moneyData = new MoneyData()
            };
            return View(temp);
        }
        [HttpPost]
        public ActionResult Save(CreateMoneyDataViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                homeService.save(viewModel.moneyData);
            }
            return RedirectToAction("MoneyListsPartial");
        }
        public ActionResult MoneyListsPartial()
        {
            return PartialView(homeService.getDataLists());
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}