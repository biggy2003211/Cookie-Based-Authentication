using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cookie_Based_Authentication.ViewModel
{
    // ViewModel 的功能是接收前端傳回的資料，或回傳資料給前端，作為內部和外部溝通的橋樑。
    public class SignInViewModel
    {
        //帳號
        public string UserId { get; set; }
        //密碼
        public string Password { get; set; }
    }
}