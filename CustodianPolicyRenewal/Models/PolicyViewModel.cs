using CustodianPolicyRenewal.Utilities;
using System.ComponentModel.DataAnnotations;

namespace CustodianPolicyRenewal.Models
{
  public class PolicyViewModel
  {
    [Required(ErrorMessage = DataAnnotationsHelper.PolicyNumberRequiredErrorMessage)]
    [RegularExpression(DataAnnotationsHelper.PolicyNumberRequiredErrorMessage, ErrorMessage = DataAnnotationsHelper.PolicyNumberRegexErrorMessage)]
    public string? PolicyNumber { get; set; }
    public string? Message { get; set; }
    public bool Status { get; set; }
    public string? Title { get; set; }
    public string? Icon { get; set; }
  }
}
