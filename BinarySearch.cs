static int FindIndexByBinarySearch(int[] array, int element)
{
	var left = 0;
	var right = array.Length - 1;
	while (left < right)
	{
		var middle = (right + left) / 2;
		if (element <= array[middle])
			right = middle;
		else left = middle + 1;
	}
	if (array[right] == element)
		return right;
	return -1;
}
