using Microsoft.AspNetCore.Authorization;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CMSBlogPost.Models.Handlers
{
    public class MinimumAgeRequirement : AuthorizationHandler<MinimumAgeRequirement>, IAuthorizationRequirement
    {
        private int _minAge;

        public MinimumAgeRequirement(int minAge)
        {
            _minAge = minAge;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumAgeRequirement requirement)
        {
            if (!context.User.HasClaim(c => c.Type == ClaimTypes.DateOfBirth))
            {
                return Task.CompletedTask;
            }

            var dateOfBirth = Convert.ToDateTime(context.User.FindFirst(c => c.Type == ClaimTypes.DateOfBirth).Value);

            int calAge = DateTime.Today.Year - dateOfBirth.Year;

            if(dateOfBirth > DateTime.Today.AddYears(-calAge))
            {
                calAge--;
            }

            if(calAge >= _minAge)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;

        }
    }
}
