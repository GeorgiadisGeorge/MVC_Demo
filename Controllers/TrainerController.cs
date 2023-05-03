using MVC_Demo.Models.Services;
using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class TrainerController : Controller
    {
        private readonly ITrainerService _trainerService;

        public TrainerController()
        {
        
        }

        public TrainerController(ITrainerService trainerService)
        {
            _trainerService = trainerService;
        }

        public ActionResult Index()
        {
            var trainers = _trainerService.GetAllTrainers();
            return View(trainers);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                _trainerService.AddTrainer(trainer);
                return RedirectToAction("Index");
            }

            return View(trainer);
        }

        public ActionResult Edit(int id)
        {
            var trainer = _trainerService.GetTrainerById(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }

            return View(trainer);
        }

        [HttpPost]
        public ActionResult Edit(Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                _trainerService.UpdateTrainer(trainer);
                return RedirectToAction("Index");
            }

            return View(trainer);
        }

        public ActionResult Delete(int id)
        {
            var trainer = _trainerService.GetTrainerById(id);
            if (trainer == null)
            {
                return HttpNotFound();
            }

            return View(trainer);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _trainerService.DeleteTrainer(id);
            return RedirectToAction("Index");
        }
    }

}