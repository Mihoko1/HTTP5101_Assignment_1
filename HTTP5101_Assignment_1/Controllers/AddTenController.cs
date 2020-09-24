using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method returns 10 more than the integer input {id}
        /// <example>GET api/AddTen/{id} </example>
        /// <param name="id">id</param>
        /// </summary>
        /// <returns>{id} + 10</returns>

        public int Get(int id)
        {
            var addValue = id + 10;
            return addValue;
        }
    }
}
