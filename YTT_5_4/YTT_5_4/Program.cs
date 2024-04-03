// УП Практическая работа 1.5
// Задание 4. Дан файл numsTask4.txt с целыми числами.
// Вычислите сумму элементов, отличающихся от максимального на 1

namespace YTT_5_4
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string path = "numsTask4.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string[] line = (await reader.ReadLineAsync()).Split(' ');
                int[] nums = new int[line.Length];
                int maxNum = Int32.MinValue;
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = Convert.ToInt32(line[i]);
                    if (nums[i] > maxNum)
                    {
                        maxNum = nums[i];
                    }
                }

                int sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != maxNum)
                    {
                        if (nums[i] == maxNum - 1)
                        {
                            sum += nums[i];
                        }
                    }
                }
                Console.WriteLine($"Сумма элементов, отличающихся от максимального на 1: {sum}");
            }
        }
    }
}