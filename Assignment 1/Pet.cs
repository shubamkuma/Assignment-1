namespace VirtualPet
{
    internal class Pet
    {
        private string cat;
        private string? chini;

        public Pet(string cat, string? chini)
        {
            this.cat = cat;
            this.chini = chini;
        }

        public object Cat { get; internal set; }
        public object Chini { get; internal set; }
    }
}