using System;

//TODO TASK ONE: 

//LAB 10;

/*namespace nubipobjectorientedprogramming
{
    class Lab10
    {
        static void Main(string[] args)
        {
            int n;
            double s = 0;
            int[] array;
            int currint;
            do
            {
                Console.Clear();
                Console.Write("Введите размерность массива: ");
            } while (!int.TryParse(Console.ReadLine(), out currint));
            n = currint;
            array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите элемент {0} : ", i + 1);
                if (int.TryParse(Console.ReadLine(), out currint))
                {
                    array[i] = currint;

                }
                else --i;
            }

            Console.Clear();
            Console.Write("Array: " + string.Join(" ", array));

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 1)
                {
                    s += Math.Pow(array[i], 2);
                }
            }
            Console.WriteLine(" \n Сумма квадратов элемментов массива составляет: " + s);
            Console.ReadKey();
        }
    }
}
*/