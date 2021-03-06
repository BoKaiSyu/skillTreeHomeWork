﻿using skillTreeMvcHomeWork.Controllers.Services;
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
            ViewData["selectLists"] = homeService.getSelectLists();
            return View();
        }
        [HttpPost]
        public ActionResult Save(MoneyData viewModel)
        {
            if (ModelState.IsValid)
            {
                homeService.save(viewModel);
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