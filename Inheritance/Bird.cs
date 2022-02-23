using System;
namespace Inheritance
{
    class Bird : Animal
    {
        public bool IsBirdOfPrey { get; set; }
        public bool CanFly { get; set; }
        public bool DoesMigrate { get; set; }
        public bool IsDomesticated { get; set; }

        public Bird()
        {
        }
    }
}
