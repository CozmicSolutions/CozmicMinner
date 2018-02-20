using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozmicMinnerSetup
{
    using System.IO;

    using MinnerDataAccess;

    using SqlDataAccess;

    public static class ResetTableData
    {
      
        public static bool ResetServerTable()
        {
            try
            {
                var script = SqlScriptFile.GetScriptFileContent(SqlScriptFile.GetResetServerScriptPath());
                DBExec.ExecBatchSql(DBConnection.GetDefaultConnection(), script);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }

    public static class SqlScriptFile
    {
        static string resetServerFileName = "ResetServerData.sql";

        public static string GetScriptFileContent(string fileFullPath)
        {
            if (File.Exists(fileFullPath))
            {
                return File.ReadAllText(fileFullPath);
            }
            return string.Empty;
        }


        /// <summary>
        /// GetScriptFolderPath
        /// </summary>
        /// <returns></returns>
        public static string GetScriptFolderPath()
        {
            
            return Environment.CurrentDirectory.Replace(@"\bin", "").Replace(@"\debug", "").Replace(@"\Debug", "") + @"\Scripts\";

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetResetServerScriptPath()
        {
            return GetScriptFolderPath() + resetServerFileName;
        }

        /// <summary>
        /// GetScriptFileFullPath
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string GetScriptFileFullPath(string fileName)
        {
            if (!fileName.EndsWith(".sql")) fileName = fileName + @".sql";
            return GetScriptFolderPath() + fileName;
        }

    }
}
