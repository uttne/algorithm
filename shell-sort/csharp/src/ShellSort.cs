namespace Algorithm
{
    public class ShellSort
    {
        public void Sort<T>(T[] list)
        where T : IComparable<T>
        {
            var h = 364;

            do
            {
                h /= 3;

                for (int d = 0; d < h; ++d)
                {
                    for (int i = h + d; i < list.Length; i += h)
                    {
                        var x = list[i];
                        var y = list[i - h];

                        if (0 < x.CompareTo(y))
                        {
                            continue;
                        }

                        list[i] = y;

                        var cursor = i - 2 * h;
                        for (; d <= cursor; cursor -= h)
                        {
                            y = list[cursor];
                            if (x.CompareTo(y) < 0)
                            {
                                list[cursor + h] = y;
                                continue;
                            }
                            break;
                        }
                        list[cursor + h] = x;
                    }
                }
            }
            while (1 < h);
        }
    }
}