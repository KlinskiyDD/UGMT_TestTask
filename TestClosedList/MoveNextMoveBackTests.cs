using ClosedListLibrary;
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
    public class MoveNextMoveBackTests
    {
        [TestMethod]
        public void AddTenItemsAndTestHeadCurrentPreviousNext()
        {
            var list = CreateListAndAddTenItems();

            AssertHeadCurrentPreviousNext(list, 0, 0, 9, 1);
        }

        [TestMethod]
        public void AddTenItems_OneMoveNext_TestHeadCurrentPreviousNext()
        {
            var list = CreateListAndAddTenItems();

            list.MoveNext();

            AssertHeadCurrentPreviousNext(list, 0, 1, 0, 2);
        }
        [TestMethod]
        public void AddTenItems_TwoMoveNext_TestHeadCurrentPreviousNext()
        {
            var list = CreateListAndAddTenItems();

            list.MoveNext();
            list.MoveNext();

            AssertHeadCurrentPreviousNext(list,0,2,1,3);
        }
        [TestMethod]
        public void AddTenItems_OneMoveBack_TestHeadCurrentPreviousNext()
        {
            var list = CreateListAndAddTenItems();

            list.MoveBack();

            AssertHeadCurrentPreviousNext(list,0,9,8,0);
        }
        [TestMethod]
        public void AddTenItems_TwoMoveBack_TestHeadCurrentPreviousNext()
        {
            var list = CreateListAndAddTenItems();

            list.MoveBack();
            list.MoveBack();

            AssertHeadCurrentPreviousNext(list, 0,8,7,9);
        }
    }
}
