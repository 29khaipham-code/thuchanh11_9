using thuchanh11_9.Models;
using Microsoft.AspNetCore.Mvc;

namespace thuchanh11_9.ViewComponents
{
    public class LoaiHangViewComponent : ViewComponent
    {
        private readonly QlhangHoaContext _db;

        public  LoaiHangViewComponent(QlhangHoaContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var dsloaihang = _db.LoaiHangs.ToList();
            return View(dsloaihang);
        }
        

    }
}
