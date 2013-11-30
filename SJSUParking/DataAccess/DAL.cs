using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SJSUParking.Models.DataAccess
{
    public class DAL
    {
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLDBConnStr"].ToString());

        public static bool UserIsValid(string username, string password)
        {
            bool authenticated = false;
            string query = string.Format("Select * FROM Users Where SJSUId = '{0}' AND Password = '{1}' ", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            authenticated = sdr.HasRows;
            conn.Close();
            return (authenticated);
        }

        public static void CreateNewUser(UserModel usermodel)
        {
            string query = string.Format("Insert into Users (SJSUId, Password, Email, FirstName, LastName, Phone, DrivingLicNo,Type) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}')",
            usermodel.SJSUId, usermodel.Password, usermodel.Email, usermodel.FirstName, usermodel.LastName, usermodel.Phone, usermodel.DrivingLicNo,"Student");
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            conn.Close();
        }
    }
}