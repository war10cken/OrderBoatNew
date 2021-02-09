using System;
using System.Linq;
using OrderBoatNew.Domain.Models;
using OrderBoatNew.EntityFramework;
using OrderBoatNew.EntityFramework.Services;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var _woods = new GenericDataService<BoatType>(new OrderBoatNewDbContextFactory());
            var g = _woods.Get(1).Result;
            var q = _woods.GetAll().Result.Select(wood => wood.Name);

            Console.ReadKey();
        }
    }
}