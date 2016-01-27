using System;
using System.Collections.Generic;

namespace Epub3DuplicatedImagesRemoverTool.Helper
{
    /// <summary>
    /// Helperclass for comparing arrays of equal length containing comparable items
    /// </summary>
    /// <typeparam name="T">The type of items to compare - must be IComparable</typeparam>
    class ArrayComparer<T> : IComparer<T[,]> where T : IComparable
    {
        public int Compare(T[,] array1, T[,] array2)
        {
            for (int x = 0; x < array1.GetLength(0); x++)
            {
                for (int y = 0; y < array2.GetLength(1); y++)
                {
                    int threshold = int.Parse(Properties.Settings.Default.Threshold);

                    int comparisonResult = Math.Abs(array1[x, y].CompareTo(array2[x, y])) > threshold ? array1[x, y].CompareTo(array2[x, y]) : 0;
                    if (comparisonResult != 0)
                    {
                        return comparisonResult;
                    }
                }
            }
            return 0;
        }
    }
}