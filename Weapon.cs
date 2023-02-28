using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal class Weapon
    {
        public Projectile[] ammolist = new Projectile[0];
        public string name;

        public Weapon(string name, int ammo)
        {
            this.name = name;
            this.ammolist = new Projectile[ammo];

            int i = 0;

            foreach (var projectile in ammolist)
            {
                ammolist[i] = new Projectile(3, new Vector2(0.0f,0.0f), new Vector2(3.0f, 2.0f));
                i++;
            }
        }
    }
}
