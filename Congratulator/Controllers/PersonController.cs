using AutoMapper;
using Congratulator.Db;
using Congratulator.Db.Models;
using Congratulator.WebApp.Helpers;
using Congratulator.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Congratulator.WebApp.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonsDbRepository _personsDbRepository;
        private readonly ImageProvider _imageProvider;
        private readonly IMapper _mapper;

        public PersonController(IPersonsDbRepository personsDbRepository, IMapper mapper, ImageProvider imageProvider)
        {
            _personsDbRepository = personsDbRepository;
            _mapper = mapper;
            _imageProvider = imageProvider;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var personDb = await _personsDbRepository.GetAllAsync();
            var model = _mapper.Map<List<PersonViewModel>>(personDb);
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(PersonViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Пожалуйста, заполните все поля!");
                return View(model);
            }

            var imagePath = _imageProvider.SaveFile(model.UploadedFile);
            if (imagePath != null)
            {
                model.ImagePath = imagePath;
            }
            var personDb = _mapper.Map<Person>(model);
            await _personsDbRepository.AddAsync(personDb);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> EditAsync(int Id)
        {
            var person = await _personsDbRepository.TryGetByIdAsync(Id);
            var model = _mapper.Map<PersonViewModel>(person);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(PersonViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Пожалуйста, заполните все поля!");
                return View(model);
            }

            var imagePath = _imageProvider.SaveFile(model.UploadedFile);
            if (imagePath != null)
            {
                model.ImagePath = imagePath;
            }

            var personDb = _mapper.Map<Person>(model);
            await _personsDbRepository.UpdateAsync(personDb);
            return RedirectToAction("Edit", "Person");
        }

        public async Task<IActionResult> RemoveAsync(int Id)
        {
            await _personsDbRepository.RemoveAsync(Id);
            return RedirectToAction("Index", "Home");
        }
    }
}
