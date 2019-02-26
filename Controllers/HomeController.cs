using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infinterest.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace Infinterest.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }
        // Signin and login page
        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Login")))
            {
                HttpContext.Session.SetString("Login", "False");
                HttpContext.Session.SetInt32("UserId", 0);
            }  
            ViewBag.Error = TempData["Error"];
            ViewBag.ErrorReg = TempData["ErrorReg"];
            return View("Index");
        }
        [HttpGet("vendor-registration")]
        public IActionResult VendorRegistration()
        {
            return View();
        }
        [HttpGet("broker-registration")]
        public IActionResult BrokerRegistration()
        {
            return View("BrokerRegistration");
        }

        [HttpGet("broker-profile")]
        public IActionResult BrokerProfile1()
        {
            return View("BrokerProfile");
        }
        [HttpGet("vendor-profile")]
        public IActionResult VendorProfile()
        {
            return View();
        }

        [HttpGet("event-detail")]
        public IActionResult EventDetail()
        {
            return View();
        }

        // [HttpPost("vendor")]
        // public IActionResult NewVendor(Vendor NewVendor)
        // {
        //     if(ModelState.IsValid)  
        //     {   
        //         int UserId = (int)HttpContext.Session.GetInt32("UserId");
        //         User User =_context.users.SingleOrDefault(user => user.UserId == UserId);
                
        //         HttpContext.Session.SetInt32("UserId", UserId);
        //         @ViewBag.User = User;

        //         NewVendor.UserId = UserId;
        //         _context.vendors.Add(NewVendor);
        //         _context.SaveChanges();
        //         return RedirectToAction("Dashboard");
        //     }
        //     else
        //     {
        //         return View("Vendor");
        //     }
        // }

        //POST Register user  
        // [HttpPost("new-user")]
        // public IActionResult NewUser(UserValidator User)
        // {   
        //     if(ModelState.IsValid)  
        //     {   
        //         User OldUser =_context.users.SingleOrDefault(user => user.Email == User.Email);
        //         if(OldUser == null){
        //             User NewUser = new User();
        //             if(User.UserType == "Vendor"){
        //                 NewUser.UserType = "V";
        //             }
        //             else{
        //                 User.UserType = "B";
        //             }
        //             NewUser.FirstName = User.FirstName;
        //             NewUser.LastName = User.LastName;
        //             NewUser.Contact = User.Contact;
        //             NewUser.Bio = User.Bio;
        //             NewUser.Email = User.Email;
        //             // DateTime CurrentTime = DateTime.Now;
        //             // NewUser.CreatedAt = CurrentTime;
                    
        //             PasswordHasher<UserValidator> Hasher = new PasswordHasher<UserValidator>();
        //             NewUser.Password = Hasher.HashPassword(User, User.Password);
                    
        //             _context.users.Add(NewUser);
        //             _context.SaveChanges();
        //             HttpContext.Session.SetString("Login", "True");
        //             HttpContext.Session.SetInt32("UserId", NewUser.UserId);
        //             if(User.UserType == "Vendor"){
        //                 return RedirectToAction("Vendor");
        //             }
        //             else{
        //                 return RedirectToAction("Broker");
        //             }

        //         }
        //         //if user is found
        //         else{
        //             TempData["ErrorReg"] = "That email address already exists";
        //             return RedirectToAction("Registration");
        //         }
        //     }
        //     else
        //     {
        //         return View("Registration");
        //     }
        // }

        //POST Login user
        // [HttpPost("existing-user")]
        // public IActionResult ExistingUser(string PasswordLogin, string EmailLogin)
        // {   
        //     if(EmailLogin != null && PasswordLogin != null)
        //     {   
        //        User User =_context.users.SingleOrDefault(user => user.Email == EmailLogin);
        //         if(User != null){
        //             var Hasher = new PasswordHasher<User>();
                
        //             if(0 != Hasher.VerifyHashedPassword(User, User.Password, PasswordLogin))
        //             {
        //                 HttpContext.Session.SetString("Login", "True");
        //                 HttpContext.Session.SetInt32("UserId", User.UserId);
        //                 return RedirectToAction("Dashboard");
        //             }
        //         }
        //         TempData["Error"] = "Your email or password are not correct";
        //         return RedirectToAction("Index");      
        //     }
        //     else 
        //     {   
        //         TempData["Error"] = "An email and password are required";
        //         return RedirectToAction("Index");
        //     }
        // }
        //GET Logoff
        [HttpGet("logoff")]
        public IActionResult Logoff()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }  

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
        [HttpGet("messaging")]
        public IActionResult Messaging()
        {
            return View();
        }

        [HttpGet("profile")]
        public IActionResult Profile()
        {
            return View();
        }
        [HttpGet("profile-changes")]
        public IActionResult ProfileChanges()
        {
            return View();
        }

        [Route("add-listings")]
        public IActionResult AddEvents()
        {
            return View();
        }

        [HttpGet("search")]
        public IActionResult AfterSearch()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
