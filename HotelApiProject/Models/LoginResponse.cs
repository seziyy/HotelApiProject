using System.Text.Json.Serialization;

namespace HotelApiProject.Models;

public class TokenResponse
{
    [JsonPropertyName("body")]
    public TokenBody Body { get; set; }

    [JsonPropertyName("header")]
    public ResponseHeader Header { get; set; }
}

public class TokenBody
{
    [JsonPropertyName("token")]
    public string Token { get; set; }

    [JsonPropertyName("expiresOn")]
    public DateTime ExpiresOn { get; set; }

    [JsonPropertyName("tokenId")]
    public int TokenId { get; set; }

    [JsonPropertyName("userInfo")]
    public UserInfo UserInfo { get; set; }

    [JsonPropertyName("loggedInWithMasterKey")]
    public bool LoggedInWithMasterKey { get; set; }
}

public class UserInfo
{
    [JsonPropertyName("mainAgency")]
    public AgencyDetails MainAgency { get; set; }

    [JsonPropertyName("agency")]
    public AgencyDetails Agency { get; set; }

    [JsonPropertyName("office")]
    public OfficeDetails Office { get; set; }

    [JsonPropertyName("operator")]
    public OperatorDetails Operator { get; set; }

    [JsonPropertyName("market")]
    public MarketDetails Market { get; set; }

    [JsonPropertyName("webSiteId")]
    public int WebSiteId { get; set; }

    // ... Diğer tüm özellikleri buraya ekleyin
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }
}

// Yardımcı sınıflar
public class AgencyDetails
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    // ... Diğer özellikleri buraya ekleyin
}

public class OfficeDetails
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class OperatorDetails
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    // ... Diğer özellikleri buraya ekleyin
}

public class MarketDetails
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    // ... Diğer özellikleri buraya ekleyin
}

public class ResponseHeader
{
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; }

    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("responseTime")]
    public DateTime ResponseTime { get; set; }

    [JsonPropertyName("messages")]
    public List<MessageInfo> Messages { get; set; }
}

public class MessageInfo
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("messageType")]
    public int MessageType { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}