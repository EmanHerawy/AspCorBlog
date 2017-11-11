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

namespace AspCorePost.Controllers
{
    public class PostController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PostController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: Post
        public ActionResult Index()
        {
            var data = _mapper.Map<List<Post>, List<PostViewModel>>(_unitOfWork.Post.GetAll().ToList());
            return View(data);
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            var data = _mapper.Map<Post, PostViewModel>(_unitOfWork.Post.GetById(id));
            return View(data);
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PostViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)

                {
                    return View();

                }
                var data = _mapper.Map<PostViewModel, Post>(model);
                _unitOfWork.Post.Add(data);
                _unitOfWork.SaveChanges();

                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            var data = _mapper.Map<Post, PostViewModel>(_unitOfWork.Post.GetById(id));
            return View(data);
        }

        // POST: Post/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PostViewModel model)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)

                {
                    return View();

                }
                var data = _mapper.Map<PostViewModel, Post>(model);
                _unitOfWork.Post.Update(data);
                _unitOfWork.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            var data = _mapper.Map<Post, PostViewModel>(_unitOfWork.Post.GetById(id));
            return View(data);
        }

        // POST: Post/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                //TODO: need to handel dependencies 
                _unitOfWork.Post.Delete(id);
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