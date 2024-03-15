using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    /*static void Main(string[] args)
    {
        Console.WriteLine("Введите строку J (драгоценности): ");
        string J = Console.ReadLine();
        
        Console.WriteLine("Введите строку S (камней)");
        string S = Console.ReadLine();

        int count = 0;
        foreach (char stone in S)
        {
            foreach (char jewel in J)
            {
                if (jewel == stone)
                {
                    count++;
                    break;
                }
            }
        }
        Console.WriteLine($"Одновременно является драгоценностями: {count}");
    }
*/
/*static void Combinations(int[] candidates, int target, int start, List<int> current, List<List<int>> result)
 {
     if (target == 0)
     {
         result.Add(new List<int>(current)); //добавляем в список результатов
         return;
     }

     for (int i = start; i < candidates.Length; ++i)
     {
         if (candidates[i] > target)
         {
             break;
         }

         if (i > start && candidates[i] == candidates[i - 1]) //пропускаем повтояющиеся  числа 
         {
             continue;
         }

         current.Add(candidates[i]);
         Combinations(candidates, target - candidates[i], i + 1, current, result);
         current.RemoveAt(current.Count - 1); //удаляем последний элемент из текущей комбинации
     }
 }
 static void Main(string[] args)
 {
     int[] candidates = new int[] {10, 1, 2, 7, 6, 1, 5};

     Console.WriteLine("Введите taget (цель)");
     int target = Convert.ToInt32(Console.ReadLine());

     List<List<int>> result = new List<List<int>>();
     Array.Sort(candidates);

     List<int> current = new List<int>();
     Combinations(candidates, target, 0, current, result);

     Console.WriteLine("Уникальные комбинации чисел, сумма которых равна цели:");

     foreach (var combination in result)
     {
         Console.WriteLine(string.Join(" ", combination));
     }
 }
}*/

/*class Program
{
    static void Duplicate(int[] nums)
    {
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                Console.WriteLine("true");
                return;
            }
        }

        Console.WriteLine("false");
    }

    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4 };

        Duplicate(nums);
    }
}*/