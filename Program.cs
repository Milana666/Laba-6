using System;
namespace ConsoleApplication4
{
    class Program
    {
        const int N_max = 1000000;  // максимальная размерность массива
        static double[] a = new double[N_max];  // объявление массива

        static void Main(string[] args)
        {
            int n = InputA();  // количество элементов и ввод массива
            OutputA("До сортировки", n);  // вывод массива
            MaxSort(n);        // сортировка по по возрастанию
            OutputA("После сортировки через минимальный элемент", n);
            BoobleSort(n);     // сортировка по убыванию
            OutputA("После пузырьковой сортировки", n);
            Console.ReadKey();
        }
        static int InputA()
        {
            int n;
            Console.Write("Ввести кол-во чисел: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            return n;
        }
        // Вывод массива
        static void OutputA(string z, int n)
        {
            Console.WriteLine(z);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0:#.#}    ", a[i]);
            }
            Console.WriteLine();
        
        }
        static void MaxSort(int n)
        {
            double p;
            int k;
            for (int i = 0; i < n - 1; i++)
            {
                k = k_min(i + 1, n);
                if (a[i] > a[k])
                {
                    p = a[i];
                    a[i] = a[k];
                    a[k] = p;
                }
            }
        }
        static void BoobleSort(int n)
        {
            double c;
            for (int i = n - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        c = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = c;
                    }
                }
        }

        }
}