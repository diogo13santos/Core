using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Core.Domain.Entities;
using Core.Infra.Data.Context;
using Core.Infra.Data.Repositories;
using Core.MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(CoreContext context, IMapper mapper)
        {
            _userRepository = new UserRepository(context);
            _mapper = mapper;
        }
        
        // GET: User
        public ActionResult Index()
        {
            var userViewModel = _mapper.Map<IEnumerable<UserViewModel>>(_userRepository.GetAll());
            return View(userViewModel);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                var userDomain = _mapper.Map<UserViewModel, User>(user);
                _userRepository.Add(userDomain);
                _userRepository.Save();

                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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