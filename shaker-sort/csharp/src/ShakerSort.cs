namespace Algorithm
{
    public class ShakerSort
    {
        public void Sort<T>(T[] list)
        where T : IComparable<T>
        {
            int l = 0;
            int r = list.Length - 1;
            while (true)
            {
                int rMax = 0;
                for (int i = l; i < r; ++i)
                {
                    var x = list[i];
                    var y = list[i + 1];
                    if (0 < x.CompareTo(y))
                    {
                        list[i] = y;
                        list[i + 1] = x;
                        rMax = i;
                    }
                }
                r = rMax;

                if (l == r) break;


                int lMax = r;
                for (int i = r; l < i; --i)
                {
                    var x = list[i - 1];
                    var y = list[i];
                    if (0 < x.CompareTo(y))
                    {
                        list[i - 1] = y;
                        list[i] = x;
                        lMax = i;
                    }
                }
                l = lMax;

                if (l == r) break;
            }
        }
    }
}