// УП Практическая работа 1.5
// Задание 5. Дан файл numsTask5.txt с целыми числами.
// Вычислите среднее арифметическое элементов расположенных между минимальным и максимальным

namespace YTT_5_5
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string path = "numsTask5.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string[] line = (await reader.ReadLineAsync()).Split(' ');
                int[] nums = new int[line.Length];
                int minNum = Int32.MaxValue, indexMin = 0;
                int maxNum = Int32.MinValue, indexMax = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = Convert.ToInt32(line[i]);
                    if (nums[i] > maxNum)
                    {
                        maxNum = nums[i];
                        indexMax = i;
                    }
                    else if (nums[i] < minNum)
                    {
                        minNum = nums[i];
                        indexMin = i;
                    }
                }

                int count = 0;
                double sum = 0;
                for (int i = indexMin + 1; i < indexMax; i++)
                {
                    sum += nums[i];
                    count++;
                }

                double average = sum / count;
                Console.WriteLine($"Среднее арифметическое элементов расположенных между минимальным и максимальным элементами: {average}");
            }
        }
    }
}