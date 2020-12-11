using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using OnlineLottery.Models;
using OnlineLottery.ViewModels;

namespace OnlineLottery.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly AppDbContext _appDbContext;

        public ShoppingCartController(ITicketRepository ticketRepository, ShoppingCart shoppingCart,AppDbContext appDbContext)
        {
            _ticketRepository = ticketRepository;
            _shoppingCart = shoppingCart;
            _appDbContext = appDbContext;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int ticketId)
        {
            var selectedTicket = _ticketRepository.GetAllTickets.Where(p => p.TicketId == ticketId).ToList();
            //.Where(c => c.TicketId == ticketId);
            var cartid = HttpContext.Session.GetString("CartId");

            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
              s => s.ShoppingCartId == cartid && s.Ticket.TicketId == ticketId);


            if (selectedTicket != null)
            {
                if (shoppingCartItem == null)
                {
                    ViewBag.Disable = "1";
                    _shoppingCart.AddToCart(selectedTicket.FirstOrDefault(), 1);
                }
                else
                {                       
                   
                    // Get UTF16 bytes and convert UTF16 bytes to UTF8 bytes
                    byte[] utf16Bytes = Encoding.Unicode.GetBytes("စျေးခြင်းထဲသို့ ထည့်ထားပြီးဖြစ်ပါသည်။");
                    byte[] utf8Bytes = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, utf16Bytes);

                    TempData["notice"] = Encoding.Default.GetString(utf8Bytes);
                    //ViewBag.Error = "Already Bought!";
                }
            }
            
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int ticketId)
        {
            var selectedTicket = _ticketRepository.GetAllTickets.FirstOrDefault(c => c.TicketId == ticketId);

            if (selectedTicket != null)
            {
                _shoppingCart.RemoveFromCart(selectedTicket);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
