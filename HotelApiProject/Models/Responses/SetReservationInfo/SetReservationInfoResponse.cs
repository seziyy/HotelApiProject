using System.Text.Json.Serialization;

namespace HotelApiProject.Models.Responses.SetReservationInfo;
public class SetReservationResponse
{
    [JsonPropertyName("header")]
    public SetReservationHeader Header { get; set; }

    [JsonPropertyName("body")]
    public SetReservationBody Body { get; set; }
}

public class SetReservationHeader
{
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; }

    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("responseTime")]
    public DateTime ResponseTime { get; set; }

    [JsonPropertyName("messages")]
    public List<SetReservationMessage> Messages { get; set; }
}

public class SetReservationMessage
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

public class SetReservationBody
{
    [JsonPropertyName("transactionId")]
    public string TransactionId { get; set; }

    [JsonPropertyName("expiresOn")]
    public DateTime ExpiresOn { get; set; }

    [JsonPropertyName("reservationData")]
    public SetReservationData ReservationData { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("transactionType")]
    public int TransactionType { get; set; }
}

public class SetReservationData
{
    [JsonPropertyName("travellers")]
    public List<SetReservationResponseTraveller> Travellers { get; set; }

    [JsonPropertyName("reservationInfo")]
    public SetReservationInfo ReservationInfo { get; set; }

    [JsonPropertyName("services")]
    public List<SetReservationService> Services { get; set; }

    [JsonPropertyName("invoices")]
    public List<object> Invoices { get; set; }
}

public class SetReservationResponseTraveller
{
    [JsonPropertyName("travellerId")]
    public string TravellerId { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; }

    [JsonPropertyName("title")]
    public int Title { get; set; }

    [JsonPropertyName("availableTitles")]
    public List<SetReservationAvailableTitle> AvailableTitles { get; set; }

    [JsonPropertyName("academicTitle")]
    public SetReservationAcademicTitleResponse AcademicTitle { get; set; }

    [JsonPropertyName("availableAcademicTitles")]
    public List<SetReservationAcademicTitleResponse> AvailableAcademicTitles { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("surname")]
    public string Surname { get; set; }

    [JsonPropertyName("isLeader")]
    public bool IsLeader { get; set; }

    [JsonPropertyName("birthDate")]
    public DateTime BirthDate { get; set; }

    [JsonPropertyName("age")]
    public int Age { get; set; }

    [JsonPropertyName("nationality")]
    public SetReservationNationalityResponse Nationality { get; set; }

    [JsonPropertyName("identityNumber")]
    public string? IdentityNumber { get; set; }

    [JsonPropertyName("passportInfo")]
    public SetReservationPassportInfoResponse PassportInfo { get; set; }

    [JsonPropertyName("address")]
    public SetReservationAddressResponse Address { get; set; }

    [JsonPropertyName("destinationAddress")]
    public SetReservationAddressResponse DestinationAddress { get; set; }

    [JsonPropertyName("services")]
    public List<SetReservationTravellerService> Services { get; set; }

    [JsonPropertyName("gender")]
    public int Gender { get; set; }

    [JsonPropertyName("orderNumber")]
    public int OrderNumber { get; set; }

    [JsonPropertyName("birthDateFrom")]
    public DateTime BirthDateFrom { get; set; }

    [JsonPropertyName("birthDateTo")]
    public DateTime BirthDateTo { get; set; }

    [JsonPropertyName("requiredFields")]
    public List<string> RequiredFields { get; set; }

    [JsonPropertyName("documents")]
    public List<object> Documents { get; set; }

    [JsonPropertyName("passengerType")]
    public int PassengerType { get; set; }

    [JsonPropertyName("additionalFields")]
    public Dictionary<string, object> AdditionalFields { get; set; }

    [JsonPropertyName("insertFields")]
    public List<object> InsertFields { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }
}

public class SetReservationAvailableTitle
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class SetReservationAcademicTitleResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class SetReservationNationalityResponse
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("twoLetterCode")]
    public string TwoLetterCode { get; set; }

    [JsonPropertyName("threeLetterCode")]
    public string ThreeLetterCode { get; set; }

    [JsonPropertyName("numericCode")]
    public string NumericCode { get; set; }

    [JsonPropertyName("isdCode")]
    public string IsdCode { get; set; }
}

