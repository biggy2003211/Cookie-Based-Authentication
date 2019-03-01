using Cookie_Based_Authentication.DAL;
using Cookie_Based_Authentication.Models;
using Cookie_Based_Authentication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cookie_Based_Authentication.BLL
{
    public class BLL_AccountManagement
    {
        public List<User> SignIn(SignInViewModel Parameter)
        {
            DAL_AccountManagement d = new DAL_AccountManagement();
            return d.SignIn(Parameter);
        }
    }
}