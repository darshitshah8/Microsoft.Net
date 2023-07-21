using ApiDbUi.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Xml;


namespace ApiDbUi.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(ILogger<IndexModel> logger , IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task OnGet()
        {
            await CreateContact();
            await GetAllContacts();
        }

        private async Task CreateContact()
        {
            ContactModel contact = new ContactModel
            {
                FirstName = "Tim",
                LastName = "Timati",
            };
                contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "timtimati@her.com" });
                contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "timatia@this.com" });

                contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "9877810000" });
                contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "9876500202" });


            var _client = _httpClientFactory.CreateClient();
            var response = await _client.PostAsync(
                "https://localhost:44368/api/Contacts",
                new StringContent(JsonSerializer.Serialize(contact),
                Encoding.UTF8,
                "application/json"));
        }


        private async Task GetAllContacts()
        {
            var _client = _httpClientFactory.CreateClient();
            var response = await _client.GetAsync("https://localhost:44368/api/Contacts");

            List<ContactModel> contacts;
            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };
                string responseText = await response.Content.ReadAsStringAsync();       
                contacts = JsonSerializer.Deserialize<List<ContactModel>>(responseText,options);  
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}