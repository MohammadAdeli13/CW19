//using Microsoft.AspNetCore.Mvc;
//using Store.DbServices;
//using Store.Models;

//namespace Store.Controllers
//{
//    public class AuthenticationController : Controller
//    {
//        //Iuserservices injection
//        IUserServices userserives;
//        public AuthenticationController(IUserServices userserives)
//        {
//            this.userserives = userserives;
//        }



//        public IActionResult Login()
//        {
//            return View();
//        }
//        [HttpPost]
//        public IActionResult Login(User user)
//        {
//            User loguser = Models.User.usersRipo.Find(admin => admin.Email == user.Email && admin.Password == user.Password);
//            if (loguser != null)
//            {
//                return Redirect("/Admin/DashBoard");
//            }
//            else
//            {
//                //ViewBag["usernotfound"] = "user not found! Email Address or Password is incorrect";
//                return View();
//            }
//        }

//        public IActionResult Register()
//        {
//            return View();
//        }
//        [HttpPost]
//        public IActionResult Register(User user)
//        {
//            User newuser = new User
//            {
//                Name = user.Name,
//                NationalCode = user.NationalCode,
//                Email = user.Email,
//                PhoneNumber = user.PhoneNumber,
//                Password = user.Password,
//                Role = user.Role,
//                CreatedDate = DateTime.Now
//            };
//            userserives.CreateUser(newuser);
//            TempData["name"] = newuser.Name;
//            TempData["role"] = newuser.Role;
//            return RedirectToAction("RegisterDone");

//        }

//        public IActionResult RegisterDone()
//        {
//            var name = TempData["name"] as string;
//            var role = TempData["role"] as string;
//            var newuser = new User
//            {
//                Name = name,
//                Role = role,
//            };
//            return View(newuser);
//        }



//    }
//}
