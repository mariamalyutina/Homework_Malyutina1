using NUnit.Framework;
using System;

namespace Homeworks_Malyutina.Tests
{
    public class VariablesTests
    {
        [TestCase(2, 3, 19)]
        [TestCase(-2, -3, 1)]
        [TestCase(-2, 3, -0.2)]
        [TestCase(3, 12, 17.66)]

        public void Task1_WhenBISNotEqualA_Solved(int a, int b, double expected)
        {
            double actual = Variables.Task1(a, b);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestCase(12, 12)]

        public void Task1_WhenBISEqualA_ArgumentException(int a, int b)
        {
            try
            {
                Variables.Task1(a, b);
            } catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(2, 3, 3, 2)]
        [TestCase(-2, -3, -3, -2)]
        [TestCase(0, 0, 0, 0)]

        public void Task2Test(int a, int b, int expectedA, int expectedB)
        {
            Variables.Task2(ref a, ref b);

            int actualA = a;
            int actualB = b;

            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }


        [TestCase(10, 11, new double [] {0.91, 10 })]
        [TestCase(10, 2, new double [] {5, 0})]
        [TestCase(5, 2, new double [] {2.5, 1})]
        [TestCase(-5, -2, new double[] {2.5, -1 })]

        public void Task3Test(int a, int b, double [] expected)
        {
            double [] actual = Variables.Task3(a, b);

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.01);
            }
        }

        [TestCase(12, 0)]

        public void Task3_WhenBEqualsZero_DivideByZeroException(int a, int b)
        {
            //try
            //{
            //    Variables.Task3(a, b);
            //}
            //catch
            //{
            //    Assert.Pass();
            //}
            //Assert.Fail();

            Assert.Throws<DivideByZeroException>(()=> Variables.Task3(a, b)); //лямбда выражение
        }

        [TestCase(2, 0, 0, 0)]
        [TestCase(3, 2, 3, 0.33)]
        [TestCase(-1, -9, -5, -4)]

        public void Task4Test(int a, int b, int c, double expected)
        {
            double actual = Variables.Task4(a, b, c);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestCase(0, 1, 3)]

        public void Task4_WhenAEqualsZero_ArgumentException(int a, int b, int c)
        {
            try
            {
                Variables.Task4(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();

        }

        [TestCase(0, 2, 1, 0, "Уравнение прямой: У = -2*X + 2")]
        [TestCase(1, 0, -1, 0, "Уравнение прямой: У = -0*X + 0")] //почему-то возвращает -0 (если 0 делится на отриц число)
        [TestCase(1, 1, -1, -1, "Уравнение прямой: У = 1*X + 0")]

        public void Task5Test(double x1, double y1, double x2, double y2, string expected)
        {
            string actual = Variables.Task5(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, 0, 5)]
        [TestCase(5, 1, 5, 1)]

        public void Task5NegativeTest(double x1, double y1, double x2, double y2)
        {
            try
            {
                Variables.Task5(x1, y1, x2, y2);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();

        }
    }
}