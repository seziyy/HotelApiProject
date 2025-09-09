namespace HotelApiProject.Models.Responses.BeginTransactionResponse;
public class BeginTransactionResponse
{
    public Body Body { get; set; }
    public Header Header { get; set; }
}

public class ReservationData
{
    public List<Traveller> Travellers { get; set; }
    public ReservationInfo reservationInfo { get; set; }
    public List<Service> Services { get; set; }
    public PaymentDetail paymentDetail { get; set; }
    public List<object> Invoices { get; set; }
}

public class Traveller
{
    public string travellerId { get; set; }
    public int Type { get; set; }
    public int Title { get; set; }
    public List<AvailableTitle> availableTitles { get; set; }
    public List<object> availableAcademicTitles { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public bool isLeader { get; set; }
    public DateTime birthDate { get; set; }
    public int? Age { get; set; }
    public Nationality Nationality { get; set; }
    public string identityNumber { get; set; }
    public PassportInfo passportInfo { get; set; }
    public Address Address { get; set; }
    public object destinationAddress { get; set; }
    public List<TravellerService> Services { get; set; }
    public int orderNumber { get; set; }
    public DateTime birthDateFrom { get; set; }
    public DateTime birthDateTo { get; set; }
    public List<string> requiredFields { get; set; }
    public List<object> Documents { get; set; }
    public int passengerType { get; set; }
    public AdditionalFields additionalFields { get; set; }
    public List<object> insertFields { get; set; }
    public int Status { get; set; }
}

public class AvailableTitle
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class Nationality
{
    public string twoLetterCode { get; set; }
}

public class PassportInfo
{
    public string serial { get; set; }
    public string number { get; set; }
    public DateTime expireDate { get; set; }
    public DateTime issueDate { get; set; }
    public string issueCountryCode { get; set; }
    public string citizenshipCountryCode { get; set; }
}

public class ContactPhone
{

}

public class TravellerService
{
    public string id { get; set; }
    public int type { get; set; }
    public Price price { get; set; }
    public int passengerType { get; set; }
}

public class Price
{
    public decimal amount { get; set; }
    public string currency { get; set; }
    public decimal? percent { get; set; }
}

public class AdditionalFields
{
    public string travellerTypeOrder { get; set; }
    public string travellerUniqueID { get; set; }
    public string tourVisio_TravellerId { get; set; }
    public string birthDateFrom { get; set; }
    public string birthDateTo { get; set; }
    public string smsLimit { get; set; }
    public string priceChanged { get; set; }
    public string allowSalePriceEdit { get; set; }
    public string sendFlightSms { get; set; }
    public string reservableInfo { get; set; }
}

public class ReservationInfo
{
    public string bookingNumber { get; set; }
    public Market market { get; set; }
    public Operator @operator { get; set; }
    public Agency agency { get; set; }
    public AgencyUser agencyUser { get; set; }
    public DateTime beginDate { get; set; }
    public DateTime endDate { get; set; }
    public Price salePrice { get; set; }
    public Price supplementDiscount { get; set; }
    public Price passengerEB { get; set; }
    public Price agencyEB { get; set; }
    public Price passengerAmountToPay { get; set; }
    public Price agencyAmountToPay { get; set; }
    public Price discount { get; set; }
    public Price agencyBalance { get; set; }
    public Price passengerBalance { get; set; }
    public Commission agencyCommission { get; set; }
    public Commission brokerCommission { get; set; }
    public Commission agencySupplementCommission { get; set; }
    public Price promotionAmount { get; set; }
    public Price priceToPay { get; set; }
    public Price agencyPriceToPay { get; set; }
    public Price passengerPriceToPay { get; set; }
    public Price totalPrice { get; set; }
    public int reservationStatus { get; set; }
    public int confirmationStatus { get; set; }
    public int paymentStatus { get; set; }
    public List<object> documents { get; set; }
    public List<object> otherDocuments { get; set; }
    public ReservableInfo reservableInfo { get; set; }
    public int paymentFrom { get; set; }
    public Country departureCountry { get; set; }
    public City departureCity { get; set; }
    public Country arrivalCountry { get; set; }
    public City arrivalCity { get; set; }
    public DateTime createDate { get; set; }
    public AdditionalFields additionalFields { get; set; }
    public string additionalCode1 { get; set; }
    public string additionalCode2 { get; set; }
    public string additionalCode3 { get; set; }
    public string additionalCode4 { get; set; }
    public decimal agencyDiscount { get; set; }
    public bool hasAvailablePromotionCode { get; set; }
}

public class Market
{
    public string code { get; set; }
    public string name { get; set; }
}

public class Operator
{
    public string code { get; set; }
    public string name { get; set; }
    public bool? agencyCanDiscountCommission { get; set; }
}

public class Agency
{
    public string code { get; set; }
    public string name { get; set; }
    public Country country { get; set; }
    public Address address { get; set; }
    public bool ownAgency { get; set; }
    public bool aceExport { get; set; }
    public ContactInfo contactInfo { get; set; }
}

public class ContactInfo
{
    public Country country { get; set; }
    public City city { get; set; }
}

public class AgencyUser
{
    public Office office { get; set; }
    public Operator @operator { get; set; }
    public Market market { get; set; }
    public Agency agency { get; set; }
    public string name { get; set; }
    public string code { get; set; }
}

public class Office
{
    public string code { get; set; }
    public string name { get; set; }
}

public class Commission
{
    public decimal percent { get; set; }
    public decimal amount { get; set; }
    public string currency { get; set; }
}

public class ReservableInfo
{
    public bool reservable { get; set; }
    public DateTime optionDate { get; set; }
}

public class Service
{
    public int orderNumber { get; set; }
    public string note { get; set; }
    public Country departureCountry { get; set; }
    public City departureCity { get; set; }
    public Country arrivalCountry { get; set; }
    public City arrivalCity { get; set; }
    public ServiceDetails serviceDetails { get; set; }
    public bool isMainService { get; set; }
    public bool isRefundable { get; set; }
    public bool bundle { get; set; }
    public List<CancellationPolicy> cancellationPolicies { get; set; }
    public List<object> documents { get; set; }
    public List<PriceBreakDown> priceBreakDowns { get; set; }
    public decimal? commission { get; set; }
    public ReservableInfo reservableInfo { get; set; }
    public int unit { get; set; }
    public List<object> conditionalSpos { get; set; }
    public bool thirdPartyExt { get; set; }
    public int confirmationStatus { get; set; }
    public int serviceStatus { get; set; }
    public int productType { get; set; }
    public bool createServiceTypeIfNotExists { get; set; }
    public string id { get; set; }
    public string code { get; set; }
    public string name { get; set; }
    public DateTime beginDate { get; set; }
    public DateTime endDate { get; set; }
    public int adult { get; set; }
    public int child { get; set; }
    public int infant { get; set; }
    public Price price { get; set; }
    public bool includePackage { get; set; }
    public bool compulsory { get; set; }
    public bool isExtraService { get; set; }
    public int provider { get; set; }
    public List<string> travellers { get; set; }
    public bool thirdPartyRecord { get; set; }
    public int recordId { get; set; }
    public AdditionalFields additionalFields { get; set; }
}

public class ServiceDetails
{
    public string serviceId { get; set; }
    public HotelDetail hotelDetail { get; set; }
    public int night { get; set; }
    public string roomCode { get; set; }
    public string room { get; set; }
    public string boardCode { get; set; }
    public string board { get; set; }
    public string accom { get; set; }
    public string star { get; set; }
}

public class HotelDetail
{
    public Address address { get; set; }
    public string faxNumber { get; set; }
    public string phoneNumber { get; set; }
    public string homePage { get; set; }
    public City transferLocation { get; set; }
    public int stopSaleGuaranteed { get; set; }
    public int stopSaleStandart { get; set; }
    public List<object> handicaps { get; set; }
    public int stars { get; set; }
    public City location { get; set; }
    public Country country { get; set; }
    public City city { get; set; }
    public bool hasChannelManagerOffer { get; set; }
    public string id { get; set; }
    public string name { get; set; }
}

public class CancellationPolicy
{
    public DateTime beginDate { get; set; }
    public DateTime dueDate { get; set; }
    public Price price { get; set; }
    public int provider { get; set; }
}

public class PriceBreakDown
{
    public string roomNumber { get; set; }
    public DateTime date { get; set; }
    public Price price { get; set; }
}

public class PaymentDetail
{
    public List<PaymentPlan> paymentPlan { get; set; }
    public List<object> paymentInfo { get; set; }
}

public class PaymentPlan
{
    public int paymentNo { get; set; }
    public DateTime dueDate { get; set; }
    public Price price { get; set; }
    public bool paymentStatus { get; set; }
}


