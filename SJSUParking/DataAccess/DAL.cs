﻿using SJSUParking.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SJSUParking.Controllers.DataAccess
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
            authenticated = sdr.HasRows;// if the table has rows with the required data then the login is authenticated
            conn.Close();
            return (authenticated);
        }
        public static UserModel UserProfile(string username)
        {
            string query = string.Format("Select * FROM Users Where SJSUId = '{0}' ", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            UserModel userInfo = new UserModel();
            sdr.Read();
            userInfo.SJSUId = sdr.GetString(0);
            userInfo.Email = sdr.GetString(2);
            userInfo.FirstName = sdr.GetString(3);
            userInfo.LastName = sdr.GetString(4);
            userInfo.Phone = sdr.GetString(5);
            userInfo.DrivingLicNo = sdr.GetString(6);
            conn.Close();
            return (userInfo);
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