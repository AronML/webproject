using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace TutorialAspNetIdentity.Security.Filters
{
    public class ClaimsAuthorizeAttribute 
    {
        private readonly string _claimName;
        private readonly string _claimValue;

        public ClaimsAuthorizeAttribute(string claimName, string claimValue)
        {
            this._claimName = claimName;
            this._claimValue = claimValue;
        }

        /*protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var identity = (ClaimsIdentity)httpContext.User.Identity;

            var claim = identity.Claims.FirstOrDefault(c => c.Type == _claimName);

            if (claim != null)
            {
                return claim.Value == _claimValue;
            }

            return false;
        }*/
    }
}
