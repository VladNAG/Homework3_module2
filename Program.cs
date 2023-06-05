using System.Net.Sockets;

namespace Homework3_module2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var vegetebles = new AllVegetables();
            vegetebles.ShowAllVegetables();
            vegetebles.Short();
            Console.WriteLine("Enter count vegetebles for salad (Max count 11)");
            int contVegSalad = int.Parse(Console.ReadLine());
            var salas = new Salad(contVegSalad);
            salas.Short();
        }
    }
}