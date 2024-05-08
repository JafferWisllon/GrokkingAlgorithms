namespace GrokkingAlgorithms.Lib
{
    public static class BinarySearch
    {
        public static int? Handle(IEnumerable<int> list, int item)
        {
            var low = 0;
            var high = list.Count() - 1;

            while (low <= high)
            {
                var mid = (low + high) / 2;
                var guess = list.ElementAt(mid);
                if (guess == item)
                    return item;
                if (guess > item)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return null;
        }
    }
}
