                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    using HotelApiProject.Models;
using HotelApiProject.Models.Requests;
using HotelApiProject.Models.Responses;
using HotelApiProject.Models.Responses.ProductInfos;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace HotelApiProject.Services;

public class SantsgApiService : ISantsgApiService
{
    private HttpClient _httpClient;
    private readonly HotelApiProject.Models.LoginRequest loginRequest = new()
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

    public async Task<HotelApiProject.Models.TokenResponse?> LoginAsync(HotelApiProject.Models.LoginRequest request)
    {
        
        string loginPath = "authenticationservice/login";
        var httpResponse = await _httpClient.PostAsJsonAsync(loginPath, request);
    HotelApiProject.Models.TokenResponse? tokenResponse = await httpResponse.Content.ReadFromJsonAsync<HotelApiProject.Models.TokenResponse>();
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
            _httpClient.DefaultRequestHeaders.Add($"Authorization", $"Bearer {tokenResponse.Body.Token}");

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

            _httpClient.DefaultRequestHeaders.Add($"Authorization", $"Bearer {tokenResponse.Body.Token}");
            var response = await _httpClient.PostAsJsonAsync("priceservice/search", request);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<PriceSearchResponse>();
            return result;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Fiyat arama isteği hatası: {e.Message}");
            return null;
        }
    }

    public async Task<Models.Responses.BeginTransactionResponse.BeginTransactionResponse> GetBeginTransactionAsync(BeginTransactionRequest request)
    {
        try
        {
            var tokenResponse = await LoginAsync(loginRequest);
            if (tokenResponse == null) return null;

            _httpClient.DefaultRequestHeaders.Add($"Authorization", $"Bearer {tokenResponse.Body.Token}");
            var response = await _httpClient.PostAsJsonAsync("transactionservice/begintransaction", request);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<Models.Responses.BeginTransactionResponse.BeginTransactionResponse>();
            return result;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"İşlem başlatma isteği hatası: {e.Message}");
            return null;
        }
    }

    public async Task<CommitTransactionResponse> GetCommitTransactionAsync(CommitTransactionRequest request)
    {
        try
        {
            var tokenResponse = await LoginAsync(loginRequest);
            if (tokenResponse == null) return null;

            _httpClient.DefaultRequestHeaders.Add($"Authorization", $"Bearer {tokenResponse.Body.Token}");
            var response = await _httpClient.PostAsJsonAsync("transactionservice/committransaction", request);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<CommitTransactionResponse>();
            return result;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"İşlem onaylama isteği hatası: {e.Message}");
            return null;
        }
    }

    public async Task<SetReservationInfoResponse> GetSetReservationInfoAsync(SetReservationInfoRequest request)
    {
        try
        {
            var tokenResponse = await LoginAsync(loginRequest);
            if (tokenResponse == null) return null;

            _httpClient.DefaultRequestHeaders.Add($"Authorization", $"Bearer {tokenResponse.Body.Token}");
            var response = await _httpClient.PostAsJsonAsync("transactionservice/setreservationinfo", request);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<SetReservationInfoResponse>();
            return result;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Rezervasyon bilgisi ayarlama isteği hatası: {e.Message}");
            return null;
        }
    }
    // ...existing code...
    public async Task<GetCheckinDatesResponse?> GetCheckinDatesAsync(GetCheckinDatesRequest request)
    {
        try
        {
            var tokenResponse = await LoginAsync(loginRequest);
            if (tokenResponse == null) return null;
            _httpClient.DefaultRequestHeaders.Add($"Authorization", $"Bearer {tokenResponse.Body.Token}");



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
    Task<HotelApiProject.Models.TokenResponse?> LoginAsync(HotelApiProject.Models.LoginRequest request);
    Task<HotelSearchResponse> SearchHotelsAsync(HotelSearchRequest request);
   
}