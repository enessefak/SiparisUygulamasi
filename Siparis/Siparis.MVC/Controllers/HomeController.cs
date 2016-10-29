using Siparis.Service;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Siparis.MVC.Controllers
{
    public class HomeController : Controller
    {
        private UserService service = UserService.GetInstance();

        // GET: Home
        public async Task<ActionResult>Index()
        {
            return View(await service.GetUsers());
        }
    }
}