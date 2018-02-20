using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozmicMinner.Classes
{
    public class ApiResponseArray
    {
        public string status { set; get; }
        public object[] data { set; get; }
    }

    public class ApiResponseObject
    {
        public string status { set; get; }
        public object data { set; get; }
    }
}
