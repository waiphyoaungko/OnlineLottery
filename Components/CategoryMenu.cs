using Microsoft.AspNetCore.Mvc;
using OnlineLottery.Models;
using OnlineLottery.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLottery.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ITicketRepository _ticketRepository;
        public CategoryMenu(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public IViewComponentResult Invoke()
        {
            int MaxOpenTime = _ticketRepository.GetAllTickets.ToList().Max(t => t.OpenTime);
            var TotalCount = _ticketRepository.GetAllTickets.Where(t => t.GroupTicketId == 0 && t.OpenTime == MaxOpenTime).ToList().Count;
            var categories = _ticketRepository.GetAllTickets.Where(t => t.GroupTicketId == 0 && t.OpenTime == MaxOpenTime)
                .GroupBy(t=>t.GroupSize).Select(r => new CategoryViewModel()
                {
                    GroupSize = r.Key,
                    Count = r.Count(),
                    TotalCount = TotalCount
                });

           

            return View(categories);
        }
    }
}
