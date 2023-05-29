using Microsoft.AspNetCore.Components.Authorization;
using RestorauntTrueCost.Shared.Entities;
using System.Net.Http.Json;
using System.Security.Claims;

namespace RestorauntTrueCost.Client.Models.Authentication
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;

        public CustomAuthStateProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            User currentUser = await _httpClient.GetFromJsonAsync<User>("api/user/whoami");

            if (currentUser != null && currentUser.Email != null)
            {
                var claimEmail = new Claim(ClaimTypes.Email, currentUser.Email);
                var claimNameIdentifier = new Claim(ClaimTypes.NameIdentifier, Convert.ToString(currentUser.Id));
                var claimRole = new Claim(ClaimTypes.Role, Convert.ToString(currentUser.Role.Name));
                var claimsIdentity = new ClaimsIdentity(new[] { claimEmail, claimNameIdentifier, claimRole }, "serverAuth");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                return new AuthenticationState(claimsPrincipal);
            }

            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }

    }
}


