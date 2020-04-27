using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testprojectaspnetcore3_1.Data;
using testprojectaspnetcore3_1.Models;
using testprojectaspnetcore3_1.Service;

namespace testprojectaspnetcore3_1.Controllers
{
    public class KalaController : Controller
    {
        private readonly IkalaRepositroy _repo;

        private readonly IMapper _mapper;

        public KalaController(IkalaRepositroy repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET: Kala
        public ActionResult Index()
        {
            var kala = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Kala>,List<DetailsKalaViewModel>>(kala);

            return View(model);
        }

        // GET: Kala/Details/5
        public ActionResult Details(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }

            var kala = _repo.FindById(id);
            var model = _mapper.Map<DetailsKalaViewModel>(kala);

            return View(model);

      
        }

        // GET: Kala/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kala/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateKalaViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var kala = _mapper.Map<Kala>(model);
                var isSuccess = _repo.Create(kala);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "در ثبت اطلاعات مشکلی بوجود امده است.");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "در ثبت اطلاعات مشکلی بوجود امده است.");
                return View(model);
            }
        }

        // GET: Kala/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }

            var kala = _repo.FindById(id);
            var model = _mapper.Map<DetailsKalaViewModel>(kala);

            return View(model);
        }

        // POST: Kala/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, DetailsKalaViewModel model)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var kala = _mapper.Map<Kala>(model);
                var isSuccess = _repo.Update(kala);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "در ویرایش اطلاعات مشکلی بوجود امده است.");
                    return View(model);
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "در ویرایش اطلاعات مشکلی بوجود امده است.");
                return View(model);
            }
        }

        // GET: Kala/Delete/5
        public ActionResult Delete(int id)
        {
            //if (!_repo.isExists(id))
            //{
            //    return NotFound();
            //}

            //var kala = _repo.FindById(id);
            //var model = _mapper.Map<DetailsKalaViewModel>(kala);

            //return View(model);

            var kala = _repo.FindById(id);
            var isSuccess = _repo.Delete(kala);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));

        }

        //// POST: Kala/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, DetailsKalaViewModel model)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here
        //        var kala = _repo.FindById(id);
        //        var isSuccess = _repo.Delete(kala);
        //        if (!isSuccess)
        //        {
        //            return View(model);
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View(model);
        //    }
        //}
    }
}