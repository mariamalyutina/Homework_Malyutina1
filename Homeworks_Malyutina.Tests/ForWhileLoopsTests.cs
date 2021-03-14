using NUnit.Framework;

namespace Homeworks_Malyutina.Tests
{
    class ForWhileLoopsTests
    {

        [TestCase(3, 0, 1)]
        [TestCase(0, 0, 1)]
        [TestCase(5, 1, 5)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]

        public void Task1Test(int a, int b, double expected)
        {
            double actual = ForWhileLoops.Task1(a, b);

            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestCase(100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        [TestCase(-250, new int[] { 250, 500, 750, 1000 })]
        [TestCase(1000, new int[] { 1000 })]

        public void Task2Test(int a, int[] expected)
        {
            int[] actual = ForWhileLoops.Task2(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]

        public void Task2_WhenAEqualsZero_ArgException(int a)
        {
            try
            {
                ForWhileLoops.Task2(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(20, 4)]
        [TestCase(1, 0)]
        [TestCase(100, 9)]

        public static void Task3Test(int a, int expected)
        {
            int actual = ForWhileLoops.Task3(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-20)]

        public static void Task3_WhenALessOrEqualsZero_ArgException(int a)
        {
            try
            {
                ForWhileLoops.Task3(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(20, 10)]
        [TestCase(2, 1)]
        [TestCase(-17, 1)]

        public static void Task4Test(int a, int expected)
        {
            int actual = ForWhileLoops.Task4(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        public static void Task4_WhenAEqualsOneOrZero_ArgException(int a)
        {
            try
            {
                ForWhileLoops.Task4(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(-20, 10, -14)]
        [TestCase(15, 50, 175)]
        [TestCase(0, 7, 7)]
        [TestCase(0, 0, 0)]

        public static void Task5Test(int a, int b, int expected)
        {
            int actual = ForWhileLoops.Task5(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(10, 55)]

        public static void Task6Test(int a, int expected)
        {
            int actual = ForWhileLoops.Task6(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-20)]
        public static void Task6_WhenALessOrEqualsZero_ArgException(int a)
        {
            try
            {
                ForWhileLoops.Task6(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(10, 500, 10)]
        [TestCase(8, 5, 1)]
        [TestCase(-30, 90, 30)]

        public static void Task7Test(int a, int b, int expected)
        {
            int actual = ForWhileLoops.Task7(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(0, 2)]
        [TestCase(8, 0)]

        public static void Task7_WhenAOrBEqualsZero_ArgException(int a, int b)
        {
            try
            {
                ForWhileLoops.Task7(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(50, 3.68)]
        [TestCase (27, 3)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]

        public static void Task8WithDeltaTest(int a, double expected)
        {
            double actual = ForWhileLoops.Task8WithDelta(a);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestCase(-2)]

        public static void Task8WithDelta_WhenALessThanZero_ArgException(int a)
        {
            try
            {
                ForWhileLoops.Task8WithDelta(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(10, 1)]
        [TestCase(356, 2)]
        [TestCase(333333, 6)]
        [TestCase(268, 0)]
        [TestCase(-3, 1)]

        public static void Task9Test(int a, int expected)
        {
            int actual = ForWhileLoops.Task9(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public static void Task9_WhenAEqualsZero_ArgException(int a)
        {
            try
            {
                ForWhileLoops.Task9(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, "1")]
        [TestCase(100, "001")]
        [TestCase(123, "321")]
        [TestCase(55, "55")]

        public static void Task10Test(int a, string expected)
        {
            string actual = ForWhileLoops.Task10(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public static void Task10_WhenAEqualsZero_ArgException(int a)
        {
            try
            {
                ForWhileLoops.Task10(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, new int[0])]
        [TestCase(3, new int[] { 2})]
        [TestCase(10, new int[] { 2, 4, 6, 8})]
        [TestCase(30, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28 })]

        public static void Task11Test(int a, int[] expected)
        {
            int[] actual = ForWhileLoops.Task11(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-20)]
        [TestCase(0)]
        public static void Task11_WhenALessOrEqualsZero_ArgException(int a)
        {
            try
            {
                ForWhileLoops.Task11(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(0, 0, "ДА")]
        [TestCase(100, 11, "ДА")]
        [TestCase(123, 569, "НЕТ")]
        [TestCase(0, -100, "ДА")]
        [TestCase(202, 0, "ДА")]
        [TestCase(-123, -569, "НЕТ")]

        public static void Task12Test(int a, int b, string expected)
        {
            string actual = ForWhileLoops.Task12(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
