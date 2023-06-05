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

        public override void Sort()
        {
            Console.WriteLine();
            Console.WriteLine("Enter quantity calories (Max-400)");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Vegetables whose calories are lower: {x} kl:");
            for (int i = 0; i < salad.Length; i++)
            {
                if (salad[i].Calories < x)
                {
                    Console.WriteLine(salad[i].Name);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Vegetables whose calories are higher: {x} kl:");
            for (int i = 0; i < salad.Length; i++)
            {
                if (salad[i].Calories >= x)
                {
                    Console.WriteLine(salad[i].Name);
                }
            }
        }
    }
}
