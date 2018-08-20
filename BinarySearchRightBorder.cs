static int BSRightBorder(int[] array, int value, int left, int right)
    {
        if (right - left == 1)
            return right;
        var middle = left + (right - left) / 2;
        if (value < array[middle])
            return BSRightBorder(array, value, left, middle);
        return BSRightBorder(array, value, middle, right);
    }
