using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Services.Models;

namespace Services.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SwimDataController : ControllerBase
    { 

        [HttpGet]
        public string GetData(string longitude,string latitude)
        {
            SwimDataStrategy swimData = new SwimDataStrategy();
            Dictionary<string,string> data = new Dictionary<string, string> (); 
            return swimData.GetData(data);
        }

    }
}