using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgricultureSite.App.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            var imageList = _imageService.GetAll();
            return View(imageList);
        }

        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddImage(Image image)
        {
            ImageValidator validator = new();
            ValidationResult result = validator.Validate(image);
            if (result.IsValid)
            {
                _imageService.Insert(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteImage(int id)
        {
            var deletedId = _imageService.GetById(id);
            return View(deletedId);
        }

        [HttpGet]
        public IActionResult EditImage(int id)
        {
            var imageId = _imageService.GetById(id);
            return View(imageId);
        }

        [HttpPost]
        public IActionResult EditImage(Image image)
        {
            ImageValidator validator = new();
            ValidationResult result = validator.Validate(image);
            if (result.IsValid)
            {
                _imageService.Update(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
