using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Client.Services.Discord
{
    public static class Responses
    {
        public class User
        {
            public string? Id { get; set; }

            public string? Username { get; set; }

            public string? Discriminator { get; set; }

            public string? Avatar { get; set; }

            public bool Verified { get; set; }

            public string? Email { get; set; }

            public int Flags { get; set; }
        }

        public class Guild
        {
            public string? Id { get; set; }

            public string? Name { get; set; }

            public string? Icon { get; set; }

            public bool Owner { get; set; }

            public IEnumerable<string>? Features { get; set; }
        }
    }
}
