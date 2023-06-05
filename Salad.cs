using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_module2
{
    public class Salad : AllVegetables
    {
        private Vegetables[] salad;
        private int calories = 0;
        public Salad(int countVeg)
        {
            Console.WriteLine();
            salad = new Vegetables[countVeg];
            for (int i = 0; i < salad.Length; i++)
            {
                Random x = new Random();
                salad[i] = ArrayVegetables[x.Next(0, 11)];
                calories += salad[i].Calories;
            }

            Console.WriteLine();
            Console.WriteLine("Salad Created:");
            foreach (Vegetables vegetables in salad)
            {
                Console.WriteLine(vegetables.Name);
            }

            Console.WriteLine();
            Console.WriteLine($"Calories salad:{calories.ToString()}kl");
        }

        public override void Short()
        {
            Console.WriteLine();
            Console.WriteLine("Bring vegetables up to 100 calories in salad:");
            for (int i = 0; i < salad.Length; i++)
            {
                if (salad[i].Calories < 100)
                {
                    Console.WriteLine(salad[i].Name);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Bring vegetables over 100 calories in salad:");
            for (int i = 0; i < salad.Length; i++)
            {
                if (salad[i].Calories >= 100)
                {
                    Console.WriteLine(salad[i].Name);
                }
            }
        }
    }
} /*сделать метод расширения на сортировку салата по типу и всех продуктов*/
