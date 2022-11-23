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
        public void CreateAnimal(List<Animal> animals)
        {
            bool check = false;
            while (!check)
            {
                Console.WriteLine("Nhap vao Id:");
                string id = va.CheckString("Nhap vao Id:");
                if(id == null)
                {
                    id= Console.ReadLine();
                }
                Console.WriteLine("Nhap vao ten dong vat");
                string ten = va.CheckTen();
                if(ten == null)
                {
                    ten = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ten da ton tai, yeu cau nhap dung fomat");
                    
                }
                double chieu_cao = va.CheckDouble("Nhap vao chieu cao:");
                double can_nang = va.CheckDouble("Nhap vao can nang:");
                string mau_sac = va.CheckString("Nhap vao mau sac:");
                if(va.CheckAnimaleExit(id, ten, chieu_cao, can_nang, mau_sac, animals).Equals(""))
                {
                    animals.Add(new Animal(id, ten, chieu_cao, can_nang,mau_sac));
                    Console.WriteLine("Add success full");
                }
                check= true;
            }
            check = false;
            Console.WriteLine("Add fail");
        }
        public void UpdateAnimal(List<Animal> animals)
        {
            string id = va.CheckString("Nhap vao Id:");
            if(id == null)
            {
                Console.WriteLine(" Id khong ton tai");
            }
            else
            {
                string ten = "";
                double chieu_cao = va.CheckDouble("Nhap vao chieu cao:");
                double can_nang = va.CheckDouble("Nhap vao can nang:");
                string mau_sac = va.CheckString("Nhap vao mau sac:");
                foreach (Animal an in animals)
                {
                    if (id.Equals(an.Id))
                    {
                        an.Ten=ten;
                        an.Chieu_cao = chieu_cao;
                        an.Can_nang = can_nang;
                        an.Mau_sac = mau_sac;
                    }else if(va.CheckAnimaleExit(id, ten, chieu_cao, can_nang, mau_sac, animals))
                    {
                        animals.Add(new Animal(id, ten, chieu_cao, can_nang, mau_sac));
                    }
                    else
                    {
                        Console.WriteLine("Animal da ton tai");
                    }
                }
            }

        }

        public void GetAnimalById(List<Animal> animals, string id)
        {
            foreach(Animal an in animals)
            {
                if (id.Equals(an.Id))
                {
                    animals.Add(an);
                } 
            }
        }
        public void RemoveAnimal(List<Animal> animals, string id)
        {
            var check = false;
                foreach (var o in animals.ToList())
                {
                    if (o.Id == id)
                    {
                        animals.Remove(o);
                        Console.WriteLine("Da xoa thanh cong");
                        check = false;
                    }
                    if(o.Id != id)
                    {
                        Console.WriteLine("Khong ton tai Animal");
                    }
                
                }
            
        }

        

        public void GetAnimalById(string id, List<Animal> animals)
        {
            var an = new Animal();
            foreach (var o in animals)
            {
                if (o.Id == id)
                {
                    an.Ten = o.Ten;
                    an.Chieu_cao = o.Chieu_cao;
                    an.Can_nang = o.Can_nang;
                    an.Mau_sac = o.Mau_sac;
                }
                else
                {
                    Console.WriteLine("khong ton tai animal co Id nay");
                }
            }
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
    }
}
