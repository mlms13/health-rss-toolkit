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
    ///This is a test class for RssToolkit.Rss.RssAggregationEventArgs and is intended
    ///to contain all RssToolkit.Rss.RssAggregationEventArgs Unit Tests
    ///</summary>
    [TestClass()]
    public class RssAggregationEventArgsTest
    {
        private TestContext testContextInstance;

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
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
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
        ///A test for Exception
        ///</summary>
        [TestMethod()]
        public void RssAggregationEventArgsExceptionTest()
        {
            RssAggregationEventArgs target = new RssAggregationEventArgs();
            Exception val = new Exception("Test");
            target.Exception = val;
            Assert.AreEqual(val.Message, target.Exception.Message, "RssToolkit.Rss.RssAggregationEventArgs.Exception was not set correctly.");
        }

        /// <summary>
        ///A test for Message
        ///</summary>
        [TestMethod()]
        public void RssAggregationEventArgsMessageTest()
        {
            RssAggregationEventArgs target = new RssAggregationEventArgs();
            string val = "Error Message Test";
            target.Message = val;
            Assert.AreEqual(val, target.Message, "RssToolkit.Rss.RssAggregationEventArgs.Message was not set correctly.");
        }

        /// <summary>
        ///A test for SeverityType
        ///</summary>
        [TestMethod()]
        public void RssAggregationEventArgsSeverityTypeTest()
        {
            RssAggregationEventArgs target = new RssAggregationEventArgs();
            RssSeverityType val = RssSeverityType.Error; 
            target.SeverityType = val;
            Assert.AreEqual(val, target.SeverityType, "RssToolkit.Rss.RssAggregationEventArgs.SeverityType was not set correctly.");
        }
    }
}
