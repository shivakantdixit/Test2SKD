using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [Route("[action]/{name}")]
        [HttpGet]
        public EmployeeDetails Get(string name)
        {
            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails.Name = name;
            employeeDetails.City = "San Ramon";
            employeeDetails.Address = "2925 Sombrero Cir";
            employeeDetails.State = "CA";
            employeeDetails.Country = "USA";

            return employeeDetails;

        }

        [Route("[action]/{name}")]
        [HttpGet]
        public PersonDetails GetDetails(string name)
        {
            PersonDetails employeeDetails = new PersonDetails();
            employeeDetails.HusbandName = "Jay";
            employeeDetails.FirstMet = "Kerala";
            employeeDetails.Marriage = Convert.ToDateTime("01-01-2017") ;
            employeeDetails.Statement = "Joru ka gulam";
            employeeDetails.Secret = "google.com";

            //employeeDetails.HusbandName = "Jay";
            //employeeDetails.FirstMet = "Kerala";
            //employeeDetails.Marriage = Convert.ToDateTime("01-01-2017");
            //employeeDetails.Statement = "Joru ka gulam";
            //employeeDetails.Secret = "google.com";

            return employeeDetails;

        }
    }
}
