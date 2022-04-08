namespace Algorithm
{
    public class SelectionSort
    {
        public void Sort<T>(T[] list)
        where T : IComparable<T>
        {
            for (int i = 0; i < list.Length; ++i)
            {
                int minIndex = i;
                for (int j = i; j < list.Length; ++j)
                {
                    var x = list[minIndex];
                    var y = list[j];
                    if (0 < x.CompareTo(y))
                    {
                        minIndex = j;
                    }
                }

                var swap = list[i];
                list[i] = list[minIndex];
                list[minIndex] = swap;
            }
        }
    }
}