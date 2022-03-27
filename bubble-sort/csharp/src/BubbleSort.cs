namespace Algorithm
{
    public class BubbleSort
    {
        public void Sort<T>(T[] list)
        where T : IComparable<T>
        {
            for (int j = 1; j < list.Length; ++j)
            {
                for (int i = 0; i < list.Length - j; ++i)
                {
                    var x = list[i];
                    var y = list[i + 1];
                    if (0 < x.CompareTo(y))
                    {
                        list[i] = y;
                        list[i + 1] = x;
                    }
                }
            }
        }
    }
}