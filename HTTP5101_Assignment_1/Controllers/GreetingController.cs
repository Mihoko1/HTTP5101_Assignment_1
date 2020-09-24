using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns the string "Hello World!"
        /// <example>POST api/Greeting</example>
        /// </summary>
        /// <returns>Hello World!</returns>

        public string Post()
        {
            return "Hello World!";
        }

        // GET api/Greeting/id
        public string Get(int id)
        {
            string message = "Greetings to " + id + " people!";
            return message;
        }
    }
}
