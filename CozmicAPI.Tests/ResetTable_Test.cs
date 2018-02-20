using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CozmicAPI.Tests
{
    using System.IO;

    using CozmicMinnerSetup;

    [TestClass]
    public class ResetTable_Test
    {
        [TestMethod]
        public void  ResetServerTableData()
        {
            ResetTableData.ResetServerTable();
        }
    }
}
