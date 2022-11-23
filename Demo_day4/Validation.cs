using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Demo_day4
{
    internal class Validation
    {
        public string CheckString(string mess)
        {
            //abc [[a-za-z0-9\s]+$
            Regex regex = new Regex("[A - Za - z0 - 9\\s]");
            var check = false;
            while (!check)
            {
                //mess = console.readline();
                // regex a = new regex(mess);
                if (!regex.IsMatch(mess))
                {
                    Console.WriteLine("chuoi nhap vao phai chuan fomat [a-z, a-z, 0-9]");
                    
                }
                check = true;
            }
            return mess;
        }

        public double CheckDouble(string mess)
        {
            Console.WriteLine(mess);
            var chuoi_nhap_vao = Console.ReadLine();
            double output;

            bool check = double.TryParse(chuoi_nhap_vao, out output);

            while (!check)
            {
                Console.WriteLine("Nhap sai dang du lieu, can nhap lai!");
                chuoi_nhap_vao = Console.ReadLine();

                check = double.TryParse(chuoi_nhap_vao , out output);
            }

            return output;
        }

        public Animal CheckIdExit(string id, List<Animal>animals)
        {
            foreach(var o in animals)
            {
                if (id.Equals(o.Id))
                {
                    Console.WriteLine("Id da ton tai");
                    return o;
                }
            }
            return null;
        }

        public string CheckTen()
        {
            while (true)
            {
                Console.WriteLine("Nhap ten:");
                var ten = Console.ReadLine();
                if(ten.ToLower().Equals("dog") || ten.ToLower().Equals("cat")
                    || ten.ToLower().Equals("pig") || ten.ToLower().Equals("chicken"))
                {
                    return ten;
                }
                else
                {
                    Console.WriteLine("Nhap sai fomat");
                    continue;
                }
            }
        }
        public bool CheckAnimaleExit(string id, string ten, double chieu_cao, double can_nang, string mau_sac, List<Animal> animals)
        {
            foreach (var o in animals)
            {
                if(id.Equals(o.Id) && ten.Equals(o.Ten)
                    && chieu_cao.Equals(o.Chieu_cao)
                    && can_nang.Equals(o.Can_nang)
                    && mau_sac.Equals(o.Mau_sac))
                {
                    return true;
                }
            }
            return false;
        }
    }
}


