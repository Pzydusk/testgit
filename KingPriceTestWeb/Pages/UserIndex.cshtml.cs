using KingPriceTestWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace KingPriceTestWeb.Pages
{
    public class UserIndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _clientFactory;

        public UserIndexModel(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;

        }

        public IList<UserViewModel> Users { get; set; }

        public string BaseUrl { get; private set; }

        public async Task OnGetAsync()
        {
            var client = _clientFactory.CreateClient("API");

            BaseUrl = _configuration.GetValue<string>("APIURL:BaseUrl");
            var response = await client.GetAsync(BaseUrl + "/api/users");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Users = JsonConvert.DeserializeObject<IList<UserViewModel>>(content);
            }
            else
            {
                // Handle error
            }
        }
    }
}
