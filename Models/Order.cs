using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLottery.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage = "ကျေးဇူးပြု၍ အမည်ဖြည့်သွင်းပါ")]
        [Display(Name = "အမည်")]
        [StringLength(30)]
        public string Name { get; set; }

        [Required(ErrorMessage = "ကျေးဇူးပြု၍ ဖုန်းဖြည့်သွင်းပါ")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"[0]\d{7,10}", ErrorMessage = "ဖုန်းနံပါတ်မှားယွင်း နေပါသည်။")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        //[BindNever]
        public decimal OrderTotal { get; set; }

        //[BindNever]
        public DateTime OrderTime { get; set; }
        //[BindNever]
        public int StatusId { get; set; }

        //[BindNever]
        public Status Status { get; set; }
    }
}
