using Algorithm;

var alg = new ShakerSort();

var list = new int[] { 99, 77, 52, 68, 6, 68, 45, 84, 15, 1 };

Console.WriteLine(String.Join(" ", list));

alg.Sort(list);

Console.WriteLine(String.Join(" ", list));
