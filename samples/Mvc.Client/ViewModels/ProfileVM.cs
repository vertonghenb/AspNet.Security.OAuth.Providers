using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Mvc.Client.Services.Discord.Responses;

namespace Mvc.Client.ViewModels
{
    public class ProfileVM
    {
        public string? Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public IEnumerable<Guild>? Guilds { get; set; }
    }
}
