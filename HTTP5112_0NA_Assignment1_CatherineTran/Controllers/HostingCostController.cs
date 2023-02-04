using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_0NA_Assignment1_CatherineTran.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// [Q6] This calculates and determines the cost
        /// of hosting given that hosting cost $5.50/FN + 13% HST
        /// 1 FN = 14 days and hosting begins at 0 days
        /// </summary>
        /// <param name="Fortnight"></param>
        /// <example>
        /// GET: api/HostingCost/HostCalculator/0
        /// -> "1 fortnights at $5.50/FN = $5.50 CAD"
        /// -> "HST 13% = $0.72 CAD"
        /// -> "Total = $6.22 CAD"
        /// GET: api/HostingCost/HostCalculator/14
        /// -> "2 fortnights at $5.50/FN = $11.00 CAD"
        /// -> "HST 13% = $1.43 CAD"
        /// -> "Total = $12.43 CAD"
        /// GET: api/HostingCost/HostCalculator/15
        /// -> "2 fortnights at $5.50/FN = $11.00 CAD"
        /// -> "HST 13% = $1.43 CAD"
        /// -> "Total = $12.43 CAD"
        /// /// GET: api/HostingCost/HostCalculator/21
        /// -> "2 fortnights at $5.50/FN = $11.00 CAD"
        /// -> "HST 13% = $1.43 CAD"
        /// -> "Total = $12.43 CAD"
        /// /// GET: api/HostingCost/HostCalculator/28
        /// -> "2 fortnights at $5.50/FN = $16.50 CAD"
        /// -> "HST 13% = $2.14 CAD"
        /// -> "Total = $16.64 CAD"
        /// </example>
        /// <returns>
        /// Outputs an array of three strings which 
        /// describes the total cost of hosting in CAD
        /// Includes the cost given the number of fortnights, 
        /// the total HST and the total cost with HST
        /// </returns>
        [Route("api/HostingCost/HostingCalculator/{Fortnight}")]
        [HttpGet]
        public IEnumerable<string> HostingCalculator(int Fortnight)
        {
            if (Fortnight <= 13) // 1FN
            {
                return new string[3] { "1 fortnights at $5.50 / FN = $5.50 CAD", " HST 13% = $0.72 CAD", " Total = $6.22 CAD" };
            }
            else if (Fortnight >= 14 && Fortnight <= 27) // 2FN
            {
                return new string[3] { "2 fortnights at $11.00 / FN = $5.50 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD" };
            }
            else if (Fortnight >= 28 && Fortnight <= 41) // 3FN
            {
                return new string[3] { "3 fortnights at $16.50 / FN = $5.50 CAD", "HST 13% = $2.14 CAD", "Total = $18.64 CAD" };
            }
            else if (Fortnight >= 42 && Fortnight <= 55) // 4FN
            {
                return new string[3] { "4 fortnights at $22.00 / FN = $5.50 CAD", "HST 13% = $2.86 CAD", "Total = $24.86 CAD" };
            }
            else if (Fortnight >= 56 && Fortnight <= 69) // 5FN
            {
                return new string[3] { "5 fortnights at $27.50 / FN = $5.50 CAD", "HST 13% = $3.57 CAD", "Total = $31.07 CAD" };
            }
            else
            {
                return new string[] { "Check with hosting provider" };
            }

        }
    }
}