public class SetReservationPassportInfoResponse
{
    [JsonPropertyName("serial")]
    public string? Serial { get; set; }

    [JsonPropertyName("number")]
    public string? Number { get; set; }

    [JsonPropertyName("expireDate")]
    public DateTime? ExpireDate { get; set; }

    [JsonPropertyName("issueDate")]
    public DateTime? IssueDate { get; set; }

    [JsonPropertyName("citizenshipCountryCode")]
    public string? CitizenshipCountryCode { get; set; }
}

public class SetReservationAddressResponse
{
    [JsonPropertyName("contactPhone")]
    public SetReservationContactPhoneResponse? ContactPhone { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("address")]
    public string? AddressLine { get; set; }

    [JsonPropertyName("zipCode")]
    public string? ZipCode { get; set; }

    [JsonPropertyName("city")]
    public SetReservationLocationInfoResponse City { get; set; }

    [JsonPropertyName("country")]
    public SetReservationLocationInfoResponse Country { get; set; }
}

public class SetReservationContactPhoneResponse
{
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

public class SetReservationLocationInfoResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public class SetReservationTravellerService
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; }

    [JsonPropertyName("price")]
    public SetReservationPrice Price { get; set; }

    [JsonPropertyName("passengerType")]
    public int PassengerType { get; set; }
}

public class SetReservationPrice
{
    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("percent")]
    public decimal? Percent { get; set; }
}

public class SetReservationInfo
{
    [JsonPropertyName("bookingNumber")]
    public string BookingNumber { get; set; }

    [JsonPropertyName("agency")]
    public SetReservationAgency Agency { get; set; }

    [JsonPropertyName("agencyUser")]
    public SetReservationAgencyUser AgencyUser { get; set; }

    [JsonPropertyName("beginDate")]
    public DateTime BeginDate { get; set; }

    [JsonPropertyName("endDate")]
    public DateTime EndDate { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("agencyReservationNumber")]
    public string? AgencyReservationNumber { get; set; }

    [JsonPropertyName("salePrice")]
    public SetReservationPrice SalePrice { get; set; }

    [JsonPropertyName("supplementDiscount")]
    public SetReservationPrice SupplementDiscount { get; set; }

    [JsonPropertyName("passengerEB")]
    public SetReservationPrice PassengerEB { get; set; }

    [JsonPropertyName("agencyEB")]
    public SetReservationPrice AgencyEB { get; set; }

    [JsonPropertyName("passengerAmountToPay")]
    public SetReservationPrice PassengerAmountToPay { get; set; }

    [JsonPropertyName("agencyAmountToPay")]
    public SetReservationPrice AgencyAmountToPay { get; set; }

    [JsonPropertyName("discount")]
    public SetReservationPrice Discount { get; set; }

    [JsonPropertyName("agencyBalance")]
    public SetReservationPrice AgencyBalance { get; set; }

    [JsonPropertyName("passengerBalance")]
    public SetReservationPrice PassengerBalance { get; set; }

    [JsonPropertyName("agencyCommission")]
    public SetReservationPrice AgencyCommission { get; set; }

    [JsonPropertyName("brokerCommission")]
    public SetReservationPrice BrokerCommission { get; set; }

    [JsonPropertyName("agencySupplementCommission")]
    public SetReservationPrice AgencySupplementCommission { get; set; }

    [JsonPropertyName("promotionAmount")]
    public SetReservationPrice PromotionAmount { get; set; }

    [JsonPropertyName("priceToPay")]
    public SetReservationPrice PriceToPay { get; set; }

    [JsonPropertyName("agencyPriceToPay")]
    public SetReservationPrice AgencyPriceToPay { get; set; }

    [JsonPropertyName("passengerPriceToPay")]
    public SetReservationPrice PassengerPriceToPay { get; set; }

    [JsonPropertyName("totalPrice")]
    public SetReservationPrice TotalPrice { get; set; }

    [JsonPropertyName("reservationStatus")]
    public int ReservationStatus { get; set; }

    [JsonPropertyName("confirmationStatus")]
    public int ConfirmationStatus { get; set; }

    [JsonPropertyName("paymentStatus")]
    public int PaymentStatus { get; set; }

