using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreBlog.core.repository;
using AspCoreBlog.Data.Models;
using AspCoreBlog.ModelsViews;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BlogController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: Blog
        public ActionResult Index()
        {
            var data =    _mapper.Map<List<Blog>, List<BlogViewModel>>(_unitOfWork.Blog.GetAll().ToList());
            return View(data);
        }

        // GET: Blog/Details/5
        public ActionResult Details(int id)
        {
            var data = _mapper.Map<Blog, BlogViewModel>(_unitOfWork.Blog.GetById(id));
            return View(data);
        }

        // GET: Blog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BlogViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)

                {
                    return View();

                }
                var data = _mapper.Map<BlogViewModel, Blog>(model);
                _unitOfWork.Blog.Add(data);
                _unitOfWork.SaveChanges();

                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: Blog/Edit/5
        public ActionResult Edit(int id)
        {
            var data = _mapper.Map<Blog, BlogViewModel>(_unitOfWork.Blog.GetById(id));
            return View(data);
        }

        // POST: Blog/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BlogViewModel model)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)

                {
                    return View();

                }
                var data = _mapper.Map<BlogViewModel, Blog>(model);
                _unitOfWork.Blog.Update(data);
                _unitOfWork.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Blog/Delete/5
        public ActionResult Delete(int id)
        {
            var data = _mapper.Map<Blog, BlogViewModel>(_unitOfWork.Blog.GetById(id));
            return View(data);
        }

        // POST: Blog/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                //TODO: need to handel dependencies 
                _unitOfWork.Blog.Delete(id);
                _unitOfWork.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}