using AutoMapper;
using Core.Domain.Entities;
using Core.Infra.Data.Context;
using Core.Infra.Data.Repositories;
using Core.MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Core.MVC.Controllers
{
    public class RolesController : Controller
    {
        private readonly RoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public RolesController(CoreContext context, IMapper mapper)
        {
            _roleRepository = new RoleRepository(context);
            _mapper = mapper;
        }

        // GET: Role
        public ActionResult Index()
        {
            var roleViewModel = _mapper.Map<IEnumerable<RoleViewModel>>(_roleRepository.GetAll());
            return View(roleViewModel);
        }

        // GET: Role/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Role/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Role/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RoleViewModel role)
        {
            if (ModelState.IsValid)
            {
                var roleDomain = _mapper.Map<RoleViewModel, Role>(role);
                _roleRepository.Add(roleDomain);
                _roleRepository.Save();

                return RedirectToAction("Index");
            }

            return View(role);
        }

        // GET: Role/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Role/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Role/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Role/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}