    [JsonPropertyName("documents")]
    public List<object> Documents { get; set; }

    [JsonPropertyName("otherDocuments")]
    public List<object> OtherDocuments { get; set; }

    [JsonPropertyName("reservableInfo")]
    public SetReservationReservableInfo ReservableInfo { get; set; }

    [JsonPropertyName("paymentFrom")]
    public int PaymentFrom { get; set; }

    [JsonPropertyName("departureCountry")]
    public SetReservationCountryInfo DepartureCountry { get; set; }

    [JsonPropertyName("departureCity")]
    public SetReservationCountryInfo DepartureCity { get; set; }

    [JsonPropertyName("arrivalCountry")]
    public SetReservationCountryInfo ArrivalCountry { get; set; }

    [JsonPropertyName("arrivalCity")]
    public SetReservationCountryInfo ArrivalCity { get; set; }

    [JsonPropertyName("createDate")]
    public DateTime CreateDate { get; set; }

    [JsonPropertyName("additionalFields")]
    public Dictionary<string, object> AdditionalFields { get; set; }

    [JsonPropertyName("additionalCode1")]
    public string? AdditionalCode1 { get; set; }

    [JsonPropertyName("additionalCode2")]
    public string? AdditionalCode2 { get; set; }

    [JsonPropertyName("additionalCode3")]
    public string? AdditionalCode3 { get; set; }

    [JsonPropertyName("additionalCode4")]
    public string? AdditionalCode4 { get; set; }

    [JsonPropertyName("agencyDiscount")]
    public decimal AgencyDiscount { get; set; }

    [JsonPropertyName("hasAvailablePromotionCode")]
    public bool HasAvailablePromotionCode { get; set; }
}

public class SetReservationAgency
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("country")]
    public SetReservationCountryInfo Country { get; set; }

    [JsonPropertyName("address")]
    public SetReservationAgencyAddress Address { get; set; }

    [JsonPropertyName("ownAgency")]
    public bool OwnAgency { get; set; }

    [JsonPropertyName("aceExport")]
    public bool AceExport { get; set; }
}

public class SetReservationAgencyAddress
{
    [JsonPropertyName("country")]
    public SetReservationCountryInfo Country { get; set; }

    [JsonPropertyName("city")]
    public SetReservationCountryInfo City { get; set; }

    [JsonPropertyName("addressLines")]
    public List<string> AddressLines { get; set; }

    [JsonPropertyName("zipCode")]
    public string? ZipCode { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("address")]
    public string? AddressLine { get; set; }
}

public class SetReservationAgencyUser
{
    [JsonPropertyName("office")]
    public SetReservationOffice Office { get; set; }

    [JsonPropertyName("operator")]
    public SetReservationOperator Operator { get; set; }

    [JsonPropertyName("market")]
    public SetReservationMarket Market { get; set; }

    [JsonPropertyName("agency")]
    public SetReservationAgencyBasic Agency { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }
}

public class SetReservationOffice
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class SetReservationOperator
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("agencyCanDiscountCommission")]
    public bool AgencyCanDiscountCommission { get; set; }
}

public class SetReservationMarket
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class SetReservationAgencyBasic
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("ownAgency")]
    public bool OwnAgency { get; set; }

    [JsonPropertyName("aceExport")]
    public bool AceExport { get; set; }
}

