namespace RestorauntTrueCost.Shared.Entities
{
    public class OrderToPosition
    {
        public int Id { get; set; }

        public int MenuPositionId { get; set; }
        public virtual MenuPosition? MenuPosition { get; set; }

        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }

        public int Count { get; set; }
    }
}
