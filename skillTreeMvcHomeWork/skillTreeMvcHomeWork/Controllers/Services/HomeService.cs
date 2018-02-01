using skillTreeMvcHomeWork.Models;
using skillTreeMvcHomeWork.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace skillTreeMvcHomeWork.Controllers.Services
{
    public class HomeService
    {
        public IEnumerable<MoneyData> getDataLists()
        {
            using (SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities())
            {
                int i = 0;
                foreach (AccountBook accountBook in db.AccountBook.OrderBy(s => s.Dateee))
                {
                    MoneyData moneyData = new MoneyData
                    {
                        number = ++i,
                        moneyType = accountBook.Categoryyy,
                        time = accountBook.Dateee,
                        money = accountBook.Amounttt,
                    };
                    yield return moneyData;
                }
            }

        }
        public void save(MoneyData viewModel)
        {
            using (SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities())
            {
                AccountBook accountBook = new AccountBook
                {
                    Dateee = viewModel.time,
                    Amounttt = (int)viewModel.money,
                    Categoryyy = viewModel.moneyType,
                    Remarkkk = viewModel.remark,
                    Id = Guid.NewGuid()
                };
                db.AccountBook.Add(accountBook);
                db.SaveChanges();
            }
        }
        public List<SelectListItem> getSelectLists()
        {
            var items = new List<SelectListItem>();
            items.Add(new SelectListItem()
            {
                Text = "支出",
                Value = "0"
            });
            items.Add(new SelectListItem()
            {
                Text = "收入",
                Value = "1"
            });
            return items;
        }
    }
}