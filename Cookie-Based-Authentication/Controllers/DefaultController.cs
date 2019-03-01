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
        /// <summary>
        /// 用於驗證有無實現權限控管機制
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("verification")]
        [Authorize(Roles = "admin")]
        public string verification()
        {
            return "value";
        }

    }
}
