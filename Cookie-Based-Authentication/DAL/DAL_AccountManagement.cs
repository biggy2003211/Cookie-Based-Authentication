using Cookie_Based_Authentication.Models;
using Cookie_Based_Authentication.ViewModel;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Cookie_Based_Authentication.DAL
{
    public class DAL_AccountManagement
    {
        public string cnstr;
        public DAL_AccountManagement()
        {
            cnstr = ConfigurationManager.ConnectionStrings["DemoAuthentication"].ConnectionString;
        }

        public List<User> SignIn(SignInViewModel Parameter)
        {
            List<User> d = new List<User>();
            using (var cn = new SqlConnection(cnstr))
            {
                cn.Open();
                var spParams = new DynamicParameters();
                spParams.Add("UserId", Parameter.UserId, DbType.String, ParameterDirection.Input);
                spParams.Add("Password", Parameter.Password, DbType.String, ParameterDirection.Input);
                var data = cn.Query<User>("sp_select_User", spParams, commandType: CommandType.StoredProcedure);
                d = data.ToList();
            }
            return d;
        }
    }
}