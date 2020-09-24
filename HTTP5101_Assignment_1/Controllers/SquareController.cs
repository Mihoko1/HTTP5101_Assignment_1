using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This method returns the square of the integer input {id}
        /// <example>GET api/Square/{id}</example>
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>{id} * {id}</returns>

        public int Get(int id)
        {
            int multipleValue = id * id;
            return multipleValue;
        }
    }
}
