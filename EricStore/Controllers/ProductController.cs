
using EricStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EricStore.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            CategoryModel model = new CategoryModel();
            using (EricTestEntities entities = new EricTestEntities())
            {
                model.Shoes = entities.Products.Select(x => 
                new ProductModel
                {
                     Description = x.Description,
                     ShoeName = x.Name,
                     ID = x.ID,
                     Price = x.Price,
                     Thumb = x.Thumb,
                     Full = x.Full
                     
                     
                }
                ).ToArray();
                

            } 
           
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(int ID)
        {
            using (EricTestEntities entities = new EricTestEntities())
            {
                Basket b = entities.Baskets.FirstOrDefault(x => x.User.Email == User.Identity.Name);
                if (b == null)
                {
                    b = entities.Baskets.Create();
                    b.UserId = entities.Users.Single(x => x.Email == User.Identity.Name).ID;
                    entities.Baskets.Add(b);
                }
                BasketProductSize bps = entities.BasketProductSizes.Create();
                bps.ProductId = ID;
                bps.Quantity_ = 1;
                bps.Size = 9;
                b.BasketProductSizes.Add(bps);

                entities.SaveChanges();
                //User.Identity.Name
            }
                return RedirectToAction("Index", "Home");
        }
    }
}