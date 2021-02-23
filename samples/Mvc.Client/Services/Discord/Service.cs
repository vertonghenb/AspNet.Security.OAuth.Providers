using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using static Mvc.Client.Services.Discord.Responses;

namespace Mvc.Client.Services.Discord
{
    public class Service : IService
    {
        private readonly HttpClient _client;
        private readonly ILogger<Service> _logger;

        public Service(HttpClient client, ILogger<Service> logger)
        {
            _client = client;
            _logger = logger;
        }

        public async Task<User?> GetCurrentUserAsync()
        {
            try
            {
                return await _client.GetFromJsonAsync<User?>("/api/users/@me");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Failed to {nameof(this.GetCurrentUserAsync)}");
                return null;
            }
        }

        public async Task<IEnumerable<Guild>?> GetCurrentUserGuildsAsync()
        {
            try
            {
                return await _client.GetFromJsonAsync<IEnumerable<Guild>?>("/api/users/@me/guilds");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Failed to {nameof(this.GetCurrentUserGuildsAsync)}");
                return null;
            }
        }
    }
}
