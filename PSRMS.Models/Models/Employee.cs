using System.ComponentModel.DataAnnotations;

namespace PSRMS.Models
{
    public class EmployeeRequests
    {
        public string EmployeeId {get; set;} = string.Empty;

        public string FullName {get; set;} = string.Empty;

        public string BusinessEmail {get; set;} = string.Empty;

        public string ContactNumber {get; set;} = string.Empty;

        public string Department {get; set;} = string.Empty;

        public string Role {get; set;} = string.Empty;


    }
}