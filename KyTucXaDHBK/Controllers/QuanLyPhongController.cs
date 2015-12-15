using KyTucXaDHBK.Models;
using KyTucXaDHBK.Models.bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace KyTucXaDHBK.Controllers
{


    public class QuanLyPhongController : Controller
    {

        PhongBO phongBo = new PhongBO();
        NhaBO nhaBo = new NhaBO();
        

        //
        // GET: /QuanLyPhong/

        public ActionResult Index()
        {
            ViewBag.listPhong = phongBo.getListPhong();
            ViewBag.listNha = nhaBo.getListNha();
            return View();
        }

        //
        // GET: /QuanLyPhong/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /QuanLyPhong/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /QuanLyPhong/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /QuanLyPhong/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /QuanLyPhong/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /QuanLyPhong/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /QuanLyPhong/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
