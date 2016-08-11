using EricStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EricStore.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            CartModel z = new CartModel();
            using (EricTestEntities model = new EricTestEntities())
            {
                var record = model.Baskets.Single(x => x.User.Email == User.Identity.Name);
                //z.Products = record.BasketProductSizes.Select(x => new Product {  ID = x})
                //z.ID = record.ID;
                // z.Price = record.Price;
                // z.Description = record.Description;

            }
                return View(z);
        }
    }
}