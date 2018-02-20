using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinnerDataAccess
{
    using System.Configuration;

    public static class DBConnection
    {
        /// <summary>
        /// GetConnection
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetConnection(string name)
        {
            var conn = "";
            try
            {
                conn = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }
            catch (Exception ex)
            {
                conn = "";
            }
            return conn;
        }

        /// <summary>
        /// GetDefaultConnection
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultConnection()
        {
            var conn = "";
            try
            {
                conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            }
            catch(Exception ex)
            {
                conn = "";
            }
            return conn;
        }
    }
}