public class SetReservationCountryInfo
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("internationalCode")]
    public string? InternationalCode { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }

    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }

    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    [JsonPropertyName("countryId")]
    public string? CountryId { get; set; }

    [JsonPropertyName("provider")]
    public int? Provider { get; set; }

    [JsonPropertyName("isTopRegion")]
    public bool? IsTopRegion { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public class SetReservationReservableInfo
{
    [JsonPropertyName("reservable")]
    public bool Reservable { get; set; }
}

public class SetReservationService
{
    [JsonPropertyName("orderNumber")]
    public int OrderNumber { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("departureCountry")]
    public SetReservationCountryInfo DepartureCountry { get; set; }

    [JsonPropertyName("departureCity")]
    public SetReservationCountryInfo DepartureCity { get; set; }

    [JsonPropertyName("arrivalCountry")]
    public SetReservationCountryInfo ArrivalCountry { get; set; }

    [JsonPropertyName("arrivalCity")]
    public SetReservationCountryInfo ArrivalCity { get; set; }

    [JsonPropertyName("serviceDetails")]
    public SetReservationServiceDetails ServiceDetails { get; set; }

    [JsonPropertyName("partnerServiceId")]
    public string PartnerServiceId { get; set; }

    [JsonPropertyName("isMainService")]
    public bool IsMainService { get; set; }

    [JsonPropertyName("isRefundable")]
    public bool IsRefundable { get; set; }

    [JsonPropertyName("bundle")]
    public bool Bundle { get; set; }

 
    [JsonPropertyName("documents")]
    public List<object> Documents { get; set; }

    [JsonPropertyName("encryptedServiceNumber")]
    public string? EncryptedServiceNumber { get; set; }

    [JsonPropertyName("priceBreakDowns")]
    public List<object> PriceBreakDowns { get; set; }

    [JsonPropertyName("commission")]
    public decimal Commission { get; set; }

    [JsonPropertyName("reservableInfo")]
    public SetReservationReservableInfo ReservableInfo { get; set; }

    [JsonPropertyName("unit")]
    public int Unit { get; set; }

    [JsonPropertyName("conditionalSpos")]
    public List<object> ConditionalSpos { get; set; }

    [JsonPropertyName("confirmationStatus")]
    public int ConfirmationStatus { get; set; }

    [JsonPropertyName("serviceStatus")]
    public int ServiceStatus { get; set; }

    [JsonPropertyName("productType")]
    public int ProductType { get; set; }

    [JsonPropertyName("createServiceTypeIfNotExists")]
    public bool CreateServiceTypeIfNotExists { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("beginDate")]
    public DateTime BeginDate { get; set; }

    [JsonPropertyName("endDate")]
    public DateTime EndDate { get; set; }

    [JsonPropertyName("adult")]
    public int Adult { get; set; }

    [JsonPropertyName("child")]
    public int Child { get; set; }

    [JsonPropertyName("infant")]
    public int Infant { get; set; }

    [JsonPropertyName("price")]
    public SetReservationPrice Price { get; set; }

    [JsonPropertyName("includePackage")]
    public bool IncludePackage { get; set; }

    [JsonPropertyName("compulsory")]
    public bool Compulsory { get; set; }

    [JsonPropertyName("isExtraService")]
    public bool IsExtraService { get; set; }

    [JsonPropertyName("provider")]
    public int Provider { get; set; }

    [JsonPropertyName("travellers")]
    public List<string> Travellers { get; set; }

    [JsonPropertyName("thirdPartyRecord")]
    public bool ThirdPartyRecord { get; set; }

    [JsonPropertyName("recordId")]
    public int RecordId { get; set; }

    [JsonPropertyName("additionalFields")]
    public Dictionary<string, object> AdditionalFields { get; set; }
}

public class SetReservationServiceDetails
{
    [JsonPropertyName("serviceId")]
    public string ServiceId { get; set; }

    [JsonPropertyName("thumbnail")]
    public string? Thumbnail { get; set; }

    [JsonPropertyName("hotelDetail")]
    public SetReservationHotelDetail? HotelDetail { get; set; }

    [JsonPropertyName("night")]
    public int? Night { get; set; }

    [JsonPropertyName("room")]
    public string? Room { get; set; }

    [JsonPropertyName("board")]
    public string? Board { get; set; }

    [JsonPropertyName("accom")]
    public string? Accom { get; set; }

    
}

public class SetReservationHotelDetail
{

    [JsonPropertyName("transferLocation")]
    public SetReservationCountryInfo? TransferLocation { get; set; }

    [JsonPropertyName("stopSaleGuaranteed")]
    public int? StopSaleGuaranteed { get; set; }

    [JsonPropertyName("stopSaleStandart")]
    public int? StopSaleStandart { get; set; }


    [JsonPropertyName("location")]
    public SetReservationCountryInfo? Location { get; set; }

    [JsonPropertyName("country")]
    public SetReservationCountryInfo? Country { get; set; }

    [JsonPropertyName("city")]
    public SetReservationCountryInfo? City { get; set; }

    [JsonPropertyName("thumbnail")]
    public string? Thumbnail { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

}