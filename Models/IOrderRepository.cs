using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLottery.Models
{
    public interface IOrderRepository
    {
        int CreateOrder(Order order);
        int UpdateOrder(int orderId);
        IEnumerable<OrderDetail> GetOrders { get; }

        //Order GetOrderById(int orderId);

        //IEnumerable<OrderDetail> GetOrderDetailsByOrderId(int orderId);

    }
}
