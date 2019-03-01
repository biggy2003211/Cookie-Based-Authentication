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
        /// 登入，伺服器將加密後帶有使用者資訊的 Cookie 寫回瀏覽器
        /// </summary>
        /// <param name="model">The model.</param>
        /// <exception cref="System.Exception">登入失敗，帳號或密碼錯誤</exception>
        [HttpPost]
        [Route("signIn")]
        public void SignIn(SignInViewModel model)
        {
            // 使用 sha256 雜湊加密
            BLL_sha256 _sha256 = new BLL_sha256();
            model.Password = _sha256.Encryption_sha256(model.Password);

            List<User> _User = CheckLogin(model);
            string roles = string.Empty;

            if ( _User.Count == 0)
            {
                throw new Exception("登入失敗，帳號或密碼錯誤");
            }
            else
            {
                roles = string.Join(",", _User.Select(c=>c.roles));
                var user = new User
                {
                    Id = _User.Select(c => c.Id).First(),
                    UserId = _User.Select(c => c.UserId).First(),
                    UserName = _User.Select(c => c.UserName).First(),
                    roles = roles
                };
                _authManager.SignIn(user);
            }
        }

        /// <summary>
        /// 登出，移除瀏覽器的表單驗證
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
        /// 檢查使用者帳號密碼是否正確
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        private List<User> CheckLogin(SignInViewModel model)
        {

            BLL_AccountManagement _BLL_AccountManagement = new BLL_AccountManagement();
            // 驗證
            List <User> _User = _BLL_AccountManagement.SignIn(model);

            return _User;
        }
    }
}
