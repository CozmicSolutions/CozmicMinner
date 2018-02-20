using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CozmicAPI.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Helpers;

    using CozmicMinner;
    using CozmicMinner.Classes;
    using CozmicMinner.Connection;

    using Newtonsoft.Json;

    [TestClass]
    public class ApiConnection_Test
    {
 
        [TestMethod]
        public void GetPool()
        {
            var creditList = ApiQuery.GetCredits();


        }
    }
}
