using Newtonsoft.Json;
using System.Diagnostics.Metrics;

namespace WEB_LIBROS.Models
{
    public class LIBRO
    {

        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("etag", NullValueHandling = NullValueHandling.Ignore)]
        public string Etag { get; set; }

        [JsonProperty("selfLink", NullValueHandling = NullValueHandling.Ignore)]
        public Uri SelfLink { get; set; }

        [JsonProperty("volumeInfo", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeInfo VolumeInfo { get; set; }

        [JsonProperty("saleInfo", NullValueHandling = NullValueHandling.Ignore)]
        public SaleInfo SaleInfo { get; set; }

        [JsonProperty("accessInfo", NullValueHandling = NullValueHandling.Ignore)]
        public AccessInfo AccessInfo { get; set; }

        [JsonProperty("searchInfo", NullValueHandling = NullValueHandling.Ignore)]
        public SearchInfo SearchInfo { get; set; }


    }

    public partial class AccessInfo
    {
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("viewability", NullValueHandling = NullValueHandling.Ignore)]
        public string Viewability { get; set; }

        [JsonProperty("embeddable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Embeddable { get; set; }

        [JsonProperty("publicDomain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicDomain { get; set; }

        [JsonProperty("textToSpeechPermission", NullValueHandling = NullValueHandling.Ignore)]
        public string TextToSpeechPermission { get; set; }

        [JsonProperty("epub", NullValueHandling = NullValueHandling.Ignore)]
        public Epub Epub { get; set; }

        [JsonProperty("pdf", NullValueHandling = NullValueHandling.Ignore)]
        public Epub Pdf { get; set; }

        [JsonProperty("webReaderLink", NullValueHandling = NullValueHandling.Ignore)]
        public Uri WebReaderLink { get; set; }

        [JsonProperty("accessViewStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessViewStatus { get; set; }

        [JsonProperty("quoteSharingAllowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QuoteSharingAllowed { get; set; }
    }

    public partial class Epub
    {
        [JsonProperty("isAvailable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAvailable { get; set; }

        [JsonProperty("acsTokenLink", NullValueHandling = NullValueHandling.Ignore)]
        public Uri AcsTokenLink { get; set; }
    }

    public partial class SaleInfo
    {
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("saleability", NullValueHandling = NullValueHandling.Ignore)]
        public string Saleability { get; set; }

        [JsonProperty("isEbook", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEbook { get; set; }

        [JsonProperty("listPrice", NullValueHandling = NullValueHandling.Ignore)]
        public SaleInfoListPrice ListPrice { get; set; }

        [JsonProperty("retailPrice", NullValueHandling = NullValueHandling.Ignore)]
        public SaleInfoListPrice RetailPrice { get; set; }

        [JsonProperty("buyLink", NullValueHandling = NullValueHandling.Ignore)]
        public Uri BuyLink { get; set; }

        [JsonProperty("offers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Offer> Offers { get; set; }
    }

    public partial class SaleInfoListPrice
    {
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        [JsonProperty("currencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyCode { get; set; }
    }

    public partial class Offer
    {
        [JsonProperty("finskyOfferType", NullValueHandling = NullValueHandling.Ignore)]
        public long? FinskyOfferType { get; set; }

        [JsonProperty("listPrice", NullValueHandling = NullValueHandling.Ignore)]
        public OfferListPrice ListPrice { get; set; }

        [JsonProperty("retailPrice", NullValueHandling = NullValueHandling.Ignore)]
        public OfferListPrice RetailPrice { get; set; }
    }

    public partial class OfferListPrice
    {
        [JsonProperty("amountInMicros", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmountInMicros { get; set; }

        [JsonProperty("currencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyCode { get; set; }
    }

    public partial class SearchInfo
    {
        [JsonProperty("textSnippet", NullValueHandling = NullValueHandling.Ignore)]
        public string TextSnippet { get; set; }
    }

    public partial class VolumeInfo
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("subtitle", NullValueHandling = NullValueHandling.Ignore)]
        public string Subtitle { get; set; }

        [JsonProperty("authors", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Authors { get; set; }

        [JsonProperty("publishedDate", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishedDate { get; set; }

        [JsonProperty("industryIdentifiers", NullValueHandling = NullValueHandling.Ignore)]
        public List<IndustryIdentifier> IndustryIdentifiers { get; set; }

        [JsonProperty("readingModes", NullValueHandling = NullValueHandling.Ignore)]
        public ReadingModes ReadingModes { get; set; }

        [JsonProperty("pageCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? PageCount { get; set; }

        [JsonProperty("printType", NullValueHandling = NullValueHandling.Ignore)]
        public string PrintType { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Categories { get; set; }

        [JsonProperty("maturityRating", NullValueHandling = NullValueHandling.Ignore)]
        public string MaturityRating { get; set; }

        [JsonProperty("allowAnonLogging", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAnonLogging { get; set; }

        [JsonProperty("contentVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentVersion { get; set; }

        [JsonProperty("panelizationSummary", NullValueHandling = NullValueHandling.Ignore)]
        public PanelizationSummary PanelizationSummary { get; set; }

        [JsonProperty("imageLinks", NullValueHandling = NullValueHandling.Ignore)]
        public ImageLinks ImageLinks { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        [JsonProperty("previewLink", NullValueHandling = NullValueHandling.Ignore)]
        public Uri PreviewLink { get; set; }

        [JsonProperty("infoLink", NullValueHandling = NullValueHandling.Ignore)]
        public Uri InfoLink { get; set; }

        [JsonProperty("canonicalVolumeLink", NullValueHandling = NullValueHandling.Ignore)]
        public Uri CanonicalVolumeLink { get; set; }

        [JsonProperty("publisher", NullValueHandling = NullValueHandling.Ignore)]
        public string Publisher { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public partial class ImageLinks
    {
        [JsonProperty("smallThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Uri SmallThumbnail { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Thumbnail { get; set; }
    }

    public partial class IndustryIdentifier
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }
    }

    public partial class PanelizationSummary
    {
        [JsonProperty("containsEpubBubbles", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContainsEpubBubbles { get; set; }

        [JsonProperty("containsImageBubbles", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContainsImageBubbles { get; set; }
    }

    public partial class ReadingModes
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Text { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Image { get; set; }
    }
}
