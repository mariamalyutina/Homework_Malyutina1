using NUnit.Framework;

namespace Homeworks_Malyutina.Tests
{
    class TwoDArraysTests
    {
        [TestCase(2, -5)]
        [TestCase(3, 0)]
        [TestCase(4, 0)]
        public static void Task1Test(int mockNum, int expected)
        {
            int[,] array = TwoDArrayMock.GetMock(mockNum); //массив передается не в качестве параметра теста, а создается внутри него

            int actual = TwoDArrays.Task1(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        public static void Task1_WhenArrayIsEmpty_ArgException(int mockNum)
        {
            int[,] array = TwoDArrayMock.GetMock(mockNum); 

            try
            {
                TwoDArrays.Task1(array);
            } catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(2, 18)]
        [TestCase(3, 5)]
        [TestCase(4, 0)]
        public static void Task2Test(int mockNum, int expected)
        {
            int[,] array = TwoDArrayMock.GetMock(mockNum); 

            int actual = TwoDArrays.Task2(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        public static void Task2_WhenArrayIsEmpty_ArgException(int mockNum)
        {
            int[,] array = TwoDArrayMock.GetMock(mockNum); 
            try
            {
                TwoDArrays.Task2(array);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(2, new int[] { 1, 0})]
        [TestCase(3, new int[] { 2, 0 })]
        [TestCase(4, new int[] { 0, 0 })]
        [TestCase(8, new int[] { 0, 2 })]
        public static void Task3Test(int mockNum, int [] expected)
        {
            int[,] array = TwoDArrayMock.GetMock(mockNum);

            int[] actual = TwoDArrays.Task3(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        public static void Task3_WhenArrayIsEmpty_ArgException(int mockNum)
        {
            int[,] array = TwoDArrayMock.GetMock(mockNum);
            try
            {
                TwoDArrays.Task3(array);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(2, new int[] { 2, 2 })]
        [TestCase(3, new int[] { 1, 0 })]
        [TestCase(4, new int[] { 0, 0 })]
        [TestCase(8, new int[] { 0, 1 })]
        public static void Task4Test(int mockNum, int[] expected)
        {
            int[,] array = TwoDArrayMock.GetMock(mockNum);

            int[] actual = TwoDArrays.Task4(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        public static void Task4_WhenArrayIsEmpty_ArgException(int mockNum)
        {
            int[,] array = TwoDArrayMock.GetMock(mockNum);
            try
            {
                TwoDArrays.Task4(array);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, 0)]
        [TestCase(2, 2)]
        [TestCase(3, 1)]
        [TestCase(4, 0)]
        [TestCase(5, 2)]
        [TestCase(6, 1)]
        [TestCase(7, 2)]
        [TestCase(8, 1)]
        public static void Task5Test(int mockNum, int expected)
        {
            int[,] array = TwoDArrayMock.GetMock(mockNum);

            int actual = TwoDArrays.Task5(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 7)]
        [TestCase(3, 8)]
        [TestCase(8, 9)]
        [TestCase(5, 10)]
        public static void Task6Test(int testMockNum, int expectedMockNum)
        {
            int[,] array = TwoDArrayMock.GetMock(testMockNum);

            int[,] actual = TwoDArrays.Task6(array);

            int[,] expected = TwoDArrayMock.GetMock(expectedMockNum);


            Assert.AreEqual(expected, actual);
        }
    }
}
