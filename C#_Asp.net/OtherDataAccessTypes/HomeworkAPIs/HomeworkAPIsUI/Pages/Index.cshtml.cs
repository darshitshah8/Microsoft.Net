using HomeworkAPIsUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HomeworkAPIsUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        public PersonModel person;
        public List<FilmsModel> films = new List<FilmsModel>();

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task OnGet()
        {
            await GetPerson();
            await GetAllFilms();
        }

        [HttpGet]
        private async Task GetAllFilms()
        {
            foreach (var item in person.films)
            {
                FilmsModel film;
                var _client = _httpClientFactory.CreateClient();
                var response = await _client.GetAsync(item);

                if (response.IsSuccessStatusCode)
                {
                    var option = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                    string responceText = await response.Content.ReadAsStringAsync();

                    film = JsonSerializer.Deserialize<FilmsModel>(responceText, option);

                    films.Add(film);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
        private async Task GetPerson()
        {
            var _client = _httpClientFactory.CreateClient();
            var response = await _client.GetAsync("https://swapi.dev/api/people/4/");


            if (response.IsSuccessStatusCode)
            {
                var option = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                string responceText = await response.Content.ReadAsStringAsync();

                person = JsonSerializer.Deserialize<PersonModel>(responceText, option);
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

    }
}
