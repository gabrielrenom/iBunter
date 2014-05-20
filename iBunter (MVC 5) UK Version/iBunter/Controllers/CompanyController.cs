using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iBunter.Models;

namespace iBunter.Controllers
{
    public class CompanyController : Controller
    {

        private iBunterEntities db = new iBunterEntities();

        //
        // GET: /Company/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Company/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Company/Create
        public ActionResult Create(int? id, int? rate)
        {

            ViewBag.countries = db.Countries.ToDictionary(item => item.Name, item => item.Id);
   
            var _vRatings = db.RatingTypes.Where(m => m.Entity == "company").ToList();
            
            ViewBag.Ratings = _vRatings;

            if (Session["Rating"] == null)
            {
                //## Init
                var _oCompany = new CompanyModel();

                //## Fill the rating
                _oCompany.Rating = new List<Rate>();
                foreach (var item in _vRatings)
                {
                    _oCompany.Rating.Add(new Rate() { Id = item.Id, Name = item.Name, Description = item.Name, Entity = item.Entity, Rated = 0 });
                }

                //## Assigning to the session
                Session["Rating"] = _oCompany;
            }
            else if (id!=null)
            {
                var model = Session["Rating"] as CompanyModel;

                foreach (var item in model.Rating)
                {
                    if (item.Id == id)
                    {
                        item.Rated = (int)rate;
                    }
                }

                Session["Rating"] = model;

            }

            return View(Session["Rating"]);
        }

        public JsonResult getCity(string id,string country)
        {
            int _iId = Convert.ToInt32(id);
            
            var _vCities = db.Cities.Where(item => item.CountryId == _iId).ToDictionary(item => item.Id.ToString(), item => item.Name);
        
            return Json(_vCities, JsonRequestBehavior.AllowGet);
        }

        public JsonResult findCompany(string term)               
        {            
            var _vCompany = db.UKCompanyDatabase.Where(item => item.CompanyName.ToLower().StartsWith(term.ToLower())).Select(o =>  o.CompanyName).Take(10).ToList();

            return Json(_vCompany, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getCompanyData(string companyname)
        {
            var _vCompany = db.UKCompanyDatabase.Where(item => item.CompanyName.ToLower().StartsWith(companyname.ToLower())).Select(o => new { o.CompanyName, o.RegAddress_PostCode, o.RegAddress_AddressLine1, o.C_RegAddress_AddressLine2, o.RegAddress_Country, o.RegAddress_PostTown, o.URI }).Take(1).ToList();

            return Json(_vCompany, JsonRequestBehavior.AllowGet);
        }

        public void setCity(string id )
        {
            int _iId = Convert.ToInt32(id);                       
        }




        //
        // POST: /Company/Create
        [HttpPost]
        //public ActionResult Create(FormCollection collection)
        public ActionResult Create(CompanyModel company, FormCollection collection)
        {
            ViewBag.SelectedCountry = null;
            ViewBag.SelectedCity = null;

            try
            {
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                    var sw = collection["Country"];
                    // TODO: Add insert logic here
                    var s = HttpContext.User.Identity.Name;

                    // return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.countries = db.Countries.ToDictionary(item => item.Name, item => item.Id);

                    var _vRatings = db.RatingTypes.Where(m => m.Entity == "company").ToList();

                    ViewBag.Ratings = _vRatings;

                    if (Session["Rating"] == null)
                    {
                        //## Init
                        var _oCompany = new CompanyModel();

                        //## Fill the rating
                        _oCompany.Rating = new List<Rate>();
                        foreach (var item in _vRatings)
                        {
                            _oCompany.Rating.Add(new Rate() { Id = item.Id, Name = item.Name, Description = item.Name, Entity = item.Entity, Rated = 0 });
                        }

                        //## Assigning to the session
                        Session["Rating"] = _oCompany;
                    }

                    if (collection["Country"]!=null) { ViewBag.SelectedCountry = collection["Country"];  }

                    if (collection["City"]!=null) { ViewBag.SelectedCity = collection["City"]; }

                    company = Session["Rating"] as CompanyModel;
                }
            }
            catch
            {
                return View();
            }
            

            return View(company);
        }

        //
        // GET: /Company/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Company/Edit/5
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
        // GET: /Company/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Company/Delete/5
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
