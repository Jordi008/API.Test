using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Tests.Models;

namespace API.Tests.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {

        [HttpGet]
        public string Get()
        {
            string message = "API running...";
            return message;
        }

        // POST: Test/DescripcionJuguete
        [HttpPost]
        [Route("Write")]
        public Response Write(DescriptionModel req)
        {
            Response response = new Response { response = "Lo que mandaste fue: " + req.description};
            return  response;
        }


    }
}