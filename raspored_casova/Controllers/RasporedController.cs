using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using raspored_casova.Models;
namespace raspored_casova.Controllers
{
    public class RasporedController : Controller
    {
        private static List<Raspored> rasporedCasova=new List<Raspored>();
        // GET: RasporedController
        public ActionResult Index()
        {
            return View(rasporedCasova);
        }

        public ActionResult Ucitaj()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ucitaj(IFormFile xmlFile) //public ActionResult Ucitaj(HttpPostedFileBase xmlFile)
        {
            // if (xmlFile == null || xmlFile.ContentLength == 0) 
            if (xmlFile == null || xmlFile.Length == 0)
            {
                ViewBag.Greska = "niste izabrali validan fajl";
                return View();
            }
            try
            {
                /*var serializer = new XmlSerializer(typeof(RasporedCasovaModel));
                using (var stream = xmlFile.inputStream)
                {
                    var model = (RasporedCasovaModel)serializer.Deserialize(stream);
                    rasporedCasova = model.casovi;
                }*/
                var serializer = new XmlSerializer(typeof(RasporedCasovaModel));

                using (var stream = xmlFile.OpenReadStream())
                {
                    var model = (RasporedCasovaModel)serializer.Deserialize(stream);
                    rasporedCasova = model.casovi;
                }

                return RedirectToAction("Index");
            }
            catch(System.Exception ex)
            {
                ViewBag.Greska = "Greska priliukom ucitavanja";
                return View();
            }


        }




        // GET: RasporedController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RasporedController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RasporedController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: RasporedController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RasporedController/Edit/5
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

        // GET: RasporedController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RasporedController/Delete/5
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
