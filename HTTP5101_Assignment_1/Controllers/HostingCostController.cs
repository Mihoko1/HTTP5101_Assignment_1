using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method returns 3 strings which describe the total hosting cost.
        /// <example>GET api/HostingCost/{id}</example>
        /// </summary>
        /// <param name="id">id</param>
        /// <returns> fee par fortnight(s), HST 13% , Total fee</returns>

        public IEnumerable<string> Get(int id)
        {
            double fn = id / 14;
            double charge = (fn + 1) * 5.50;
            double roundCharge = Math.Round(charge, 2, MidpointRounding.ToEven);
            string chargeMessage = fn + " fortnights at $5.50/FN = $" + roundCharge.ToString("0.00") + " CAD";

            double total = charge * 1.13;
            double roundTotal = Math.Round(total, 2, MidpointRounding.ToEven);
            string totalMessage = "Total = $" + roundTotal + " CAD";

            double hst = roundTotal - charge;
            double roundHst = Math.Round(hst, 2, MidpointRounding.ToEven);
            string hstMessage = "HST 13% = $" + roundHst + " CAD";

            return new string[] { chargeMessage, hstMessage, totalMessage };
        }
    }
}
