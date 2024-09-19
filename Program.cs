//using System.Linq;
using System.Xml;
using static L2O___D09.ListGenerators;
namespace test_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WHERE is filrerition - refered excution
            //var result = ProductList.Where(p => p.UnitsInStock == 0);
            //result = from p in ProductList
            //         where p.UnitsInStock == 0
            //         select p;
            //result = ProductList.Where((p, i) => (p.UnitsInStock == 0) && (i <= 5));
            //foreach (var item in result)
            //{
            //    Console.WriteLine("unit=" + item + " ,");
            //}
            #endregion
            #region SELECT is transformation opreation - refered excution
            //var result = ProductList.Select(p => p.ProductName);
            //result = from p in ProductList
            //         select p.ProductName;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);   
            //}
            //var result = ProductList.Select(p => new { Id = p.ProductID, p.ProductName });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Order elements - refered excution
            //var result = ProductList.OrderBy(p => p.ProductName).Select(P=>new {P.ProductID,P.ProductName});
            //result = from p in ProductList
            //         orderby p.ProductName
            //         select new { p.ProductID, p.ProductName };
            //foreach (var item in result)
            //    Console.WriteLine(item);
            //var result2 = ProductList.OrderByDescending(p => p.ProductName).Select(P => new { P.ProductID, P.ProductName });
            //result2 = from p in ProductList
            //         orderby p.ProductName descending
            //         select new { p.ProductID, p.ProductName };
            //foreach (var item in result2)
            //    Console.WriteLine(item);

            #endregion
            #region Element operators - Imidiate excution
            //var result = ProductList.FirstOrDefault();
            //result= ProductList.LastOrDefault(p => p.UnitsInStock==0);
            //result = ProductList.ElementAtOrDefault(500); //Eexception
            //Console.WriteLine(result?.ProductName??"NA");

            #endregion
            #region Aggregate - Imidiate excution
            //var result = ProductList.Count();
            //result = ProductList.Count(p=>p.UnitsInStock == 0); 
            //var result = ProductList.Max(p=>p.UnitPrice);
            //Console.WriteLine(result);
            //var result2 = (from p in ProductList
            //              where p.UnitPrice == result
            //              select new {p.ProductName,p.UnitPrice}).FirstOrDefault();
            //Console.WriteLine(result2.ProductName+" "+result2.UnitPrice);
            var avg = ProductList.Average(p=>p.UnitsInStock);
            var sum = ProductList.Sum(p => p.UnitsInStock);
            Console.WriteLine(avg);
            Console.WriteLine(sum);

            #endregion
        }
    }
}
