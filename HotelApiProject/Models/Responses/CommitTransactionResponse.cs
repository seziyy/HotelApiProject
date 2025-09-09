using System.Text.Json.Serialization;

namespace HotelApiProject.Models.Responses;

public class CommitTransactionResponse
{
    public Header Header { get; set; }
    public CommitTransactionResponseBody Body { get; set; }
}


public class CommitTransactionResponseBody
{
    public string ReservationNumber { get; set; }
    public string EncryptedReservationNumber { get; set; }
    public string TransactionId { get; set; }
 
}

public class ReservationDataDto
{
    public List<TravellerDto> Travellers { get; set; }
    public ReservationInfoDto ReservationInfo { get; set; }
    public List<ServiceDto> Services { get; set; }
    public PaymentDetailDto PaymentDetail { get; set; }
    public PermissionInfoDto PermissionInfo { get; set; }
    public List<object> Invoices { get; set; }
    public List<object> Journal { get; set; }
}

public class TravellerDto
{
    public string TravellerId { get; set; }
    public int Type { get; set; }
    public int Title { get; set; }
    public List<AvailableTitleDto> AvailableTitles { get; set; }
    public AcademicTitleDto AcademicTitle { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public bool IsLeader { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age { get; set; }
    public NationalityDto Nationality { get; set; }
    public string IdentityNumber { get; set; }
    public PassportInfoDto PassportInfo { get; set; }
    public AddressDto Address { get; set; }
    public List<ServiceDto> Services { get; set; }
    public int Gender { get; set; }
    public int OrderNumber { get; set; }
    public List<string> RequiredFields { get; set; }
    public List<object> Documents { get; set; }
    public int PassengerType { get; set; }
    public AdditionalFieldsDto AdditionalFields { get; set; }
    public int Status { get; set; }
}

public class AvailableTitleDto
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class AcademicTitleDto
{
    public string Id { get; set; }
}

public class NationalityDto
{
    public string Name { get; set; }
    public string TwoLetterCode { get; set; }
    public string ThreeLetterCode { get; set; }
    public string NumericCode { get; set; }
    public string IsdCode { get; set; }
}

public class PassportInfoDto
{
    public string Serial { get; set; }
    public string Number { get; set; }
    public DateTime ExpireDate { get; set; }
    public DateTime IssueDate { get; set; }
    public string CitizenshipCountryCode { get; set; }
}

public class AddressDto
{
    public ContactPhoneDto ContactPhone { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string ZipCode { get; set; }
    public CityDto City { get; set; }
    public CountryDto Country { get; set; }
}

public class ContactPhoneDto
{
    public string CountryCode { get; set; }
    public string PhoneNumber { get; set; }
}

public class CityDto
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class CountryDto
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class ServiceDto
{
    public int OrderNumber { get; set; }
    public string Note { get; set; }
    public PriceDto Price { get; set; }
    public bool IsRefundable { get; set; }
    public bool Bundle { get; set; }
    public CancellationPolicyDto CancellationPolicy { get; set; }
    public List<DocumentDto> Documents { get; set; }
    public string EncryptedServiceNumber { get; set; }
    public PriceDto PriceBreakdowns { get; set; }
    public int Commission { get; set; }
    public ReservableInfoDto ReservableInfo { get; set; }
    public int Unit { get; set; }
    public bool ThirdPartyExt { get; set; }
    public int ConfirmationStatus { get; set; }
    public int ServiceStatus { get; set; }
    public int ProductType { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Adult { get; set; }
    public int Child { get; set; }
    public int Infant { get; set; }
    public bool IncludePackage { get; set; }
    public bool Compulsory { get; set; }
    public bool IsExtraService { get; set; }
    public int Provider { get; set; }
    public List<string> Travellers { get; set; }
    public bool ThirdPartyRecord { get; set; }
    public int RecordId { get; set; }
    public AdditionalFieldsDto AdditionalFields { get; set; }
}

public class PriceDto
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }
}

public class CancellationPolicyDto
{
    public DateTime BeginDate { get; set; }
    public DateTime DueDate { get; set; }
    public PriceDto Price { get; set; }
    public int Provider { get; set; }
}

public class DocumentDto
{
    public int DocumentType { get; set; }
    public string Url { get; set; }
    public string Name { get; set; }
    public bool IsDefault { get; set; }
    public bool Proforma { get; set; }
    public int FromToType { get; set; }
}

public class ReservableInfoDto
{
    public bool Reservable { get; set; }
    public DateTime OptionDate { get; set; }
}

public class PaymentDetailDto
{
    public List<PaymentPlanDto> PaymentPlan { get; set; }
}

public class PaymentPlanDto
{
    public int PaymentNo { get; set; }
    public DateTime DueDate { get; set; }
    public PriceDto Price { get; set; }
    public bool PaymentStatus { get; set; }
}

public class PermissionInfoDto
{
    public List<int> Permissions { get; set; }
}

public class HeaderDto
{
    public string RequestId { get; set; }
    public bool Success { get; set; }
    public DateTime ResponseTime { get; set; }
    public List<MessageDto> Messages { get; set; }
}

public class MessageDto
{
    public int Id { get; set; }
    public int Code { get; set; }
    public int MessageType { get; set; }
    public string Message { get; set; }
}

public class AdditionalFieldsDto
{
    public string TravellerTypeOrder { get; set; }
    public string TravellerUniqueID { get; set; }
    public string TourVisioTravellerId { get; set; }
    public string SmsLimit { get; set; }
    public string PriceChanged { get; set; }
    public string AllowSalePriceEdit { get; set; }
    public string AllowAgencyCanRes { get; set; }
}

// ReservationInfoDto
public class ReservationInfoDto
{
    public string BookingNumber { get; set; }
    public string EncryptedBookingNumber { get; set; }
    public MarketDto Market { get; set; }
    public OperatorDto Operator { get; set; }
    public AgencyDto Agency { get; set; }
    public AgencyUserDto AgencyUser { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Note { get; set; }
    public string AgencyReservationNumber { get; set; }
    public PriceDto SalePrice { get; set; }
    public PriceDto SupplementDiscount { get; set; }
    public PriceDto PassengerEB { get; set; }
    public PriceDto AgencyEB { get; set; }
    public PriceDto PassengerAmountToPay { get; set; }
    public PriceDto AgencyAmountToPay { get; set; }
    public PriceDto Discount { get; set; }
    public PriceDto AgencyBalance { get; set; }
    public PriceDto PassengerBalance { get; set; }
    public PriceDto AgencyCommission { get; set; }
    public PriceDto BrokerCommission { get; set; }
    public PriceDto AgencySupplementCommission { get; set; }
    public PriceDto PromotionAmount { get; set; }
    public PriceDto PriceToPay { get; set; }
    public PriceDto AgencyPriceToPay { get; set; }
    public PriceDto PassengerPriceToPay { get; set; }
    public PriceDto TotalPrice { get; set; }
    public int ReservationStatus { get; set; }
    public int ConfirmationStatus { get; set; }
    public int PaymentStatus { get; set; }
    public bool IsPayAtHotel { get; set; }
    public List<DocumentDto> Documents { get; set; }
    public List<DocumentDto> OtherDocuments { get; set; }
    public ReservableInfoDto ReservableInfo { get; set; }
    public PaymentFromDto PaymentFrom { get; set; }
    public CountryDto DepartureCountry { get; set; }
    public CityDto DepartureCity { get; set; }
    public CountryDto ArrivalCountry { get; set; }
    public CityDto ArrivalCity { get; set; }
    public DateTime CreateDate { get; set; }
    public AdditionalFieldsDto AdditionalFields { get; set; }
    public string AdditionalCode1 { get; set; }
    public string AdditionalCode2 { get; set; }
    public string AdditionalCode3 { get; set; }
    public string AdditionalCode4 { get; set; }
    public int AgencyDiscount { get; set; }
    public bool HasAvailablePromotionCode { get; set; }
}

// MarketDto
public class MarketDto
{
    public string Code { get; set; }
}

// OperatorDto
public class OperatorDto
{
    public string Code { get; set; }
}

// AgencyDto
public class AgencyDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public CountryDto Country { get; set; }
    public AddressDto Address { get; set; }
    public bool OwnAgency { get; set; }
    public bool AceExport { get; set; }
}

// AgencyUserDto
public class AgencyUserDto
{
    public OfficeDto Office { get; set; }
    public OperatorDto Operator { get; set; }
    public MarketDto Market { get; set; }
    public AgencyDto Agency { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
}

// OfficeDto
public class OfficeDto
{
    public string Code { get; set; }
    public string Name { get; set; }
}

// PriceDto

// DocumentDto

// PaymentFromDto
public class PaymentFromDto
{
    public int PaymentFrom { get; set; }
}

