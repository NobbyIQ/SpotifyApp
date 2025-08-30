using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using SpotifyApiWrapper.AspNetCore;
using SpotifyApiWrapper.Http;
using SpotifyApiWrapper.Http.TokenProvider;
using System.Security.Claims;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSpotifyApi();

builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = "Cookies";
    options.DefaultChallengeScheme = "Spotify";
})
.AddCookie("Cookies")
.AddOAuth("Spotify", options =>
{
    options.ClientId = builder.Configuration["Authentication:Spotify:ClientId"] ?? string.Empty;
    options.ClientSecret = builder.Configuration["Authentication:Spotify:ClientSecret"] ?? string.Empty;
    options.CallbackPath = new PathString("/signin-spotify");
    options.AuthorizationEndpoint = "https://accounts.spotify.com/authorize";
    options.TokenEndpoint = "https://accounts.spotify.com/api/token";
    options.UserInformationEndpoint = "https://api.spotify.com/v1/me";
    options.Scope.Add("user-read-email");
    options.Scope.Add("user-read-private");
    options.Scope.Add("playlist-read-private");
    options.SaveTokens = true;
    options.ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
    options.ClaimActions.MapJsonKey(ClaimTypes.Name, "display_name");
    options.ClaimActions.MapJsonKey(ClaimTypes.Email, "email");
    options.Events = new OAuthEvents
    {
        OnCreatingTicket = async context =>
        {
            var request = new HttpRequestMessage(HttpMethod.Get, context.Options.UserInformationEndpoint);
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", context.AccessToken);
            var response = await context.Backchannel.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, context.HttpContext.RequestAborted);
            response.EnsureSuccessStatusCode();
            var user = JsonDocument.Parse(await response.Content.ReadAsStringAsync(context.HttpContext.RequestAborted));
            context.RunClaimActions(user.RootElement);
        }
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllers();

app.Run();
