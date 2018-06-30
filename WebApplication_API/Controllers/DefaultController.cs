using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/ValidAmountReq")]
    public class DefaultController : ApiController
    {
        
    }

}
