namespace Assginment7._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 9, 15, 3, 40, 5, 13, 50, 19 };


            for (int gap = nums.Length / 2; gap >= 1; gap = gap / 2)
            {

                for (int i = 0; i < gap; i++)
                {
                    for (int k = i; k < nums.Length; k = k + gap)
                    {
                        int j = k;
                        while (j - gap >= 0)
                        {
                            if (nums[j] > nums[j - gap])
                            {
                                int temp = nums[j];
                                nums[j] = nums[j - gap];
                                nums[j - gap] = temp;

                            }
                            j = j - gap;

                        }
                    }
                }

            }
            foreach (int i in nums) { Console.Write(i + " "); }
        }
    }
}
