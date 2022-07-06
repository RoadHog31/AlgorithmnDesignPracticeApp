using AlgorithmnDesignPracticeApp.Data;
using AlgorithmnDesignPracticeApp.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AlgorithmnDesignPracticeApp.Controllers
{
    /// <summary>
    ///  An entity with a foreign key is the child or dependent entity in the relationship. 
    ///  This entity's foreign key value must match the primary key value (or an alternate key value) of the related principal/parent entity.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAlgorithmnDesignAppRepository algorithmnDesignAppRepository;
        private readonly IMapper mapper;

        public HomeController(ILogger<HomeController> logger, IAlgorithmnDesignAppRepository algorithmnDesignAppRepository, IMapper mapper)
        {
            _logger = logger;
            this.algorithmnDesignAppRepository = algorithmnDesignAppRepository;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    
}
