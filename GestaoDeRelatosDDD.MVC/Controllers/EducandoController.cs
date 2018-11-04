using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.MVC.ViewModels;

namespace GestaoDeRelatosDDD.MVC.Controllers
{
    public class EducandoController : Controller
    {
        private readonly IEducandoAppService _educandoApp;

        public EducandoController(IEducandoAppService educandoApp)
        {
            _educandoApp = educandoApp;
        }

        // GET: Educando
        public ActionResult Index()
        {
            var educandoViewModel = Mapper.Map<IEnumerable<Educando>, IEnumerable<EducandoViewModel>>(_educandoApp.GetAll());
            return View(educandoViewModel);
        }

        // GET: Educando/Details/5
        public ActionResult Details(int id)
        {
            var educando = _educandoApp.GetById(id);
            var educandoViewModel = Mapper.Map<Educando, EducandoViewModel>(educando);
            return View(educandoViewModel);
        }

        // GET: Educando/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Educando/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EducandoViewModel educando)
        {
            if (ModelState.IsValid)
            {
                var educandoDomain = Mapper.Map<EducandoViewModel, Educando>(educando);
                _educandoApp.Add(educandoDomain);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Educando/Edit/5
        public ActionResult Edit(int id)
        {

            var educando = _educandoApp.GetById(id);
            var educandoViewModel = Mapper.Map<Educando, EducandoViewModel>(educando);
            return View(educandoViewModel);
        }

        // POST: Educando/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EducandoViewModel educando)
        {
            if (ModelState.IsValid)
            {
                var educandoDomain = Mapper.Map<EducandoViewModel, Educando>(educando);
                _educandoApp.Update(educandoDomain);

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Educando/Delete/5
        public ActionResult Delete(int id)
        {
            var educando = _educandoApp.GetById(id);
            var educandoViewModel = Mapper.Map<Educando, EducandoViewModel>(educando);

            return View(educandoViewModel);
        }

        // POST: Educando/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var educando = _educandoApp.GetById(id);
            _educandoApp.Remove(educando);

            return RedirectToAction("Index");
        }
    }
}
