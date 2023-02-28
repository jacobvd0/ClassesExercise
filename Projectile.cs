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
        public float speed;
        public Vector2 position = new Vector2();
        public Vector2 direction = new Vector2();

        public Projectile(float speed, Vector2 position, Vector2 direction) // Allow variables to be defined when calling the class
        {
            this.speed = speed;
            this.position = position;
            this.direction = direction;
        }

        public void ModifyBySpeedAndDirection()
        {
            position += direction * speed;
            Console.WriteLine(position);
        }
    }
}
