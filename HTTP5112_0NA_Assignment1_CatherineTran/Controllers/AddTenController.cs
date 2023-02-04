using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_0NA_Assignment1_CatherineTran.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// [Q1] Returns 10 more than the integer input {id}
        /// </summary>
        /// <param name="id"></param>
        /// <example>
        /// GET localhost/AddTen/21 -> 31
        /// GET localhost/AddTen/0 -> 10
        /// GET localhost/AddTen/-9 -> 1
        /// </example>
        /// <returns>
        /// Ten more than the integer input
        /// </returns>
        public int Get(int id)
        {
            int x = id + 10;
            return x;
        }
    }
}
