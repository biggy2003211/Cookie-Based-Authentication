using Cookie_Based_Authentication.App_Start;
using Cookie_Based_Authentication.BLL;
using Cookie_Based_Authentication.Models;
using Cookie_Based_Authentication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cookie_Based_Authentication.Controllers
{
    [RoutePrefix("api/auth")]
    public class AuthController : ApiController
    {
        private AuthManager _authManager;
        public AuthController()
        {
            _authManager = new AuthManager();
        }

        //登入
        [HttpPost]
        [Route("signIn")]
        public void SignIn(SignInViewModel model)
        {
            //模擬從資料庫取得資料
            sha256 _sha256 = new sha256();
            model.Password = _sha256.Encryption_sha256(model.Password);
            // 未雜湊加密前明碼: 123
            if (!(model.UserId == "abc" && model.Password == "pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM="))
            {
                throw new Exception("登入失敗，帳號或密碼錯誤");
            }

            var user = new User
            {
                Id = 1,
                UserId = "abc",
                UserName = "小明",
                Identity = Identity.User
            };
            _authManager.SignIn(user);
        }

        //登出
        [HttpPost]
        [Route("signOut")]
        public void SignOut()
        {
            _authManager.SignOut();
        }

        //測試是否通過驗證
        [HttpPost]
        [Route("isAuthenticated")]
        public bool IsAuthenticated()
        {
            var user = _authManager.GetUser();
            if (user == null)
            {
                return false;
            }
            return true;
        }
    }
}
