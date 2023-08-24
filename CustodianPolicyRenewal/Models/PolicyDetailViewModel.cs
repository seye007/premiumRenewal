using System.Collections.Generic;
using System.Security.AccessControl;

namespace CustodianPolicyRenewal.Models
{
  public class PolicyDetail
  {
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public decimal? Premium { get; set; }
    public string? PolicyNumber { get; set; }
    public string? Product { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public DateTime StartDate { get; set; }
    public string? Frequency { get; set; }
  }
}
