using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper_ORM.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace Dapper_ORM.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly string connectionString = "Server=localhost;Port=5432;Database=DapperDb;User Id=yurekliisa;Password=123qwe;";
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var result = connection.Query<Student>("SELECT * FROM Student;");
                return Ok(result);
            }

            return BadRequest();
        }
    }
}
