using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Glock17 : Weapons
    {
        private int weight = 15;
        private int clipSize = 8;
        public const int minDamage = 8;
        public const int maxDamage = 15;      
        public Glock17()
        {
            setName("Glock17");
            setWeight(weight);
        }
    }
}
