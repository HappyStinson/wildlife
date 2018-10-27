namespace Wildlife.Animalia
{
    class Worm : Animal
    {
        public double Length { get; set; }

        public Worm() : base("Worm", "Oligochaeta") { }

        public Worm(string species, double length) : base(species, "Oligochaeta")
        {
            base.Initialize("Epidermis", "Feeds on vegetation, refuses, and decayed animal matter in soil", 0.2);
            Length = length;
        }

        public override string ToString()
        {
            if (Length > 0)
                return base.ToString() + $"\nLength: {Length} m";

            return base.ToString();
        }
    }
}