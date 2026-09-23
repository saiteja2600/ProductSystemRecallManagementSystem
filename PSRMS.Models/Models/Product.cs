using System.ComponentModel.DataAnnotations;
namespace PSRMS.Models
{
    public class ProductRequests
    {
        public string Productid {get; set;} = string.Empty;
        public string ProductName {get; set;} = string.Empty;
        public string ModelNumber {get; set;}= string.Empty;
        public string Category {get; set;} = string.Empty;
        public string Brand {get; set;}=string.Empty;
        public string BatchNumber {get; set;}=string.Empty;
        public string ManufacturingDate {get; set;} = string.Empty;
        public string WarrantyPeriod {get; set;} = string.Empty;
        public string Description {get; set;} = string.Empty;

    }
}