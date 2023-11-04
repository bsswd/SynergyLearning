using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        string query1 = "1 5 7 9 100 23 954 231";
        string query2 = "9 233 91 472 9123 854";

        int[] array1 = { 5, 6, 1, 2, 3, 100};
        int[] array2 = { 819, 6, 1, 2, 3, 100 };
        int[] array3 = { -819, 6, 1, -2, 3, -100 };

        string[] array4 = { "1", "2", "3" };


        [TestMethod]
        public void TestFindMax()
        {
            Assert.AreEqual(Linq.Program.FindMax(query1), Example.FindMax(query1));
            Assert.AreEqual(Linq.Program.FindMax(query2), Example.FindMax(query2));
        }

        [TestMethod]

        public void TestWhere()
        {
            var enumerable1 = array1.Where(x => x > 5);
            var enumerable2 = Extensions.LinqExtensions.Where(array1, x=> x > 5);

            var e1 = enumerable1.GetEnumerator();
            var e2 = enumerable2.GetEnumerator();

            if (enumerable1.ToArray().Length != enumerable2.ToArray().Length)
                throw new AssertFailedException();

            while (e1.MoveNext() && e2.MoveNext())
            {
                if (e1.Current != e2.Current)
                    throw new AssertFailedException();
            }
        }
    }
}
