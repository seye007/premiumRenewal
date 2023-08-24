using CustodianPolicyRenewal.Models;

namespace CustodianPolicyRenewal.Services.Implementations
{
  public interface IPolicyRenewalService
  {
    PolicyDetail? GetPoliyDetailByPolicyNumber(PolicyViewModel policyNumberModel);
  }
}