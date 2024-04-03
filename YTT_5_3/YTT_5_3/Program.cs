// УП Практическая работа 1.5
// Задание 3. Дан файл numsTask3.txt с целыми числами, вычислите среднее арифметическое элементов расположенных до минимального.

namespace YTT_5_3
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string path = "numsTask3.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string[] line = (await reader.ReadLineAsync()).Split(' ');
                int[] nums = new int[line.Length];
                int minNum = Int32.MaxValue, indexNum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = Convert.ToInt32(line[i]);
                    if (nums[i] < minNum)
                    {
                        minNum = nums[i];
                        indexNum = i;
                    }
                }

                int count = 0;
                double sum = 0;
                for (int i = 0; i < indexNum; i++)
                {
                    sum += nums[i];
                    count++;
                } 
                
                double average = sum / count;
                Console.WriteLine($"Среднее арифметическое элементов расположенных до минимального: {average}");
            }
        }
    }
}