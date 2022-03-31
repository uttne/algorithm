namespace Algorithm
{
    public class CombSort
    {
        public async void Sort<T>(T[] list)
        where T : IComparable<T>
        {
            var h = list.Length;
            bool isFinish = false;
            do
            {
                h = (isFinish = h <= 1) ? 1 : h * 10 / 13;
                for (int i = 0; i + h < list.Length; ++i)
                {
                    var x = list[i];
                    var y = list[i + h];

                    if (0 < x.CompareTo(y))
                    {
                        list[i] = y;
                        list[i + h] = x;
                        isFinish = false;
                    }
                }
            }
            while (isFinish == false);
        }
    }
}