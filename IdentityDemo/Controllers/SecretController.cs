using System.Web.Mvc;

namespace IdentityDemo.Controllers
{
    [Authorize(Users = "pdo9141@gmail.com")]
    //[Authorize(Roles = "admin, sales")]
    public class SecretController : Controller
    {   
        public ContentResult Secret()
        {
            return Content("This is a secret...");
        }

        [AllowAnonymous]
        public ContentResult Overt()
        {
            return Content("This is not a secret...");
        }
    }
}