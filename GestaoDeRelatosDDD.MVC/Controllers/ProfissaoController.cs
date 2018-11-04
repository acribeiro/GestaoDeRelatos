
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.MVC.ViewModels;

namespace GestaoDeRelatosDDD.MVC.Controllers
{
    public class ProfissaoController : Controller
    {
        private readonly IProfissaoAppService _profissaoApp;

        public ProfissaoController(IProfissaoAppService profissaoApp)
        {
            _profissaoApp = profissaoApp;
        }

        // GET: Profissao
        public ActionResult Index()
        {
            var profissaoViewModel = Mapper.Map<IEnumerable<Profissao>, IEnumerable<ProfissaoViewModel>>(_profissaoApp.GetAll());
            return View(profissaoViewModel);
        }

        // GET: Profissao/Details/5
        public ActionResult Details(int id)
        {
            var profissao = _profissaoApp.GetById(id);
            var profissaoViewModel = Mapper.Map<Profissao, ProfissaoViewModel>(profissao);
            return View(profissaoViewModel);
        }

        // GET: Profissao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profissao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProfissaoViewModel profissao)
        {
            if (ModelState.IsValid)
            {
                var profissaoDomain = Mapper.Map<ProfissaoViewModel, Profissao>(profissao);
                _profissaoApp.Add(profissaoDomain);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Profissao/Edit/5
        public ActionResult Edit(int id)
        {
            var profissao = _profissaoApp.GetById(id);
            var profissaoViewModel = Mapper.Map<Profissao, ProfissaoViewModel>(profissao);
            return View(profissaoViewModel);
        }

        // POST: Profissao/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProfissaoViewModel profissao)
        {
            if (ModelState.IsValid)
            {
                var profissaoDomain = Mapper.Map<ProfissaoViewModel, Profissao>(profissao);
                _profissaoApp.Update(profissaoDomain);

                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Profissao/Delete/5
        public ActionResult Delete(int id)
        {
            var profissao = _profissaoApp.GetById(id);
            var profissaoViewModel = Mapper.Map<Profissao, ProfissaoViewModel>(profissao);
            return View(profissaoViewModel);
        }

        // POST: Profissao/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var profissao = _profissaoApp.GetById(id);
            _profissaoApp.Remove(profissao);

            return RedirectToAction("Index");
        }
    }
}
