using OnlineLottery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLottery.ViewModels
{
    public class TicketListViewModel
    {
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
