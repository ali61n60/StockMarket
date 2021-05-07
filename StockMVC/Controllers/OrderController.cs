using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ModelStd.AspBook;
using ModelStd.DB.Stock;
using ModelStd.IRepository;
using ServiceStd.IOC;
using StockMVC.Models.ViewModels;

namespace StockMVC.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() =>  View(new Order());
        
    }
}
