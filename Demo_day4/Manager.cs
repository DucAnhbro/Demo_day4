using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_day4
{
    internal class Manager
    {
        Validation va = new Validation();

        private List<Animal> listA = null;
        Animal animal = new Animal();

        public Manager()
        {
            listA = new List<Animal>();
        }

        public List<Animal> GetListAnimal()
        {
            return listA;
        }

        private int GenerateID()
        {
            int max = 1;
            if (listA != null && listA.Count > 0)
            {
                max = listA[0].Id;
                foreach (var o in listA)
                {
                    if (max < o.Id)
                    {
                        max = o.Id;
                    }
                }
                max++;
            }
            return max;
        }
        public int NumberAnimal()
        {
            int Count = 0;
            if (listA != null)
            {
                Count = listA.Count;
            }
            return Count;
        }
        public void CreateAnimal()
        {
            
            Animal animal = new Animal();
            animal.Id = GenerateID();
            Console.Write("Nhap ten dong vat: ");
            animal.Ten = Console.ReadLine();

            Console.Write("Nhap Chieu cao: ");
            animal.Chieu_cao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap Can nang: ");
            animal.Can_nang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap mau sac: ");
            animal.Mau_sac= Console.ReadLine();

            listA.Add(animal);
        }
        public void ShowAnimal(List<Animal> animals)
        {
            Console.WriteLine("{0, -5} {1, -20} {2, -10} {3, 10} {4, 10} ",
                  "ID", "Ten", "Chieu cao", "Can nang", "mau sac");
            if (animals != null && animals.Count > 0)
            {
                foreach (var o in animals)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -10} {3, 10} {4, 10}",
                                      o.Id, o.Ten, o.Chieu_cao, o.Can_nang, o.Mau_sac);
                }
            }
            Console.WriteLine();
        }

        public Animal FindByID(int id)
        {
            Animal searchResult = null;
            if (listA != null && listA.Count > 0)
            {
                foreach (var o in listA)
                {
                    if (o.Id == id)
                    {
                        searchResult = o;
                    }
                }
            }
            return searchResult;
        }
        public void UpdateAnimal(int id)
        {
            Animal animal = FindByID(id);
            if ( animal != null)
            {
                Console.Write("Nhap ten sinh vien: ");
                string name = Convert.ToString(Console.ReadLine());
                if (name != null && name.Length > 0)
                {
                    animal .Ten = name;
                }

                Console.Write("Nhap Chieu cao: ");
                string chieu_cao = Convert.ToString(Console.ReadLine());
                if (chieu_cao != null && chieu_cao.Length > 0)
                {
                    animal.Chieu_cao = Convert.ToDouble(chieu_cao);
                }

                Console.Write("Nhap Can nang: ");
                string can_nang = Convert.ToString(Console.ReadLine());
                if (chieu_cao != null && chieu_cao.Length > 0)
                {
                    animal.Chieu_cao = Convert.ToDouble(can_nang);
                }

                Console.Write("Nhap Mau sac: ");
                string mau_sac = Convert.ToString(Console.ReadLine());
                if (mau_sac != null && mau_sac.Length > 0)
                {
                    animal.Ten = mau_sac;
                }
            }
            else
            {
                Console.WriteLine("Sinh vien co ID = {0} khong ton tai.", id);
            }
        }
        public bool DeleteById(int id)
        {
            bool IsDeleted = false;
            // tìm kiếm sinh viên theo ID
            Animal animal = FindByID(id);
            if (animal != null)
            {
                IsDeleted = listA.Remove(animal);
            }
            return IsDeleted;
        }
    }
}
