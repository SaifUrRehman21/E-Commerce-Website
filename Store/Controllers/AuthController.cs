using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        //private BridgeContext db = new BridgeContext();

        //Get: Auth/Login
        public ActionResult Login()
        {
            return View();
        }

        //Post: Auth/Login
        [HttpPost]
        public ActionResult Login(User model)
        {
            using (var db = new BridgeContext())
            {
                var emialCheck = db.Users.FirstOrDefault(u => u.Email.ToLower() == model.Email.ToLower());
                var getPassword = db.Users.Where(u => u.Email == model.Email).Select(u => u.Password);
                var getPasswordd = getPassword.ToList();
                var getPassworddd = getPasswordd[0];

                var getRole = db.Users.Where(u => u.Email == model.Email).Select(u => u.Role);
                var getRolee = getRole.ToList();
                var getRoleee = getRolee[0];

                var FirstName = db.Users.Where(u => u.Email == model.Email).Select(u => u.FirstName);
                var FirstNamee = FirstName.ToList();
                var FirstNameee = FirstNamee[0];

                var LastName = db.Users.Where(u => u.Email == model.Email).Select(u => u.LastName);
                var LastNamee = LastName.ToList();
                var LastNameee = LastNamee[0];

                var UserId = db.Users.Where(u => u.Email == model.Email).Select(u => u.UserId);
                var UserIdd = UserId.ToList();
                var UserIddd = UserIdd[0];

                if ((emialCheck != null) && (model.Password==getPassworddd))
                {
                        var identity = new ClaimsIdentity(new[] {
                        new Claim(ClaimTypes.Name, FirstNameee + " "+ LastNameee),
                        new Claim(ClaimTypes.Email, model.Email),
                        new Claim(ClaimTypes.Role, getRoleee)}, 
                        "ApplicationCookie");

                    TempData["UserID"] = UserIddd;

                        var authManager = Request.GetOwinContext().Authentication;
                        authManager.SignIn(identity);
                    
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Index", "Home");
        }

            //GET: Auth/Logout
            public ActionResult Logout()
        {
            var authManager = Request.GetOwinContext().Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Login", "Auth");
        }

        // GET: Auth/Registration
        public ActionResult Registration()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration([Bind(Include = "ID,FirstName,LastName,Email,Phone,DOB,Role,Gender,Password,ConformPassword")] User user)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BridgeContext())
                {
                    user.Role = "User";
                    var localvar = db.Users.Create();
                    localvar.Email = user.Email;
                    localvar.Password = user.Password;
                    localvar.FirstName = user.FirstName;
                    localvar.Role = user.Role;
                    db.Users.Add(user);
                    db.SaveChanges();


                    var identity = new ClaimsIdentity(new[] {
                        new Claim(ClaimTypes.Name, user.FirstName+" "+user.LastName),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.Role)},"ApplicationCookie");

                    var authManager = Request.GetOwinContext().Authentication;
                    authManager.SignIn(identity);

                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}