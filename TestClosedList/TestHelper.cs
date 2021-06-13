using ClosedListLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClosedList
{
    public static class TestHelper
    {
        public static ClosedList<int> CreateListAndAddTenItems()
        {
            ClosedList<int> list = new ClosedList<int>();
            for (int i = 0; i < 10; i++)
                list.Add(i);
            return list;
        }

        public static void AssertHeadCurrentPreviousNext(ClosedList<int> list,int head, int current, int previous, int next)
        {
            Assert.AreEqual(head, list.Head);
            Assert.AreEqual(current, list.Current);
            Assert.AreEqual(previous, list.Previous);
            Assert.AreEqual(next, list.Next);
        }
    }
}
