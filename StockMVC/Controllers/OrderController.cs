using Microsoft.AspNetCore.Mvc;
using ModelStd.AspBook;

namespace StockMVC.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() =>  View(new Order());
        
    }
}
