using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineLottery.Models;
using OnlineLottery.ViewModels;
using ReflectionIT.Mvc.Paging;

namespace OnlineLottery.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IStatusRepository _statusRepository;
        private readonly Common _common;

        public TicketController(ITicketRepository ticketRepository,IStatusRepository statusRepository,Common common)
        {
            this._ticketRepository = ticketRepository;
            this._statusRepository = statusRepository;
            this._common = common;
        }

        public IActionResult Index(int page = 1,string ts="",string ticketno ="", string prefixddl="")
        {           
            int MaxOpenTime = _ticketRepository.GetAllTickets.ToList().Max(t => t.OpenTime);
            if (string.IsNullOrEmpty(ts) && string.IsNullOrEmpty(ticketno))
            {
                var query = _ticketRepository.GetAllTickets.ToList()
                     .Where(t => t.GroupTicketId == 0 && t.OpenTime == MaxOpenTime)
                     .OrderBy(t => t.TicketId).ToList();
                var model = PagingList.Create(query, 5, page);
                return View(model);
              
            }
            else
            {
                if (!string.IsNullOrEmpty(ticketno))
                {
                    var ticketnumber = prefixddl + " " + _common.ConvertEToMNumber(ticketno);
                    Ticket ticket = new Ticket();
                    ticket.TicketNo = ticketnumber;
                    var query = _ticketRepository.GetAllTickets.ToList()
                         .Where(t => t.GroupTicketId == 0 && t.OpenTime == MaxOpenTime)
                         .Where(t=> t.SubCategories.Any(z => z.TicketNo.Contains(ticketnumber)))
                         .OrderBy(t => t.TicketId).ToList();

                    var model = PagingList.Create(query, 5, page);
                    return View(model);
                }
                else
                {
                    var query = _ticketRepository.GetAllTickets.ToList()
                         .Where(t => t.GroupTicketId == 0 && t.OpenTime == MaxOpenTime && t.GroupSize == ts)
                         .OrderBy(t => t.TicketId).ToList();
                    var model = PagingList.Create(query, 5, page);
                    return View(model);
                }
            }
          
        }
    }
}
