namespace Wildlife.Animalia
{
    class Horse : Animal
    {
        public string Breed { get; set; }

        public Horse() : base("Horse", "Mammalia") { }
        public Horse(string species, string breed) : base(species, "Mammalia")
        {
            base.Initialize("Fur", "Grass and Carrots", 18);
            Breed = breed;
        }

        public override string ToString()
        {
            if (System.String.IsNullOrWhiteSpace(Breed))
                return base.ToString();

            return base.ToString() + "\nBreed: " + Breed;
        }
    }
}