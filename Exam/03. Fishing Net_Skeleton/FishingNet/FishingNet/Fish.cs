namespace FishingNet
{
    public class Fish
    {
        public string FishType;
        public double Lenght;
        public double Weight;

        public Fish(string fishType, double lenght, double weight)
        {
            this.FishType = fishType;
            this.Lenght = lenght;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return $"There is a {FishType}, {Lenght} cm. long, and {Weight} gr. in weight.";
        }
    }
}
