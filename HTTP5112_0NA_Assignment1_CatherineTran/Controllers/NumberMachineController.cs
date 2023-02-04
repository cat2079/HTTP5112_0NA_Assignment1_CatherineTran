using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_0NA_Assignment1_CatherineTran.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// [Q5] This method has an input {id}, and 
        /// applies four mathematical operations to it
        /// The input must be a positive or negative 
        /// integer or 0
        /// </summary>
        /// <param name="id"></param>
        /// <example>
        /// GET localhost/NumberMachine/10 -> 4
        /// GET localhost/NumberMachine/-5 -> -2
        /// GET localhost/NumberMachine/30 -> 14
        /// </example>
        /// <returns>
        /// Returns a value that is rounded down to
        /// the lowest inetger from the results of
        /// the four mathematical calculations applied
        /// It returns the input integer squared with
        /// 5 subtracted from the squared input
        /// This result is then divided by the sum of
        /// the input integer added to the input integer
        /// </returns>
        public IEnumerable<int> Get(int id)
        {   
            return new int[] {((id * id) - 5 ) / (id + id)};
        }
    }
}
