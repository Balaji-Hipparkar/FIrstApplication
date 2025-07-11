using EFCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCF.Controllers
{
    public class StudInfoController : Controller
    {
        // GET: StudInfo
        StudDbContext Context=new StudDbContext();  
        public ActionResult Index()
        {
            var students=Context.studInfos.ToList();
            return View(students);
        }

        // GET: StudInfo/Details/5
        public ActionResult Details(int id)
        {
            var student=Context.studInfos.Find(id); 
            return View(student);
        }

        // GET: StudInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudInfo/Create
        [HttpPost]
        public ActionResult Create(StudInfo collection)
        {
            try
            {
                // TODO: Add insert logic here
                Context.studInfos.Add(collection);  
                Context.SaveChanges();  
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudInfo/Edit/5
        public ActionResult Edit(int id)
        {
            var student = Context.studInfos.Find(id);
            return View(student);
        }

        // POST: StudInfo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, StudInfo collection)
        {
            try
            {
                // TODO: Add update logic here
                Context.Entry(collection).State=System.Data.Entity.EntityState.Modified;    
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudInfo/Delete/5
        public ActionResult Delete(int id)
        {
            var student = Context.studInfos.Find(id);
            return View(student);
        }

        // POST: StudInfo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, StudInfo collection)
        {
            try
            {
                // TODO: Add delete logic here
                var student = Context.studInfos.Find(id);
                Context.studInfos.Remove(student);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
