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

        public void useWeapon() // Uses up one ammo slot and sets it to null (also checks if there is enough remaning (non null) ammo left before doing so)
        {
            // variables needed for foreach loop
            bool isAmmo = false;
            int i = 0;

            foreach (var projectile in ammolist) // Loops through all the slots in the ammo list
            {
                if (ammolist[i] != null) // Checks if there is ammo in that slot
                {
                    ammolist[i] = null; // Removes ammo from the slot
                    isAmmo = true; // Sets a variable which says if it has detected ammo or not
                    Console.WriteLine($"Your {name} has been fired"); // Tell the user that the gun has been fired
                    break; // End the foreach loop early as it has already found the ammo it needed
                }
                i++;
            }
            if (!isAmmo) // Checks if the isAmmo is not true (should only be set to this if no ammo is found in the table)
            {
                Console.WriteLine($"Your {name} has no ammo left");
            }
        }
    }
}
