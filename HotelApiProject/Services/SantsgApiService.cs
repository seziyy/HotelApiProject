using HotelApiProject.Models;
using Microsoft.AspNetCore.Identity.Data;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace HotelApiProject.Services;

public class SantsgApiService : ISanTsqApi
{
    private HttpClient _httpClient;
    private readonly Models.LoginRequest loginRequest = new()
    {
        Agency = "INTERNSHIP",
        User = "INTERNSHIP",
        Password = "@San2025"
    };
    public SantsgApiService(HttpClient httpClient)
    {


        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://test-service.tourvisio.com/v2/api/");

        //var authString = "B2B:B2B:123456";
        //var authBytes = Encoding.UTF8.GetBytes(authString);
        //var base64Auth = Convert.ToBase64String(authBytes);

        //_httpClient.DefaultRequestHeaders.Authorization =
        // new AuthenticationHeaderValue("Basic", base64Auth);

    }

    public async Task<TokenResponse?> LoginAsync(HotelApiProject.Models.LoginRequest request)
    {
        
        string loginPath = "authenticationservice/login";
        var httpResponse = await _httpClient.PostAsJsonAsync(loginPath, request);
        TokenResponse? tokenResponse = await httpResponse.Content.ReadFromJsonAsync<TokenResponse>();
        return tokenResponse;
    }

    public async Task<HotelSearchResponse> SearchHotelsAsync(HotelSearchRequest request)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("HotelSearch", request);


            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<HotelSearchResponse>();

            if (result == null)
            {
                return null;
            }

            return result;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"İstek hatası: {e.Message}");
            return null;
        }
    }
    public async Task<ProductInfoResponse> GetProductInfoAsync(ProductInfoRequest request)
    {
        try
        {

            var tokenResponse = await LoginAsync(loginRequest);
            if (tokenResponse == null) return null;

            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenResponse.Body.Token}");

            var response = await _httpClient.PostAsJsonAsync("productservice/getproductinfo", request);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<ProductInfoResponse>();
            return result;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Otel detayları isteği hatası: {e.Message}");

            return null;
        }
        
    }
   
    public async Task<PriceSearchResponse> GetPriceSearchAsync(PriceSearchRequest request)
    {
        try
        {
            var tokenResponse = await LoginAsync(loginRequest);
            if (tokenResponse == null) return null;

            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenResponse.Body.Token}");

            var response = await _httpClient.PatchAsJsonAsync("productservice/pricesearch", request);
            response.EnsureSuccessStatusCode();


            var result = await response.Content.ReadFromJsonAsync<PriceSearchResponse>();
            return result;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Fiyat sorgulama isteği hatası: {e.Message}");
            return null;
        }
    }
    public async Task<GetCheckinDatesResponse?> GetCheckinDatesAsync(GetCheckinDatesRequest request)
    {
        try
        {
            var tokenReponse = await LoginAsync(loginRequest);
            if (tokenReponse == null) return null;

            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenReponse.Body.Token}");



            var response = await _httpClient.PostAsJsonAsync("productservice/getcheckindates", request);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<GetCheckinDatesResponse>();

            return result;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Giriş tarihleri isteği hatası: {e.Message}");
            return null;
        }
    }
    public async Task<AutocompleteResponse?> GetAutocompleteAsync(AutocompleteRequest request)
    {
        try
        {
            var tokenResponse = await LoginAsync(loginRequest);
            if (tokenResponse == null) return null;

            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenResponse.Body.Token}");

            var response = await _httpClient.PostAsJsonAsync("productservice/getarrivalautocomplete", request);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<AutocompleteResponse>();
            return result;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Autocomplete isteği hatası: {e.Message}");
            return null;
        }
    }

}



public interface ISanTsqApi
{
    Task<AutocompleteResponse?> GetAutocompleteAsync(AutocompleteRequest request);
    Task<GetCheckinDatesResponse?> GetCheckinDatesAsync(GetCheckinDatesRequest request);
    Task<PriceSearchResponse> GetPriceSearchAsync(PriceSearchRequest request);
    Task<ProductInfoResponse> GetProductInfoAsync(ProductInfoRequest request);
    Task<TokenResponse?> LoginAsync(Models.LoginRequest request);
    Task<HotelSearchResponse> SearchHotelsAsync(HotelSearchRequest request);
   
}