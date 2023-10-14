namespace SortLibrary
{
    public static class MergeSort
    {
        public static T[] Sort<T>(T[] array, Comparison<T> comparison = null)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            var length = array.Length;
            var mid = array.Length / 2;
            var left = new T[mid];
            var right = new T[length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }
            for (int j = mid; j < length; j++)
            {
                right[j - mid] = array[j];
            }

            Sort(left);
            Sort(right);

            return Merge(array, left, right, comparison);
        }

        public static T[] Merge<T>(T[] array, T[] left, T[] right, Comparison<T> comparison = null)
        {
            var leftL = left.Length;
            var rightL = right.Length;
            int i = 0, j = 0, k = 0;
            while (i < leftL && j < rightL)
            {
                if (comparison == null)
                {
                    if (Comparer<T>.Default.Compare(left[i], right[j]) <= 0)
                    {
                        array[k++] = left[i++];
                    }
                    else
                    {
                        array[k++] = right[j++];
                    }
                }
                else
                {
                    if (comparison(left[i], right[j]) <= 0)
                    {
                        array[k++] = left[i++];
                    }
                    else
                    {
                        array[k++] = right[j++];
                    }
                }

            }
            while (i < leftL)
            {
                array[k++] = left[i++];
            }
            while (j < rightL)
            {
                array[k++] = right[j++];
            }
            return array;
        }

        public static List<T> Sort<T>(List<T> list, Comparison<T> comparison = null)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            var length = list.Count;
            var mid = length / 2;
            var left = new List<T>();
            var right = new List<T>();

            for (int i = 0; i < mid; i++)
            {
                left.Add(list[i]);
            }
            for (int j = mid; j < length; j++)
            {
                right.Add(list[j]);
            }

            Sort(left);
            Sort(right);

            return Merge(list, left, right, comparison);
        }

        public static List<T> Merge<T>(List<T> list, List<T> left, List<T> right, Comparison<T> comparison = null)
        {
            var leftL = left.Count;
            var rightL = right.Count;
            int i = 0, j = 0, k = 0;
            while (i < leftL && j < rightL)
            {
                if (comparison == null)
                {
                    if (Comparer<T>.Default.Compare(left[i], right[j]) <= 0)
                    {
                        list[k++] = left[i++];
                    }
                    else
                    {
                        list[k++] = right[j++];
                    }
                }
                else
                {
                    if (comparison(left[i], right[j]) <= 0)
                    {
                        list[k++] = left[i++];
                    }
                    else
                    {
                        list[k++] = right[j++];
                    }
                }

            }
            while (i < leftL)
            {
                list[k++] = left[i++];
            }
            while (j < rightL)
            {
                list[k++] = right[j++];
            }
            return list;
        }
    }
}
