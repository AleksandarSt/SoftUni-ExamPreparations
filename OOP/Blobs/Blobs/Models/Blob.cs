using System;

namespace Blobs.Models
{
    public class Blob
    {
        private string name;

        private int health;

        private int damage;

        private Behavior behavior;

        private Attack attack;

        public Blob(string name, int health, int damage,Behavior behavior,Attack attack)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            //this.Behavior = new Behavior();
            //this.Attack = new Attack();
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please enter valid name");
                }

                this.name = value;
            }
        }

        public int Health 
        {
            get { return this.health; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentException("Health cannot be negative.");
                }

                this.health=value;
            } 
        }

        public int Damage
        {
            get { return this.damage; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Damage cannot be negative.");
                }

                this.damage = value;
            } 
        }

        //public Behavior Behavior { get; set; }

        //public Attack Attack { get; set; }
    }
}
