using Cookie_Based_Authentication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Cookie_Based_Authentication.App_Start
{
    public class AuthManager
    {
        //登入
        public void SignIn(User user)
        {
            //新增表單驗證用的票證
            var ticket = new FormsAuthenticationTicket(
                //版本
                1,   
                //使用者名稱
                user.UserName,
                //發行時間
                DateTime.Now,
                //有效期限
                DateTime.Now.AddMinutes(60),
                //是否將 Cookie 設定成 Session Cookie，如果是則會在瀏覽器關閉後移除
                false,
                //將要記錄的使用者資訊轉換為 JSON 字串
                JsonConvert.SerializeObject(user),
                //儲存 Cookie 的路徑
                FormsAuthentication.FormsCookiePath);

            //將 Ticket 加密
            var encTicket = FormsAuthentication.Encrypt(ticket);

            //將 Ticket 寫入 Cookie
            HttpContext.Current.Response.Cookies.Add(
                new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
        }

        //登出
        public void SignOut()
        {
            //移除瀏覽器的表單驗證
            FormsAuthentication.SignOut();
        }

        //取得使用者資訊
        public User GetUser()
        {
            //取得 ASP.NET 使用者
            var user = HttpContext.Current.User;

            //是否通過驗證
            if (user?.Identity?.IsAuthenticated == true)
            {
                //取得 FormsIdentity
                var identity = (FormsIdentity)user.Identity;

                //取得 FormsAuthenticationTicket
                var ticket = identity.Ticket;

                //將 Ticket 內的 UserData 解析回 User 物件
                return JsonConvert.DeserializeObject<User>(ticket.UserData);
            }
            return null;
        }
    }
}