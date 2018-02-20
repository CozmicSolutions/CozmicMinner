using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CozmicAPI.Tests
{
    using System.IO;

    using CozmicMinnerSetup;

    [TestClass]
    public class WebBrowser_Test
    {
        [TestMethod]
        public void  ShowForm()
        {
            WebBrowserForm_Test dialog = new WebBrowserForm_Test();
            dialog.ShowDialog();

        }
    }
}
