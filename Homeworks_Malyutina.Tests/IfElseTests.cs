using NUnit.Framework;

namespace Homeworks_Malyutina.Tests
{
    class IfElseTests
    {
        [TestCase(3, 0, 3)]
        [TestCase(5, 5, 25)]
        [TestCase(-2, 3, -5)]

        public void Task1Test(int a, int b, int expected)
        {
            int actual = IfElse.Task1(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 3, "I четверть")]
        [TestCase(-5, 5, "II четверть")]
        [TestCase(-2, -3, "III четверть")]
        [TestCase(10, -3, "IV четверть")]

        public void Task2Test(int a, int b, string expected)
        {
            string actual = IfElse.Task2(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]

        public void Task2_WhenXAndYEqualsZero_ArgException(int a, int b)
        {
            try
            {
                IfElse.Task2(a, b);
            } catch
            {
                Assert.Pass();
            }
            Assert.Fail();
            
        }

        [TestCase(-1, 0, 3, new int[] { -1, 0, 3})]
        [TestCase(100, -3, 1, new int[] { -3, 1, 100 })]
        [TestCase(0, 0, 0, new int[] { 0, 0, 0 })]
        [TestCase(9, 20, -8, new int[] { -8, 9, 20 })]
        [TestCase(-9, -20, -8, new int[] { -20, -9, -8 })]

        public void Task3Test(int a, int b, int c, int[] expected)
        {
            int[] actual = IfElse.Task3(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0, 0, new double[] { 0})]
        [TestCase(1, -8, 12, new double[] { 6, 2 })]
        [TestCase(-5, 4, 3, new double[] { -0.47, 1.27})]
        [TestCase(5, 3, 7, new double[0])]
        [TestCase(1, -6, 9, new double[] { 3})]

        public void Task4Test(int a, int b, int c, double[] expected)
        {
            double[] actual = IfElse.Task4(a, b, c);

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.01);
            }
        }

        [TestCase(0, -6, 9)]

        public void Task4_WhenAEqualsZero_ArgException(int a, int b, int c)
        {
            try
            {
                IfElse.Task4(a, b, c);
            } catch
            {
                Assert.Pass();
            }
            Assert.Fail();

            
        }

        [TestCase(30, "тридцать")]
        [TestCase(-15, "минус пятнадцать")]
        [TestCase(99, "девяносто девять")]
        [TestCase(19, "девятнадцать")]

        public void Task5Test(int a, string expected)
        {
            string actual = IfElse.Task5(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(7)]
        [TestCase(22252)]

        public void Task5_WhenNotDoubleDigitArgument_ArgException(int a)
        {
            try
            {
                IfElse.Task5(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();

        }
    }
}
