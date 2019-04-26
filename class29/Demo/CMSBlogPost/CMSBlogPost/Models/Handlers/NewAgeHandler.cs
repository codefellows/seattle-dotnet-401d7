using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CMSBlogPost.Models.Handlers
{
    public class NewAgeHandler : AuthorizationHandler<NewAgeRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, NewAgeRequirement requirement)
        {
            if (!context.User.HasClaim(c => c.Type == ClaimTypes.DateOfBirth))
            {
                return Task.CompletedTask;
            }

            var dateOfBirth = Convert.ToDateTime(context.User.FindFirst(c => c.Type == ClaimTypes.DateOfBirth).Value);

            int calAge = DateTime.Today.Year - dateOfBirth.Year;

            if (dateOfBirth > DateTime.Today.AddYears(-calAge))
            {
                calAge--;
            }

            if (calAge >= 18)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
