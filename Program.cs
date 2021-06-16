using Castle.DynamicProxy;
using Newtonsoft.Json.Linq;
using ORM;
using System;
using multipurposeOrm;

namespace ORM
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyGenerator generator = new ProxyGenerator();
            Vehicle veh = generator.CreateClassProxy<Vehicle>(new Interceptor());
            veh.Id = 454;

            Console.ReadLine();
        }
    }
}
