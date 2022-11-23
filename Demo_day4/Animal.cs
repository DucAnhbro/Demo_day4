using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_day4
{
    internal class Animal
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public double Chieu_cao { get; set; }
        public double Can_nang { get; set; }
        public string Mau_sac { get; set; }

        public Animal()
        {
        }

        public Animal(int id, string ten,double chieu_cao, double can_nang, string mau_sac)
        {
            Id = id;
            Ten = ten;
            Chieu_cao = chieu_cao;
            Can_nang = can_nang;
            Mau_sac = mau_sac;
        }
        

        public virtual string Output()
        {
            return "Id"+"Ten"+"Chieu_cao" + "" + "Can_nang" + "" + "Mau_sac" + ToString();  ;
        }

    }

   
}
