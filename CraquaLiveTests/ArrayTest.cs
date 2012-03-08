using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using bc.flash;

namespace CraquaLiveTests
{
    [TestFixture]
    public class VectorTest
    {
        [Test]
        public void testSort()
        {
            AsVector<int> vector = new AsVector<int>();
            vector.push(3);
            vector.push(1);
            vector.push(4);
            vector.push(0);

            vector.sort(sorter);
            List<int> list = vector.internalList;
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Assert.AreEqual(vector[0] == 0 && vector[1] == 1 && vector[2] == 3 && vector[3] == 4, true);
        }

        private float sorter(int a, int b)
        {
            if (a < b)
            {
                return -1;
            }
            if (a > b)
            {
                return 1;
            }
            return 0;
        }
    }
}
