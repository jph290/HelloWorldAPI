using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldAPI.Controllers
{
    public class HelloWorldController : ApiController
    {
        private HelloWorldAPI.Models.HelloWorld helloClass = new Models.HelloWorld();

        public virtual IHttpActionResult GetWelcome()
        {
            return Ok(helloClass.Welcome);
        }
    }
}
