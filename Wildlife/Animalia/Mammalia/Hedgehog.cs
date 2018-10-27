namespace Wildlife.Animalia
{
    class Hedgehog : Animal
    {
        public string Habitat { get; set; }

        public Hedgehog() : base("Hedgehog", "Mammalia") { }
        public Hedgehog(string species, string habitat) : base(species, "Mammalia")
        {
            base.Initialize("Spikes", "Insects", 8.4);
            Habitat = habitat;
        }

        public override string ToString()
        {
            if (System.String.IsNullOrWhiteSpace(Habitat))
                return base.ToString();

            return base.ToString() + "\nHabitat: " + Habitat;
        }
    }
}