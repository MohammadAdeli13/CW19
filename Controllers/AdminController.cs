using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult EditProfile()
        {
            return View("~/Areas/Admin/Views/EditProfile.cshtml");
        }

        //public IActionResult LogOut()
        //{
        //    return View();
        //}

        public IActionResult CreateProduct()
        {
            return View("~/Areas/Admin/Views/CreateProduct.cshtml");
        }
        public IActionResult EditProduct()
        {
            return View("~/Areas/Admin/Views/EditProduct.cshtml");
        }
        public IActionResult AllProducts()
        {
            return View("~/Areas/Admin/Views/AllProducts.cshtml");
        }
        public IActionResult SearchByTitle()
        {
            return View("~/Areas/Admin/Views/SearchByTitle.cshtml");
        }
    }
}
