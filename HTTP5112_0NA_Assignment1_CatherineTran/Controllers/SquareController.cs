using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_0NA_Assignment1_CatherineTran.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// [Q2] Returns the square of the integer input {id}
        /// Input must be a postitive or negative integer
        /// </summary>
        /// <param name="id"></param>
        /// <example>
        /// GET localhost/Square/2 -> 4
        /// GET localhost/Square/-2 -> 4
        /// GET localhost/Square/10 -> 100
        /// </example>
        /// <returns>
        /// Outputs the square of the input integer
        /// </returns>
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id * id };
        }
    }
}
