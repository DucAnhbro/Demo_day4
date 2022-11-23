using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_day4
{
    internal class Program
    {
        static List<Animal> animals = new List<Animal>();
        Animal an = new Animal();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("============ MENU ============");
                Console.WriteLine("1. Them");
                Console.WriteLine("2. Sua");
                Console.WriteLine("3. Xoa");
                Console.WriteLine("4. Xem danh sach");
                Console.WriteLine("===============================");
                var choice = Console.ReadLine();
                
                Manager ma = new Manager();
                switch (choice)
                {
                    case "1":
                        //Console.WriteLine("case 1");
                        ma.CreateAnimal(animals);
                        break;
                    case "2":
                        ma.UpdateAnimal(animals);
                        break;
                    case "3":
                        var id = Console.ReadLine();
                        ma.RemoveAnimal(animals,id);
                        break;
                    case "4":
                        ma.ShowAnimal(animals);
                        break;
                    default:
                        Console.WriteLine("Nhap tu 1-4");
                        break;
                }
            }

        }
            
    }
}
