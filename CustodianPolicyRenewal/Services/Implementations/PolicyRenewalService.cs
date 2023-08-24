using CustodianPolicyRenewal.Models;

namespace CustodianPolicyRenewal.Services.Implementations
{
  public class PolicyRenewalService : IPolicyRenewalService
  {
    public PolicyRenewalService() { }
    private  static List<PolicyDetail> GenerateMockedPolicyDetailsList()
    {
      return new List<PolicyDetail>
        {
            new PolicyDetail
            {
                FullName = "Kristo Tyas",
                Email = "ktyas0@stumbleupon.com",
                PhoneNumber = "587-727-2764",
                PolicyNumber = "6029814648",
                Premium = 810000,
                Product = "Capital Builder",
                Address = "683 Dennis Point"
            },
            new PolicyDetail
            {
                FullName = "Roselin Dodd",
                Email = "rdodd1@youtube.com",
                PhoneNumber = "217-283-1706",
                PolicyNumber = "9405932683",
                Premium = 326700,
                Product = "Annuity",
                Address = "65 Hagan Way"
            },
        };
    }
    public PolicyDetail? GetPoliyDetailByPolicyNumber(PolicyViewModel policyNumberModel)
    {
      PolicyDetail? response = null;
      var policyDetails = GenerateMockedPolicyDetailsList();
      var policyDetail = policyDetails.FirstOrDefault(p => p.PolicyNumber == policyNumberModel.PolicyNumber);
      if (policyDetail != null)
      {
        response = policyDetail;
      }
      return response;
    }
  }
}
