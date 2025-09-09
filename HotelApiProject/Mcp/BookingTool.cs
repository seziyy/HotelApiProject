using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using HotelApiProject.Models.Requests;
using HotelApiProject.Services;
using ModelContextProtocol.Server;
using System.Reflection.Metadata.Ecma335;


namespace HotelApiProject.Mcp;



[McpServerToolType]
public class BookingTool
{
    private readonly ISantsgApiService _santsgApiService;

    public BookingTool(ISantsgApiService santsgApiService)
    {
        _santsgApiService = santsgApiService;
    }

    [McpServerTool, Description("Fiyat arama işlemi yapar. product type for hotel is 2.")]
    public async Task<object?> BeginTransactionAsync(BeginTransactionRequest request)
    {
        var result = await _santsgApiService.GetBeginTransactionAsync(request);
        if (result == null)
        {
            return new { message = "Hiç Sonuç yok." };
        }
        return result;

    }

    [McpServerTool, Description("Başlatılmış işlemi onaylar ve kalıcı hale getirir. product type for hotel is 2.")]
    public async Task<object?> CommitTransactionAsync(CommitTransactionRequest request)
    {
        var result = await _santsgApiService.GetCommitTransactionAsync(request);
        if (result == null)
        {
            return new { message = "Hiç Sonuç yok." };
        }
        return result;

    }
    /*
    [McpServerTool, Description("Rezervasyon bilgilerini ayarlar ve işleme gönderir. product type for hotel is 2.")]
    public async Task<object?> SetReservationInfoAsync(SetReservationRequest request)
    {
        var result = await _santsgApiService.GetSetReservationInfoAsync(request);
        if (result == null)
        {
            return new { message = "Hiç Sonuç yok." };
        }
        return result;

    }
    */

}
