using Microsoft.AspNetCore.Authorization;

namespace Authentication.AuthorizationRequirments
{
    public class CustomRequiredClaim : IAuthorizationRequirement
    {
        public CustomRequiredClaim(string claimType)
        {
            ClaimType = claimType;
        }

        public string ClaimType { get; }
    }

    public class CustomRequiredClaimHandler : Authorize
}
