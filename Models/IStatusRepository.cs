using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLottery.Models
{
    public interface IStatusRepository
    {       
        IEnumerable<Status> GetAllStautses { get; }
    }
}
