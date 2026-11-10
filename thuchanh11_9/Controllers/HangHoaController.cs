using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using thuchanh11_9.Models;

namespace thuchanh11_9.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly QlhangHoaContext _db;

        public HangHoaController(QlhangHoaContext db)
        {
            _db = db;
        }
        // GET: HangHoaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HangHoaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HangHoaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HangHoaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HangHoa hangHoa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Add(hangHoa);
                    _db.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception)
            {
                // Xử lý lỗi
            }

            return View(hangHoa);
        }

        // GET: HangHoaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HangHoaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HangHoaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HangHoaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
