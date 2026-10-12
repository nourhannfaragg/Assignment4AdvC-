using Day_01_G03;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Assignment4AdvC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //var result = ListGenerator.ProductsList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);

            //Q2
            //var result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result);

            //Q3
            int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = arr.Where(n => n > 5).Skip(1).First();
            //Console.WriteLine(result);

            //Q4
            //var result = arr.Count(p => p % 2 != 0);
            //Console.WriteLine(result);

            //Q5
            //var result = ListGenerator.CustomersList.Select(x =>
            //new
            //{
            //    Name = x.CustomerName,
            //    Count = x.Orders.Count()
            //});

            //Q6
            //var result = ListGenerator.ProductsList.Select(x => new
            //{
            //    Category = x.Category,
            //    Cont = x.Category.Count()
            //});

            //Q7
            //var result = arr.Sum();
            //Console.WriteLine(result);

            //Q8
            string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Sum(w=> w.Length);
            //Console.WriteLine(result);

            //Q9
            //var result = words.Min(x => x.Length);
            //Console.WriteLine(result);

            //Q10
            //var result = words.Max(x=> x.Length);
            //Console.WriteLine(result);

            //Q11
            //var result = words.Average(x => x.Length);
            //Console.WriteLine(result);

            //Q12
            //var result = ListGenerator.ProductsList.GroupBy(p => p.Category)
            //                                       .Select(g => new
            //                                       {
            //                                           Category = g.Key,
            //                                           TotalUnits = g.Sum(p => p.UnitsInStock)
            //                                       });



            //Q12
            //var result = ListGenerator.ProductsList.GroupBy(c => c.Category)
            //                                       .Select(p => new
            //                                       {
            //                                           Category = p.Key,
            //                                           CheapestPrice = p.Min(c => c.UnitPrice),
            //                                       });

            //Q13
            //var result = from p in ListGenerator.ProductsList
            //             group p by p.Category into CategoryGroup
            //             let CheapePrice = CategoryGroup.Min(p => p.UnitPrice)
            //             from product in CategoryGroup
            //             where product.UnitPrice == CheapePrice
            //             select product;


            //Q14

            //Fluent
            //var result = ListGenerator.ProductsList.GroupBy(c => c.Category)
            //                           .Select(g => new
            //                           {
            //                               CategoryName = g.Key,
            //                               MaxPrice = g.Max(p => p.UnitPrice)
            //                           });

            //Query
            //var result = from p in ListGenerator.ProductsList
            //             group p by p.Category into CategoryGroup
            //             select new
            //             {
            //                 CategoryName = CategoryGroup.Key,
            //                 MaxPrice = CategoryGroup.Max(p => p.UnitPrice)
            //             };

            //Q15
            //var result = from p in ListGenerator.ProductsList
            //             group p by p.Category into CategoryGroup
            //             let MaxPrice = CategoryGroup.Max(p=> p.UnitPrice)
            //             from product in CategoryGroup
            //             where product.UnitPrice == MaxPrice
            //             select product;


            //Q16
            //fluent
            //var result = ListGenerator.ProductsList.GroupBy(c => c.Category)
            //                                             .Select(g => new
            //                                             {
            //                                                 CategoryName = g.Key,
            //                                                 AvgPrice = g.Average(p => p.UnitPrice)
            //                                             });

            //Query
            //var result = from p in ListGenerator.ProductsList
            //             group p by p.Category into CategoryGroup
            //             select new
            //             {
            //                 CategoryName = CategoryGroup.Key,
            //                 AvgCategory = CategoryGroup.Average(p => p.UnitPrice)
            //             };


            //Set Operatirs:

            //Q1
            //var result = ListGenerator.ProductsList.Select(c => c.Category)
            //                                       .Distinct();

            //Q2
            //var result = ListGenerator.ProductsList.Select(p => p.ProductName[0])
            //                                       .Union(ListGenerator.CustomersList.Select(p => p.CustomerName[0]));


            //Q3
            //var result = ListGenerator.ProductsList.Select(p => p.ProductName[0])
            //    .Intersect(ListGenerator.CustomersList.Select(c => c.CustomerName[0]));


            //Q4
            //var result = ListGenerator.ProductsList.Select(p => p.ProductName[0])
            //    .Except(ListGenerator.CustomersList.Select(c => c.CustomerName[0]));

            //Q5
            //var result = ListGenerator.ProductsList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3))
            //    .Concat(ListGenerator.CustomersList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3)));


            //Partitioning Operators:

            //Q1
            //var result = ListGenerator.CustomersList.Where(c => c.Region == "WA")
            //                                         .SelectMany(c => c.Orders)
            //                                         .Take(3);


            //Q2
            //var result = ListGenerator.CustomersList.Where(c => c.Region == "WA")
            //                                         .SelectMany(c => c.Orders)
            //                                         .Skip(2);

            //Q3
            //var result = arr.TakeWhile((p, i) => p >= i);

            //Q4
            //var result = arr.TakeWhile(e => e % 2 != 0);

            //Q5
            //var result = arr.SkipWhile((num, i) => num >= i);

            //Quantifiers

            //Q1
            //bool result = words.Any(w => w.Contains("ei"));
            //Console.WriteLine(result);

            //Q2
            //var result = ListGenerator.ProductsList.GroupBy(p => p.Category)
            //                                        .Where(g => g.Any(p => p.UnitsInStock == 0));
            //foreach( var item in result )
            //{
            //    Console.WriteLine(item.Key);
            //    foreach(var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}


            //Q3
            //var result = ListGenerator.ProductsList.GroupBy(c => c.Category)
            //                                       .Where(e => e.All(p => p.UnitsInStock > 0));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}


            //LINQ - Group Operators

            //Q1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result = numbers.GroupBy(num => num % 5);

            //foreach(var nums in result)
            //{
            //    Console.WriteLine($"Numbers With A Remainder Of {nums.Key} When Divided By 5:");

            //    foreach(var n in nums)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}

            //Q2
            //var result = words.GroupBy(w => w[0]);
            //foreach (var word in result)
            //{
            //    Console.WriteLine($"Words Starting With {word.Key}");
            //    foreach (var item in word)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            


        }
    }
}
