using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.MVC.ViewModels;

namespace GestaoDeRelatosDDD.MVC.Controllers
{
    public class UnidadeController : Controller
    {

        private readonly IUnidadeAppService _unidadeApp;

        public UnidadeController(IUnidadeAppService unidadeApp)
        {
            _unidadeApp = unidadeApp;
        }

        // GET: Unidade
        public ActionResult Index()
        {
            var unidadeViewModel = Mapper.Map<IEnumerable<Unidade>, IEnumerable<UnidadeViewModel>>(_unidadeApp.GetAll());
            return View(unidadeViewModel);
        }

        // GET: Unidade/Details/5
        public ActionResult Details(int id)
        {
            var unidade = _unidadeApp.GetById(id);
            var unidadeViewModel = Mapper.Map<Unidade, UnidadeViewModel>(unidade);
            return View(unidadeViewModel);
        }

        // GET: Unidade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Unidade/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UnidadeViewModel unidade)
        {
            if (ModelState.IsValid)
            {
                var unidadeDomain = Mapper.Map<UnidadeViewModel, Unidade>(unidade);
                _unidadeApp.Add(unidadeDomain);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Unidade/Edit/5
        public ActionResult Edit(int id)
        {
            var unidade = _unidadeApp.GetById(id);
            var unidadeViewModel = Mapper.Map<Unidade, UnidadeViewModel>(unidade);
            return View(unidadeViewModel);
        }

        // POST: Unidade/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UnidadeViewModel unidade)
        {
            if (ModelState.IsValid)
            {
                var unidadeDomain = Mapper.Map<UnidadeViewModel, Unidade>(unidade);
                _unidadeApp.Update(unidadeDomain);

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Unidade/Delete/5
        public ActionResult Delete(int id)
        {
            var unidade = _unidadeApp.GetById(id);
            var unidadeViewModel = Mapper.Map<Unidade, UnidadeViewModel>(unidade);
            return View(unidadeViewModel);
        }

        // POST: Unidade/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var unidade = _unidadeApp.GetById(id);
            _unidadeApp.Remove(unidade);

            return RedirectToAction("Index");
        }
    }
}
