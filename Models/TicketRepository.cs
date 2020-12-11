using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLottery.Models
{
    public class TicketRepository : ITicketRepository
    {
        private readonly AppDbContext _appDbContext;

        public TicketRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Ticket> GetAllTickets
        {            
            get
            {
                return _appDbContext.Ticktes.Include(s => s.Status).Where(s => s.StatusId == 1);
            }
        }

        public IEnumerable<Ticket> GetTicketByStatus(int StatusId)
        {
            return _appDbContext.Ticktes.Include(s => s.Status).Where(s=>s.StatusId == StatusId);           
        }

        public void EditTicket(Ticket ticket)
        {
            _appDbContext.Ticktes.Update(ticket);
        }
    }
}
