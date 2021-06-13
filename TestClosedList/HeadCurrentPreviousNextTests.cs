using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestClosedList.TestHelper;

namespace TestClosedList
{
    [TestClass]
    public class HeadCurrentPreviousNextTests
    {
        [TestMethod]
        public void AddTenItems_And_HeadTest()
        {
            var list = CreateListAndAddTenItems();

            var result = list.Head;

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void AddTenItems_And_CurrentTest()
        {
            var list = CreateListAndAddTenItems();

            var result = list.Current;

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void AddTenItems_And_PreviousTest()
        {
            var list = CreateListAndAddTenItems();

            var result = list.Previous;

            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void AddTenItems_And_NextTest()
        {
            var list = CreateListAndAddTenItems();

            var result = list.Next;

            Assert.AreEqual(1, result);
        }
    }
}
