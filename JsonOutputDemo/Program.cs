using System;
using CorporationWiki.Web.Common;

namespace JsonOutputDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var demoDate = new DateTime(2011, 2, 21);

            var jsonVal = JsonSerializer.Current.SerializeObject(demoDate);

            Console.WriteLine(jsonVal);
        }
    }
}
