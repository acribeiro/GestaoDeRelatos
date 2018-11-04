using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.MVC.ViewModels;

namespace GestaoDeRelatosDDD.MVC.Controllers
{
    public class RelatoController : Controller
    {
        private readonly IRelatoAppService _relatoApp;

        public RelatoController(IRelatoAppService relatoApp)
        {
            _relatoApp = relatoApp;
        }

        // GET: Relato
        public ActionResult Index()
        {
            var relatoViewModel = Mapper.Map<IEnumerable<Relato>, IEnumerable<RelatoViewModel>>(_relatoApp.GetAll());
            return View(relatoViewModel);
        }

        // GET: Relato/Details/5
        public ActionResult Details(int id)
        {
            var relato = _relatoApp.GetById(id);
            var relatoViewModel = Mapper.Map<Relato, RelatoViewModel>(relato);
            return View(relatoViewModel);
        }

        // GET: Relato/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Relato/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RelatoViewModel relato)
        {
            if (ModelState.IsValid)
            {
                var relatoDomain = Mapper.Map<RelatoViewModel, Relato>(relato);
                _relatoApp.Add(relatoDomain);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Relato/Edit/5
        public ActionResult Edit(int id)
        {
            var relato = _relatoApp.GetById(id);
            var relatoViewModel = Mapper.Map<Relato, RelatoViewModel>(relato);
            return View(relatoViewModel);
        }

        // POST: Relato/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RelatoViewModel relato)
        {
            if (ModelState.IsValid)
            {
                var relatoDomain = Mapper.Map<RelatoViewModel, Relato>(relato);
                _relatoApp.Update(relatoDomain);

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Relato/Delete/5
        public ActionResult Delete(int id)
        {
            var relato = _relatoApp.GetById(id);
            var relatoViewModel = Mapper.Map<Relato, RelatoViewModel>(relato);
            return View(relatoViewModel);
        }

        // POST: Relato/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var relato = _relatoApp.GetById(id);
            _relatoApp.Remove(relato);

            return RedirectToAction("Index");
        }
    }
}
