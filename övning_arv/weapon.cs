using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_arv
{
    class weapon
    {
        //public string name = "";
        public int minDamage;
        public int maxDamage;

        static Random gen = new Random();

        public int damage(int damage)
        {
            minDamage = gen.Next(30, 100);
            maxDamage = gen.Next(30, 100);
            return gen.Next(minDamage, maxDamage);

        }

        gun w1 = new gun();
        bomb w2 = new bomb();

        public string printStats(string printStats)
        {
            Console.WriteLine(w1.name + w1.maxDamage + w1.minDamage);
            Console.WriteLine(w2.name + w2.maxDamage + w1.minDamage);
            return printStats;
        }

    }
}
