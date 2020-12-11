using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLottery.Models
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; } // open, incart, bid, request, request_cancel,order,order_cancel,resolve, return,reject,close
        public List<Ticket> Tickets { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public List<Order> Orders { get; set; }
    }
}
