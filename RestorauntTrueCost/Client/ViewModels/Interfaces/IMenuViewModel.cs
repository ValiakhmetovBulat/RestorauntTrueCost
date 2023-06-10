using RestorauntTrueCost.Shared.Entities;

namespace RestorauntTrueCost.Client.ViewModels.Interfaces
{
    public interface IMenuViewModel
    {
        public List<Section> MenuSections { get; set; }
        public List<PositionType> MenuPositionTypes { get; set; }
        public List<MenuPosition> MenuPositions { get; set; }
        public List<CartToPosition> Cart { get; set; }
        public Section? SelectedSection { get; set; }
        public PositionType? SelectedType { get; set; }
        public Task<List<MenuPosition>> GetMenuPositions();
        public Task<List<Section>> GetMenuPositionSections();
        public Task<List<PositionType>> GetMenuPositionTypes();
        public Task<List<CartToPosition>> GetCart();
        public void ChangeSection(Section section);
        public void ChangeTypes(PositionType type);
        public Task AddToCart(int positionId);
        public Task RemoveFromCart(int positionId);
        public Task RemoveAllPositionFromCart(int positionId);

    }
}
