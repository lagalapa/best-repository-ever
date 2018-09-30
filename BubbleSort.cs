static void BubbleSort(int[] array)
{
    for (var i = array.Length - 1; i > 0; i--)
        for (var j = 1; j <= i; j++)
            if (array[j] < array[j - 1])
            {
                var tmp = array[j];
                array[j] = array[j - 1];
                array[j - 1] = tmp;
            }
}
