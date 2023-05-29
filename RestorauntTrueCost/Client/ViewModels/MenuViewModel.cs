using RestorauntTrueCost.Client.ViewModels.Interfaces;
using RestorauntTrueCost.Shared.Entities;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net.Http.Json;

namespace RestorauntTrueCost.Client.ViewModels
{
    public class MenuViewModel : IMenuViewModel
    {
        public List<Section> MenuSections { get; set; } = new List<Section>();
        public List<PositionType> MenuPositionTypes { get; set; } = new List<PositionType>();
        public List<MenuPosition> MenuPositions { get; set; } = new List<MenuPosition>();
        public List<CartToPosition> Cart { get; set; } = new List<CartToPosition>();
        public Section? SelectedSection { get; set; }
        public PositionType? SelectedType { get; set; } 

        private HttpClient _httpClient;

        public MenuViewModel()
        {

        }

        public MenuViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<MenuPosition>> GetMenuPositions()
        {
            return await _httpClient.GetFromJsonAsync<List<MenuPosition>>("api/Menu");
        }

        public async Task<List<Section>> GetMenuPositionSections()
        {
            var sections = await _httpClient.GetFromJsonAsync<List<Section>>("api/Section");
            if (sections != null)
            {
                SelectedSection = sections.FirstOrDefault();
            }

            return sections;
        }        

        public async Task<List<PositionType>> GetMenuPositionTypes()
        {
            var positionTypes = await _httpClient.GetFromJsonAsync<List<PositionType>>("api/PositionTypes");
            if (positionTypes != null)
            {
                SelectedType = positionTypes.Where(t => t.SectionId == SelectedSection.Id).FirstOrDefault();
            }
            return positionTypes;
        }

        public async Task<List<CartToPosition>> GetCart()
        {
            return await _httpClient.GetFromJsonAsync<List<CartToPosition>>("api/cart/mycart");
        }

        public void ChangeSection(Section section)
        {
            SelectedSection = section;
            SelectedType = MenuPositionTypes.Where(t => t.SectionId == SelectedSection.Id).FirstOrDefault();
        }

        public void ChangeTypes(PositionType type)
        {
            SelectedType = type;
        }

        public async Task AddToCart(int positionId)
        {
            var resp = await _httpClient.PostAsJsonAsync("api/cart/add/" + positionId, positionId);            

            if (resp.IsSuccessStatusCode)
            {
                Cart = await GetCart();
            }
        }

        public async Task RemoveFromCart(int positionId)
        {
            var resp = await _httpClient.PostAsJsonAsync("api/cart/remove/" + positionId, positionId);           

            if (resp.IsSuccessStatusCode)
            {
                Cart = await GetCart();
            }
        }

        public async Task RemoveAllPositionFromCart(int positionId)
        {
            await _httpClient.DeleteFromJsonAsync<List<CartToPosition>>("api/cart/removeall/" + positionId);

            Cart = await GetCart();
        }
    }
}
