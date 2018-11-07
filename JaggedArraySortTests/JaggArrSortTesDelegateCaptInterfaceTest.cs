using JaggedArraySort;
using JaggedArraySort.Comparer;
using NUnit.Framework;
using System;

namespace JaggedArraySortTests
{

    [TestFixture]
    public class JaggArrSortTesDelegateCaptInterfaceTest
    {
        [Test]
        public void BubbleSortOfIncreasingSumElemInLineTest_ReturnSortingArray()
        {
            // Assert
            int[][] InputJagArr = new int[][]
            {
                new int[] {1, 3, 5, 7, 9},
                null,
                new int[] {0, 2, 4, 6},
                new int[] {11, 22},
                null,
                new int[] {1, 48},
                new int[] {1, 1, 1, 21}
            };

            int[][] ExpectedJagArr = new int[][]
            {
                null,
                null,
                new int[] {0, 2, 4, 6},
                new int[] {1, 1, 1, 21},
                new int[] {1, 3, 5, 7, 9},
                new int[] {11, 22},
                new int[] {1, 48},
            };

            // Act
            Comparator comparator = new SumArrayIncrComparer().Compare;
            BubbleSortJagArrDelegateCaptInterface.BubbleSort(InputJagArr, comparator);

            //// Assert

            CollectionAssert.AreEqual(ExpectedJagArr, InputJagArr);
        }

        [Test]
        public void BubbleSortOfDecreasingSumElemInLineTest_ReturnSortingArray()
        {
            // Assert
            int[][] InputJagArr = new int[][]
            {
                new int[] {1, 3, 5, 7, 9},
                null,
                new int[] {0, 2, 4, 6},
                new int[] {11, 22},
                null,
                new int[] {1, 48},
                new int[] {1, 1, 1, 21}
            };

            int[][] ExpectedJagArr = new int[][]
            {
                new int[] {1, 48},
                new int[] {11, 22},
                new int[] {1, 3, 5, 7, 9},
                new int[] {1, 1, 1, 21},
                new int[] {0, 2, 4, 6},
                null,
                null
            };

            // Act
            Comparator comparator = new SumArrayDecrComparer().Compare;
            BubbleSortJagArrDelegateCaptInterface.BubbleSort(InputJagArr, comparator);

            // Assert
            CollectionAssert.AreEqual(ExpectedJagArr, InputJagArr);
        }

        [Test]
        public void SortOfIncreasingMaxElemInLineTest_ReturnSortingArray()
        {
            // Assert
            int[][] inputJagArr = new int[][]
            {
                new int[] {1, 3, 5, 7, 9},
                new int[] {0, 2, 4, 6},
                null,
                new int[] {11, 22},
                null,
                new int[] {1, 48},
                new int[] {1, 1, 1, 9952}
            };

            int[][] expectedJagArr = new int[][]
            {
                null,
                null,
                new int[] {0, 2, 4, 6},
                new int[] {1, 3, 5, 7, 9},
                new int[] {11, 22},
                new int[] {1, 48},
                new int[] {1, 1, 1, 9952},
            };

            // Act
            Comparator comparator = new MaxArrayLineIncrComparer().Compare;
            BubbleSortJagArrDelegateCaptInterface.BubbleSort(inputJagArr, comparator);

            // Assert
            CollectionAssert.AreEqual(expectedJagArr, inputJagArr);
        }

        [Test]
        public void SortOfDecreasingMaxElemInLineTest_ReturnSortingArray()
        {
            // Assert
            int[][] inputJagArr = new int[][]
            {
                new int[] {1, 3, 5, 7, 9},
                new int[] {0, 2, 4, 6},
                null,
                new int[] {11, 22},
                null,
                new int[] {1, 48},
                new int[] {1, 1, 1, 9952}
            };

            int[][] expectedJagArr = new int[][]
            {
                new int[] {1, 1, 1, 9952},
                new int[] {1, 48},
                new int[] {11, 22},
                new int[] {1, 3, 5, 7, 9},
                new int[] {0, 2, 4, 6},
                null,
                null
            };

            // Act
            Comparator comparator = new MaxArrayLineDecrComparer().Compare;
            BubbleSortJagArrDelegateCaptInterface.BubbleSort(inputJagArr, comparator);

            // Assert
            CollectionAssert.AreEqual(expectedJagArr, inputJagArr);
        }

        [Test]
        public void SortOfIncreasingMinElemInLineTest_ReturnSortingArray()
        {
            // Assert
            int[][] inputJagArr = new int[][]
            {
                new int[] {1, 3, 5, 7, 9},
                null,
                new int[] {0, 2, 4, 6},
                new int[] {-11, 22},
                null,
                new int[] {1, 48},
                new int[] {1, 1, 1, 21}
            };

            int[][] expectedJagArr = new int[][]
            {
                null,
                null,
                new int[] {-11, 22},
                new int[] {0, 2, 4, 6},
                new int[] {1, 3, 5, 7, 9},
                new int[] {1, 48},
                new int[] {1, 1, 1, 21}
            };

            // Act
            Comparator comparator = new MinArrayLineIncrComparer().Compare;
            BubbleSortJagArrDelegateCaptInterface.BubbleSort(inputJagArr, comparator);

            // Assert
            CollectionAssert.AreEqual(expectedJagArr, inputJagArr);
        }

        [Test]
        public void SortOfDecreasingMinElemInLineTest_ReturnSortingArray()
        {
            // Assert
            int[][] inputJagArr = new int[][]
            {
                new int[] {1, 3, 5, 7, 9},
                null,
                new int[] {0, 2, 4, 6},
                new int[] {-11, 22},
                null,
                new int[] {1, 48},
                new int[] {1, 1, 1, 21}
            };

            int[][] expectedJagArr = new int[][]
            {
                null,
                null,
                new int[] {1, 3, 5, 7, 9},
                new int[] {1, 48},
                new int[] {1, 1, 1, 21},
                new int[] {0, 2, 4, 6},
                new int[] {-11, 22}
            };

            // Act
            Comparator comparator = new MinArrayLineDecrComparer().Compare;
            BubbleSortJagArrDelegateCaptInterface.BubbleSort(inputJagArr, comparator);

            // Assert
            CollectionAssert.AreEqual(expectedJagArr, inputJagArr);
        }

        public Comparator comparatorTest;
        public IComparer compar;

        [Test]
        public void BubbleSortSumElemInLineTestDelegateCaptInterface_ThrowsArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => BubbleSortJagArrDelegateCaptInterface.BubbleSort(null, comparatorTest));

        [Test]
        public void BubbleSortSumElemInLineTest_ThrowsArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => BubbleSortJagArrDelegateCaptInterface.BubbleSort(null, compar));
    }
}
