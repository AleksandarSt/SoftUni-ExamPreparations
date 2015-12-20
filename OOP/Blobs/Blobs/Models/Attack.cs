using Blobs.Models.Interfaces;
using System;
namespace Blobs.Models
{
    public class Attack:IAttack
    {
        private string name;

        public Attack(string name)
        {
            this.Name = name;
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

        public virtual void ExecuteAttack()
        {
        }
    }
}
