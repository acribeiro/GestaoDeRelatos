using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.MVC.ViewModels;

namespace GestaoDeRelatosDDD.MVC.Controllers
{
    public class OficinaController : Controller
    {
        private readonly IOficinaAppService _oficinaApp;

        public OficinaController(IOficinaAppService oficinaApp)
        {
            _oficinaApp = oficinaApp;
        }

        // GET: Oficina
        public ActionResult Index()
        {
            var oficinaViewModel = Mapper.Map<IEnumerable<Oficina>, IEnumerable<OficinaViewModel>>(_oficinaApp.GetAll());
            return View(oficinaViewModel);
        }

        // GET: Oficina/Details/5
        public ActionResult Details(int id)
        {
            var oficina = _oficinaApp.GetById(id);
            var oficinaViewModel = Mapper.Map<Oficina, OficinaViewModel>(oficina);
            return View(oficinaViewModel);
        }

        // GET: Oficina/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Oficina/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OficinaViewModel oficina)
        {
            if (ModelState.IsValid)
            {
                var oficinaDomain = Mapper.Map<OficinaViewModel, Oficina>(oficina);
                _oficinaApp.Add(oficinaDomain);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Oficina/Edit/5
        public ActionResult Edit(int id)
        {
            var oficina = _oficinaApp.GetById(id);
            var oficinaViewModel = Mapper.Map<Oficina, OficinaViewModel>(oficina);
            return View(oficinaViewModel);
        }

        // POST: Oficina/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OficinaViewModel oficina)
        {
            if (ModelState.IsValid)
            {
                var oficinaDomain = Mapper.Map<OficinaViewModel, Oficina>(oficina);
                _oficinaApp.Update(oficinaDomain);

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Oficina/Delete/5
        public ActionResult Delete(int id)
        {
            var oficina = _oficinaApp.GetById(id);
            var oficinaViewModel = Mapper.Map<Oficina, OficinaViewModel>(oficina);
            return View(oficinaViewModel);
        }

        // POST: Oficina/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var oficina = _oficinaApp.GetById(id);
            _oficinaApp.Remove(oficina);

            return RedirectToAction("Index");
        }
    }
}
