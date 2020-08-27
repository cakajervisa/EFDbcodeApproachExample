using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDbFirstApproachExample.Models;

namespace EFDbFirstApproachExample.Controllers
{
    public class BrandsController : Controller
    {
        
            public ActionResult Index(string search = "", 
                string SortColumn = "BrandID", string IconClass = "fa-sort-asc", int PageNo =1)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
                ViewBag.search = search;
                List<Brand> brands = db.Brands.Where(temp => temp.BrandName.Contains(search)).ToList();
              // List<Brand> brands = db.Brands.ToList();

            /*Sorting*/
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (ViewBag.SortColumn == "BrandID")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    brands = brands.OrderBy(temp => temp.BrandID).ToList();
                else
                    brands = brands.OrderByDescending(temp => temp.BrandID).ToList();
            }
            else if (ViewBag.SortColumn == "BrandName")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    brands = brands.OrderBy(temp => temp.BrandName).ToList();
                else
                    brands = brands.OrderByDescending(temp => temp.BrandName).ToList();
            }


            /* Paging */
            int NoOfRecordsPerPage = 5;
            int NoOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(brands.Count) / Convert.ToDouble(NoOfRecordsPerPage)));
            int NoOfRecordsToSkip = (PageNo - 1) * NoOfRecordsPerPage;
            ViewBag.PageNo = PageNo;
            ViewBag.NoOfPages = NoOfPages;
            brands = brands.Skip(NoOfRecordsToSkip).Take(NoOfRecordsPerPage).ToList();

            return View(brands);
        }//details 


        
   


    public ActionResult Details(long id)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Brand b = db.Brands.Where(temp => temp.BrandID == id).FirstOrDefault();
         
            return View(b);
        }
        public ActionResult Edit(long id)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Brand existingBrand = db.Brands.Where(temp => temp.BrandID == id).FirstOrDefault();
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Brands = db.Brands.ToList();
            return View(existingBrand);
        }
        [HttpPost]
        public ActionResult Edit(Brand b)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Brand existingBrand = db.Brands.Where(temp => temp.BrandID == b.BrandID).FirstOrDefault();
            existingBrand.BrandName = b.BrandName; 
        //    existingProduct.BrandID = p.BrandID;
           
            db.SaveChanges();
            return RedirectToAction("Index", "Brands");
        }
        public ActionResult Delete(long id)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Brand existingBrand = db.Brands.Where(temp => temp.BrandID == id).FirstOrDefault();
            return View(existingBrand);
        }
        [HttpPost]
        public ActionResult Delete(long id, Brand b)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Brand existingBrand = db.Brands.Where(temp => temp.BrandID == id).FirstOrDefault();
            db.Brands.Remove(existingBrand);
            db.SaveChanges();
            return RedirectToAction("Index", "Brands");
        }
        public ActionResult Create()
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
         
            ViewBag.Brands = db.Brands.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Brand b)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
          
            db.Brands.Add(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }

}


