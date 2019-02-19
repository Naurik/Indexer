using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int Size = int.Parse(Console.ReadLine());
            Index array = new Index(Size);
            try
            {
                    for (int i = 0; i < array.Size; i++)
                    {
                        Console.WriteLine("Введите число: ");
                        int number = int.Parse(Console.ReadLine());
                        array[i] = number;
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for(int i=0; i< array.Size; i++)
            {
                Console.WriteLine(i+1 + " элемент массива = " + array[i]);
            }
            Console.ReadLine();
        }
    }
}
