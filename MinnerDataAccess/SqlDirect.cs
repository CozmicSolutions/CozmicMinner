using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinnerDataAccess
{
    using System.Data;

    using SqlDataAccess;

    public class SqlDirect
    {
        public static bool TryToDelete(string tableName, string field, object value)
        {
            try
            {
                DBExec.ExecuteNonQuery(DBConnection.GetDefaultConnection(), CommandType.Text, SqlScript.DeleteRecord(tableName, field, value));
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }

    public static class SqlScript
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DeleteRecord(string tableName, string field, object value)
        {
            var query = "DELETE FROM {0} WHERE {1} = '{2}'";
            return string.Format(query, tableName , field, value);
        }

    }
}
