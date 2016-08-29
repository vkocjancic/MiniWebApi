using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MiniWebApi.Controllers
{
    public class PingController : ApiController
    {

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, (new { active = true }));
        }

    }
}