using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ModelStd.DB.Stock;
using ModelStd.Infrastructure;
using Newtonsoft.Json;

namespace ModelStd.Carts
{
    public class SessionCart:Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
            .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart")
            ?? new SessionCart();
            cart.Session = session;
            return cart;
        }
        [JsonIgnore]        
        public ISession Session { get; set; }
        public override void AddItem(Symbol symbol, int quantity)
        {
            base.AddItem(symbol, quantity);
            Session.SetJson("Cart", this);
        }

        public override void RemoveLine(Symbol symbol)
        {
            base.RemoveLine(symbol);
            Session.SetJson("Cart", this);
        }
        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }

    }
}
