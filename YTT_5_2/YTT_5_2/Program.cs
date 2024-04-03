// УП Практическая работа 1.5
// Задание 2. Дан файл numsTask2.txt с вещественными числами, расположенными через «;».
// Напишите алгоритм, сортирующий числа по возрастанию. Запишите полученную отсортированную последовательность обратно в файл.

namespace YTT_5_2
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string path = "numsTask2.txt";
            List<double> subsequence = new List<double>();

            using (StreamReader reader = new StreamReader(path))
            {
                string[] line = (await reader.ReadLineAsync()).Split(';');
                double[] nums = new double[line.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = Convert.ToDouble(line[i]);
                }
                
                for (int i = 0; i < nums.Length; i++)
                {
                    double minNum = Double.MaxValue;
                    int indexNum = 0;
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] < minNum)
                        {
                            minNum = nums[j];
                            indexNum = j;
                        }
                    }
                    subsequence.Add(minNum);
                    nums[indexNum] = Double.MaxValue;
                }
            }

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                await writer.WriteLineAsync();
                foreach (var n in subsequence)
                {
                    await writer.WriteAsync($"{n} ");
                }
                Console.WriteLine("Числа отсортированны!");
                
            }
        }
    }
}