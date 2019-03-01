using Cookie_Based_Authentication.App_Start;
using Cookie_Based_Authentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cookie_Based_Authentication.Controllers
{
    [RoutePrefix("api/Verification")]
    public class VerificationController : ApiController
    {
        /// <summary>
        /// 用於驗證有無實現權限控管機制
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Admin")]
        [AuthorizeRolesAttribute(MyRoles.Admin)]
        public string verification_Admin()
        {
            return "You are Admin";
        }

        /// <summary>
        /// 用於驗證有無實現權限控管機制
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("VipMember")]
        [AuthorizeRolesAttribute(MyRoles.VipMember)]
        public string verification_User()
        {
            return "You are VipMember";
        }

        /// <summary>
        /// 用於驗證有無實現權限控管機制
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("VipMemberOrMember")]
        [AuthorizeRolesAttribute(MyRoles.VipMember, MyRoles.Member)]
        public string verification_Admin_or_Member()
        {
            return "You are VipMember or Member";
        }

    }
}
