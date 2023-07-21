using ElasticSearchDemo.Models;
using Nest;

namespace ElasticSearchDemo.Extensions
{
    public static class ElasticSearchExtensions
    {
        public static void AddElasticsearch(
            this IServiceCollection services, IConfiguration configuration)
        {
            var url = configuration["ELKConfiguration:Url"];
            var defaultIndex = configuration["ELKConfiguration:index"];

            var settings = new ConnectionSettings(new Uri(url))
                .PrettyJson()
                .DefaultIndex(defaultIndex);

            AddDefaultMappings(settings);

            var client = new ElasticClient(settings);

            services.AddSingleton<IElasticClient>(client);

            CreateIndex(client, defaultIndex);
        }

        private static void AddDefaultMappings(ConnectionSettings settings)
        {
            settings
                .DefaultMappingFor<Product>(m => m
                    .Ignore(p => p.Price)
                    .Ignore(p => p.Quantity)
                );
        }

        private static void CreateIndex(IElasticClient client, string indexName)
        {
            var createIndexResponse = client.Indices.Create(indexName,
                index => index.Map<Product>(x => x.AutoMap())
            );
        }
    }
    
}
