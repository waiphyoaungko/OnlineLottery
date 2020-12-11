using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLottery.Models
{
    public class StatusRepository : IStatusRepository
    {
        private readonly AppDbContext _appDbContext;

        public StatusRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Status> GetAllStautses => _appDbContext.Statuses;
    }
}
