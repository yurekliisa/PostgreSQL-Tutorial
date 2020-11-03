using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_ORM.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_ORM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
       private readonly ILogger<CategoryController> _logger;
        private readonly EfContext _context;
        public CategoryController(
            ILogger<CategoryController> logger,
            EfContext context
            )
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.Categories.ToList();
            return Ok(result);
        }
    }
}
