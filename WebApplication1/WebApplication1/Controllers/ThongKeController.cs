using System.Linq;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class ThongKeController : Controller
    {
        private PiviotDbContext db = null;
        public ThongKeController()
        {
            db = new PiviotDbContext();
        }
        public ActionResult Index()
        {
            var model = db.Database.SqlQuery<ThongKeViewModel>("Thongke").ToList();
            return View(model);
        }
    }
}