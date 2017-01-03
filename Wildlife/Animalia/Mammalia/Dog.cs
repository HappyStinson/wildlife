namespace Wildlife.Animalia
{
    class Dog : Animal
    {
        public bool Domestic { get; private set; }

        public Dog() : base("Dog", "Mammalia") { }
        public Dog(string species, bool domestic) : base(species, "Mammalia")
        {
            base.Initialize("Fur", "Dentastix", 17);
            Domestic = domestic;
        }

        public void MakeDomestic()
        {
            Species = "Petted " + Species;
            Domestic = true;
        }

        public string DomesticInfo() => Species + ": " + DomesticStatus();

        private string DomesticStatus()
        {
            var domestic = "No";
            if (Domestic)
                domestic = "Yes";

            return "Is domestic? " + domestic;
        }

        public override string ToString()
        {
            return base.ToString() +  "\n" + DomesticStatus();
        }
    }
}