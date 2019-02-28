using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cookie_Based_Authentication.Models
{
    public class User
    {
        //流水號
        public int Id { get; set; }
        //帳號
        public string UserId { get; set; }
        //名稱
        public string UserName { get; set; }
        //身分
        public string roles { get; set; }
    }
}