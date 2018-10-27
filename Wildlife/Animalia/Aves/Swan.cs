using System;

namespace Wildlife.Animalia.Aves
{
    public class Swan : Bird
    {
        public int Speed { get; set; }

        public Swan() : base("Swan", 0.0) { }
        public Swan(string species, double wingSpan, int speed) : base(species, wingSpan)
        {
            Speed = speed;
        }

        public override string ToString()
        {
            if (Speed > 0)
                return base.ToString() + "\nSpeed: " + Speed;

            return base.ToString();
        }
    }
}