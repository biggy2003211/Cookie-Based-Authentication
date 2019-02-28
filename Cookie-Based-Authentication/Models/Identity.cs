using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Cookie_Based_Authentication.Models
{
    public enum Identity
    {
        [Description("管理者")]
        Admin = 1,

        [Description("一般使用者")]
        User = 2,
    }
}