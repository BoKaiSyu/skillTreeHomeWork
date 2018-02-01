using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace skillTreeMvcHomeWork.Models.ViewModels
{
    public class CreateMoneyDataViewModel
    {
        public MoneyData moneyData { get; set; }
        public List<SelectListItem> selectLists { get; set; }
    }
}