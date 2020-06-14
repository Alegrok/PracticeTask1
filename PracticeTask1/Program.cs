using System.IO;

namespace PracticeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = ""; // Переменная для суммы n-значных чисел
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                // Ввод числа n
                int n = int.Parse(sr.ReadLine());

                if (n == 1) output = "45"; // Сумма однозначных чисел
                else if (n == 2) output = "4905"; // Сумма двузначных чисел
                else // Находим сумму n-значных чисел по алгоритму
                {
                    output = "494";
                    for (int i = 0; i < n - 3; i++) output += "9";
                    output += "55";
                    for (int i = 0; i < n - 2; i++) output += "0";
                }
            }
            using (StreamWriter fstream = new StreamWriter("output.txt"))
            {
                // Вывод суммы n-значных чисел в файл
                fstream.Write(output);
            }
        }
    }
}