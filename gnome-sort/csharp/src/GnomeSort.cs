namespace Algorithm
{
    public class GnomeSort
    {
        public void Sort<T>(T[] list)
        where T : IComparable<T>
        {

            int gnome = 1;
            while (gnome < list.Length)
            {
                var x = list[gnome - 1];
                var y = list[gnome];

                if (0 < x.CompareTo(y))
                {
                    list[gnome - 1] = y;
                    list[gnome] = x;

                    if (1 < gnome)
                    {
                        gnome--;
                        continue;
                    }
                }
                gnome++;
            }
        }
    }
}