using NUnit.Framework;

namespace Homeworks_Malyutina.Tests
{
    class ArraysTests
    {
        [TestCase(new int[] { 25, 3, -1, 0, -888, 20 }, -888)]
        [TestCase(new int[] { 25}, 25)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0 }, 0)]

        public static void Task1Test(int[] array, int expected)
        {
            int actual = Arrays.Task1(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]

        public static void Task1_WhenArrayIsEmpty_ArgException(int[] array)
        {
            try
            {
                Arrays.Task1(array);
            } catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 25, 3, -1, 0, -888, 20 }, 25)]
        [TestCase(new int[] {-888}, -888)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0 }, 0)]

        public static void Task2Test(int[] array, int expected)
        {
            int actual = Arrays.Task2(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]

        public static void Task2_WhenArrayIsEmpty_ArgException(int[] array)
        {
            try
            {
                Arrays.Task2(array);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { -25, 3, -1, 0, -888, -2000000 }, 5)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 1 }, 0)]
        [TestCase(new int[] { 1, 2, 1, 1, 1, 0 }, 5)]
        [TestCase(new int[] { 1}, 0)]

        public static void Task3Test(int[] array, int expected)
        {
            int actual = Arrays.Task3(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]

        public static void Task3_WhenArrayIsEmpty_ArgException(int[] array)
        {
            try
            {
                Arrays.Task3(array);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { -25, 3, -1, 0, -888, -2000000 }, 1)]
        [TestCase(new int[] { 1, 0, 0, 0, 0, 1 }, 0)]
        [TestCase(new int[] { 1, 2, 1, 1, 1, 0 }, 1)]
        [TestCase(new int[] { 1 }, 0)]

        public static void Task4Test(int[] array, int expected)
        {
            int actual = Arrays.Task4(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]

        public static void Task4_WhenArrayIsEmpty_ArgException(int[] array)
        {
            try
            {
                Arrays.Task4(array);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { -25, 3, -1, 0, -888, -200 }, -197)]
        [TestCase(new int[] { 1, 0, 5, 0, 7, 0 }, 0)]
        [TestCase(new int[] { 1, 2, 1, 1, 1, 0 }, 3)]
        [TestCase(new int[] {2}, 0)]

        public static void Task5Test(int[] array, int expected)
        {
            int actual = Arrays.Task5(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]

        public static void Task5_WhenArrayIsEmpty_ArgException(int[] array)
        {
            try
            {
                Arrays.Task5(array);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { -25, 3, -1, 0, -888, -200 }, new int[] { -200, -888, 0, -1, 3, -25 })]
        [TestCase(new int[] { 1, 0, 5 }, new int[] { 5, 0, 1 })]
        [TestCase(new int[] { 0, 0, 0, 0}, new int[] { 0, 0, 0, 0 })]
        [TestCase(new int[] { 2}, new int[] { 2})]

        public static void Task6Test(int[] array, int[] expected)
        {
            int[] actual = Arrays.Task6(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]

        public static void Task6_WhenArrayIsEmpty_ArgException(int[] array)
        {
            try
            {
                Arrays.Task6(array);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { -25, 3, -1, 0, -888, -200 }, 3)]
        [TestCase(new int[] { 1, 0, 5 }, 2)]
        [TestCase(new int[] { 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { 2 }, 0)]

        public static void Task7Test(int[] array, int expected)
        {
            int actual = Arrays.Task7(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]

        public static void Task7_WhenArrayIsEmpty_ArgException(int[] array)
        {
            try
            {
                Arrays.Task7(array);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { -25, 3, -1, 0, -888, -200 }, new int[] { 0, -888, -200, -25, 3, -1 })]
        [TestCase(new int[] { 1, 0, 5 }, new int[] { 5, 0, 1 })]
        [TestCase(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 })]
        [TestCase(new int[] { 2 }, new int[] { 2 })]

        public static void Task8Test(int[] array, int[] expected)
        {
            int[] actual = Arrays.Task8(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]

        public static void Task8_WhenArrayIsEmpty_ArgException(int[] array)
        {
            try
            {
                Arrays.Task8(array);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { -25, 3, -1, 0, -888, -200 }, new int[] { -888, -200, -25, -1, 0, 3})]
        [TestCase(new int[] { 1, 0, 5 }, new int[] { 0, 1, 5 })]
        [TestCase(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 })]
        [TestCase(new int[] { 2 }, new int[] { 2 })]

        public static void Task9Test(int[] array, int[] expected)
        {
            int[] actual = Arrays.Task9(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]

        public static void Task9_WhenArrayIsEmpty_ArgException(int[] array)
        {
            try
            {
                Arrays.Task9(array);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { -25, 3, -1, 0, -888, -200 }, new int[] { 3, 0, -1, -25, -200, -888 })]
        [TestCase(new int[] { 1, 0, 5 }, new int[] { 5, 1, 0 })]
        [TestCase(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 })]
        [TestCase(new int[] { 2 }, new int[] { 2 })]

        public static void Task10Test(int[] array, int[] expected)
        {
            int[] actual = Arrays.Task10(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]

        public static void Task10_WhenArrayIsEmpty_ArgException(int[] array)
        {
            try
            {
                Arrays.Task10(array);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
