using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLottery.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string TicketNo { get; set; } // က ၂၃၆၅၄၃
        public string TicketGroupNo { get; set; } // က ၂၃၆၅၄၃-၅ or က-ည ၂၃၆၇၄၂
        public string GroupingPattern { get; set; }
        public int StatusId { get; set; }
        public string Owner { get; set; } // Lottery Whole Sale Shop Name
        public decimal Price { get; set; }
        public int? GroupTicketId { get; set; } // Ticket Parent Id
        public string ImageUrl { get; set; }
        public int OpenTime { get; set; } // 16th, 17th (၁၁ကြိမ်မြောက်)
        public string GroupSize { get; set; } // ၃ စောင် ၊ ၅ စောင်၊ ၁၀ စောင်၊ မင်္ဂလာစုံတွဲ
        public Status Status { get; set; }
        public List<Ticket> SubCategories { get; set; } // All tickets in one Product
    }
}
