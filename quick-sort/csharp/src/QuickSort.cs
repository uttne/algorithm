namespace Algorithm
{
    public class QuickSort
    {
        public void Sort<T>(T[] list)
        where T : IComparable<T>
        {
            var indexStack = new Stack<(int start, int length)>();

            indexStack.Push((0, list.Length));

            while (0 < indexStack.Count)
            {
                var index = indexStack.Pop();

                var start = index.start;
                var length = index.length;

                if (length <= 1)
                {
                    continue;
                }
                if (length == 2)
                {
                    if (0 < list[start].CompareTo(list[start + 1]))
                    {
                        var tmp = list[start];
                        list[start] = list[start + 1];
                        list[start + 1] = tmp;
                    }
                    continue;
                }
                var pivot = start + length / 2;

                var pivotValue = list[pivot];

                int left = start;
                int right = start + length - 1;

                while (true)
                {
                    for (; left < pivot; left++)
                    {
                        if (pivotValue.CompareTo(list[left]) < 0)
                        {
                            break;
                        }
                    }

                    for (; pivot < right; right--)
                    {
                        if (0 < pivotValue.CompareTo(list[right]))
                        {
                            break;
                        }
                    }

                    if (left == pivot || pivot == right)
                    {
                        break;
                    }

                    var tmp = list[left];
                    list[left] = list[right];
                    list[right] = tmp;
                }

                if (left != pivot)
                {
                    for (int i = pivot - 1; left <= i; i--)
                    {
                        if (pivotValue.CompareTo(list[i]) < 0)
                        {
                            list[pivot] = list[i];
                            int k = i;
                            for (; k + 1 < pivot; ++k)
                            {
                                list[k] = list[k + 1];
                            }
                            list[k] = pivotValue;
                            pivot--;
                        }
                    }
                }
                else if (pivot != right)
                {
                    for (int i = pivot + 1; i <= right; i++)
                    {
                        if (0 < pivotValue.CompareTo(list[i]))
                        {
                            list[pivot] = list[i];
                            int k = i;
                            for (; pivot < k - 1; --k)
                            {
                                list[k] = list[k - 1];
                            }
                            list[k] = pivotValue;
                            pivot++;
                        }
                    }
                }

                indexStack.Push((start, pivot - start));
                indexStack.Push((pivot + 1, length + start - (pivot+ 1)));
            }
        }
    }
}