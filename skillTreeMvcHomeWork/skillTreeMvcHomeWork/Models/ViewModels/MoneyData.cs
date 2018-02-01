using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace skillTreeMvcHomeWork.Models.ViewModels
{
    public class MoneyData
    {
        public int number { get; set; }
        [Display(Name = "類別")]
        [Required(ErrorMessage = "請輸入類別!")]
        public int moneyType { get; set; }
        [Display(Name = "日期")]
        [Required(ErrorMessage = "請輸入日期!")]
        //[Remote("checkDateTime", "Valid")]
        public DateTime time { get; set; }
        [Display(Name = "金額")]
        [Required(ErrorMessage = "請輸入金額!")]
        [Range(0, int.MaxValue, ErrorMessage = "請輸入正整數!")]
        public decimal money { get; set; }
        [Display(Name = "備註")]
        [StringLength(100, ErrorMessage = "最多為100字!")]
        public string remark { get; set; }
    }
}