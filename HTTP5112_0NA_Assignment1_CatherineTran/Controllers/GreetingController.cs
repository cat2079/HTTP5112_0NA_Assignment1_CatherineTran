using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_0NA_Assignment1_CatherineTran.Controllers
{
    public class GreetingController : ApiController
    {   
        /// <summary>
        /// [Q3] Returns the string "Hello World!"
        /// when executed in the Command Prompt
        /// as it is a POST request and not
        /// a GET request
        /// </summary>
        /// <example>
        /// In the Command Prompt type:
        /// curl -d "" "http://localhost:{port-number}/api/Greeting" -> ["Hello World!"]
        /// </example>
        /// <returns></returns>
        public IEnumerable<string> Post()
        {
            return new string[] { "Hello World!" };
        }
    }
}
