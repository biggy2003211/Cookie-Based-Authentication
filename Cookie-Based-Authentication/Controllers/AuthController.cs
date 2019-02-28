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

        string userData = "";

        /// <summary>
        /// 登入
        /// </summary>
        /// <param name="model">The model.</param>
        /// <exception cref="System.Exception">登入失敗，帳號或密碼錯誤</exception>
        [HttpPost]
        [Route("signIn")]
        public void SignIn(SignInViewModel model)
        {
            // 使用 sha256 雜湊加密
            sha256 _sha256 = new sha256();
            model.Password = _sha256.Encryption_sha256(model.Password);

            // 未雜湊加密前明碼: 123
            if (ValidateLogin(model))
            {
                var user = new User
                {
                    Id = 1,
                    UserId = "abc",
                    UserName = "小明",
                    roles = userData
                };
                _authManager.SignIn(user);
            }
            else
            {
                throw new Exception("登入失敗，帳號或密碼錯誤");
            }
        }

        /// <summary>
        /// 登出
        /// </summary>
        [HttpPost]
        [Route("signOut")]
        public void SignOut()
        {
            _authManager.SignOut();
        }

        /// <summary>
        /// 測試是否通過驗證
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is authenticated; otherwise, <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// 驗證使用者是否登入成功
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        private bool ValidateLogin(SignInViewModel model)
        {
            // 驗證
            if (!(model.UserId == "abc" && model.Password == "pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM="))
            {
                return false;
            }

            // 授權：設定角色到 userData 
            userData = "gold_member,board_admin";

            return true;
        }
    }
}
