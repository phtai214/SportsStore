/*************  ✨ Windsurf Command 🌟  *************/
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
namespace SportsStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart _cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            _cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
namespace SportsStore.Components { public class CartSummaryViewComponent : ViewComponent { private Cart cart; public CartSummaryViewComponent(Cart cartService) { cart = cartService; } public IViewComponentResult Invoke() { return View(cart); } } }
/*******  f04a04c3-8864-4f4c-9a09-296a866b2f85  *******/