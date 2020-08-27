using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDbFirstApproachExample.Models;

namespace EFDbFirstApproachExample.Controllers
{
    public class CategoriesController : Controller
    {
            // GET: Categories/Index
            public ActionResult Index(string search = "",
              string SortColumn = "CategoryName", string IconClass = "fa-sort-asc", int PageNo = 1)
            {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
                ViewBag.search = search;
                List<Category> categories = db.Categories.Where(temp => temp.CategoryName.Contains(search)).ToList();



            /*Sorting*/
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (ViewBag.SortColumn == "CategoryID")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    categories = categories.OrderBy(temp => temp.CategoryID).ToList();
                else
                    categories = categories.OrderByDescending(temp => temp.CategoryID).ToList();
            }
            else if (ViewBag.SortColumn == "CategoryName")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    categories = categories.OrderBy(temp => temp.CategoryName).ToList();
                else
                    categories = categories.OrderByDescending(temp => temp.CategoryName).ToList();
            }


            /* Paging */
            int NoOfRecordsPerPage = 5;
            int NoOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(categories.Count) / Convert.ToDouble(NoOfRecordsPerPage)));
            int NoOfRecordsToSkip = (PageNo - 1) * NoOfRecordsPerPage;
            ViewBag.PageNo = PageNo;
            ViewBag.NoOfPages = NoOfPages;
            categories = categories.Skip(NoOfRecordsToSkip).Take(NoOfRecordsPerPage).ToList();


            return View(categories);
             }







        public ActionResult Details(long id)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Category C = db.Categories.Where(temp => temp.CategoryID == id).FirstOrDefault();

            return View(C);
        }

        public ActionResult Edit(long id)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Category existingcategory = db.Categories.Where(temp => temp.CategoryID == id).FirstOrDefault();
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Brands = db.Brands.ToList();
            return View(existingcategory);
        }

        [HttpPost]
        public ActionResult Edit(Category c)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
           Category existingcategory = db.Categories.Where(temp => temp.CategoryID == c.CategoryID).FirstOrDefault();
            existingcategory.CategoryName = c.CategoryName;
          

            db.SaveChanges();
            return RedirectToAction("Index", "Categories");
        }
        public ActionResult Delete(long id)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
           Category existingcategory = db.Categories.Where(temp => temp.CategoryID == id).FirstOrDefault();
            return View(existingcategory);
        }
        [HttpPost]
        public ActionResult Delete(long id, Category c )
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Category existingcategory = db.Categories.Where(temp => temp.CategoryID == id).FirstOrDefault();
            db.Categories.Remove(existingcategory);
            db.SaveChanges();
            return RedirectToAction("Index", "Categories");
        }

         public ActionResult Create()
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            ViewBag.Categories = db.Categories.ToList();
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category c )
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
          
            db.Categories.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}


