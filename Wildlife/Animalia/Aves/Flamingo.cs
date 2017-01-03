namespace Wildlife.Animalia.Aves
{
    public class Flamingo : Bird
    {
        private string reproduction;

        public Flamingo() : base("Flamingo", 0.0) { }
        public Flamingo(string species, double wingSpan, string reproduction) : base(species, wingSpan)
        {
            this.reproduction = reproduction;
        }

        public override string ToString()
        {
            if (System.String.IsNullOrWhiteSpace(reproduction))
                return base.ToString();

            return base.ToString() + "\nReproduction: " + reproduction;
        }
    }
}