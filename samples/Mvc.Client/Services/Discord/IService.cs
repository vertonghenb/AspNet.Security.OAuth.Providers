using System.Collections.Generic;
using System.Threading.Tasks;
using static Mvc.Client.Services.Discord.Responses;

namespace Mvc.Client.Services.Discord
{
    public interface IService
    {
        Task<User?> GetCurrentUserAsync();

        Task<IEnumerable<Guild>?> GetCurrentUserGuildsAsync();
    }
}
