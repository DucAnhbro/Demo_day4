using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_day4
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Manager ma = new Manager();
            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY THU CUNG ");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them thu cung                               **");
                Console.WriteLine("**  2. Cap nhat thong tin thu cung boi ID.          **");
                Console.WriteLine("**  3. Xoa thu cung boi ID.                         **");
                Console.WriteLine("**  4. Hien thi danh sach thu cung.                 **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Them thu cung .");
                        ma.CreateAnimal();
                        Console.WriteLine("\nThem thu cung  thanh cong!");
                        break;
                    case 2:
                        if (ma.NumberAnimal() > 0)
                        {
                            int id;
                            Console.WriteLine("\n2. Cap nhat thong tin thu cung. ");
                            Console.Write("\nNhap ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            ma.UpdateAnimal(id);
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach thu cung trong!");
                        }
                        break;
                    case 3:
                        if (ma.NumberAnimal() > 0)
                        {
                            int id;
                            Console.WriteLine("\n3. Xoa thu cung.");
                            Console.Write("\nNhap ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            if (ma.DeleteById(id))
                            {
                                Console.WriteLine("\nthu cung co id = {0} da bi xoa.", id);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;

                    case 4:
                        if (ma.NumberAnimal() > 0)
                        {
                            Console.WriteLine("\n4. Hien thi danh sach thu cung.");
                            ma.ShowAnimal(ma.GetListAnimal());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach dong vat trong!");
                        }
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }
        }
    }
}
