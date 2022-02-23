using System;
namespace Inheritance
{
    class Reptile : Animal
    {
        public bool DoesHibernate { get; set; }
        public bool IsAquatic { get; set; }
        public bool IsCarnivore { get; set; }
        public string Region { get; set; }

        public Reptile()
        {
        }
    }
}
