namespace CustodianPolicyRenewal.Utilities
{
  public class DataAnnotationsHelper
  {
    public const string PolicyNumberReqularExpression = @"^\d{8,10}$";
    public const string PolicyNumberRequiredErrorMessage = "Policy number is required";
    public const string PolicyNumberRegexErrorMessage = "Policy Number must be between 8 and 10 digits.";
  }
}
