using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.MVC.ViewModels;

namespace GestaoDeRelatosDDD.MVC.Controllers
{
    public class EducadorController : Controller
    {
        private readonly IEducadorAppService _educadorApp;

        public EducadorController(IEducadorAppService educadorApp)
        {
            _educadorApp = educadorApp;
        }

        // GET: Educador
        public ActionResult Index()
        {
            var educadorViewModel = Mapper.Map<IEnumerable<Educador>, IEnumerable<EducadorViewModel>>(_educadorApp.GetAll());
            return View(educadorViewModel);
        }

        // GET: Educador/Details/5
        public ActionResult Details(int id)
        {
            var educador = _educadorApp.GetById(id);
            var educadorViewModel = Mapper.Map<Educador, EducadorViewModel>(educador);
            return View(educadorViewModel);
        }

        // GET: Educador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Educador/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EducadorViewModel educador)
        {
            if (ModelState.IsValid)
            {
                var educadorDomain = Mapper.Map<EducadorViewModel, Educador>(educador);
                _educadorApp.Add(educadorDomain);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Educador/Edit/5
        public ActionResult Edit(int id)
        {
            var educador = _educadorApp.GetById(id);
            var educadorViewModel = Mapper.Map<Educador, EducadorViewModel>(educador);

            return View(educadorViewModel);
        }

        // POST: Educador/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EducadorViewModel educador)
        {
            if (ModelState.IsValid)
            {
                var educadorDomain = Mapper.Map<EducadorViewModel, Educador>(educador);
                _educadorApp.Update(educadorDomain);

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Educador/Delete/5
        public ActionResult Delete(int id)
        {
            var educador = _educadorApp.GetById(id);
            var educadorViewModel = Mapper.Map<Educador, EducadorViewModel>(educador);

            return View(educadorViewModel);
        }

        // POST: Educador/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var educador = _educadorApp.GetById(id);
            _educadorApp.Remove(educador);

            return RedirectToAction("Index");
        }
    }
}
