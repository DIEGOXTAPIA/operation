using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Addition.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionController : ControllerBase
    {

        [HttpGet]
        [Route("Add")]
        public int Add(int numa, int numb)
        {
        return (numa + numb);
        }
        [HttpGet]
        [Route("Mult")]

        public int Mult(int numa, int numb)
        {
            return (numa * numb);
        }
        [HttpGet]
        [Route("Resta")]

        public int Resta(int numa, int numb)
        {
            return (numa - numb);
        }
        [HttpGet]
        [Route("Div")]

        public int Div(int numa, int numb)
        {
            return (numa / numb);
        }


    }
}
