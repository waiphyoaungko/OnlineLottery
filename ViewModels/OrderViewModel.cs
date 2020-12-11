using OnlineLottery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLottery.ViewModels
{
    public class OrderViewModel
    {
        public int AutoNumber { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTime OrderTime { get; set; }
        public IEnumerable<OrderDetail> OrderDetailList { get; set; }
    }
}
