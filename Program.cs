using Newtonsoft.Json.Linq;
using System;

namespace ORM
{
    class Program
    {
        static void Main(string[] args)
        {
            var routeObj = JObject.FromObject(new { id = 3 });
            var abc = new Route();
            abc
            var route = routeObj.ToObject<Route>();            
            Console.ReadLine();
        }
    }
}
