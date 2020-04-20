using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

        public string Welcome(string name, int numTimes = 1) {
            //return "This is the Welcome action method...";
            //var output = "";

            //for (int i = 1; i <= numTimes; i++)
            //{
            //    output += $"Hello {name} - progress: {i} of {numTimes}";
            //}

            return HtmlEncoder.Default.Encode( $"Hello {name}: numTimes is {numTimes}");
            //return HtmlEncoder.Default.Encode(output);
        }
    }
}