using System.Linq;

namespace CodingAgility.MiddleSum
{
    public class MiddleSum
    {
        public readonly int[] List;

        public MiddleSum(int[] list)
        {
            List = list;
        }

        public bool HasMiddleSum
        {
            get
            {
                int sum = List.Sum();

                int sumLeft = 0;
                int sumRight = 0;

                foreach (int i in List)
                {
                    sumLeft += i;
                    sumRight = sum - i;

                    if (sumLeft == sumRight) return true;

                    sum = sumRight;
                }

                return false;
            }
        }
    }
}
