using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ModelStd.Carts;
using ModelStd.DB.Stock;
using ModelStd.IRepository;
using ServiceStd.IOC;
using StockMVC.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockMVC.Controllers
{
    public class CartController : Controller
    {
        ISymbolInfo _symbolInfo;
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public CartController(Cart cartService)
        {
            _symbolInfo = Bootstrapper.container.GetInstance<ISymbolInfo>();
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
            Symbol symbol = _symbolInfo.GetAllSymbols()
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
