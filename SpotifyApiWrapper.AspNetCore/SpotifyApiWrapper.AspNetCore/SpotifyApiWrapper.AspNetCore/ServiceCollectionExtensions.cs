using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using SpotifyApiWrapper.Handlers;
using SpotifyApiWrapper.Http;
using SpotifyApiWrapper.Http.TokenProvider;
using SpotifyApiWrapper.Interfaces;
using SpotifyApiWrapper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpotifyApiWrapper.SpotifyClient;

namespace SpotifyApiWrapper.AspNetCore
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSpotifyApi(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddScoped<ISpotifyTokenProvider, SpotifyTokenProvider>();
            services.AddScoped<IPlaylistService, PlaylistService>();
            services.AddScoped<ISpotifyClient, SpotifyClient>();
            services.AddTransient<SpotifyAuthHandler>();

            services.AddHttpClient<ISpotifyApiHttpClient, ISpotifyApiHttpClient>(client =>
            {
                client.BaseAddress = new Uri("https://api.spotify.com/v1/");
            })
            .AddHttpMessageHandler<SpotifyAuthHandler>();

            return services;
        }
    }
}
