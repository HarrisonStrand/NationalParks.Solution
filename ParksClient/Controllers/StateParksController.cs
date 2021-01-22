using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParksClient.Models;

namespace ParksClient.Controllers
{
    public class StateParksController : Controller
    {
        public IActionResult Index()
        {
            var allStateParks = StatePark.GetStateParks();
            return View(allStateParks);
        }

        [HttpPost]
        public IActionResult Index(StatePark statePark)
        {
            StatePark.Post(statePark);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var statePark = StatePark.GetDetails(id);
            return View(statePark);
        }

        public IActionResult Edit(int id)
        {
            var statePark = StatePark.GetDetails(id);
            return View(statePark);
        }

        [HttpPost]
        public IActionResult Details(int id, StatePark statePark)
        {
            statePark.Id = id;
            StatePark.Put(statePark);
            return RedirectToAction("Details", id);
        }

        public IActionResult Delete(int id)
        {
            StatePark.Delete(id);
            return RedirectToAction("Index");
        }
    }
}