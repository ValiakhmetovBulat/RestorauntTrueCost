namespace RestorauntTrueCost.Shared.Entities
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? HashColor { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
