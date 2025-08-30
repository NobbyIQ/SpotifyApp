using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Interfaces
{
    public interface ISpotifyTokenProvider
    {
        Task<string?> GetAccessTokenAsync();
    }
}
