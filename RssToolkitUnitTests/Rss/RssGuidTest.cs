﻿// The following code was generated by Microsoft Visual Studio 2005.
// The test owner should check each test for validity.
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Collections.Generic;
using RssToolkit.Rss;
namespace RssToolkitUnitTest
{
    /// <summary>
    ///This is a test class for RssToolkit.Rss.RssGuid and is intended
    ///to contain all RssToolkit.Rss.RssGuid Unit Tests
    ///</summary>
    [TestClass()]
    public class RssGuidTest
    {
        private TestContext testContextInstance;
        private static RssDocument rss;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            rss = RssToolkitUnitTest.Utility.RssUtility.GetRssDocumentFromXml();
        }
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for IsPermaLink
        ///</summary>
        [TestMethod()]
        public void RssGuidIsPermaLinkTest()
        {
            Assert.AreEqual("false", rss.Channel.Items[0].Guid.IsPermaLink, "RssToolkit.Rss.RssGuid.IsPermaLink was not set correctly.");
        }

        /// <summary>
        ///A test for Text
        ///</summary>
        [TestMethod()]
        public void RssGuidTextTest()
        {
            Assert.AreEqual("ap/20070214/bush", rss.Channel.Items[0].Guid.Text, "RssToolkit.Rss.RssGuid.Text was not set correctly.");
        }
    }
}
