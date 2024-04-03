// УП Практическая работа 1.5
// Задание 1. Дан файл numsTask1.txt с целыми числами, вычислите произведение элементов расположенных после минимального

namespace YTT_5_1
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string path = "numsTask1.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string[] line = (await reader.ReadLineAsync()).Split(' ');
                int[] nums = new int[line.Length];
                int minNum = Convert.ToInt32(line[0]);
                int indexNum = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    nums[i] = Convert.ToInt32(line[i]);
                    if (nums[i] < minNum)
                    {
                        minNum = nums[i];
                        indexNum = i;
                    }
                }

                if (indexNum + 1 >= nums.Length)
                {
                    Console.WriteLine($"После числа {nums[indexNum]} - нет чисел!");
                }
                else
                {
                    int product = 1;
                    for (int i = indexNum + 1; i < nums.Length; i++)
                    {
                        product *= nums[i];
                    }
                    Console.WriteLine($"Произведение элементов расположенных после минимального: {product}");
                }
            }
        }
    }
}