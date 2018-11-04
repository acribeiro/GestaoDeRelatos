
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.MVC.ViewModels;

namespace GestaoDeRelatosDDD.MVC.Controllers
{
    public class TurnoController : Controller
    {
        private readonly ITurnoAppService _turnoApp;

        public TurnoController(ITurnoAppService turnoApp)
        {
            _turnoApp = turnoApp;
        }

        // GET: Turno
        public ActionResult Index()
        {
            var tecnicoViewModel = Mapper.Map<IEnumerable<Turno>, IEnumerable<TurnoViewModel>>(_turnoApp.GetAll());
            return View(tecnicoViewModel);
        }

        // GET: Turno/Details/5
        public ActionResult Details(int id)
        {
            var turno = _turnoApp.GetById(id);
            var turnoViewModel = Mapper.Map<Turno, TurnoViewModel>(turno);
            return View(turnoViewModel);
        }

        // GET: Turno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Turno/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TurnoViewModel turno)
        {
            if (ModelState.IsValid)
            {
                var turnoDomain = Mapper.Map<TurnoViewModel, Turno>(turno);
                _turnoApp.Add(turnoDomain);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Turno/Edit/5
        public ActionResult Edit(int id)
        {
            var turno = _turnoApp.GetById(id);
            var turnoViewModel = Mapper.Map<Turno, TurnoViewModel>(turno);
            return View(turnoViewModel);
        }

        // POST: Turno/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TurnoViewModel turno)
        {
            if (ModelState.IsValid)
            {
                var turnoDomain = Mapper.Map<TurnoViewModel, Turno>(turno);
                _turnoApp.Update(turnoDomain);

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Turno/Delete/5
        public ActionResult Delete(int id)
        {
            var turno = _turnoApp.GetById(id);
            var turnoViewModel = Mapper.Map<Turno, TurnoViewModel>(turno);
            return View(turnoViewModel);
        }

        // POST: Turno/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var turno = _turnoApp.GetById(id);
            _turnoApp.Remove(turno);

            return RedirectToAction("Index");
        }
    }
}
