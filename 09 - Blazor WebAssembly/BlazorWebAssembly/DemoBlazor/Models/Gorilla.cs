namespace DemoBlazor.Models
{
    public class Gorilla
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool OwnsBanana { get; set; }
        public FurColor FurColor { get; set; }

        public override string ToString()
        {
            return $"{Name} {Description} {OwnsBanana} {FurColor}";
        }
    }
    public enum FurColor
    {
        Red,
        Brown,
        Pink,
        Orange,
        White
    }
}
