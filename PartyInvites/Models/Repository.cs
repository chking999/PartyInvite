using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {
        public static readonly List<GuestResponse> Responses = new List<GuestResponse>();

        public static void AddResponse(GuestResponse response)
        {
            Responses.Add(response);
        }
    }
}
