using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using thuchanh11_9.Models;

namespace thuchanh11_9.Controllers
{
    public class HomeController : Controller
    {

        private readonly QlhangHoaContext _db;

        public HomeController(QlhangHoaContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var hanghoas = _db.HangHoas.Where(h => h.Gia >= 100).ToList();
            return View(hanghoas);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult LocHangHoa ( int MaLoai)
        {
            var dshanghoa = _db.HangHoas.Where(h => h.MaLoai == MaLoai).ToList();

            return PartialView("PhamNgocKhai_MainContent", dshanghoa);
        }
      
    }
}
