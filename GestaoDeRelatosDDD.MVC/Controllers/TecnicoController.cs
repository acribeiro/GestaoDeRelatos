
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.MVC.ViewModels;

namespace GestaoDeRelatosDDD.MVC.Controllers
{
    public class TecnicoController : Controller
    {
        private readonly ITecnicoAppService _tecnicoApp;

        public TecnicoController(ITecnicoAppService tecnicoApp)
        {
            _tecnicoApp = tecnicoApp;
        }

        // GET: Tecnico
        public ActionResult Index()
        {
            var tecnicoViewModel = Mapper.Map<IEnumerable<Tecnico>, IEnumerable<TecnicoViewModel>>(_tecnicoApp.GetAll());
            return View(tecnicoViewModel);
        }

        // GET: Tecnico/Details/5
        public ActionResult Details(int id)
        {
            var tecnico = _tecnicoApp.GetById(id);
            var tecnicoViewModel = Mapper.Map<Tecnico, TecnicoViewModel>(tecnico);
            return View(tecnicoViewModel);
        }

        // GET: Tecnico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tecnico/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TecnicoViewModel tecnico)
        {
            if (ModelState.IsValid)
            {
                var tecnicoDomain = Mapper.Map<TecnicoViewModel, Tecnico>(tecnico);
                _tecnicoApp.Add(tecnicoDomain);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Tecnico/Edit/5
        public ActionResult Edit(int id)
        {
            var tecnico = _tecnicoApp.GetById(id);
            var tecnicoViewModel = Mapper.Map<Tecnico, TecnicoViewModel>(tecnico);
            return View(tecnicoViewModel);
        }

        // POST: Tecnico/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TecnicoViewModel tecnico)
        {
            if (ModelState.IsValid)
            {
                var tecnicoDomain = Mapper.Map<TecnicoViewModel, Tecnico>(tecnico);
                _tecnicoApp.Update(tecnicoDomain);

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Tecnico/Delete/5
        public ActionResult Delete(int id)
        {
            var tecnico = _tecnicoApp.GetById(id);
            var tecnicoViewModel = Mapper.Map<Tecnico, TecnicoViewModel>(tecnico);
            return View(tecnicoViewModel);
        }

        // POST: Tecnico/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var tecnico = _tecnicoApp.GetById(id);
            _tecnicoApp.Remove(tecnico);

            return RedirectToAction("Index");
        }
    }
}
