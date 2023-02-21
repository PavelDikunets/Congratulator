using AutoMapper;
using Congratulator.Db;
using Congratulator.Models;
using Congratulator.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Congratulator.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonsDbRepository _personsDbRepository;
        private readonly IMapper _mapper;

        public HomeController(IPersonsDbRepository personsDbRepository, IMapper mapper)
        {
            _personsDbRepository = personsDbRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var persons = await _personsDbRepository.GetAllAsync();

            var model = _mapper.Map<List<PersonViewModel>>(persons);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}