using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_day4
{
    internal class Chicken : Animal, Tieng_keu
    {
        public void Spiker()
        {
            Console.WriteLine("cuc cuc cuc");
        }
        public override string Output()
        {
            return base.Output();
            Spiker();
        }
    }
}
