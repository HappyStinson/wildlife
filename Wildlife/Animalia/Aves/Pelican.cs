using System;

namespace Wildlife.Animalia.Aves
{
    public class Pelican : Bird
    {
        public string Fact { get; set; }

        public Pelican() : base("Pelican", 0.0) { }
        public Pelican(string species, double wingSpan, string fact) : base(species, wingSpan)
        {
            Fact = fact;
        }

        public override string ToString()
        {
            if (Fact != null)
                return base.ToString() + "\nInteresting fact: " + Fact;

            return base.ToString();
        }
    }
}