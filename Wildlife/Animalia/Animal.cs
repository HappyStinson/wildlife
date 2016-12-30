namespace Wildlife
{
    public class Animal
    {
        public string Class { get; set; }
        public string Species { get; set; }
        public string BodyCover { get; set; }
        public string PreferedFood { get; set; }
        public int LifeSpan { get; set; }

        public Animal(string species)
        {
            Species = species;
        }
    }
}