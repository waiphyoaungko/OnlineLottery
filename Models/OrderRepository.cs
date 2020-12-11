using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLottery.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;
        private readonly ITicketRepository _ticketRepository;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart, ITicketRepository ticketRepository)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
            _ticketRepository = ticketRepository;
        }

        public IEnumerable<OrderDetail> GetOrders
        {
            get
            {
                return _appDbContext.OrderDetails.Include(o => o.Order).Include(o => o.Ticket)
                    .Include(o => o.Ticket.SubCategories).Where(o => o.Order.StatusId == 3);
            }
        }

        public Order GetOrderById(int orderId)
        {
            return _appDbContext.Orders.Where(o => o.OrderId == orderId).FirstOrDefault();
        }

        public int CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            order.StatusId = 3;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    Price = shoppingCartItem.Ticket.Price,
                    TicketId = shoppingCartItem.Ticket.TicketId,
                    OrderId = order.OrderId
                };

                _appDbContext.OrderDetails.Add(orderDetail);

                var ticket = _ticketRepository.GetAllTickets.Where(t => t.TicketId == shoppingCartItem.Ticket.TicketId).FirstOrDefault();
                if (ticket != null)
                {
                    ticket.StatusId = 3;
                    _appDbContext.Ticktes.Update(ticket);
                }
                else
                {
                    return 0;
                }

            }

            int success = _appDbContext.SaveChanges();

            return success;

        }

        public int UpdateOrder(int orderId)
        {
            var order = _appDbContext.Orders.Where(o=>o.OrderId == orderId).FirstOrDefault();
            order.StatusId = 1;
            _appDbContext.Orders.Update(order);
          
            var orderDetail = _appDbContext.OrderDetails.Where(od => od.OrderId == orderId).ToList();
            foreach(var od in orderDetail)
            {
                var ticket = _appDbContext.Ticktes.Where(t => t.TicketId == od.TicketId).FirstOrDefault();
                ticket.StatusId = 1;
                _appDbContext.Ticktes.Update(ticket);
            }

            int success = _appDbContext.SaveChanges();

            //var shoppingCartItems = _shoppingCart.GetShoppingCartItems();

            //foreach (var shoppingCartItem in shoppingCartItems)
            //{
            //    var orderDetail = new OrderDetail
            //    {
            //        Amount = shoppingCartItem.Amount,
            //        Price = shoppingCartItem.Ticket.Price,
            //        TicketId = shoppingCartItem.Ticket.TicketId,
            //        OrderId = order.OrderId
            //    };

            //    _appDbContext.OrderDetails.Add(orderDetail);

            //    var ticket = _ticketRepository.GetAllTickets.Where(t => t.TicketId == shoppingCartItem.Ticket.TicketId).FirstOrDefault();
            //    if (ticket != null)
            //    {
            //        ticket.StatusId = 3;
            //        _appDbContext.Ticktes.Update(ticket);
            //    }
            //    else
            //    {
            //        return 0;
            //    }

            //}

            //int success = _appDbContext.SaveChanges();

            return success;

        }
    }
}
