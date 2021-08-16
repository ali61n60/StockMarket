using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ModelStd.Carts;
using ModelStd.DB.Stock;
using ModelStd.IRepository;
using ServiceStd.IOC;
using ServiceStd.IService;
using StockMVC.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMVC.Controllers
{
    public class CartController : Controller
    {
        ISymbolService _symbolService;
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public CartController(Cart cartService)
        {
            _symbolService = Bootstrapper.container.GetInstance<ISymbolService>();
            Cart = cartService;
        }

        [HttpGet]
        public IActionResult CartAction(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            return View(new CartViewModel() { Cart = Cart, ReturnUrl = ReturnUrl });
        }

        [HttpPost]
        public IActionResult CartAction(long Id, string returnUrl)
        {
            Symbol symbol = _symbolService.GetAllSymbols()
                .FirstOrDefault(s => s.Id == Id);
            if (symbol != null) symbol.SymbolGroup = null; // self referencing problem
            
            Cart.AddItem(symbol, 1);
                       
            return CartAction(returnUrl);
        }     

        [HttpPost]
        public IActionResult Remove(int symbolId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Symbol.Id== symbolId).Symbol);
            return RedirectToPage( returnUrl);
        }
    }
}
