                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    using HotelApiProject.Models;
using HotelApiProject.Models.Requests;
using HotelApiProject.Models.Responses;
using HotelApiProject.Models.Responses.BeginTransactionResponse;
using HotelApiProject.Models.Responses.ProductInfos;


namespace HotelApiProject.Services;

public interface ISantsgApiService
{
    Task<AutocompleteResponse?> GetAutocompleteAsync(AutocompleteRequest request);
    Task<GetCheckinDatesResponse?> GetCheckinDatesAsync(GetCheckinDatesRequest request);
    Task<PriceSearchResponse> GetPriceSearchAsync(PriceSearchRequest request);
    Task<ProductInfoResponse> GetProductInfoAsync(ProductInfoRequest request);
    Task<HotelApiProject.Models.TokenResponse?> LoginAsync(HotelApiProject.Models.LoginRequest request);
    Task<HotelSearchResponse> SearchHotelsAsync(HotelSearchRequest request);
    Task<BeginTransactionResponse> GetBeginTransactionAsync(BeginTransactionRequest request);
    Task<CommitTransactionResponse> GetCommitTransactionAsync(CommitTransactionRequest request);
    Task<SetReservationInfoResponse> GetSetReservationInfoAsync(SetReservationInfoRequest request);
}