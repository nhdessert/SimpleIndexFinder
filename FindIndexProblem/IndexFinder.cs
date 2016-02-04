namespace FindIndexProblem
{
    public static class IndexFinder
    {
        public static int FindIndex(int x, int[] array)
        {
            return FindIndex(x, 0, array.Length - 1, array);
        }

        private static int FindIndex(int x, int left, int right, int[] array)
        {
            if (left > right)
            {
                return -1;
            }

            int middle = (left + right) / 2;

            if (x == array[middle])
            {
                return middle;
            }

            if (array[left] < array[middle])
            {
                if (array[left] <= x && x <= array[middle])
                {
                    return FindIndex(x, left, middle, array);
                }
                else
                {
                    return FindIndex(x, middle + 1, right, array);
                }
            }

            if (array[middle + 1] <= array[right])
            {
                if (array[middle + 1] <= x && x <= array[right])
                {
                    return FindIndex(x, middle + 1, right, array);
                }
                else
                {
                    return FindIndex(x, left, middle, array);
                }
            }

            return -1;
        }
    }
}
