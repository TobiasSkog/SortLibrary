namespace SortLibrary
{
    public static class BubbleSort
    {
        public static List<T> Sort<T>(List<T> list, Comparison<T> comparison = null)
        {
            bool swapped;
            if (list == null || list.Count < 1)
            {
                return list;
            }

            do
            {
                swapped = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (comparison == null)
                    {
                        if (Comparer<T>.Default.Compare(list[i], list[i + 1]) > 0)
                        {
                            T temp = list[i];
                            list[i] = list[i + 1];
                            list[i + 1] = temp;

                            swapped = true;
                        }
                    }
                    else
                    {
                        if (comparison(list[i], list[i + 1]) > 0)
                        {
                            T temp = list[i];
                            list[i] = list[i + 1];
                            list[i + 1] = temp;

                            swapped = true;
                        }
                    }
                }
            } while (swapped);

            return list;
        }
    }
}
