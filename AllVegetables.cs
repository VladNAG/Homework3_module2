using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_module2
{
    public class AllVegetables
    {
        public AllVegetables()
        {
            ArrayVegetables = new Vegetables[11];
            var parsley = new Greens("Parsley");
            ArrayVegetables[0] = parsley;
            var dill = new Greens("Dill");
            ArrayVegetables[1] = dill;
            var basil = new Greens("Basil");
            ArrayVegetables[2] = basil;
            var cabbage = new LeafyVegetables("Cabbage");
            ArrayVegetables[3] = cabbage;
            var broccoli = new LeafyVegetables("Broccoli");
            ArrayVegetables[4] = broccoli;
            var tomato = new FruiVegetables("Tomato");
            ArrayVegetables[5] = tomato;
            var peper = new FruiVegetables("Peper");
            ArrayVegetables[6] = peper;
            var cucumber = new FruiVegetables("Cucumber");
            ArrayVegetables[7] = cucumber;
            var potato = new RootVegetables("Potato");
            ArrayVegetables[8] = potato;
            var carrot = new RootVegetables("Carrot");
            ArrayVegetables[9] = carrot;
            var beet = new RootVegetables("Beet");
            ArrayVegetables[10] = beet;
        }

        public Vegetables[] ArrayVegetables { get; protected set; }
        public void ShowAllVegetables()
        {
            Array.Sort(ArrayVegetables);
            Console.WriteLine("All Vegetables:");
            for (int i = 0; i < ArrayVegetables.Length; i++)
            {
                if (i == ArrayVegetables.Length - 1)
                {
                    Console.Write($"{ArrayVegetables[i].Name}:{ArrayVegetables[i].Calories.ToString()}kl!!!");
                }
                else
                {
                    Console.Write($"{ArrayVegetables[i].Name}:{ArrayVegetables[i].Calories.ToString()}kl, ");
                }
            }
        }

        public virtual void Sort()
        {
            Console.WriteLine();
            Console.WriteLine("Enter quantity calories (Max-400)");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Vegetables whose calories are lower: {x} kl:");
            for (int i = 0; i < ArrayVegetables.Length; i++)
            {
                if (ArrayVegetables[i].Calories < x)
                {
                    Console.WriteLine(ArrayVegetables[i].Name);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Vegetables whose calories are higher: {x} kl:");
            for (int i = 0; i < ArrayVegetables.Length; i++)
            {
                if (ArrayVegetables[i].Calories >= x)
                {
                    Console.WriteLine(ArrayVegetables[i].Name);
                }
            }
        }
    }
}
