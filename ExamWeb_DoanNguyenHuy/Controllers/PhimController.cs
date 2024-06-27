using ExamWeb_DoanNguyenHuy.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_DoanNguyenHuy.Controllers
{
    public class PhimController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PhimController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var dsPhim = _db.Phims.ToList();
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Phim phim)
        {
            if (ModelState.IsValid)
            {
                _db.Phims.Add(phim);
                _db.SaveChanges();
                TempData["success"] = "Đã thêm 1 bộ phim";
                return RedirectToAction("Index");
            }
            return View(phim);
        }
        public IActionResult Update(int id)
        {
            
            var phim = _db.Phims.SingleOrDefault(x => x.Id == id);
            if (phim != null)
                return View(phim);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Update(Phim phim)
        {
            if (ModelState.IsValid)
            {
                _db.Phims.Update(phim);
                _db.SaveChanges();
                TempData["success"] = "Đã cập nhật phim";
                return RedirectToAction("Index");
            }
            return View(phim);
        }
        public IActionResult Delete(int id)
        {
            var phim = _db.Phims.FirstOrDefault(x => x.Id == id);
            if (phim == null)
            {
                return NotFound();
            }
            return View(phim);
        }
        // Xử lý xóa chủng loại
        public IActionResult DeleteConfirmed(int id)
        {
            var phim = _db.Phims.Find(id);
            if (phim == null)
            {
                return NotFound();
            }
            _db.Phims.Remove(phim);
            _db.SaveChanges();
            TempData["success"] = "Đã xoá phim";
            return RedirectToAction("Index");
        }
    }
}
