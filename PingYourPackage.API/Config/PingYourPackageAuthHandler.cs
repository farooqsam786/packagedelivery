using PingYourPackage.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Dependencies;
using WebApiDoodle.Web.MessageHandlers;

namespace PingYourPackage.API.Config
{
    public class PingYourPackageAuthHandler :  BasicAuthenticationHandler
    {
        protected override Task<IPrincipal> AuthenticateUserAsync(HttpRequestMessage request, string username, string password, CancellationToken cancellationToken)
        {

            var membershipService = request.GetMembershipService();
            var validUserCtx = membershipService.ValidateUser(username, password);
            return Task.FromResult(validUserCtx.Principal);
        }
    }

    internal static class HttpRequestMessageExtensions
    {
        internal static IMembershipService GetMembershipService(this HttpRequestMessage request)
        {
            return request.GetService<IMembershipService>();
        }

        private static TService GetService<TService>(this HttpRequestMessage request)
        {
            IDependencyScope dependencyScope = request.GetDependencyScope();
            TService service = (TService)dependencyScope.GetService(typeof(TService));
            return service;
        }
    }
}
