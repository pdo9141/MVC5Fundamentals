using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace KatanaIntro
{
    public class GreetingController : ApiController
    {
        public Greeting Get()
        {
            return new Greeting { Id = 9, Text = "Hello World" };
        }
    }
}
