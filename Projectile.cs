using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal class Projectile
    {
        // Defines variables
        public float speed;
        public Vector2 position = new Vector2();
        public Vector2 direction = new Vector2();

        public Projectile(float speed, Vector2 position, Vector2 direction) // Allow variables to be defined when calling the class
        {
            // Sets new variables to the ones requested
            this.speed = speed;
            this.position = position;
            this.direction = direction;
        }

        public void ModifyBySpeedAndDirection() // Modifies the location/position depending on the direction the projectile is going and the speed of it
        {
            position += direction * speed;
            Console.WriteLine(position);
        }
    }
}
