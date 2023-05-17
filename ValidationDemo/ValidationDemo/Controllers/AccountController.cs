using Microsoft.AspNetCore.Mvc;
using ValidationDemo.Models;
using ValidationDemo.Models.Account;
using ValidationDemo.Utility.CustomExceptions;

namespace ValidationDemo.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Register", "Account");
        }

        [HttpGet]
        public IActionResult Register()
        {
            RegisterVM newUser = new();
            return View(newUser);
        }

        [HttpPost]
        public IActionResult Register(RegisterVM newUser)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new InvalidModelStateException(GetModelStateErrors());
                }
                TempData["success"] = "User created successfully!";
                return RedirectToAction("Index", "Home");
            }
            catch (InvalidModelStateException imEx)
            {
                TempData["error"] = imEx.Errors.FirstOrDefault();
                return View(newUser);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View(newUser);
            }
        }

        private Dictionary<string, string> GetModelStateErrors()
        {
            var errors = new Dictionary<string, string>();

            foreach (var entry in ModelState)
            {
                if (entry.Value.Errors.Count > 0)
                {
                    var errorMessages = entry.Value.Errors.Select(e => e.ErrorMessage);
                    var errorMessage = string.Join(", ", errorMessages);
                    errors[entry.Key] = errorMessage;
                }
            }

            return errors;
        }
    }
}
