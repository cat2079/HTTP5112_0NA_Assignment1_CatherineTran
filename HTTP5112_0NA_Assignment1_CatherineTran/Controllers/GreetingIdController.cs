using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_0NA_Assignment1_CatherineTran.Controllers
{
    public class GreetingIdController : ApiController
    {
        /// <summary>
        /// [Q4] Returns the string 
        /// "Greetings to {id} people!"
        /// where id is an integer value
        /// Input for id must be a positive
        /// or negative integer or 0
        /// </summary>
        /// <param name="id"></param>
        /// <example>
        /// GET localhost/Greeting/3 -> "Greetings to 3 people!"
        /// GET localhost/Greeting/6 -> "Greetings to 6 people!"
        /// GET localhost/Greeting/0 -> "Greetings to 0 people!"
        /// </example>
        /// <returns></returns>
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "Greetings to " + id + " people!" };
        }
    }
}


