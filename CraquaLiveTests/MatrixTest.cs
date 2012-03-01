using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using bc.flash.geom;

namespace CraquaLiveTests
{
    [TestFixture]
    public class MatrixTest
    {
        [Test]
        public void TranslateTest()
        {
            AsMatrix matrix = new AsMatrix();
            matrix.translate(100, 200);

            Assert.AreEqual(matrix.tx == 100 && matrix.ty == 200, true);
        }
    }
}
