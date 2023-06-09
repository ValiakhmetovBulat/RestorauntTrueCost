﻿namespace RestorauntTrueCost.Shared.Entities
{
    public class CartToPosition
    {
        public int Id { get; set; }

        public int MenuPositionId { get; set; }
        public virtual MenuPosition? MenuPosition { get; set; }

        public int Count { get; set; }

        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
