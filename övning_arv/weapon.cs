using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_arv
{
    class weapon
    {
        public string name = "";
        public int minDamage = 30;
        public int maxDamage = 100;

        Random gen = new Random();

        public int damage(int damage)
        {
            minDamage = gen.Next(30, 100);
            maxDamage = gen.Next(30, 100);
            return gen.Next(minDamage, maxDamage);

        }

    }
}
