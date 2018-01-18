using skillTreeMvcHomeWork.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace skillTreeMvcHomeWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<MoneyData> dataLists = new List<MoneyData>();
            Random random = new Random();
            DateTime nowTime = DateTime.Now;
            for (int i = 0; i < 100; i++)
            {
                MoneyData temp = new MoneyData();

                int typeRandom = random.Next(1, 100);
                int moneyRandom = random.Next(100, 100000);

                temp.number = i + 1;
                switch (typeRandom % 2)
                {
                    case 0:
                        temp.moneyType = "支出";
                        break;
                    case 1:
                        temp.moneyType = "收入";
                        break;
                }
                temp.time = nowTime.AddDays(i).ToString("yyyy-MM-dd");
                temp.money = moneyRandom.ToString("0,0", CultureInfo.InvariantCulture);

                dataLists.Add(temp);
            }

            return View(dataLists);
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