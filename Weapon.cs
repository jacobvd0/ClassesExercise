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

        public Weapon(string name, int ammo) // Requires a name and amount of ammo
        {
            this.name = name; // Changes the weapon name to the requested one
            this.ammolist = new Projectile[ammo]; // Makes a new list with the required space for the amount of ammo

            int i = 0; // Makes the int for the foreach loop

            foreach (var projectile in ammolist) // Loops through all the ammo slots in the array and puts ammo in them
            {
                ammolist[i] = new Projectile(3, new Vector2(0.0f,0.0f), new Vector2(3.0f, 2.0f));
                i++;
            }
        }
    }
}
