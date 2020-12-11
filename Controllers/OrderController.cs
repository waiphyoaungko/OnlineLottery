using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineLottery.Models;
using OnlineLottery.ViewModels;
using ReflectionIT.Mvc.Paging;

namespace OnlineLottery.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly ITicketRepository _ticketRepository;
        private readonly AppDbContext _appDbContext;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart, ITicketRepository ticketRepository,
                                 AppDbContext appDbContext)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            _ticketRepository = ticketRepository;
            _appDbContext = appDbContext;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty");
            }

            if (ModelState.IsValid)
            {
                int status = _orderRepository.CreateOrder(order);
                if (status > 0)
                {
                    _shoppingCart.ClearCart();
                    TempData["notice"] = "Successfully Ordered.";
                    return RedirectToAction("Index", "Ticket");
                }
                else
                {
                    _shoppingCart.ClearCart();
                    TempData["notice"] = "Already Bought By other.";
                    return RedirectToAction("Index", "Ticket");
                }
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thank you for your order. Wish you win!";
            return View();
        }

        [Authorize]
        public IActionResult OrderCancel(int orderId)
        {
            if (orderId == 0)
            {
                //var month = _orderRepository.GetOrders.OrderByDescending(o => o.Order.OrderTime).FirstOrDefault().Order.OrderTime.Month;
                //var year = _orderRepository.GetOrders.OrderByDescending(o => o.Order.OrderTime).FirstOrDefault().Order.OrderTime.Year;
                int MaxOpenTime = _ticketRepository.GetAllTickets.ToList().Max(t => t.OpenTime);

                var query = _orderRepository.GetOrders
                    .Where(o => o.Ticket.OpenTime == MaxOpenTime).GroupBy(o => o.OrderId)
                    .Select(g => new OrderViewModel
                    {
                        AutoNumber = g.Key,
                        OrderDetailList = g.ToList()
                    }); ; ;

                return View(query);
            }
            else
            {
                int status = _orderRepository.UpdateOrder(orderId);
                if (status > 0)
                {
                    TempData["notice"] = "Successfully canceled order.";
                    return RedirectToAction("OrderCancel", "Order");
                }
                else
                {
                    _shoppingCart.ClearCart();
                    TempData["notice"] = "Cancel Failed.";
                    return RedirectToAction("OrderCancel", "Order");
                }
              
            }
        }

        //[HttpPost]
        //public IActionResult OrderCancel(int orderId)
        //{
        //    int id = orderId;
        //    return View();

        //}
    }
}
