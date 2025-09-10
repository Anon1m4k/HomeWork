using System.Collections.Generic;

namespace MockTestsHomeWork
{
    public class CollectionAssertNumberGenerator
    {
        public IEnumerable<int> GetSquareNumbers(int count)
        {
            List<int> result = new List<int>();
            for (int i = 1; i <= count; i++)
            {
                result.Add(i * i);
            }
            return result;
        }
    }
}