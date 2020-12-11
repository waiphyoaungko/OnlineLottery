using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLottery.Models
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetAllTickets { get; }
        IEnumerable<Ticket> GetTicketByStatus(int StatusId);
        void EditTicket(Ticket ticket);

    }
}
