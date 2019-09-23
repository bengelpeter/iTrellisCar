using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using iTrellisCar.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json.Linq;

namespace iTrellisCar.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {

        private readonly IHostingEnvironment _env;
     
        public SampleDataController(IHostingEnvironment env)
        {
            _env = env;
        }
        /// <summary>
        /// Gets the cars from a Json file and returns a list of cars using a Model.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="hasSunroof"></param>
        /// <param name="isFourWheelDrive"></param>
        /// <param name="hasLowMiles"></param>
        /// <param name="hasPowerWindows"></param>
        /// <param name="hasNavigation"></param>
        /// <param name="hasHeatedSeats"></param>
        /// <returns></returns>
        [HttpGet("[action]")]
        public IActionResult ReturnCar(string color = null, string hasSunroof = null
            , string isFourWheelDrive = null, string hasLowMiles = null, string hasPowerWindows = null
            , string hasNavigation = null, string hasHeatedSeats = null)
        {

            try
            {
                string webRootPath = _env.WebRootPath;
                var json = "";
                //Gets the Json File From wwwroot
                using (StreamReader r = new StreamReader(webRootPath + "\\CarJson.json"))
                {
                     json = r.ReadToEnd();
                }


                //Turn Json into Array
                JArray jsonArray = JArray.Parse(json);
                //Car List Model
                var cars = jsonArray.ToObject<List<Car>>();

                //Filter clauses
                if (color != null && color != "All")
                {
                    cars = cars.Where(r => r.color == color).ToList();
                }
                if (hasSunroof != null && hasSunroof != "All")
                {
                    cars = cars.Where(r => r.hasSunroof == (hasSunroof == "Yes" ? true : false)).ToList();
                }
                if (isFourWheelDrive != null && isFourWheelDrive != "All")
                {
                    cars = cars.Where(r => r.isFourWheelDrive == (isFourWheelDrive == "Yes" ? true : false)).ToList();
                }
                if (hasLowMiles != null && hasLowMiles != "All")
                {
                    cars = cars.Where(r => r.hasLowMiles == (hasLowMiles == "Yes" ? true : false)).ToList();
                }
                if (hasPowerWindows != null && hasPowerWindows != "All")
                {
                    cars = cars.Where(r => r.hasPowerWindows == (hasPowerWindows == "Yes" ? true : false)).ToList();
                }
                if (hasNavigation != null && hasNavigation != "All")
                {
                    cars = cars.Where(r => r.hasNavigation == (hasNavigation == "Yes" ? true : false)).ToList();
                }
                if (hasHeatedSeats != null && hasHeatedSeats != "All")
                {
                    cars = cars.Where(r => r.hasHeatedSeats == (hasHeatedSeats == "Yes" ? true : false)).ToList();
                }

                
                return Ok(cars);
            }
            catch (Exception excError)
            {
                return StatusCode(500, $"Internal server error: {excError}");
            }


        }

    }

}
