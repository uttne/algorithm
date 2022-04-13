namespace Algorithm
{
    public class InsertionSort
    {
        public void Sort<T>(T[] list)
        where T : IComparable<T>
        {
            for (int i = 1; i < list.Length; ++i)
            {
                var x = list[i];
                var y = list[i - 1];

                if (0 < x.CompareTo(y))
                {
                    continue;
                }
                list[i] = y;
                int k = i - 2;
                for (; 0 <= k; --k)
                {
                    y = list[k];
                    if (x.CompareTo(y) < 0)
                    {
                        list[k + 1] = y;
                        continue;
                    }
                    break;
                }
                list[k + 1] = x;
            }
        }
    }
}