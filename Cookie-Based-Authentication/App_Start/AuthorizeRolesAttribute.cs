using Cookie_Based_Authentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Cookie_Based_Authentication.App_Start
{
    public class AuthorizeRolesAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// Custom attribute 實現透過列舉(Enum)方式達成管控權限機制
        /// </summary>
        /// <param name="allowedRoles">The allowed roles.</param>
        public AuthorizeRolesAttribute(params MyRoles[] allowedRoles)
        {
            var allowedRolesAsStrings = allowedRoles.Select(x => Enum.GetName(typeof(MyRoles), x));
            Roles = string.Join(",", allowedRolesAsStrings);
        }
    }
}