namespace Wildlife.Animalia
{
    public class Animal
    {
        public string Class { get; set; }
        public string Species { get; set; }
        private string BodyCover { get; set; }
        private string Diet { get; set; }
        private double LifeSpan { get; set; }

        public Animal(string species)
        {
            Species = species;
        }

        public Animal(string species, string taxonomyClass) : this(species)
        {
            Class = taxonomyClass;
        }

        protected void Initialize(string bodyCover, string diet, double lifespan)
        {
            BodyCover = bodyCover;
            Diet = diet;
            LifeSpan = lifespan;
        }

        public override string ToString()
        {
            var text = "Scientific class: " + Class + "\nSpecies: " + Species;

            if (BodyCover != null)
                text += "\nBody cover: " + BodyCover;

            if (Diet != null)
                text += "\nDiet: " + Diet;

            if (LifeSpan > 0)
                text += $"\nLife-span: {LifeSpan} years";

            return text;
        }
    }
}