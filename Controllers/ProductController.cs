using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Product_Store.Models;
using Product_Store.Repository;

namespace Product_Store.Controllers
{
    public class ProductController : Controller
    {
        private IProduct ipro;
        public ProductController()
        {
            this.ipro = new RepositoryProduct(new ProductEntities());
        }

        // GET: Product  
        public ActionResult Index()
        {
            var emplist = ipro.getProduct().ToList();
            return View(emplist);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var getpro = ipro.getEmpbyid(id);
            var prodisplay = new Product_Table();
            prodisplay.Product_Name = getpro.Product_Name;
            prodisplay.Category = getpro.Category;
            prodisplay.Price = getpro.Price;
            prodisplay.Unit = getpro.Unit;
            prodisplay.Quantity = getpro.Quantity;
            return View(prodisplay);
        }

        // GET: Product/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Product_Table());
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, Product_Table proinsert)
        {
            try
            {
                // TODO: Add insert logic here
                var addpro = new Product_Table();
                addpro.Product_Name = proinsert.Product_Name;
                addpro.Category = proinsert.Category;
                addpro.Price = proinsert.Price;
                addpro.Unit = proinsert.Unit;
                addpro.Quantity = proinsert.Quantity;
                ipro.InsertEmpRecord(addpro);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var getpro = ipro.getEmpbyid(id);
            var addpro = new Product_Table();
            addpro.Product_Name = getpro.Product_Name;
            addpro.Category = getpro.Category;
            addpro.Price = getpro.Price;
            addpro.Unit = getpro.Unit;
            addpro.Quantity = getpro.Quantity;
            return View(addpro);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product_Table proupdate, FormCollection collection)
        {
            try
            {
                ipro.UpdateProduct(proupdate);
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var empdel = ipro.getEmpbyid(id);

            return View(empdel);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ipro.DeleteProduct(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
