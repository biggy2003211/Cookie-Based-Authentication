using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cookie_Based_Authentication.Controllers
{
    [RoutePrefix("api/Default")]
    public class DefaultController : ApiController
    {
        [HttpGet]
        [Route("verification")]
        [Authorize(Roles = "board_admin")]
        public string verification()
        {
            return "value";
        }

    }
}
