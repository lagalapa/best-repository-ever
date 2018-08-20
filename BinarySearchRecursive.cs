int BS(int[] array, int number, int left, int right)
{
    if (left < right)
    {
        int middle = (left + right) / 2;
        if (number > array[middle])
            return BS(array, number, middle + 1, right);
        return BS(array, number, left, middle);
    }
    return (array[left] == number) ? left : -1;
}
