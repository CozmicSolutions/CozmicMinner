using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozmicMinner.Connection
{
    using System.IO;
    using System.Net;

   public static class ApiConnection
    {
        private static string EthPoolUrl = @"http://api.ethpool.org";


        /// <summary>
        /// Get
        /// </summary>
        /// <param name="address"></param>
        /// <param name="sParameters"></param>
        /// <returns></returns>
        public static StringBuilder Get(string address, string sParameters)
        {
            //XmlDocument xmlRet = new XmlDocument();
            var sb = new StringBuilder();

            var shost = "{0}/{1}";
            /*
            https://apibeta.parcelpro.com/<version>/auth
            */
            var url = string.Format(shost, address, sParameters);
            HttpWebRequest webRequest;

            try
            {
                webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "GET";


                webRequest.ContentType = "application/json; charset=utf-8";
            }
            catch (Exception ex)
            {
                return sb;
            }
            HttpWebResponse response;
            try
            {
                // execute the request
                response = (HttpWebResponse)
                    webRequest.GetResponse();
                //Log("You are now logged in to: " + _sServerAddress);
            }
            catch (WebException ex)
            {
                var text = new StringBuilder();
                if (ex.Response == null)
                    text.Append(ex.Message);
                else
                {
                    text.Append(string.Format("Error Code: {0}\n\r", (ex.Response as HttpWebResponse).StatusCode));
                    text.Append(string.Format("Error Desc: {0}\n\r", (ex.Response as HttpWebResponse).StatusDescription));
                }

               return sb;
            }


            // we will read data via the response stream
            Stream resStream;
            string tempString = null;
            var count = 0;

            try
            {
                resStream = response.GetResponseStream();
                // used on each read operation
                var buf = new byte[8192];
                do
                {
                    // fill the buffer with data
                    count = resStream.Read(buf, 0, buf.Length);

                    // make sure we read some data
                    if (count != 0)
                    {
                        // translate from bytes to ASCII text
                        tempString = Encoding.ASCII.GetString(buf, 0, count);

                        // continue building the string
                        sb.Append(tempString);
                    }
                } while (count > 0); // any more data to read?
            }
            catch (Exception ex)
            {
                return sb;
            }

            return sb;
        }
    }
}
