using Microsoft.AspNetCore.Mvc; using Microsoft.AspNetCore.Mvc.RazorPages; using SportsStore.Infrastructure; using SportsStore.Models; namespace SportsStore.Pages { public class CartModel : PageModel {

private IStoreRepository repository; public CartModel(IStoreRepository repo, Cart cartService) { repository = repo; Cart = cartService; } public Cart Cart { get; set; } public string ReturnUrl { get; set; } = "/"; public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/"; //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart(); 
        }
