using skillTreeMvcHomeWork.Models.ViewModels;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace skillTreeMvcHomeWork.Controllers.Services
{
    public class HomeService
    {
        public IEnumerable<MoneyData> getDataLists()
        {
            using (SkillTreeEntities db = new SkillTreeEntities())
            {
                int i = 0;
                foreach (AccountBook accountBook in db.AccountBook.OrderBy(s => s.Dateee))
                {
                    MoneyData moneyData = new MoneyData();
                    moneyData.number = ++i;
                    switch (accountBook.Categoryyy)
                    {
                        case 0:
                            moneyData.moneyType = "支出";
                            break;
                        case 1:
                            moneyData.moneyType = "收入";
                            break;
                    }
                    moneyData.time = accountBook.Dateee.ToString("yyyy-MM-dd");
                    moneyData.money = accountBook.Amounttt.ToString("0,0", CultureInfo.InvariantCulture);

                    yield return moneyData;
                }
            }

        }
    }
}