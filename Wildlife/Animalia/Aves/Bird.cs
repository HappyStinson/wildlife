namespace Wildlife.Animalia.Aves
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird() : base("Bird", "Aves") { }
        public Bird(string species, double wingSpan) : base(species, "Aves")
        {
            base.Initialize("Feathers", "Vegetables", 25);
            WingSpan = wingSpan;
        }

        public override string ToString()
        {
            if (WingSpan > 0)
                return base.ToString() + $"\nWing span: {WingSpan} m";

            return base.ToString();
        }
    }
}